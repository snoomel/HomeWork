using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Таксопарки
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }
        private static FormRegistration f;
        public static FormRegistration freg
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormRegistration();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }
        void MyInsert()
        {
            if (String.IsNullOrEmpty(textBoxLog.Text) ||
            (String.IsNullOrEmpty(textBoxPass.Text)))
            {
                MessageBox.Show("Обязательно укажите Логин и Пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            long login;
            if (!long.TryParse(textBoxLog.Text, out login))
            {
                MessageBox.Show("Введите номер телефона");
                textBoxLog.Clear();

            }
            else
            {
                string sqlInsert = @"INSERT INTO Пользователи (Логин, Пароль, Роль) VALUES (@log, @pass, @role)";
                SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlInsert;
                command.Parameters.AddWithValue("@log", textBoxLog.Text);
                command.Parameters.AddWithValue("@pass", GetHash(textBoxPass.Text));
                command.Parameters.AddWithValue("@role", "Клиент");
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                connection.Close();
            }
        }
        void MyInsert2()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
            SqlDataAdapter sda3 = new SqlDataAdapter("Select Count(*) From Клиент", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            dataGridView1.Update();
            int id_c = int.Parse(dataGridView1[0, 0].Value.ToString());
            if (String.IsNullOrEmpty(textBox1.Text) ||
            (String.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Обязательно укажите фамилию и имя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
                string sqlInsert = @"INSERT INTO Клиент (id_клиента, Фамилия, Имя, Отчество, Номер_телефона) VALUES (@id_c, @sname, @name, @otch, @tn)";
                SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@id_c", id_c+1);
            command.Parameters.AddWithValue("@sname", textBox1.Text);
            command.Parameters.AddWithValue("@name", textBox2.Text);
            command.Parameters.AddWithValue("@otch", textBox3.Text);
            command.Parameters.AddWithValue("@tn", textBoxLog.Text);
            try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Вы успешно зарегистрировались", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                connection.Close();
                textBoxLog.Clear();
                textBoxPass.Clear();
                textBoxPass2.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxLog.Text) ||
            (String.IsNullOrEmpty(textBoxPass.Text)))
            {
                MessageBox.Show("Обязательно укажите Логин и Пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            long login;
            if (!long.TryParse(textBoxLog.Text, out login))
            {
                MessageBox.Show("Введите номер телефона");
                textBoxLog.Clear();
            }
            SqlConnection con = new SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
            SqlDataAdapter sda3 = new SqlDataAdapter("Select Count(*) From Клиент where Номер_телефона= '" + long.Parse(textBoxLog.Text) + "' ", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            dataGridView1.Update();
            int id_c = int.Parse(dataGridView1[0, 0].Value.ToString());
            if (textBoxPass.Text == textBoxPass2.Text)
                if (id_c == 0)
                {
                    groupBox1.Visible = true;
                    textBoxLog.Enabled=false;
                    textBoxPass.Enabled = false;
                    textBoxPass2.Enabled = false;
                }
                else
                {
                    MessageBox.Show(string.Format("{0}\n{1}", "Ошибка регистрации", "Пользователь с таким номером телефона уже зарегистрировн!"), "Регистрация");

                }
            else 
            {
                MessageBox.Show("Введенные пароли не совпадают", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPass.Clear();
                textBoxPass2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text == textBoxPass2.Text)
            {
                MyInsert();
                MyInsert2();
            }
            else
                MessageBox.Show("Введенные пароли не совпадают", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
    

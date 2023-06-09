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
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormRegistration.freg.ShowForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Пользователи where Логин= '" + textBox1.Text + "' and Пароль = '" + GetHash(textBox2.Text) + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataAdapter sda2 = new SqlDataAdapter("Select Роль From Пользователи where Логин= '" + textBox1.Text + "' ", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            dataGridView1.Update();
            string s = "";
            try
            {
                s = dataGridView1[0, 0].Value.ToString();
            }
            catch 
            {
                MessageBox.Show(string.Format("{0}\n{1}", "Ошибка входа", "Попробуйте снова!"), "Авторизация");
            }
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (s == "Администратор")
                {
                    FormMain.fmain.ShowForm();
                    this.Hide();
                    
                }
                if (s == "Оператор")
                {
                    FormOperator.foper.ShowForm();
                    this.Hide();
                    
                }
                if (s == "Клиент")
                {
                    long tel = long.Parse(textBox1.Text);
                    SqlDataAdapter sda3 = new SqlDataAdapter("Select id_клиента From Клиент where Номер_телефона= '" + long.Parse(textBox1.Text) + "' ", con);
                    DataTable dt3 = new DataTable();
                    sda3.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    dataGridView1.Update();
                    int id_c = int.Parse(dataGridView1[0, 0].Value.ToString());
                    id_c = FormClientsList.fс.ShowSelectForm(id_c);
                    this.Hide();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(string.Format("{0}\n{1}", "Ошибка входа", "Попробуйте снова!"), "Авторизация");
            }
        }
    }
}

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
    public partial class FormAccounts : Form
    {
        public FormAccounts()
        {
            InitializeComponent();
            buttonShow_Click(this, EventArgs.Empty);
        }
        private static FormAccounts f;
        public static FormAccounts faccs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAccounts();
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
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником данных
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select 
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }
        void MyInsert()
        {
            if (String.IsNullOrEmpty(textBoxLog.Text) ||
            (String.IsNullOrEmpty(textBoxPass.Text) ||
            (String.IsNullOrEmpty(comboBoxRole.Text))))
            {
                MessageBox.Show("Обязательно укажите Логин, Пароль и Роль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlInsert = @"INSERT INTO Пользователи (Логин, Пароль, Роль) VALUES (@log, @pass, @role)";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@log", textBoxLog.Text);
            command.Parameters.AddWithValue("@pass", GetHash(textBoxPass.Text));
            command.Parameters.AddWithValue("@role", comboBoxRole.Text);
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
            buttonShow_Click(this, EventArgs.Empty);
        }
        void MyUpdate()
        {
            if (String.IsNullOrEmpty(textBoxLog.Text))
            {
                MessageBox.Show("Обязательно укажите логин учетной записи, для которой будете менять данные", "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            string sqlUpdate = "UPDATE Пользователи SET {0} WHERE [Логин] = @log";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBoxPass.Text))
                sqlValues += "[Пароль]=@pass,";
            if (!String.IsNullOrEmpty(comboBoxRole.Text))
                sqlValues += "[Роль]=@role";
            command.CommandText = String.Format(sqlUpdate, sqlValues);
            if (!String.IsNullOrEmpty(textBoxLog.Text))
                command.Parameters.AddWithValue("@log", textBoxLog.Text);
            if (!String.IsNullOrEmpty(textBoxPass.Text))
                command.Parameters.AddWithValue("@pass", GetHash(textBoxPass.Text));
            if (!String.IsNullOrEmpty(comboBoxRole.Text))
                command.Parameters.AddWithValue("@role", comboBoxRole.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonShow_Click(this, EventArgs.Empty);
        }
        void MyDelete()
        {
            if (String.IsNullOrEmpty(textBoxLog.Text))
            {
                MessageBox.Show("Обязательно укажите логин учетной записи, данные которой необходимо удалить", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"DELETE FROM Пользователи WHERE [Логин] = @log";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@log", textBoxLog.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonShow_Click(this, EventArgs.Empty);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
        dataGridViewREG.DataSource = FillDataGridView("SELECT * FROM Пользователи");
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButtonINS.Checked)
                MyInsert();
            if (radioButtonUPD.Checked)
                MyUpdate();
            if (radioButtonDEL.Checked)
                MyDelete();
        }
 

        private void FormAccounts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркиDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.таксопаркиDataSet.Пользователи);

        }

        private void radioButtonDEL_CheckedChanged_2(object sender, EventArgs e)
        {
            panel1.Visible = !radioButtonDEL.Checked;
        }
    }

}

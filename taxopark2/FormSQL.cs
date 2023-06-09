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

namespace Таксопарки
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        private static FormSQL f;
        public static FormSQL fsql
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        //объявляем метод, на вход подаем строку запроса, а возвращаем объект DataTable
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

        private void radioButtonClients_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(
                "SELECT [Номер_телефона], CONCAT (Фамилия , ' ', Имя ,' ', Отчество) AS Подробнее, 'Является клиентом' AS Статус FROM Клиент");
        }

        private void radioButtonOffers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(
                "SELECT [Id_заказа], [Водитель].[id_водителя], Тариф, CONCAT (Фамилия , ' ', SUBSTRING(Имя, 1,1) ,'.', SUBSTRING(Отчество ,1 ,1), '. на ', Автомобиль) AS Подробнее FROM Заказ, Водитель WHERE Заказ.[id_водителя] =Водитель.id_водителя");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonDrivers.Checked)
            {
                string sqlS = "SELECT id_водителя, Фамилия, Имя, Отчество, Права, Номер_телефона, Автомобиль, id_таксопарка FROM Водитель WHERE Фамилия LIKE @last";
                SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlS;
                command.Parameters.AddWithValue("@last", textBox1.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewSelect.DataSource = table;
                if (table.Rows.Count == 0) MessageBox.Show("Нет водителей с похожей фамилией!",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Обязательно укажите обязательно укажите минимальное количество водителей", "Внимание!", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                textBox2.Text = "1";
                return;
            }
            string sqlSelect = "SELECT id_таксопарка, COUNT(*) AS [Количество водителей] FROM Водитель WHERE id_таксопарка >0 GROUP BY id_таксопарка HAVING COUNT(*) >= @mmin";
            if (checkBoxOrder.Checked)
                sqlSelect += " ORDER BY COUNT(*) desc";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@mmin", textBox2.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0)
                MessageBox.Show("Нет таких таксопарков!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Обязательно укажите ID клиента", "Внимание!", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                textBox3.Text = "1";
                return;
            }
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Обязательно укажите ID водителя", "Внимание!", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                textBox4.Text = "1";
                return;
            }
            string sqlSub = "";
            if (radioButtonUncor.Checked)
            {
                sqlSub += "SELECT id_водителя, CONCAT (Фамилия , ' ', SUBSTRING(Имя, 1,1) ,'.', SUBSTRING(Отчество ,1 ,1), '. на ', Автомобиль) AS Подробнее, id_таксопарка FROM Водитель WHERE id_таксопарка= (SELECT id_таксопарка FROM Водитель WHERE id_водителя=@idd)";
                SqlConnection connection = new
                    SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlSub;
                command.Parameters.AddWithValue("@idd", textBox4.Text);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewSubquery.DataSource = table;
                if (table.Rows.Count == 0)
                    MessageBox.Show("Нет таких водителей!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sqlSub += "SELECT id_водителя, CONCAT (Фамилия , ' ', SUBSTRING(Имя, 1,1) ,'.', SUBSTRING(Отчество ,1 ,1), '. на ', Автомобиль) AS Подробнее, id_таксопарка FROM Водитель WHERE EXISTS (SELECT * FROM Заказ WHERE Заказ.id_водителя= Водитель.id_водителя AND id_клиента=@idc)";
                SqlConnection connection = new
                    SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlSub;
                command.Parameters.AddWithValue("@idc", textBox3.Text);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewSubquery.DataSource = table;
                if (table.Rows.Count == 0)
                    MessageBox.Show("Нет таких водителей!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            dataGridViewDML.DataSource = FillDataGridView("SELECT * FROM Заказ");
        }

        void MyInsert()
        {
            if (String.IsNullOrEmpty(textBoxIDO.Text) ||
            (String.IsNullOrEmpty(textBox6.Text) ||
            (String.IsNullOrEmpty(textBox7.Text) ||
            (String.IsNullOrEmpty(textBox8.Text) ||
            (String.IsNullOrEmpty(textBox9.Text) ||
            (String.IsNullOrEmpty(textBox10.Text)))))))
            {
                MessageBox.Show("Обязательно введите ID заказа а также данные, которые хотите добавить", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int ido;
            if (!int.TryParse(textBoxIDO.Text, out ido))
            {
                MessageBox.Show("Некоректное значение ID заказа!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idc;
            if (!int.TryParse(textBox8.Text, out idc))
            {
                MessageBox.Show("Некоректное значение ID клиента!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idd;
            if (!int.TryParse(textBox7.Text, out idd))
            {
                MessageBox.Show("Некоректное значение ID водителя!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int pr;
            if (!int.TryParse(textBox10.Text, out pr))
            {
                MessageBox.Show("Некоректное значение стоимости заказа!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlInsert = @"INSERT INTO Заказ (id_заказа, id_клиента, id_водителя, Начальная_точка, Конечная_точка, [Оплата по карте], [Стоимость заказа], [Комментарий к заказу], Тариф) VALUES (@ido, @idc, @idd, @nt, @kt, @crd, @pr, @com, @tr)";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@ido", ido);
            command.Parameters.AddWithValue("@idc", idc);
            command.Parameters.AddWithValue("@idd", idd);
            command.Parameters.AddWithValue("@nt", textBox6.Text);
            command.Parameters.AddWithValue("@kt", textBox9.Text);
            command.Parameters.AddWithValue("@crd", checkBox1.Checked);
            command.Parameters.AddWithValue("@pr", pr);
            command.Parameters.AddWithValue("@com", textBox11.Text);
            command.Parameters.AddWithValue("@tr", textBox5.Text);
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
            if (String.IsNullOrEmpty(textBoxIDO.Text))
            {
                MessageBox.Show("Обязательно укажите ID заказа а также данные, которые хотите изменить", "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            int ido;
            if (!int.TryParse(textBoxIDO.Text, out ido))
            {
                MessageBox.Show("Некоректное значение ID заказа!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idc;
            if (!int.TryParse(textBox8.Text, out idc))
            {
                MessageBox.Show("Некоректное значение ID клиента!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idd;
            if (!int.TryParse(textBox7.Text, out idd))
            {
                MessageBox.Show("Некоректное значение ID водителя!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int pr;
            if (!int.TryParse(textBox10.Text, out pr))
            {
                MessageBox.Show("Некоректное значение стоимости заказа!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlUpdate = "UPDATE Заказ SET {0}, [Оплата по карте]=@crd, [Комментарий к заказу]=@com, Тариф=@tr WHERE id_заказа = @ido";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBox6.Text))
                sqlValues += "Начальная_точка=@nt,";
            if (!String.IsNullOrEmpty(textBox9.Text))
                sqlValues += "Конечная_точка=@kt,";
            if (!String.IsNullOrEmpty(textBox7.Text))
                sqlValues += "id_водителя=@idd,";
            if (!String.IsNullOrEmpty(textBox8.Text))
                sqlValues += "id_клиента=@idc,";
            if (!String.IsNullOrEmpty(textBoxIDO.Text))
                sqlValues += "id_заказа=@ido,";
            if (!String.IsNullOrEmpty(textBox10.Text))
                sqlValues += "[Стоимость заказа]=@pr";
            command.CommandText = String.Format(sqlUpdate, sqlValues);
            command.Parameters.AddWithValue("@ido", ido);
            command.Parameters.AddWithValue("@idc", idc);
            command.Parameters.AddWithValue("@idd", idd);
            command.Parameters.AddWithValue("@nt", textBox6.Text);
            command.Parameters.AddWithValue("@kt", textBox9.Text);
            command.Parameters.AddWithValue("@crd", checkBox1.Checked);
            command.Parameters.AddWithValue("@pr", pr);
            command.Parameters.AddWithValue("@com", textBox11.Text);
            command.Parameters.AddWithValue("@tr", textBox5.Text);
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
            if (String.IsNullOrEmpty(textBoxIDO.Text))
            {
                MessageBox.Show("Обязательно укажите номер заявления, данные которого необходимо удалить", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int ido;
            if (!int.TryParse(textBoxIDO.Text, out ido))
            {
                MessageBox.Show("Некоректное ID заказа!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"DELETE FROM Заказ WHERE id_заказа = @ido";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.ТаксопаркиConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@ido", ido);
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButtonAdd.Checked)
                MyInsert();
            if (radioButtonUpd.Checked)
                MyUpdate();
            if (radioButtonDel.Checked)
                MyDelete();
        }

        private void radioButtonDel_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = !radioButtonDel.Checked;
        }
    }
}



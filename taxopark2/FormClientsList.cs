using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Таксопарки
{
    public partial class FormClientsList : Form
    {
        public FormClientsList()
        {
            InitializeComponent();
        }

        private static FormClientsList f;
        public static FormClientsList fс
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormClientsList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
            заказBindingNavigator.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }
        public void ShowFormOper()
        {
            Show();
            Activate();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            заказBindingNavigator.Visible = false;
            клиентBindingNavigatorSaveItem.Visible = false;
            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;
            id_клиентаTextBox.ReadOnly = true;
            фамилияTextBox.ReadOnly = true;
            имяTextBox.ReadOnly = true;
            отчествоTextBox.ReadOnly = true;
            номер_телефонаTextBox.ReadOnly = true;
            заказDataGridView.ReadOnly = true;
        }
        long idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            клиентBindingNavigator.Visible = false;
            заказBindingNavigator.Visible = false;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
                (int)((DataRowView)клиентBindingSource.Current)["[id_клиента]"];
            else
                return -1;
        }
        private void FormClientsList_Shown(object sender, EventArgs e)
        {
            клиентBindingSource.Position = клиентBindingSource.Find("id_клиента", idCurrent);
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.таксопаркиDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void клиентBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.клиентBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.таксопаркиDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }

        private void FormClientsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркиDataSet.Водитель". При необходимости она может быть перемещена или удалена.
            this.водительTableAdapter.Fill(this.таксопаркиDataSet.Водитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркиDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.таксопаркиDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркиDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.таксопаркиDataSet.Клиент);

        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try 
            { 
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.таксопаркиDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void заказDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == заказDataGridView.Columns["О_водителе"].Index && e.RowIndex >= 0)
            {

                {
                    int id = -1;
                    if
                    (((DataRowView)заказBindingSource.Current)["id_водителя"].ToString() != "")
                    {
                        id = (int)(((DataRowView)заказBindingSource.Current)["id_водителя"]);
                    }
                    id = FormDriversList.fd.ShowSelectForm(id);
                    if (id >= 0)
                    {
                        MessageBox.Show(id.ToString());
                        ((DataRowView)заказBindingSource.Current)["id_водителя"] = id;
                        заказBindingSource.EndEdit();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormParksList.ft.ShowForm2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDriversList.fd.ShowForm2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long id = long.Parse(id_клиентаTextBox.Text);
            id = FormNewOrder.fno.ShowSelectForm(id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            заказDataGridView.Update();
        }
    }
}

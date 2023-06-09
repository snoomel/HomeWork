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
    public partial class FormNewOrder : Form
    {
        public FormNewOrder()
        {
            InitializeComponent();
        }
        private static FormNewOrder f;
        public static FormNewOrder fno
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormNewOrder();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
            
        }
        long idCurrent = -1;
        public long ShowSelectForm(long id)
        {
            panel1.Visible = true;
            bindingNavigatorPositionItem.Visible = false;
            bindingNavigatorCountItem.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;
            bindingNavigatorMoveFirstItem.Visible = false;
            bindingNavigatorMovePreviousItem.Visible = false;
            bindingNavigatorPositionItem.ReadOnly = true;
            bindingNavigatorMoveNextItem.Visible = false;
            bindingNavigatorMoveLastItem.Visible = false;
            //id_заказаTextBox.Visible = false;
            //id_водителяTextBox.Visible = false;
            //id_клиентаTextBox.Visible = false;
            //стоимость_заказаTextBox.Visible = false;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
                (int)((DataRowView)заказBindingSource.Current)["id_клиента"];
            else
                return -1;
        }
        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.таксопаркиDataSet);

        }

        private void FormNewOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркиDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.таксопаркиDataSet.Заказ);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            //id_заказаTextBox.Text = "1";

            id_водителяTextBox.Text = "1";
            //id_клиентаTextBox.Visible = false;
            стоимость_заказаTextBox.Text = "1";
            id_клиентаTextBox.Text = Convert.ToString(idCurrent);
        }

        private void FormNewOrder_Shown(object sender, EventArgs e)
        {
            заказBindingSource.Position = заказBindingSource.Find("id_клиента", idCurrent);
        }

        private void id_клиентаTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

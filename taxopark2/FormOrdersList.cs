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
    public partial class FormOrdersList : Form
    {
        public FormOrdersList()
        {
            InitializeComponent();
        }

        private static FormOrdersList f;
        public static FormOrdersList fo
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormOrdersList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        public void ShowFormOper()
        {
            Show();
            Activate();
            bindingNavigatorAddNewItem.Visible = false;
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

        private void FormOrdersList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркиDataSet.Водитель". При необходимости она может быть перемещена или удалена.
            this.водительTableAdapter.Fill(this.таксопаркиDataSet.Водитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркиDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.таксопаркиDataSet.Заказ);

        }

        private void заказDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (заказDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value == null)
                e.CellStyle.BackColor = Color.White;
            else
            {
                if (заказDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn8"].Value.ToString() == "Эконом")
                    e.CellStyle.BackColor = Color.LightPink;
                if (заказDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn8"].Value.ToString() == "Комфорт")
                    e.CellStyle.BackColor = Color.LightBlue;
                if (заказDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn8"].Value.ToString() == "Комфорт+")
                    e.CellStyle.BackColor = Color.LightGreen;
            }
        }
        string GetSelectedFieldName()
        {
            return
            заказDataGridView.Columns[заказDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
                заказBindingSource.Find(GetSelectedFieldName(),
                toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                заказBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Поиск не дал результатов", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                заказBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        заказBindingSource.Filter =
                        GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
            }
            else
                заказBindingSource.Filter = "";
            if (заказBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                заказBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
    }
}

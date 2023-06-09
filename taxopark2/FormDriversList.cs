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
    public partial class FormDriversList : Form
    {
        public FormDriversList()
        {
            InitializeComponent();
        }

        private static FormDriversList f;
        public static FormDriversList fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormDriversList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
            водительBindingNavigator.Visible = true;
        }
        public void ShowForm2()
        {
            Show();
            Activate();
            bindingNavigatorMoveFirstItem.Visible = true;
            bindingNavigatorMovePreviousItem.Visible = true;
            bindingNavigatorPositionItem.ReadOnly = false;
            bindingNavigatorMoveNextItem.Visible = true;
            bindingNavigatorMoveLastItem.Visible = true;
            водительBindingNavigatorSaveItem.Visible = false;
            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;  
            bindingNavigatorPositionItem.ReadOnly = true;
            id_водителяTextBox.ReadOnly = true;
            фамилияTextBox.ReadOnly = true;
            имяTextBox.ReadOnly = true;
            отчествоTextBox.ReadOnly = true;
            праваTextBox.ReadOnly = true;
            номер_телефонаTextBox.ReadOnly = true;
            автомобильComboBox.Enabled = false;
            id_таксопаркаTextBox.ReadOnly = true;
            buttonOpenPhoto.Enabled = false;
        }
        public void ShowFormOper()
        {
            Show();
            Activate();
            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;
        }

        private void водительBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

            
            this.Validate();
            this.водительBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.таксопаркиDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }

        private void FormDriversList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркиDataSet.Таксопарк". При необходимости она может быть перемещена или удалена.
            this.таксопаркTableAdapter.Fill(this.таксопаркиDataSet.Таксопарк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркиDataSet.Таксопарк". При необходимости она может быть перемещена или удалена.
            this.таксопаркTableAdapter.Fill(this.таксопаркиDataSet.Таксопарк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркиDataSet.Водитель". При необходимости она может быть перемещена или удалена.
            this.водительTableAdapter.Fill(this.таксопаркиDataSet.Водитель);

        }

        string fileImage = "";
        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                фотографияPictureBox.Image = new
                Bitmap(openFileDialogPhoto.FileName);
            }
            else fileImage = "";
        }

        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            bindingNavigatorMoveFirstItem.Visible = false;
            bindingNavigatorMovePreviousItem.Visible = false;
            bindingNavigatorPositionItem.ReadOnly = true;
            bindingNavigatorMoveNextItem.Visible = false;
            bindingNavigatorMoveLastItem.Visible = false;
            водительBindingNavigatorSaveItem.Visible = false;
            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;
            bindingNavigatorPositionItem.ReadOnly = true;
            id_водителяTextBox.ReadOnly = true;
            фамилияTextBox.ReadOnly = true;
            имяTextBox.ReadOnly = true;
            отчествоTextBox.ReadOnly = true;
            праваTextBox.ReadOnly = true;
            номер_телефонаTextBox.ReadOnly = true;
            автомобильComboBox.Enabled = false;
            id_таксопаркаTextBox.ReadOnly = true;
            buttonOpenPhoto.Enabled = false;
            
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
                (int)((DataRowView)водительBindingSource.Current)["id_водителя"];
            else
                return -1;
        }

        

        private void FormDriversList_Shown(object sender, EventArgs e)
        {
            водительBindingSource.Position = водительBindingSource.Find("id_водителя", idCurrent);
        }
    }
}

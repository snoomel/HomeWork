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
    public partial class FormParksList : Form
    {
        public FormParksList()
        {
            InitializeComponent();
        }

        private static FormParksList f;
        public static FormParksList ft
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormParksList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        public void ShowForm2()
        {
            Show();
            Activate();
            таксопаркBindingNavigator.Visible = false;
            таксопаркDataGridView.ReadOnly = true;
        }

        private void таксопаркBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.таксопаркBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.таксопаркиDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }

        private void FormParksList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркиDataSet.Таксопарк". При необходимости она может быть перемещена или удалена.
            this.таксопаркTableAdapter.Fill(this.таксопаркиDataSet.Таксопарк);

        }
    }
}

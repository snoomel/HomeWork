using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Таксопарки.Properties;

namespace Таксопарки
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КИБЭВС, Чолокоглы Михаил Александрович, группа 749-1, 2021", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void редактироватьИнформациюОТаксопаркахToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void редактироватьИнформациюОКлиентахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void редактироватьИнформациюОВодителяхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void редактироватьИнформациюОЗаказахToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormClientsList.fс.ShowForm();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

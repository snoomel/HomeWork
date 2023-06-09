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
        private static FormMain f;
        public static FormMain fmain
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormMain();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormParksList.ft.ShowForm();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormClientsList.fс.ShowForm();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FormDriversList.fd.ShowForm();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FormOrdersList.fo.ShowForm();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)СибГМУ, Кафедра стоматологии, Воротова Екатерина Андреевна, группа 1949, 2023", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)СибГМУ, Кафедра стоматологии, Воротова Екатерина Андреевна, группа 1949, 2023", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void редактироватьИнформациюОТаксопаркахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParksList.ft.ShowForm();
        }

        private void редактироватьИнформациюОКлиентахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientsList.fс.ShowForm();
        }

        private void редактироватьИнформациюОВодителяхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDriversList.fd.ShowForm();
        }

        private void редактироватьИнформациюОЗаказахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrdersList.fo.ShowForm();
        }

        private void редактироватьИнформациюОТаксопаркахToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormParksList.ft.ShowForm();
        }

        private void редактироватьИнформациюОклиентахToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormClientsList.fс.ShowForm();
        }

        private void редактироватьИнформациюОВодителяхToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDriversList.fd.ShowForm();
        }

        private void редактироватьИнформациюОЗаказахToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormOrdersList.fo.ShowForm();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)СибГМУ, Кафедра стоматологии, Воротова Екатерина Андреевна, группа 1949, 2023", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL.fsql.ShowForm();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            FormSQL.fsql.ShowForm();
        }

        private void запросыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSQL.fsql.ShowForm();
        }

        private void редактироватьИнформациюОбУчЗаписяхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccounts.faccs.ShowForm();
        }
    }
}

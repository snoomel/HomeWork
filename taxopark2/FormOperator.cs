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
    public partial class FormOperator : Form
    {
        public FormOperator()
        {
            InitializeComponent();
        }

        private static FormOperator f;
        public static FormOperator foper
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormOperator();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClientsList.fс.ShowFormOper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDriversList.fd.ShowFormOper();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormOrdersList.fo.ShowFormOper();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormParksList.ft.ShowForm2();
        }
    }
}

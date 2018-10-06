using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace apeno
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ApeNoDataSet.report'. Você pode movê-la ou removê-la conforme necessário.
            this.reportTableAdapter.Fill(this.ApeNoDataSet.report);

            this.reportViewer1.RefreshReport();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }
    }
}

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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ApeNoDataSet.desenvolvedores'. Você pode movê-la ou removê-la conforme necessário.
            this.desenvolvedoresTableAdapter.Fill(this.ApeNoDataSet.desenvolvedores);

            this.reportViewer1.RefreshReport();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form16_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}

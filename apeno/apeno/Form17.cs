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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ApeNoDataSet.admin_sistema'. Você pode movê-la ou removê-la conforme necessário.
            this.admin_sistemaTableAdapter.Fill(this.ApeNoDataSet.admin_sistema);

            this.reportViewer1.RefreshReport();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form17_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}

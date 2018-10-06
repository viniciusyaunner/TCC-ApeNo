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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ApeNoDataSet.topico'. Você pode movê-la ou removê-la conforme necessário.
            this.topicoTableAdapter.Fill(this.ApeNoDataSet.topico);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }
    }
}

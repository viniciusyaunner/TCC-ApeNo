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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void prti_topicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prti_topicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apeNoDataSet);

        }

        private void prti_topicoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.prti_topicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apeNoDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'apeNoDataSet.prti_topico'. Você pode movê-la ou removê-la conforme necessário.
            this.prti_topicoTableAdapter.Fill(this.apeNoDataSet.prti_topico);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }
    }
}

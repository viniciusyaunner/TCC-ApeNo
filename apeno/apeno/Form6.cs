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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void admin_sistemaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.admin_sistemaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apeNoDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'apeNoDataSet.prti_topico'. Você pode movê-la ou removê-la conforme necessário.
            this.prti_topicoTableAdapter.Fill(this.apeNoDataSet.prti_topico);
            // TODO: esta linha de código carrega dados na tabela 'apeNoDataSet.admin_sistema'. Você pode movê-la ou removê-la conforme necessário.
            this.admin_sistemaTableAdapter.Fill(this.apeNoDataSet.admin_sistema);

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }

        private void nomeadminTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nomeadminTextBox.TextLength > 255) {
                MessageBox.Show("Por favor, abrevie ou mude o nome");
            }
        }

        private void regiaoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nomeadminTextBox.TextLength > 60)
            {
                MessageBox.Show("Por favor, abrevie ou mude o nome");
            }
        }

        private void expedienteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nomeadminTextBox.TextLength > 40)
            {
                MessageBox.Show("Por favor, abrevie ou mude o nome");
            }
        }
    }
}

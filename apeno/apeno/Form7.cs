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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void prti_topicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prti_topicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apeNoDataSet);

        }

        private void topicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.topicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apeNoDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'apeNoDataSet.prti_topico'. Você pode movê-la ou removê-la conforme necessário.
            this.prti_topicoTableAdapter.Fill(this.apeNoDataSet.prti_topico);
            // TODO: esta linha de código carrega dados na tabela 'apeNoDataSet.topico'. Você pode movê-la ou removê-la conforme necessário.
            this.topicoTableAdapter.Fill(this.apeNoDataSet.topico);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                prti_topicoTableAdapter.porNick(apeNoDataSet.prti_topico, "%" + textBox1.Text + "%");
            }
            else {
                try
                {
                    prti_topicoTableAdapter.Fill(apeNoDataSet.prti_topico);
                }
                catch (Exception ex) {
                    MessageBox.Show("ERRO: " + ex);
                }
            }
        }

        private void prti_topicoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }

        private void nometopicoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nometopicoTextBox.TextLength > 120)
            {
                MessageBox.Show("Por favor, abrevie ou mude o nome");
            }
        }

        private void assuntoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nometopicoTextBox.TextLength > 70)
            {
                MessageBox.Show("Por favor, abrevie ou mude o nome");
            }
        }

        private void descricaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void criadorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nometopicoTextBox.TextLength > 255)
            {
                MessageBox.Show("Por favor, abrevie ou mude o nome");
            }
        }

        
    }
}

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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void desenvolvedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.desenvolvedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apeNoDataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'apeNoDataSet.desenvolvedores'. Você pode movê-la ou removê-la conforme necessário.
            this.desenvolvedoresTableAdapter.Fill(this.apeNoDataSet.desenvolvedores);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                desenvolvedoresTableAdapter.pornomd(apeNoDataSet.desenvolvedores, "%" + textBox1.Text + "%");
            }
            else
            {
                try
                {
                    desenvolvedoresTableAdapter.Fill(apeNoDataSet.desenvolvedores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form12_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}

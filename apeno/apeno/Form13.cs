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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void admin_sistemaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.admin_sistemaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apeNoDataSet);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'apeNoDataSet.admin_sistema'. Você pode movê-la ou removê-la conforme necessário.
            this.admin_sistemaTableAdapter.Fill(this.apeNoDataSet.admin_sistema);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                admin_sistemaTableAdapter.porregiao(apeNoDataSet.admin_sistema, "%" + textBox1.Text + "%");
            }
            else
            {
                try
                {
                    admin_sistemaTableAdapter.Fill(apeNoDataSet.admin_sistema);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }
    }
}

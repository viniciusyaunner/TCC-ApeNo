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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void reportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apeNoDataSet);

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'apeNoDataSet.report'. Você pode movê-la ou removê-la conforme necessário.
            this.reportTableAdapter.Fill(this.apeNoDataSet.report);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                reportTableAdapter.porcat(apeNoDataSet.report, "%" + textBox1.Text + "%");
            }
            else
            {
                try
                {
                    reportTableAdapter.Fill(apeNoDataSet.report);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex);
                }
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form14_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}

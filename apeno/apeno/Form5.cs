using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace apeno
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void desenvolvedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.desenvolvedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apeNoDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'apeNoDataSet.desenvolvedores'. Você pode movê-la ou removê-la conforme necessário.
            this.desenvolvedoresTableAdapter.Fill(this.apeNoDataSet.desenvolvedores);

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

      
    }
}

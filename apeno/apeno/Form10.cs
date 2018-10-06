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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void reportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apeNoDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'apeNoDataSet.report'. Você pode movê-la ou removê-la conforme necessário.
            this.reportTableAdapter.Fill(this.apeNoDataSet.report);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }
    }
}

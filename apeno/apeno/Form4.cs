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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apeNoDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'apeNoDataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.apeNoDataSet.usuario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }
    }
}

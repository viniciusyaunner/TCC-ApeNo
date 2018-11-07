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

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nomeTextBox.Text.Length > 255)
            {
                MessageBox.Show("Por favor, abrevie ou mude o nome");
            }
        }

        private void nicknameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nicknameTextBox.Text.Length > 70)
            {
                MessageBox.Show("Por favor, abrevie ou mude o nickname");
            }
        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (senhaTextBox.Text.Length > 40)
            {
                MessageBox.Show("Por favor, abrevie ou mude o senha");
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (emailTextBox.Text.Length > 120)
            {
                MessageBox.Show("Por favor, abrevie ou mude o email");
            }
        }
    }
}

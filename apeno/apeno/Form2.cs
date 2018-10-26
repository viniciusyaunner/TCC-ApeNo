using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;



namespace apeno
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Falta por a senha e a chance de você ter feito apenas uma quebra de linha.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new
            OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\TCC-ApeNo\\ApeNo.accdb");
            OleDbCommand comandos = new OleDbCommand();
            conexao.Open();
            comandos.CommandText = ("select nomeadmin, senha from admin_sistema where nomeadmin='" + textBox1.Text + "' and senha='" + textBox2.Text + "'");
            comandos.Connection = conexao;
            OleDbDataReader consulta = comandos.ExecuteReader();
            if (consulta.HasRows)
            {
                Form3 f3 = new Form3();
                f3.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login ou senha inválido");
            }
            conexao.Close();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click((object)sender, (EventArgs)e);
            }

        }
    }
}

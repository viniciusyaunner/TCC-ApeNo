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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja acessar os dados de administrador?", "ApeNo - Cuidado", MessageBoxButtons.YesNo);
           if(dialogResult == DialogResult.Yes)
                {
                    Form6 f6 = new Form6();
                    f6.Show();
                    Hide();
                }
            else if (dialogResult == DialogResult.No)
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                    Hide();
                }
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            Hide();
        }



        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void participaçãoDeTopicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }

        private void desenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            Hide();
        }

        private void topicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            Hide();
        }

        private void controleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            Hide();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            Hide();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            Hide();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            Hide();
        }

        private void desenvolvedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            Hide();
        }

        private void administradorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            Hide();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            Hide();
        }

        private void relatórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form19 f19 = new Form19();
            f19.Show();
            Hide();
        }

        private void topicoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();
            f18.Show();
            Hide();
        }

        private void administradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
            Hide();
        }

        private void desenvolvedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            Hide();
        }
    }
}

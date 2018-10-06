using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace apeno
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);



            splash frmSplash = new splash();



            //Abre o formulário de apresentação           

            frmSplash.Show();



            //Processa todas as mensagens pendentes do windows.

            //Necessário para carregar a imagem do splash antes de executar o Application.Run

            Application.DoEvents();



            //Carregar configurações do usuário

            Thread.Sleep(2000);


            //Fecha formulário de apresentação

            frmSplash.Dispose();



            //Inicia a aplicação com o FrmPrincipal

            Application.Run(new Form2()); ;
        }
    }
}

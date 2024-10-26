using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedia
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void IntNumber(KeyPressEventArgs e)
        {
            // Comando pra que o TextBox não aceite letras e numeros negativos, porque ele não vai aceitar o sinal de -
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true; 

            // ! este é o sinal de diferente, aqui no codigo ele faz a seguinte situação:
            // se o Char que está sendo verificado se é um digito, ele trava, ou seja (e.KeyChar) vai me informar se é numero;
            // então ele passa, senão o sinal de ! ele não vai passar.
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CalculoMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_situacao.Visible = false;
            tb_nota01.Focus();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                float soma, media, valor;
                soma = 0;
                foreach (Control controle in this.Controls)
                {
                    if (controle is TextBox)
                    {
                        valor = Convert.ToSingle(((TextBox)controle).Text);
                        soma += valor;

                    }
                    media = soma / 4;
                    this.Controls["label_nota"].Text = media.ToString("f1", CultureInfo.InvariantCulture);
                    if (media >= 7)
                    {
                        label_situacao.Visible = true;
                        label_situacao.Text = "Aprovado";

                    }
                    else
                    {
                        label_situacao.Visible = true;
                        label_situacao.Text = "Reprovado";
                    }
                }
            }
            catch (Exception c)
            {
                // Caso queira mostrar a Mensagem de erro com a variável.
                //MessageBox.Show("Informe as médias do Aluno." + c);
                MessageBox.Show("Informe todas as notas do aluno.");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }
                this.Controls["label_nota"].Text = ".....";
                label_situacao.Visible = false;
            }
        }

        private void tb_nota01_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 44 & e.KeyChar != 08)
            {
                e.Handled = true;
                return;
            }
        }

        private void tb_nota01_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_nota01.Text, out int numero))
            {
                if (numero > 10)
                {
                    MessageBox.Show("A nota não pode ser maior que 10");
                    tb_nota01.Text = string.Empty;
                }
            }
        }

        private void tb_nota02_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 44 & e.KeyChar != 08)
            {
                e.Handled = true;
                return;
            }
        }

        private void tb_nota02_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_nota02.Text, out int numero))
            {
                if (numero > 10)
                {
                    MessageBox.Show("A nota não pode ser maior que 10");
                    tb_nota02.Text = string.Empty;
                }
            }
        }

        private void tb_nota03_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 44 & e.KeyChar != 08)
            {
                e.Handled = true;
                return;
            }
        }

        private void tb_nota03_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_nota03.Text, out int numero))
            {
                if (numero > 10)
                {
                    MessageBox.Show("A nota não pode ser maior que 10");
                    tb_nota03.Text = string.Empty;
                }
            }
        }

        private void tb_nota04_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 44 & e.KeyChar != 08)
            {
                e.Handled = true;
                return;
            }
        }

        private void tb_nota04_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_nota04.Text, out int numero))
            {
                if (numero > 10)
                {
                    MessageBox.Show("A nota não pode ser maior que 10");
                    tb_nota04.Text = string.Empty;
                }
            }
        }
    }
}

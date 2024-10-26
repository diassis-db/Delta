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

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) // Calcular
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
                    this.Controls["label7"].Text = media.ToString("f1", CultureInfo.InvariantCulture);
                    if(media >= 7)
                    {
                        label10.Visible = true;
                        label10.Text = "Aprovado";

                    }
                    else
                    {
                        label10.Visible = true;
                        label10.Text = "Reprovado";
                    }
                }
            }catch(Exception c)
            {
                // Caso queira mostrar a Mensagem de erro com a variável.
                //MessageBox.Show("Informe as médias do Aluno." + c);
                MessageBox.Show("Informe todas as notas do aluno.");
            }

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e) //Limpar
        {
            foreach (Control controle in this.Controls)
            {
                if(controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }
                this.Controls["label7"].Text = ".....";
                label10.Visible = false;
            }
        }
        // Aqui vamos chamar lá no Raio do textBox na parte de KEY PRESS e dentro dele vamos chamar o metodo criado lá no Programs.cs
        // Lembrando em cada TextBox tenho que chamar o metodo para que não aceite letras.
        // Metodo IntNumber

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)& e.KeyChar != 44 & e.KeyChar != 08)
            {
                e.Handled = true;
                return; 
            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 44 & e.KeyChar != 08)
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 44 & e.KeyChar != 08)
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Program.IntNumber(e);
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 44 & e.KeyChar != 08)
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero))
            {
                if (numero > 10)
                {
                    MessageBox.Show("A nota não pode ser maior que 10");
                    textBox1.Text = string.Empty;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int numero))
            {
                if (numero > 10)
                {
                    MessageBox.Show("A nota não pode ser maior que 10");
                    textBox2.Text = string.Empty;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int numero))
            {
                if (numero > 10)
                {
                    MessageBox.Show("A nota não pode ser maior que 10");
                    textBox3.Text = string.Empty;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int numero))
            {
                if (numero > 10)
                {
                    MessageBox.Show("A nota não pode ser maior que 10");
                    textBox4.Text = string.Empty;
                }
            }
        }
    }
}

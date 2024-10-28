namespace CalculoMedia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label_situacao = new System.Windows.Forms.Label();
            this.label_nota = new System.Windows.Forms.Label();
            this.tb_nota01 = new System.Windows.Forms.TextBox();
            this.tb_nota02 = new System.Windows.Forms.TextBox();
            this.tb_nota03 = new System.Windows.Forms.TextBox();
            this.tb_nota04 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 02";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 03";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 04";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "A média é:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(332, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "A média programada para aprovação do aluno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "deve ser igual ou maior que 7";
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(447, 94);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(86, 32);
            this.btn_calcular.TabIndex = 9;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(453, 138);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 31);
            this.btn_limpar.TabIndex = 16;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // label_situacao
            // 
            this.label_situacao.AutoSize = true;
            this.label_situacao.BackColor = System.Drawing.Color.Transparent;
            this.label_situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_situacao.Location = new System.Drawing.Point(428, 272);
            this.label_situacao.Name = "label_situacao";
            this.label_situacao.Size = new System.Drawing.Size(100, 24);
            this.label_situacao.TabIndex = 17;
            this.label_situacao.Text = "Aprovado";
            // 
            // label_nota
            // 
            this.label_nota.AutoSize = true;
            this.label_nota.BackColor = System.Drawing.Color.Transparent;
            this.label_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nota.Location = new System.Drawing.Point(497, 206);
            this.label_nota.Name = "label_nota";
            this.label_nota.Size = new System.Drawing.Size(34, 20);
            this.label_nota.TabIndex = 18;
            this.label_nota.Text = ".....";
            // 
            // tb_nota01
            // 
            this.tb_nota01.Location = new System.Drawing.Point(310, 17);
            this.tb_nota01.Name = "tb_nota01";
            this.tb_nota01.Size = new System.Drawing.Size(100, 22);
            this.tb_nota01.TabIndex = 19;
            this.tb_nota01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_nota01.TextChanged += new System.EventHandler(this.tb_nota01_TextChanged);
            this.tb_nota01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nota01_KeyPress);
            // 
            // tb_nota02
            // 
            this.tb_nota02.Location = new System.Drawing.Point(310, 60);
            this.tb_nota02.Name = "tb_nota02";
            this.tb_nota02.Size = new System.Drawing.Size(100, 22);
            this.tb_nota02.TabIndex = 20;
            this.tb_nota02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_nota02.TextChanged += new System.EventHandler(this.tb_nota02_TextChanged);
            this.tb_nota02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nota02_KeyPress);
            // 
            // tb_nota03
            // 
            this.tb_nota03.Location = new System.Drawing.Point(310, 104);
            this.tb_nota03.Name = "tb_nota03";
            this.tb_nota03.Size = new System.Drawing.Size(100, 22);
            this.tb_nota03.TabIndex = 21;
            this.tb_nota03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_nota03.TextChanged += new System.EventHandler(this.tb_nota03_TextChanged);
            this.tb_nota03.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nota03_KeyPress);
            // 
            // tb_nota04
            // 
            this.tb_nota04.Location = new System.Drawing.Point(310, 147);
            this.tb_nota04.Name = "tb_nota04";
            this.tb_nota04.Size = new System.Drawing.Size(100, 22);
            this.tb_nota04.TabIndex = 22;
            this.tb_nota04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_nota04.TextChanged += new System.EventHandler(this.tb_nota04_TextChanged);
            this.tb_nota04.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nota04_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(590, 305);
            this.Controls.Add(this.tb_nota04);
            this.Controls.Add(this.tb_nota03);
            this.Controls.Add(this.tb_nota02);
            this.Controls.Add(this.tb_nota01);
            this.Controls.Add(this.label_nota);
            this.Controls.Add(this.label_situacao);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADOR DE MEDIA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label_situacao;
        private System.Windows.Forms.Label label_nota;
        private System.Windows.Forms.TextBox tb_nota01;
        private System.Windows.Forms.TextBox tb_nota02;
        private System.Windows.Forms.TextBox tb_nota03;
        private System.Windows.Forms.TextBox tb_nota04;
    }
}


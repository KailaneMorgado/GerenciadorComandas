namespace GerenciadorComandas
{
    partial class fmTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTelaInicial));
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblNomeGerenciador = new System.Windows.Forms.Label();
            this.lblCumprimento = new System.Windows.Forms.Label();
            this.lblEsqueceu = new System.Windows.Forms.Label();
            this.lblCriarConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(25, 109);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(107, 106);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(238, 32);
            this.txbEmail.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(26, 167);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(65, 23);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // txbSenha
            // 
            this.txbSenha.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(107, 158);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '♦';
            this.txbSenha.Size = new System.Drawing.Size(238, 32);
            this.txbSenha.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(164, 228);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 32);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblNomeGerenciador
            // 
            this.lblNomeGerenciador.AutoSize = true;
            this.lblNomeGerenciador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.lblNomeGerenciador.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGerenciador.Location = new System.Drawing.Point(43, 28);
            this.lblNomeGerenciador.Name = "lblNomeGerenciador";
            this.lblNomeGerenciador.Size = new System.Drawing.Size(302, 31);
            this.lblNomeGerenciador.TabIndex = 5;
            this.lblNomeGerenciador.Text = "Gerenciador de Comandas";
            // 
            // lblCumprimento
            // 
            this.lblCumprimento.AutoSize = true;
            this.lblCumprimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCumprimento.Location = new System.Drawing.Point(46, 74);
            this.lblCumprimento.Name = "lblCumprimento";
            this.lblCumprimento.Size = new System.Drawing.Size(293, 16);
            this.lblCumprimento.TabIndex = 6;
            this.lblCumprimento.Text = "Seja bem-vindo! Faça o login ou crie uma conta!\r\n";
            // 
            // lblEsqueceu
            // 
            this.lblEsqueceu.AutoSize = true;
            this.lblEsqueceu.ForeColor = System.Drawing.Color.Black;
            this.lblEsqueceu.Location = new System.Drawing.Point(104, 202);
            this.lblEsqueceu.Name = "lblEsqueceu";
            this.lblEsqueceu.Size = new System.Drawing.Size(113, 13);
            this.lblEsqueceu.TabIndex = 7;
            this.lblEsqueceu.Text = "Esqueceu sua senha?";
            // 
            // lblCriarConta
            // 
            this.lblCriarConta.AutoSize = true;
            this.lblCriarConta.Location = new System.Drawing.Point(258, 202);
            this.lblCriarConta.Name = "lblCriarConta";
            this.lblCriarConta.Size = new System.Drawing.Size(81, 13);
            this.lblCriarConta.TabIndex = 8;
            this.lblCriarConta.Text = "Criar uma conta";
            // 
            // fmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 292);
            this.Controls.Add(this.lblCriarConta);
            this.Controls.Add(this.lblEsqueceu);
            this.Controls.Add(this.lblCumprimento);
            this.Controls.Add(this.lblNomeGerenciador);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Comandas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblNomeGerenciador;
        private System.Windows.Forms.Label lblCumprimento;
        private System.Windows.Forms.Label lblEsqueceu;
        private System.Windows.Forms.Label lblCriarConta;
    }
}


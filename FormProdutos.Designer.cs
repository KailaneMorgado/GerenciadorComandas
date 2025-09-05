namespace GerenciadorComandas
{
    partial class FormProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbPrecoEditar = new System.Windows.Forms.TextBox();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblSelecioneApagar = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.picboxProduto = new System.Windows.Forms.PictureBox();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaCadastrar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaCadastro = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbPrecoCadastro = new System.Windows.Forms.TextBox();
            this.lblPrecoCadastro = new System.Windows.Forms.Label();
            this.txbNomeCadastro = new System.Windows.Forms.TextBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProduto)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(105, 69);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(597, 305);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.cmbCategoriaEditar);
            this.grbEditar.Controls.Add(this.lblCategoriaEditar);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbPrecoEditar);
            this.grbEditar.Controls.Add(this.lblPrecoEditar);
            this.grbEditar.Controls.Add(this.txbNomeEditar);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbEditar.Location = new System.Drawing.Point(278, 406);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(240, 177);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // cmbCategoriaEditar
            // 
            this.cmbCategoriaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEditar.FormattingEnabled = true;
            this.cmbCategoriaEditar.Location = new System.Drawing.Point(58, 94);
            this.cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            this.cmbCategoriaEditar.Size = new System.Drawing.Size(176, 21);
            this.cmbCategoriaEditar.TabIndex = 7;
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(0, 97);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaEditar.TabIndex = 5;
            this.lblCategoriaEditar.Text = "Categoria:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(138)))), ((int)(((byte)(115)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(89, 133);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // txbPrecoEditar
            // 
            this.txbPrecoEditar.Location = new System.Drawing.Point(58, 63);
            this.txbPrecoEditar.Name = "txbPrecoEditar";
            this.txbPrecoEditar.Size = new System.Drawing.Size(176, 20);
            this.txbPrecoEditar.TabIndex = 3;
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(6, 66);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoEditar.TabIndex = 2;
            this.lblPrecoEditar.Text = "Preço:";
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(58, 35);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(176, 20);
            this.txbNomeEditar.TabIndex = 1;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(6, 38);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(38, 13);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblSelecioneApagar);
            this.grbApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbApagar.Location = new System.Drawing.Point(548, 406);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(240, 177);
            this.grbApagar.TabIndex = 8;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(138)))), ((int)(((byte)(115)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApagar.Location = new System.Drawing.Point(74, 97);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(95, 42);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblSelecioneApagar
            // 
            this.lblSelecioneApagar.AutoSize = true;
            this.lblSelecioneApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecioneApagar.Location = new System.Drawing.Point(15, 48);
            this.lblSelecioneApagar.Name = "lblSelecioneApagar";
            this.lblSelecioneApagar.Size = new System.Drawing.Size(219, 16);
            this.lblSelecioneApagar.TabIndex = 2;
            this.lblSelecioneApagar.Text = "Selecione um produto para apagar:";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(339, 18);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(112, 31);
            this.lblProdutos.TabIndex = 9;
            this.lblProdutos.Text = "Produtos";
            // 
            // picboxProduto
            // 
            this.picboxProduto.Image = global::GerenciadorComandas.Properties.Resources.wishlist;
            this.picboxProduto.Location = new System.Drawing.Point(457, 12);
            this.picboxProduto.Name = "picboxProduto";
            this.picboxProduto.Size = new System.Drawing.Size(49, 51);
            this.picboxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxProduto.TabIndex = 10;
            this.picboxProduto.TabStop = false;
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCadastrar);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.txbPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.lblPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.txbNomeCadastro);
            this.grbCadastrar.Controls.Add(this.lblNomeCadastro);
            this.grbCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbCadastrar.Location = new System.Drawing.Point(12, 406);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(240, 177);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // cmbCategoriaCadastrar
            // 
            this.cmbCategoriaCadastrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaCadastrar.FormattingEnabled = true;
            this.cmbCategoriaCadastrar.Location = new System.Drawing.Point(58, 97);
            this.cmbCategoriaCadastrar.Name = "cmbCategoriaCadastrar";
            this.cmbCategoriaCadastrar.Size = new System.Drawing.Size(176, 21);
            this.cmbCategoriaCadastrar.TabIndex = 6;
            // 
            // lblCategoriaCadastro
            // 
            this.lblCategoriaCadastro.AutoSize = true;
            this.lblCategoriaCadastro.Location = new System.Drawing.Point(0, 97);
            this.lblCategoriaCadastro.Name = "lblCategoriaCadastro";
            this.lblCategoriaCadastro.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaCadastro.TabIndex = 5;
            this.lblCategoriaCadastro.Text = "Categoria:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(138)))), ((int)(((byte)(115)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(89, 133);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbPrecoCadastro
            // 
            this.txbPrecoCadastro.Location = new System.Drawing.Point(58, 63);
            this.txbPrecoCadastro.Name = "txbPrecoCadastro";
            this.txbPrecoCadastro.Size = new System.Drawing.Size(176, 20);
            this.txbPrecoCadastro.TabIndex = 3;
            // 
            // lblPrecoCadastro
            // 
            this.lblPrecoCadastro.AutoSize = true;
            this.lblPrecoCadastro.Location = new System.Drawing.Point(6, 66);
            this.lblPrecoCadastro.Name = "lblPrecoCadastro";
            this.lblPrecoCadastro.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoCadastro.TabIndex = 2;
            this.lblPrecoCadastro.Text = "Preço:";
            // 
            // txbNomeCadastro
            // 
            this.txbNomeCadastro.Location = new System.Drawing.Point(58, 35);
            this.txbNomeCadastro.Name = "txbNomeCadastro";
            this.txbNomeCadastro.Size = new System.Drawing.Size(176, 20);
            this.txbNomeCadastro.TabIndex = 1;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(6, 38);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Nome:";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(206)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.picboxProduto);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProduto)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblPrecoCadastro;
        private System.Windows.Forms.TextBox txbNomeCadastro;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbPrecoCadastro;
        private System.Windows.Forms.Label lblCategoriaCadastro;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbPrecoEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblSelecioneApagar;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.PictureBox picboxProduto;
        private System.Windows.Forms.ComboBox cmbCategoriaCadastrar;
        private System.Windows.Forms.ComboBox cmbCategoriaEditar;
    }
}
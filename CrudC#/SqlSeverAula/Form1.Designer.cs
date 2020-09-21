namespace SqlSeverAula
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtQtdProduto = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtDescProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeletarTudo = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(158, 244);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(120, 44);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar Pordutos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(12, 244);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 44);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar Produto";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(158, 184);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(120, 44);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir Produtos";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(12, 184);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(120, 44);
            this.btnDeletar.TabIndex = 5;
            this.btnDeletar.Text = "Deletar Produto";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(139, 50);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(183, 20);
            this.txtNomeProduto.TabIndex = 6;
            // 
            // txtQtdProduto
            // 
            this.txtQtdProduto.Location = new System.Drawing.Point(139, 76);
            this.txtQtdProduto.Name = "txtQtdProduto";
            this.txtQtdProduto.Size = new System.Drawing.Size(183, 20);
            this.txtQtdProduto.TabIndex = 7;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(139, 102);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.ReadOnly = true;
            this.txtIdProduto.Size = new System.Drawing.Size(183, 20);
            this.txtIdProduto.TabIndex = 8;
            // 
            // txtDescProduto
            // 
            this.txtDescProduto.Location = new System.Drawing.Point(139, 128);
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Size = new System.Drawing.Size(183, 20);
            this.txtDescProduto.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Qtd do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Id do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descrição do Produto";
            // 
            // btnDeletarTudo
            // 
            this.btnDeletarTudo.BackColor = System.Drawing.Color.Red;
            this.btnDeletarTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarTudo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeletarTudo.Location = new System.Drawing.Point(12, 332);
            this.btnDeletarTudo.Name = "btnDeletarTudo";
            this.btnDeletarTudo.Size = new System.Drawing.Size(266, 44);
            this.btnDeletarTudo.TabIndex = 14;
            this.btnDeletarTudo.Text = "Deletar Todo o Banco";
            this.btnDeletarTudo.UseVisualStyleBackColor = false;
            this.btnDeletarTudo.Click += new System.EventHandler(this.btnDeletarTudo_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(332, 15);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.Size = new System.Drawing.Size(451, 448);
            this.dgProdutos.TabIndex = 1;
            this.dgProdutos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdutos_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnDeletarTudo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.txtQtdProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgProdutos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtQtdProduto;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.TextBox txtDescProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeletarTudo;
        private System.Windows.Forms.DataGridView dgProdutos;
    }
}


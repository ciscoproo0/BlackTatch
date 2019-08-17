namespace Apresentacao
{
    partial class frmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.listVenda = new System.Windows.Forms.ListView();
            this.CodProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecoUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vlrSubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblVlr = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.drpBox = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.lblQuantidadeEstoque = new System.Windows.Forms.Label();
            this.lblQuantidadeEs = new System.Windows.Forms.Label();
            this.lblCifrao = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.lblPrec = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.drpBox.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // listVenda
            // 
            this.listVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodProd,
            this.Produto,
            this.PrecoUnit,
            this.Quantidade,
            this.vlrSubTotal});
            this.listVenda.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVenda.Location = new System.Drawing.Point(12, 216);
            this.listVenda.Name = "listVenda";
            this.listVenda.Size = new System.Drawing.Size(746, 138);
            this.listVenda.TabIndex = 8;
            this.listVenda.UseCompatibleStateImageBehavior = false;
            this.listVenda.View = System.Windows.Forms.View.Details;
            // 
            // CodProd
            // 
            this.CodProd.Text = "Cod Produto";
            this.CodProd.Width = 129;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.Width = 206;
            // 
            // PrecoUnit
            // 
            this.PrecoUnit.Text = "Preço Unitário";
            this.PrecoUnit.Width = 137;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Width = 109;
            // 
            // vlrSubTotal
            // 
            this.vlrSubTotal.Text = "Valor SubTotal";
            this.vlrSubTotal.Width = 140;
            // 
            // lblVlr
            // 
            this.lblVlr.AutoSize = true;
            this.lblVlr.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.lblVlr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVlr.Location = new System.Drawing.Point(537, 366);
            this.lblVlr.Name = "lblVlr";
            this.lblVlr.Size = new System.Drawing.Size(100, 21);
            this.lblVlr.TabIndex = 10;
            this.lblVlr.Text = "ValorTotal: ";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.Red;
            this.lblValorTotal.Location = new System.Drawing.Point(643, 359);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(0, 37);
            this.lblValorTotal.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(656, 396);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(102, 49);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar Compra";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // drpBox
            // 
            this.drpBox.Controls.Add(this.btnPesquisa);
            this.drpBox.Controls.Add(this.lblQuantidadeEstoque);
            this.drpBox.Controls.Add(this.lblQuantidadeEs);
            this.drpBox.Controls.Add(this.lblCifrao);
            this.drpBox.Controls.Add(this.lblQuantidade);
            this.drpBox.Controls.Add(this.lblPrecoUnitario);
            this.drpBox.Controls.Add(this.lblDescricaoProduto);
            this.drpBox.Controls.Add(this.lblPrec);
            this.drpBox.Controls.Add(this.txtQuantidade);
            this.drpBox.Controls.Add(this.lblDesc);
            this.drpBox.Controls.Add(this.txtCodigo);
            this.drpBox.Controls.Add(this.lblCodigo);
            this.drpBox.Location = new System.Drawing.Point(12, 12);
            this.drpBox.Name = "drpBox";
            this.drpBox.Size = new System.Drawing.Size(746, 115);
            this.drpBox.TabIndex = 17;
            this.drpBox.TabStop = false;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackgroundImage = global::Apresentacao.Properties.Resources.search_256;
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisa.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPesquisa.Location = new System.Drawing.Point(6, 42);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(31, 29);
            this.btnPesquisa.TabIndex = 43;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // lblQuantidadeEstoque
            // 
            this.lblQuantidadeEstoque.AutoSize = true;
            this.lblQuantidadeEstoque.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeEstoque.ForeColor = System.Drawing.Color.Red;
            this.lblQuantidadeEstoque.Location = new System.Drawing.Point(497, 78);
            this.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque";
            this.lblQuantidadeEstoque.Size = new System.Drawing.Size(0, 37);
            this.lblQuantidadeEstoque.TabIndex = 42;
            // 
            // lblQuantidadeEs
            // 
            this.lblQuantidadeEs.AutoSize = true;
            this.lblQuantidadeEs.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantidadeEs.Location = new System.Drawing.Point(290, 91);
            this.lblQuantidadeEs.Name = "lblQuantidadeEs";
            this.lblQuantidadeEs.Size = new System.Drawing.Size(201, 21);
            this.lblQuantidadeEs.TabIndex = 41;
            this.lblQuantidadeEs.Text = "Quantidade em estoque:";
            // 
            // lblCifrao
            // 
            this.lblCifrao.AutoSize = true;
            this.lblCifrao.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCifrao.ForeColor = System.Drawing.Color.Red;
            this.lblCifrao.Location = new System.Drawing.Point(497, 48);
            this.lblCifrao.Name = "lblCifrao";
            this.lblCifrao.Size = new System.Drawing.Size(65, 37);
            this.lblCifrao.TabIndex = 40;
            this.lblCifrao.Text = "R$: ";
            this.lblCifrao.Visible = false;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.lblQuantidade.Location = new System.Drawing.Point(183, 18);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(91, 21);
            this.lblQuantidade.TabIndex = 37;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoUnitario.ForeColor = System.Drawing.Color.Red;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(568, 48);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(0, 37);
            this.lblPrecoUnitario.TabIndex = 36;
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoProduto.ForeColor = System.Drawing.Color.Red;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(497, 16);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(0, 37);
            this.lblDescricaoProduto.TabIndex = 35;
            // 
            // lblPrec
            // 
            this.lblPrec.AutoSize = true;
            this.lblPrec.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrec.Location = new System.Drawing.Point(290, 61);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(127, 21);
            this.lblPrec.TabIndex = 34;
            this.lblPrec.Text = "Preço Unitário:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.txtQuantidade.ForeColor = System.Drawing.Color.Red;
            this.txtQuantidade.Location = new System.Drawing.Point(203, 42);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(53, 29);
            this.txtQuantidade.TabIndex = 33;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesc.Location = new System.Drawing.Point(290, 29);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(183, 21);
            this.lblDesc.TabIndex = 32;
            this.lblDesc.Text = "Descrição do Produto:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.txtCodigo.ForeColor = System.Drawing.Color.Red;
            this.txtCodigo.Location = new System.Drawing.Point(46, 42);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(90, 29);
            this.txtCodigo.TabIndex = 31;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(15, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(142, 21);
            this.lblCodigo.TabIndex = 30;
            this.lblCodigo.Text = "Código do Produto";
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInserir.Location = new System.Drawing.Point(631, 183);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(127, 27);
            this.btnInserir.TabIndex = 38;
            this.btnInserir.Text = "Inserir na Lista";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.btnPesquisarCliente);
            this.grpCliente.Controls.Add(this.txtCodCliente);
            this.grpCliente.Controls.Add(this.chkCliente);
            this.grpCliente.Controls.Add(this.lblCodigoCliente);
            this.grpCliente.Location = new System.Drawing.Point(12, 133);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(746, 41);
            this.grpCliente.TabIndex = 18;
            this.grpCliente.TabStop = false;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackgroundImage = global::Apresentacao.Properties.Resources.search_256;
            this.btnPesquisarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarCliente.Enabled = false;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPesquisarCliente.Location = new System.Drawing.Point(166, 10);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(31, 29);
            this.btnPesquisarCliente.TabIndex = 46;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.txtCodCliente.ForeColor = System.Drawing.Color.Red;
            this.txtCodCliente.Location = new System.Drawing.Point(358, 10);
            this.txtCodCliente.MaxLength = 10;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(90, 29);
            this.txtCodCliente.TabIndex = 45;
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.chkCliente.Location = new System.Drawing.Point(13, 12);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(147, 25);
            this.chkCliente.TabIndex = 0;
            this.chkCliente.Text = "Adicionar Cliente";
            this.chkCliente.UseVisualStyleBackColor = true;
            this.chkCliente.CheckedChanged += new System.EventHandler(this.chkCliente_CheckedChanged);
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Enabled = false;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.lblCodigoCliente.Location = new System.Drawing.Point(199, 14);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(134, 21);
            this.lblCodigoCliente.TabIndex = 44;
            this.lblCodigoCliente.Text = "Código do Cliente";
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 457);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.drpBox);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblVlr);
            this.Controls.Add(this.listVenda);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVenda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.drpBox.ResumeLayout(false);
            this.drpBox.PerformLayout();
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listVenda;
        private System.Windows.Forms.Label lblVlr;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ColumnHeader CodProd;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader PrecoUnit;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader vlrSubTotal;
        private System.Windows.Forms.GroupBox drpBox;
        private System.Windows.Forms.Label lblQuantidadeEstoque;
        private System.Windows.Forms.Label lblQuantidadeEs;
        private System.Windows.Forms.Label lblCifrao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.Label lblPrec;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.Label lblCodigoCliente;
    }
}
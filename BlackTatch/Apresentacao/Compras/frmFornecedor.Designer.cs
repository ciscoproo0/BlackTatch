namespace Apresentacao
{
    partial class frmFornecedor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblIdForn = new System.Windows.Forms.Label();
            this.btnCompra = new System.Windows.Forms.Button();
            this.Painel = new System.Windows.Forms.Panel();
            this.lblCadastrarModelo = new System.Windows.Forms.Label();
            this.btnInserirModelo = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblQuantidadeItens = new System.Windows.Forms.Label();
            this.gridItem = new System.Windows.Forms.DataGridView();
            this.ModeloGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnItens = new System.Windows.Forms.Button();
            this.comboProdutos = new System.Windows.Forms.ComboBox();
            this.btnlista = new System.Windows.Forms.Button();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.btnInserirCompra = new System.Windows.Forms.Button();
            this.txtQuantidadeTotal = new System.Windows.Forms.TextBox();
            this.lblQuantidadeTotal = new System.Windows.Forms.Label();
            this.txtNaturezaOperacao = new System.Windows.Forms.TextBox();
            this.lblNaturezaOperacao = new System.Windows.Forms.Label();
            this.txtCompraDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricaoCompra = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblValorTotalCompra = new System.Windows.Forms.Label();
            this.txtDataCompra = new System.Windows.Forms.TextBox();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.lblIdCompraFornecedor = new System.Windows.Forms.Label();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.grpBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dtGridFornecedor = new System.Windows.Forms.DataGridView();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeRepresentanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailRepresentanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneCelularRepresentanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFixoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.lblIE = new System.Windows.Forms.Label();
            this.txtHomePage = new System.Windows.Forms.TextBox();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.txtTelCelRep = new System.Windows.Forms.TextBox();
            this.lblTelCel = new System.Windows.Forms.Label();
            this.txtTelFixo = new System.Windows.Forms.TextBox();
            this.lblTelFixo = new System.Windows.Forms.Label();
            this.txtEmailRepresen = new System.Windows.Forms.TextBox();
            this.lblNomeRepres = new System.Windows.Forms.Label();
            this.txtNomeRepresentante = new System.Windows.Forms.TextBox();
            this.lblNomeRepresentante = new System.Windows.Forms.Label();
            this.txtEmailEmpresa = new System.Windows.Forms.TextBox();
            this.lblNomeEmpre = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.numQuant = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.Painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            this.grpbox.SuspendLayout();
            this.grpBoxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(Apresentacao.ServiceReference1.Fornecedor);
            // 
            // lblIdForn
            // 
            this.lblIdForn.AutoSize = true;
            this.lblIdForn.Location = new System.Drawing.Point(109, 28);
            this.lblIdForn.Name = "lblIdForn";
            this.lblIdForn.Size = new System.Drawing.Size(48, 13);
            this.lblIdForn.TabIndex = 32;
            this.lblIdForn.Text = "Número";
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(3, 3);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(78, 42);
            this.btnCompra.TabIndex = 16;
            this.btnCompra.Text = "Anexar Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // Painel
            // 
            this.Painel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Painel.Controls.Add(this.numQuant);
            this.Painel.Controls.Add(this.lblCadastrarModelo);
            this.Painel.Controls.Add(this.btnCompra);
            this.Painel.Controls.Add(this.btnInserirModelo);
            this.Painel.Controls.Add(this.lblIdForn);
            this.Painel.Controls.Add(this.lblModelo);
            this.Painel.Controls.Add(this.lblQuantidadeItens);
            this.Painel.Controls.Add(this.gridItem);
            this.Painel.Controls.Add(this.btnItens);
            this.Painel.Controls.Add(this.comboProdutos);
            this.Painel.Controls.Add(this.btnlista);
            this.Painel.Controls.Add(this.txtNotaFiscal);
            this.Painel.Controls.Add(this.lblTamanho);
            this.Painel.Controls.Add(this.txtPrecoCusto);
            this.Painel.Controls.Add(this.lblPrecoCusto);
            this.Painel.Controls.Add(this.btnInserirCompra);
            this.Painel.Controls.Add(this.txtQuantidadeTotal);
            this.Painel.Controls.Add(this.lblQuantidadeTotal);
            this.Painel.Controls.Add(this.txtNaturezaOperacao);
            this.Painel.Controls.Add(this.lblNaturezaOperacao);
            this.Painel.Controls.Add(this.txtCompraDescricao);
            this.Painel.Controls.Add(this.lblDescricaoCompra);
            this.Painel.Controls.Add(this.txtValorCompra);
            this.Painel.Controls.Add(this.lblValorTotalCompra);
            this.Painel.Controls.Add(this.txtDataCompra);
            this.Painel.Controls.Add(this.lblDataCompra);
            this.Painel.Controls.Add(this.lblIdCompraFornecedor);
            this.Painel.Location = new System.Drawing.Point(12, 12);
            this.Painel.Name = "Painel";
            this.Painel.Size = new System.Drawing.Size(365, 438);
            this.Painel.TabIndex = 34;
            // 
            // lblCadastrarModelo
            // 
            this.lblCadastrarModelo.AutoSize = true;
            this.lblCadastrarModelo.Location = new System.Drawing.Point(230, 137);
            this.lblCadastrarModelo.Name = "lblCadastrarModelo";
            this.lblCadastrarModelo.Size = new System.Drawing.Size(138, 13);
            this.lblCadastrarModelo.TabIndex = 49;
            this.lblCadastrarModelo.Text = "Modelo não cadastrado? ";
            // 
            // btnInserirModelo
            // 
            this.btnInserirModelo.Location = new System.Drawing.Point(233, 151);
            this.btnInserirModelo.Name = "btnInserirModelo";
            this.btnInserirModelo.Size = new System.Drawing.Size(121, 23);
            this.btnInserirModelo.TabIndex = 24;
            this.btnInserirModelo.Text = "Cadastrar Modelo";
            this.btnInserirModelo.UseVisualStyleBackColor = true;
            this.btnInserirModelo.Click += new System.EventHandler(this.btnInserirModelo_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(3, 137);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(47, 13);
            this.lblModelo.TabIndex = 47;
            this.lblModelo.Text = "Modelo";
            // 
            // lblQuantidadeItens
            // 
            this.lblQuantidadeItens.AutoSize = true;
            this.lblQuantidadeItens.Location = new System.Drawing.Point(165, 181);
            this.lblQuantidadeItens.Name = "lblQuantidadeItens";
            this.lblQuantidadeItens.Size = new System.Drawing.Size(69, 13);
            this.lblQuantidadeItens.TabIndex = 45;
            this.lblQuantidadeItens.Text = "Quantidade";
            // 
            // gridItem
            // 
            this.gridItem.AllowUserToAddRows = false;
            this.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModeloGrid,
            this.CustoGrid,
            this.NotaFiscal,
            this.Quantidade});
            this.gridItem.Location = new System.Drawing.Point(3, 262);
            this.gridItem.Name = "gridItem";
            this.gridItem.Size = new System.Drawing.Size(351, 123);
            this.gridItem.TabIndex = 44;
            // 
            // ModeloGrid
            // 
            this.ModeloGrid.HeaderText = "Modelo";
            this.ModeloGrid.Name = "ModeloGrid";
            // 
            // CustoGrid
            // 
            this.CustoGrid.HeaderText = "Custo";
            this.CustoGrid.Name = "CustoGrid";
            // 
            // NotaFiscal
            // 
            this.NotaFiscal.HeaderText = "Nota Fiscal";
            this.NotaFiscal.Name = "NotaFiscal";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // btnItens
            // 
            this.btnItens.Enabled = false;
            this.btnItens.Location = new System.Drawing.Point(3, 391);
            this.btnItens.Name = "btnItens";
            this.btnItens.Size = new System.Drawing.Size(353, 28);
            this.btnItens.TabIndex = 29;
            this.btnItens.Text = "Inserir Itens  Compra";
            this.btnItens.UseVisualStyleBackColor = true;
            this.btnItens.Click += new System.EventHandler(this.btnItens_Click);
            // 
            // comboProdutos
            // 
            this.comboProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProdutos.FormattingEnabled = true;
            this.comboProdutos.Location = new System.Drawing.Point(6, 153);
            this.comboProdutos.Name = "comboProdutos";
            this.comboProdutos.Size = new System.Drawing.Size(221, 21);
            this.comboProdutos.TabIndex = 23;
            this.comboProdutos.Click += new System.EventHandler(this.comboProdutos_Click);
            // 
            // btnlista
            // 
            this.btnlista.Enabled = false;
            this.btnlista.Location = new System.Drawing.Point(2, 223);
            this.btnlista.Name = "btnlista";
            this.btnlista.Size = new System.Drawing.Size(353, 33);
            this.btnlista.TabIndex = 28;
            this.btnlista.Text = "por na lista";
            this.btnlista.UseVisualStyleBackColor = true;
            this.btnlista.Click += new System.EventHandler(this.btnlista_Click);
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.Location = new System.Drawing.Point(89, 197);
            this.txtNotaFiscal.MaxLength = 15;
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(80, 22);
            this.txtNotaFiscal.TabIndex = 26;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(86, 181);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(63, 13);
            this.lblTamanho.TabIndex = 37;
            this.lblTamanho.Text = "Nota Fiscal";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Location = new System.Drawing.Point(6, 197);
            this.txtPrecoCusto.MaxLength = 10;
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(77, 22);
            this.txtPrecoCusto.TabIndex = 25;
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(3, 181);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(84, 13);
            this.lblPrecoCusto.TabIndex = 35;
            this.lblPrecoCusto.Text = "Preço de Custo";
            // 
            // btnInserirCompra
            // 
            this.btnInserirCompra.Enabled = false;
            this.btnInserirCompra.Location = new System.Drawing.Point(5, 98);
            this.btnInserirCompra.Name = "btnInserirCompra";
            this.btnInserirCompra.Size = new System.Drawing.Size(353, 28);
            this.btnInserirCompra.TabIndex = 22;
            this.btnInserirCompra.Text = "Inserir Compra";
            this.btnInserirCompra.UseVisualStyleBackColor = true;
            this.btnInserirCompra.Click += new System.EventHandler(this.btnInserirCompra_Click);
            // 
            // txtQuantidadeTotal
            // 
            this.txtQuantidadeTotal.Location = new System.Drawing.Point(237, 71);
            this.txtQuantidadeTotal.MaxLength = 10;
            this.txtQuantidadeTotal.Name = "txtQuantidadeTotal";
            this.txtQuantidadeTotal.Size = new System.Drawing.Size(64, 22);
            this.txtQuantidadeTotal.TabIndex = 21;
            // 
            // lblQuantidadeTotal
            // 
            this.lblQuantidadeTotal.AutoSize = true;
            this.lblQuantidadeTotal.Location = new System.Drawing.Point(234, 55);
            this.lblQuantidadeTotal.Name = "lblQuantidadeTotal";
            this.lblQuantidadeTotal.Size = new System.Drawing.Size(97, 13);
            this.lblQuantidadeTotal.TabIndex = 32;
            this.lblQuantidadeTotal.Text = "Quantidade Total";
            // 
            // txtNaturezaOperacao
            // 
            this.txtNaturezaOperacao.Location = new System.Drawing.Point(119, 71);
            this.txtNaturezaOperacao.MaxLength = 20;
            this.txtNaturezaOperacao.Name = "txtNaturezaOperacao";
            this.txtNaturezaOperacao.Size = new System.Drawing.Size(100, 22);
            this.txtNaturezaOperacao.TabIndex = 20;
            // 
            // lblNaturezaOperacao
            // 
            this.lblNaturezaOperacao.AutoSize = true;
            this.lblNaturezaOperacao.Location = new System.Drawing.Point(116, 55);
            this.lblNaturezaOperacao.Name = "lblNaturezaOperacao";
            this.lblNaturezaOperacao.Size = new System.Drawing.Size(120, 13);
            this.lblNaturezaOperacao.TabIndex = 30;
            this.lblNaturezaOperacao.Text = "Natureza da operação";
            // 
            // txtCompraDescricao
            // 
            this.txtCompraDescricao.Location = new System.Drawing.Point(6, 71);
            this.txtCompraDescricao.MaxLength = 30;
            this.txtCompraDescricao.Name = "txtCompraDescricao";
            this.txtCompraDescricao.Size = new System.Drawing.Size(100, 22);
            this.txtCompraDescricao.TabIndex = 19;
            // 
            // lblDescricaoCompra
            // 
            this.lblDescricaoCompra.AutoSize = true;
            this.lblDescricaoCompra.Location = new System.Drawing.Point(3, 55);
            this.lblDescricaoCompra.Name = "lblDescricaoCompra";
            this.lblDescricaoCompra.Size = new System.Drawing.Size(115, 13);
            this.lblDescricaoCompra.TabIndex = 28;
            this.lblDescricaoCompra.Text = "Descrição da Compra";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(273, 25);
            this.txtValorCompra.MaxLength = 15;
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(82, 22);
            this.txtValorCompra.TabIndex = 18;
            // 
            // lblValorTotalCompra
            // 
            this.lblValorTotalCompra.AutoSize = true;
            this.lblValorTotalCompra.Location = new System.Drawing.Point(270, 9);
            this.lblValorTotalCompra.Name = "lblValorTotalCompra";
            this.lblValorTotalCompra.Size = new System.Drawing.Size(93, 13);
            this.lblValorTotalCompra.TabIndex = 13;
            this.lblValorTotalCompra.Text = "Valor da Compra";
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.Location = new System.Drawing.Point(186, 25);
            this.txtDataCompra.MaxLength = 10;
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(81, 22);
            this.txtDataCompra.TabIndex = 17;
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Location = new System.Drawing.Point(183, 8);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(90, 13);
            this.lblDataCompra.TabIndex = 11;
            this.lblDataCompra.Text = "Data da Compra";
            // 
            // lblIdCompraFornecedor
            // 
            this.lblIdCompraFornecedor.AutoSize = true;
            this.lblIdCompraFornecedor.Location = new System.Drawing.Point(98, 9);
            this.lblIdCompraFornecedor.Name = "lblIdCompraFornecedor";
            this.lblIdCompraFornecedor.Size = new System.Drawing.Size(90, 13);
            this.lblIdCompraFornecedor.TabIndex = 9;
            this.lblIdCompraFornecedor.Text = "Cod Fornecedor";
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.grpBoxPesquisa);
            this.grpbox.Controls.Add(this.btnLimpar);
            this.grpbox.Controls.Add(this.btnAtualizar);
            this.grpbox.Controls.Add(this.btnInserir);
            this.grpbox.Controls.Add(this.txtCEP);
            this.grpbox.Controls.Add(this.lblCEP);
            this.grpbox.Controls.Add(this.txtNumero);
            this.grpbox.Controls.Add(this.lblNumero);
            this.grpbox.Controls.Add(this.txtBairro);
            this.grpbox.Controls.Add(this.lblBairro);
            this.grpbox.Controls.Add(this.txtEndereco);
            this.grpbox.Controls.Add(this.lblEndereco);
            this.grpbox.Controls.Add(this.txtCNPJ);
            this.grpbox.Controls.Add(this.lblCNPJ);
            this.grpbox.Controls.Add(this.txtIE);
            this.grpbox.Controls.Add(this.lblIE);
            this.grpbox.Controls.Add(this.txtHomePage);
            this.grpbox.Controls.Add(this.lblHomePage);
            this.grpbox.Controls.Add(this.txtTelCelRep);
            this.grpbox.Controls.Add(this.lblTelCel);
            this.grpbox.Controls.Add(this.txtTelFixo);
            this.grpbox.Controls.Add(this.lblTelFixo);
            this.grpbox.Controls.Add(this.txtEmailRepresen);
            this.grpbox.Controls.Add(this.lblNomeRepres);
            this.grpbox.Controls.Add(this.txtNomeRepresentante);
            this.grpbox.Controls.Add(this.lblNomeRepresentante);
            this.grpbox.Controls.Add(this.txtEmailEmpresa);
            this.grpbox.Controls.Add(this.lblNomeEmpre);
            this.grpbox.Controls.Add(this.txtNomeEmpresa);
            this.grpbox.Controls.Add(this.lblNomeEmpresa);
            this.grpbox.Location = new System.Drawing.Point(383, 12);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(534, 421);
            this.grpbox.TabIndex = 35;
            this.grpbox.TabStop = false;
            // 
            // grpBoxPesquisa
            // 
            this.grpBoxPesquisa.Controls.Add(this.txtPesquisa);
            this.grpBoxPesquisa.Controls.Add(this.lblPesquisa);
            this.grpBoxPesquisa.Controls.Add(this.dtGridFornecedor);
            this.grpBoxPesquisa.Location = new System.Drawing.Point(241, 153);
            this.grpBoxPesquisa.Name = "grpBoxPesquisa";
            this.grpBoxPesquisa.Size = new System.Drawing.Size(285, 262);
            this.grpBoxPesquisa.TabIndex = 59;
            this.grpBoxPesquisa.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(111, 13);
            this.txtPesquisa.MaxLength = 50;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(168, 22);
            this.txtPesquisa.TabIndex = 60;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(6, 16);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(112, 13);
            this.lblPesquisa.TabIndex = 60;
            this.lblPesquisa.Text = "Pesquisar por nome:";
            // 
            // dtGridFornecedor
            // 
            this.dtGridFornecedor.AllowUserToAddRows = false;
            this.dtGridFornecedor.AllowUserToDeleteRows = false;
            this.dtGridFornecedor.AutoGenerateColumns = false;
            this.dtGridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFornecedorDataGridViewTextBoxColumn,
            this.nomeEmpresaDataGridViewTextBoxColumn,
            this.nomeRepresentanteDataGridViewTextBoxColumn,
            this.emailEmpresaDataGridViewTextBoxColumn,
            this.emailRepresentanteDataGridViewTextBoxColumn,
            this.homePageDataGridViewTextBoxColumn,
            this.telefoneCelularRepresentanteDataGridViewTextBoxColumn,
            this.telefoneFixoDataGridViewTextBoxColumn});
            this.dtGridFornecedor.DataSource = this.fornecedorBindingSource;
            this.dtGridFornecedor.Location = new System.Drawing.Point(6, 41);
            this.dtGridFornecedor.Name = "dtGridFornecedor";
            this.dtGridFornecedor.ReadOnly = true;
            this.dtGridFornecedor.Size = new System.Drawing.Size(273, 215);
            this.dtGridFornecedor.TabIndex = 59;
            this.dtGridFornecedor.Click += new System.EventHandler(this.dtGridFornecedor_Click);
            // 
            // idFornecedorDataGridViewTextBoxColumn
            // 
            this.idFornecedorDataGridViewTextBoxColumn.DataPropertyName = "IdFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.HeaderText = "IdFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.Name = "idFornecedorDataGridViewTextBoxColumn";
            this.idFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeEmpresaDataGridViewTextBoxColumn
            // 
            this.nomeEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NomeEmpresa";
            this.nomeEmpresaDataGridViewTextBoxColumn.HeaderText = "NomeEmpresa";
            this.nomeEmpresaDataGridViewTextBoxColumn.Name = "nomeEmpresaDataGridViewTextBoxColumn";
            this.nomeEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeRepresentanteDataGridViewTextBoxColumn
            // 
            this.nomeRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "NomeRepresentante";
            this.nomeRepresentanteDataGridViewTextBoxColumn.HeaderText = "NomeRepresentante";
            this.nomeRepresentanteDataGridViewTextBoxColumn.Name = "nomeRepresentanteDataGridViewTextBoxColumn";
            this.nomeRepresentanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailEmpresaDataGridViewTextBoxColumn
            // 
            this.emailEmpresaDataGridViewTextBoxColumn.DataPropertyName = "EmailEmpresa";
            this.emailEmpresaDataGridViewTextBoxColumn.HeaderText = "EmailEmpresa";
            this.emailEmpresaDataGridViewTextBoxColumn.Name = "emailEmpresaDataGridViewTextBoxColumn";
            this.emailEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailRepresentanteDataGridViewTextBoxColumn
            // 
            this.emailRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "EmailRepresentante";
            this.emailRepresentanteDataGridViewTextBoxColumn.HeaderText = "EmailRepresentante";
            this.emailRepresentanteDataGridViewTextBoxColumn.Name = "emailRepresentanteDataGridViewTextBoxColumn";
            this.emailRepresentanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homePageDataGridViewTextBoxColumn
            // 
            this.homePageDataGridViewTextBoxColumn.DataPropertyName = "HomePage";
            this.homePageDataGridViewTextBoxColumn.HeaderText = "HomePage";
            this.homePageDataGridViewTextBoxColumn.Name = "homePageDataGridViewTextBoxColumn";
            this.homePageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneCelularRepresentanteDataGridViewTextBoxColumn
            // 
            this.telefoneCelularRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "TelefoneCelularRepresentante";
            this.telefoneCelularRepresentanteDataGridViewTextBoxColumn.HeaderText = "TelefoneCelularRepresentante";
            this.telefoneCelularRepresentanteDataGridViewTextBoxColumn.Name = "telefoneCelularRepresentanteDataGridViewTextBoxColumn";
            this.telefoneCelularRepresentanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneFixoDataGridViewTextBoxColumn
            // 
            this.telefoneFixoDataGridViewTextBoxColumn.DataPropertyName = "TelefoneFixo";
            this.telefoneFixoDataGridViewTextBoxColumn.HeaderText = "TelefoneFixo";
            this.telefoneFixoDataGridViewTextBoxColumn.Name = "telefoneFixoDataGridViewTextBoxColumn";
            this.telefoneFixoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(451, 17);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 36);
            this.btnLimpar.TabIndex = 48;
            this.btnLimpar.Text = " Novo Fornecedor";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(451, 103);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 36);
            this.btnAtualizar.TabIndex = 51;
            this.btnAtualizar.Text = "Atualizar Fornecedor";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(451, 59);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 38);
            this.btnInserir.TabIndex = 49;
            this.btnInserir.Text = "Inserir Fornecedor";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(165, 305);
            this.txtCEP.MaxLength = 10;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(68, 22);
            this.txtCEP.TabIndex = 46;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(163, 289);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(26, 13);
            this.lblCEP.TabIndex = 57;
            this.lblCEP.Text = "CEP";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(130, 305);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(29, 22);
            this.txtNumero.TabIndex = 45;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(127, 289);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(20, 13);
            this.lblNumero.TabIndex = 56;
            this.lblNumero.Text = "Nº";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(9, 305);
            this.txtBairro.MaxLength = 15;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(115, 22);
            this.txtBairro.TabIndex = 44;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 289);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(38, 13);
            this.lblBairro.TabIndex = 55;
            this.lblBairro.Text = "Bairro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(9, 259);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(225, 22);
            this.txtEndereco.TabIndex = 42;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(6, 243);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(55, 13);
            this.lblEndereco.TabIndex = 54;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(9, 194);
            this.txtCNPJ.MaxLength = 20;
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(128, 22);
            this.txtCNPJ.TabIndex = 39;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(6, 178);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(32, 13);
            this.lblCNPJ.TabIndex = 53;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(142, 194);
            this.txtIE.MaxLength = 20;
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(92, 22);
            this.txtIE.TabIndex = 41;
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Location = new System.Drawing.Point(139, 178);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(99, 13);
            this.lblIE.TabIndex = 52;
            this.lblIE.Text = "Inscrição Estadual";
            // 
            // txtHomePage
            // 
            this.txtHomePage.Location = new System.Drawing.Point(9, 155);
            this.txtHomePage.MaxLength = 50;
            this.txtHomePage.Name = "txtHomePage";
            this.txtHomePage.Size = new System.Drawing.Size(225, 22);
            this.txtHomePage.TabIndex = 38;
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Location = new System.Drawing.Point(6, 139);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(60, 13);
            this.lblHomePage.TabIndex = 50;
            this.lblHomePage.Text = "Site / Blog";
            // 
            // txtTelCelRep
            // 
            this.txtTelCelRep.Location = new System.Drawing.Point(240, 110);
            this.txtTelCelRep.MaxLength = 15;
            this.txtTelCelRep.Name = "txtTelCelRep";
            this.txtTelCelRep.Size = new System.Drawing.Size(100, 22);
            this.txtTelCelRep.TabIndex = 36;
            // 
            // lblTelCel
            // 
            this.lblTelCel.AutoSize = true;
            this.lblTelCel.Location = new System.Drawing.Point(237, 94);
            this.lblTelCel.Name = "lblTelCel";
            this.lblTelCel.Size = new System.Drawing.Size(185, 13);
            this.lblTelCel.TabIndex = 47;
            this.lblTelCel.Text = "Telefone Celular do Representante";
            // 
            // txtTelFixo
            // 
            this.txtTelFixo.Location = new System.Drawing.Point(9, 110);
            this.txtTelFixo.MaxLength = 15;
            this.txtTelFixo.Name = "txtTelFixo";
            this.txtTelFixo.Size = new System.Drawing.Size(105, 22);
            this.txtTelFixo.TabIndex = 35;
            // 
            // lblTelFixo
            // 
            this.lblTelFixo.AutoSize = true;
            this.lblTelFixo.Location = new System.Drawing.Point(6, 94);
            this.lblTelFixo.Name = "lblTelFixo";
            this.lblTelFixo.Size = new System.Drawing.Size(113, 13);
            this.lblTelFixo.TabIndex = 43;
            this.lblTelFixo.Text = "Telefone da Empresa";
            // 
            // txtEmailRepresen
            // 
            this.txtEmailRepresen.Location = new System.Drawing.Point(240, 69);
            this.txtEmailRepresen.MaxLength = 50;
            this.txtEmailRepresen.Name = "txtEmailRepresen";
            this.txtEmailRepresen.Size = new System.Drawing.Size(201, 22);
            this.txtEmailRepresen.TabIndex = 33;
            // 
            // lblNomeRepres
            // 
            this.lblNomeRepres.AutoSize = true;
            this.lblNomeRepres.Location = new System.Drawing.Point(237, 53);
            this.lblNomeRepres.Name = "lblNomeRepres";
            this.lblNomeRepres.Size = new System.Drawing.Size(129, 13);
            this.lblNomeRepres.TabIndex = 40;
            this.lblNomeRepres.Text = "Email do Representante";
            // 
            // txtNomeRepresentante
            // 
            this.txtNomeRepresentante.Location = new System.Drawing.Point(240, 26);
            this.txtNomeRepresentante.MaxLength = 50;
            this.txtNomeRepresentante.Name = "txtNomeRepresentante";
            this.txtNomeRepresentante.Size = new System.Drawing.Size(201, 22);
            this.txtNomeRepresentante.TabIndex = 30;
            // 
            // lblNomeRepresentante
            // 
            this.lblNomeRepresentante.AutoSize = true;
            this.lblNomeRepresentante.Location = new System.Drawing.Point(237, 10);
            this.lblNomeRepresentante.Name = "lblNomeRepresentante";
            this.lblNomeRepresentante.Size = new System.Drawing.Size(132, 13);
            this.lblNomeRepresentante.TabIndex = 37;
            this.lblNomeRepresentante.Text = "Nome do Representante";
            // 
            // txtEmailEmpresa
            // 
            this.txtEmailEmpresa.Location = new System.Drawing.Point(9, 69);
            this.txtEmailEmpresa.MaxLength = 50;
            this.txtEmailEmpresa.Name = "txtEmailEmpresa";
            this.txtEmailEmpresa.Size = new System.Drawing.Size(225, 22);
            this.txtEmailEmpresa.TabIndex = 32;
            // 
            // lblNomeEmpre
            // 
            this.lblNomeEmpre.AutoSize = true;
            this.lblNomeEmpre.Location = new System.Drawing.Point(6, 53);
            this.lblNomeEmpre.Name = "lblNomeEmpre";
            this.lblNomeEmpre.Size = new System.Drawing.Size(96, 13);
            this.lblNomeEmpre.TabIndex = 34;
            this.lblNomeEmpre.Text = "Email da Empresa";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(9, 26);
            this.txtNomeEmpresa.MaxLength = 50;
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(225, 22);
            this.txtNomeEmpresa.TabIndex = 29;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(6, 10);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(99, 13);
            this.lblNomeEmpresa.TabIndex = 31;
            this.lblNomeEmpresa.Text = "Nome da Empresa";
            // 
            // numQuant
            // 
            this.numQuant.Location = new System.Drawing.Point(175, 197);
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(52, 22);
            this.numQuant.TabIndex = 52;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 460);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.Painel);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFornecedor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.Painel.ResumeLayout(false);
            this.Painel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            this.grpBoxPesquisa.ResumeLayout(false);
            this.grpBoxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblIdForn;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Panel Painel;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lblValorTotalCompra;
        private System.Windows.Forms.TextBox txtDataCompra;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.Label lblIdCompraFornecedor;
        private System.Windows.Forms.Button btnInserirCompra;
        private System.Windows.Forms.TextBox txtQuantidadeTotal;
        private System.Windows.Forms.Label lblQuantidadeTotal;
        private System.Windows.Forms.TextBox txtNaturezaOperacao;
        private System.Windows.Forms.Label lblNaturezaOperacao;
        private System.Windows.Forms.TextBox txtCompraDescricao;
        private System.Windows.Forms.Label lblDescricaoCompra;
        private System.Windows.Forms.ComboBox comboProdutos;
        private System.Windows.Forms.Button btnlista;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.DataGridView gridItem;
        private System.Windows.Forms.Button btnItens;
        private System.Windows.Forms.Label lblQuantidadeItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblCadastrarModelo;
        private System.Windows.Forms.Button btnInserirModelo;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.GroupBox grpBoxPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dtGridFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeRepresentanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailRepresentanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homePageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneCelularRepresentanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFixoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.TextBox txtHomePage;
        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.TextBox txtTelCelRep;
        private System.Windows.Forms.Label lblTelCel;
        private System.Windows.Forms.TextBox txtTelFixo;
        private System.Windows.Forms.Label lblTelFixo;
        private System.Windows.Forms.TextBox txtEmailRepresen;
        private System.Windows.Forms.Label lblNomeRepres;
        private System.Windows.Forms.TextBox txtNomeRepresentante;
        private System.Windows.Forms.Label lblNomeRepresentante;
        private System.Windows.Forms.TextBox txtEmailEmpresa;
        private System.Windows.Forms.Label lblNomeEmpre;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.NumericUpDown numQuant;
    }
}
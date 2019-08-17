namespace Apresentacao
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.dtGridCliente = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txtTelCel = new System.Windows.Forms.TextBox();
            this.lblTeCel = new System.Windows.Forms.Label();
            this.txtTelCom = new System.Windows.Forms.TextBox();
            this.lblTelCom = new System.Windows.Forms.Label();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.rdoAtivoNao = new System.Windows.Forms.RadioButton();
            this.rdoAtivoSim = new System.Windows.Forms.RadioButton();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtTipoEndereco = new System.Windows.Forms.TextBox();
            this.lblTipoEndereco = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtTelRes = new System.Windows.Forms.TextBox();
            this.lblTelResi = new System.Windows.Forms.Label();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.lblIE = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridCliente
            // 
            this.dtGridCliente.AllowUserToAddRows = false;
            this.dtGridCliente.AllowUserToDeleteRows = false;
            this.dtGridCliente.AutoGenerateColumns = false;
            this.dtGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn});
            this.dtGridCliente.DataSource = this.clienteBindingSource;
            this.dtGridCliente.Location = new System.Drawing.Point(12, 300);
            this.dtGridCliente.Name = "dtGridCliente";
            this.dtGridCliente.ReadOnly = true;
            this.dtGridCliente.Size = new System.Drawing.Size(443, 127);
            this.dtGridCliente.TabIndex = 33;
            this.dtGridCliente.Click += new System.EventHandler(this.dtGridCliente_Click);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Apresentacao.ServiceReference1.Cliente);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtDataCadastro);
            this.groupBox1.Controls.Add(this.lblDataCadastro);
            this.groupBox1.Controls.Add(this.txtTelCel);
            this.groupBox1.Controls.Add(this.lblTeCel);
            this.groupBox1.Controls.Add(this.txtTelCom);
            this.groupBox1.Controls.Add(this.lblTelCom);
            this.groupBox1.Controls.Add(this.lblIdCli);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Controls.Add(this.lblAtivo);
            this.groupBox1.Controls.Add(this.rdoAtivoNao);
            this.groupBox1.Controls.Add(this.rdoAtivoSim);
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.lblUF);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.lblComplemento);
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Controls.Add(this.lblCEP);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.txtTipoEndereco);
            this.groupBox1.Controls.Add(this.lblTipoEndereco);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.txtTelRes);
            this.groupBox1.Controls.Add(this.lblTelResi);
            this.groupBox1.Controls.Add(this.txtIE);
            this.groupBox1.Controls.Add(this.lblIE);
            this.groupBox1.Controls.Add(this.txtCNPJ);
            this.groupBox1.Controls.Add(this.lblCNPJ);
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Controls.Add(this.lblRG);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblIdCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 282);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(190, 237);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 38);
            this.btnNovo.TabIndex = 88;
            this.btnNovo.Text = "Novo Cliente";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(115, 22);
            this.txtEmail.TabIndex = 87;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(135, 192);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 86;
            this.lblEmail.Text = "Email";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(17, 208);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(104, 22);
            this.txtDataCadastro.TabIndex = 85;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(14, 192);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(96, 13);
            this.lblDataCadastro.TabIndex = 84;
            this.lblDataCadastro.Text = "Data de Cadastro";
            // 
            // txtTelCel
            // 
            this.txtTelCel.Location = new System.Drawing.Point(187, 156);
            this.txtTelCel.Name = "txtTelCel";
            this.txtTelCel.Size = new System.Drawing.Size(86, 22);
            this.txtTelCel.TabIndex = 83;
            // 
            // lblTeCel
            // 
            this.lblTeCel.AutoSize = true;
            this.lblTeCel.Location = new System.Drawing.Point(187, 140);
            this.lblTeCel.Name = "lblTeCel";
            this.lblTeCel.Size = new System.Drawing.Size(60, 13);
            this.lblTeCel.TabIndex = 82;
            this.lblTeCel.Text = "Tel Celular";
            // 
            // txtTelCom
            // 
            this.txtTelCom.Location = new System.Drawing.Point(102, 156);
            this.txtTelCom.Name = "txtTelCom";
            this.txtTelCom.Size = new System.Drawing.Size(79, 22);
            this.txtTelCom.TabIndex = 81;
            // 
            // lblTelCom
            // 
            this.lblTelCom.AutoSize = true;
            this.lblTelCom.Location = new System.Drawing.Point(99, 140);
            this.lblTelCom.Name = "lblTelCom";
            this.lblTelCom.Size = new System.Drawing.Size(74, 13);
            this.lblTelCom.TabIndex = 80;
            this.lblTelCom.Text = "Tel Comercial";
            // 
            // lblIdCli
            // 
            this.lblIdCli.AutoSize = true;
            this.lblIdCli.Location = new System.Drawing.Point(14, 35);
            this.lblIdCli.Name = "lblIdCli";
            this.lblIdCli.Size = new System.Drawing.Size(45, 13);
            this.lblIdCli.TabIndex = 79;
            this.lblIdCli.Text = "Código";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(352, 238);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 37);
            this.btnAtualizar.TabIndex = 77;
            this.btnAtualizar.Text = "Atualizar Cliente";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(271, 237);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 38);
            this.btnInserir.TabIndex = 76;
            this.btnInserir.Text = "Inserir Cliente";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(14, 250);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(77, 13);
            this.lblAtivo.TabIndex = 75;
            this.lblAtivo.Text = "Cliente Ativo?";
            // 
            // rdoAtivoNao
            // 
            this.rdoAtivoNao.AutoSize = true;
            this.rdoAtivoNao.Location = new System.Drawing.Point(92, 258);
            this.rdoAtivoNao.Name = "rdoAtivoNao";
            this.rdoAtivoNao.Size = new System.Drawing.Size(46, 17);
            this.rdoAtivoNao.TabIndex = 74;
            this.rdoAtivoNao.TabStop = true;
            this.rdoAtivoNao.Text = "Não";
            this.rdoAtivoNao.UseVisualStyleBackColor = true;
            // 
            // rdoAtivoSim
            // 
            this.rdoAtivoSim.AutoSize = true;
            this.rdoAtivoSim.Location = new System.Drawing.Point(92, 235);
            this.rdoAtivoSim.Name = "rdoAtivoSim";
            this.rdoAtivoSim.Size = new System.Drawing.Size(43, 17);
            this.rdoAtivoSim.TabIndex = 73;
            this.rdoAtivoSim.TabStop = true;
            this.rdoAtivoSim.Text = "Sim";
            this.rdoAtivoSim.UseVisualStyleBackColor = true;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(279, 115);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(27, 22);
            this.txtUF.TabIndex = 72;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(276, 99);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 71;
            this.lblUF.Text = "UF";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(127, 115);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(76, 22);
            this.txtComplemento.TabIndex = 70;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(124, 99);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(79, 13);
            this.lblComplemento.TabIndex = 69;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(209, 115);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(64, 22);
            this.txtCEP.TabIndex = 68;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(206, 99);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(26, 13);
            this.lblCEP.TabIndex = 67;
            this.lblCEP.Text = "CEP";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(91, 115);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(30, 22);
            this.txtNumero.TabIndex = 66;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(88, 99);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(20, 13);
            this.lblNumero.TabIndex = 65;
            this.lblNumero.Text = "Nº";
            // 
            // txtTipoEndereco
            // 
            this.txtTipoEndereco.Location = new System.Drawing.Point(17, 115);
            this.txtTipoEndereco.Name = "txtTipoEndereco";
            this.txtTipoEndereco.Size = new System.Drawing.Size(71, 22);
            this.txtTipoEndereco.TabIndex = 64;
            // 
            // lblTipoEndereco
            // 
            this.lblTipoEndereco.AutoSize = true;
            this.lblTipoEndereco.Location = new System.Drawing.Point(14, 99);
            this.lblTipoEndereco.Name = "lblTipoEndereco";
            this.lblTipoEndereco.Size = new System.Drawing.Size(55, 13);
            this.lblTipoEndereco.TabIndex = 63;
            this.lblTipoEndereco.Text = "Tipo End.";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(212, 74);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(79, 22);
            this.txtBairro.TabIndex = 62;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(209, 58);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(38, 13);
            this.lblBairro.TabIndex = 61;
            this.lblBairro.Text = "Bairro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(17, 74);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(187, 22);
            this.txtEndereco.TabIndex = 60;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(14, 58);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(55, 13);
            this.lblEndereco.TabIndex = 59;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtTelRes
            // 
            this.txtTelRes.Location = new System.Drawing.Point(17, 156);
            this.txtTelRes.Name = "txtTelRes";
            this.txtTelRes.Size = new System.Drawing.Size(79, 22);
            this.txtTelRes.TabIndex = 58;
            // 
            // lblTelResi
            // 
            this.lblTelResi.AutoSize = true;
            this.lblTelResi.Location = new System.Drawing.Point(14, 140);
            this.lblTelResi.Name = "lblTelResi";
            this.lblTelResi.Size = new System.Drawing.Size(82, 13);
            this.lblTelResi.TabIndex = 57;
            this.lblTelResi.Text = "Tel Residencial";
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(312, 156);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(115, 22);
            this.txtIE.TabIndex = 56;
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Location = new System.Drawing.Point(309, 140);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(99, 13);
            this.lblIE.TabIndex = 55;
            this.lblIE.Text = "Inscrição Estadual";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(312, 115);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(115, 22);
            this.txtCNPJ.TabIndex = 54;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(309, 99);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(32, 13);
            this.lblCNPJ.TabIndex = 53;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(312, 32);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(115, 22);
            this.txtRG.TabIndex = 52;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(309, 16);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(22, 13);
            this.lblRG.TabIndex = 51;
            this.lblRG.Text = "RG";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(312, 74);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(115, 22);
            this.txtCPF.TabIndex = 50;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(309, 58);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(26, 13);
            this.lblCPF.TabIndex = 49;
            this.lblCPF.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(222, 22);
            this.txtNome.TabIndex = 48;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(66, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(37, 13);
            this.lblNome.TabIndex = 47;
            this.lblNome.Text = "Nome";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(14, 16);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(45, 13);
            this.lblIdCliente.TabIndex = 46;
            this.lblIdCliente.Text = "Código";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGridCliente);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtTelCel;
        private System.Windows.Forms.Label lblTeCel;
        private System.Windows.Forms.TextBox txtTelCom;
        private System.Windows.Forms.Label lblTelCom;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.RadioButton rdoAtivoNao;
        private System.Windows.Forms.RadioButton rdoAtivoSim;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtTipoEndereco;
        private System.Windows.Forms.Label lblTipoEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtTelRes;
        private System.Windows.Forms.Label lblTelResi;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Button btnNovo;
    }
}
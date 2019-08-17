namespace TesteFunc
{
    partial class Form1
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblIdFuncionario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.txtDtNascimento = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblTipoEndereco = new System.Windows.Forms.Label();
            this.txtTipoEndereco = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.lblTelRes = new System.Windows.Forms.Label();
            this.txtTelRes = new System.Windows.Forms.TextBox();
            this.lblTelCel = new System.Windows.Forms.Label();
            this.txtTelCel = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblComissao = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblTituloEleitor = new System.Windows.Forms.Label();
            this.txtTituloEleitor = new System.Windows.Forms.TextBox();
            this.lblSecaoEleitor = new System.Windows.Forms.Label();
            this.txtSecaoEleitor = new System.Windows.Forms.TextBox();
            this.lblZonaEleitoral = new System.Windows.Forms.Label();
            this.txtZonaEleitoral = new System.Windows.Forms.TextBox();
            this.lblPIS = new System.Windows.Forms.Label();
            this.txtPis = new System.Windows.Forms.TextBox();
            this.lblCarteiraProfissional = new System.Windows.Forms.Label();
            this.txtCarteiraProfissional = new System.Windows.Forms.TextBox();
            this.lblSerieCarteiraProfissional = new System.Windows.Forms.Label();
            this.txtSerieCarteiraProfissional = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.dtGridFuncionario = new System.Windows.Forms.DataGridView();
            this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblIdFunc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 277);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 40);
            this.btnInserir.TabIndex = 31;
            this.btnInserir.Text = "Inserir Cliente";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(116, 277);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 40);
            this.btnAtualizar.TabIndex = 32;
            this.btnAtualizar.Text = "Atualizar Cliente";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(220, 277);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 40);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir Cliente";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblIdFuncionario
            // 
            this.lblIdFuncionario.AutoSize = true;
            this.lblIdFuncionario.Location = new System.Drawing.Point(12, 9);
            this.lblIdFuncionario.Name = "lblIdFuncionario";
            this.lblIdFuncionario.Size = new System.Drawing.Size(40, 13);
            this.lblIdFuncionario.TabIndex = 7;
            this.lblIdFuncionario.Text = "Código";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(90, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 25);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(379, 9);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 11;
            this.lblRG.Text = "RG";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(379, 25);
            this.txtRG.MaxLength = 15;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(95, 20);
            this.txtRG.TabIndex = 2;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(480, 9);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 13;
            this.lblCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(480, 25);
            this.txtCPF.MaxLength = 15;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(95, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Location = new System.Drawing.Point(581, 9);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblDtNascimento.TabIndex = 15;
            this.lblDtNascimento.Text = "Data de Nascimento";
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(581, 25);
            this.txtDtNascimento.MaxLength = 15;
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.Size = new System.Drawing.Size(104, 20);
            this.txtDtNascimento.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(691, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(691, 25);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(95, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(12, 52);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 19;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 68);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(315, 20);
            this.txtEndereco.TabIndex = 7;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(333, 52);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 21;
            this.lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(333, 68);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(44, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // lblTipoEndereco
            // 
            this.lblTipoEndereco.AutoSize = true;
            this.lblTipoEndereco.Location = new System.Drawing.Point(383, 52);
            this.lblTipoEndereco.Name = "lblTipoEndereco";
            this.lblTipoEndereco.Size = new System.Drawing.Size(92, 13);
            this.lblTipoEndereco.TabIndex = 23;
            this.lblTipoEndereco.Text = "Tipo de Endereço";
            // 
            // txtTipoEndereco
            // 
            this.txtTipoEndereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTipoEndereco.Location = new System.Drawing.Point(383, 68);
            this.txtTipoEndereco.MaxLength = 10;
            this.txtTipoEndereco.Name = "txtTipoEndereco";
            this.txtTipoEndereco.Size = new System.Drawing.Size(95, 20);
            this.txtTipoEndereco.TabIndex = 9;
            this.txtTipoEndereco.Tag = "";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(483, 52);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 25;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtComplemento.Location = new System.Drawing.Point(484, 68);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(124, 20);
            this.txtComplemento.TabIndex = 10;
            this.txtComplemento.Tag = "";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(614, 52);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 27;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBairro.Location = new System.Drawing.Point(614, 68);
            this.txtBairro.MaxLength = 20;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(140, 20);
            this.txtBairro.TabIndex = 11;
            this.txtBairro.Tag = "";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(760, 52);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 29;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCidade.Location = new System.Drawing.Point(760, 68);
            this.txtCidade.MaxLength = 20;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(95, 20);
            this.txtCidade.TabIndex = 12;
            this.txtCidade.Tag = "";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(940, 52);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 31;
            this.lblUF.Text = "UF";
            // 
            // txtUF
            // 
            this.txtUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUF.Location = new System.Drawing.Point(940, 68);
            this.txtUF.MaxLength = 10;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(31, 20);
            this.txtUF.TabIndex = 14;
            this.txtUF.Tag = "";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(861, 52);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 33;
            this.lblCEP.Text = "CEP";
            // 
            // txtCEP
            // 
            this.txtCEP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCEP.Location = new System.Drawing.Point(861, 68);
            this.txtCEP.MaxLength = 10;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(73, 20);
            this.txtCEP.TabIndex = 13;
            this.txtCEP.Tag = "";
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Location = new System.Drawing.Point(794, 9);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(75, 13);
            this.lblNacionalidade.TabIndex = 35;
            this.lblNacionalidade.Text = "Nacionalidade";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNacionalidade.Location = new System.Drawing.Point(794, 25);
            this.txtNacionalidade.MaxLength = 10;
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(95, 20);
            this.txtNacionalidade.TabIndex = 6;
            this.txtNacionalidade.Tag = "";
            // 
            // lblTelRes
            // 
            this.lblTelRes.AutoSize = true;
            this.lblTelRes.Location = new System.Drawing.Point(12, 182);
            this.lblTelRes.Name = "lblTelRes";
            this.lblTelRes.Size = new System.Drawing.Size(71, 13);
            this.lblTelRes.TabIndex = 37;
            this.lblTelRes.Text = "Telefone Fixo";
            // 
            // txtTelRes
            // 
            this.txtTelRes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTelRes.Location = new System.Drawing.Point(12, 198);
            this.txtTelRes.MaxLength = 15;
            this.txtTelRes.Name = "txtTelRes";
            this.txtTelRes.Size = new System.Drawing.Size(95, 20);
            this.txtTelRes.TabIndex = 25;
            this.txtTelRes.Tag = "";
            // 
            // lblTelCel
            // 
            this.lblTelCel.AutoSize = true;
            this.lblTelCel.Location = new System.Drawing.Point(113, 182);
            this.lblTelCel.Name = "lblTelCel";
            this.lblTelCel.Size = new System.Drawing.Size(84, 13);
            this.lblTelCel.TabIndex = 39;
            this.lblTelCel.Text = "Telefone Celular";
            // 
            // txtTelCel
            // 
            this.txtTelCel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTelCel.Location = new System.Drawing.Point(113, 198);
            this.txtTelCel.MaxLength = 15;
            this.txtTelCel.Name = "txtTelCel";
            this.txtTelCel.Size = new System.Drawing.Size(95, 20);
            this.txtTelCel.TabIndex = 26;
            this.txtTelCel.Tag = "";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(15, 221);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 41;
            this.lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCargo.Location = new System.Drawing.Point(15, 237);
            this.txtCargo.MaxLength = 20;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(125, 20);
            this.txtCargo.TabIndex = 27;
            this.txtCargo.Tag = "";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(146, 221);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 43;
            this.lblSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSalario.Location = new System.Drawing.Point(146, 237);
            this.txtSalario.MaxLength = 15;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(95, 20);
            this.txtSalario.TabIndex = 28;
            this.txtSalario.Tag = "";
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Location = new System.Drawing.Point(247, 221);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(52, 13);
            this.lblComissao.TabIndex = 45;
            this.lblComissao.Text = "Comissao";
            // 
            // txtComissao
            // 
            this.txtComissao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtComissao.Location = new System.Drawing.Point(247, 237);
            this.txtComissao.MaxLength = 15;
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(95, 20);
            this.txtComissao.TabIndex = 29;
            this.txtComissao.Tag = "";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(9, 320);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(70, 13);
            this.lblObs.TabIndex = 48;
            this.lblObs.Text = "Observações";
            // 
            // lblTituloEleitor
            // 
            this.lblTituloEleitor.AutoSize = true;
            this.lblTituloEleitor.Location = new System.Drawing.Point(15, 96);
            this.lblTituloEleitor.Name = "lblTituloEleitor";
            this.lblTituloEleitor.Size = new System.Drawing.Size(82, 13);
            this.lblTituloEleitor.TabIndex = 50;
            this.lblTituloEleitor.Text = "Título de Eleitor";
            // 
            // txtTituloEleitor
            // 
            this.txtTituloEleitor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTituloEleitor.Location = new System.Drawing.Point(15, 112);
            this.txtTituloEleitor.MaxLength = 20;
            this.txtTituloEleitor.Name = "txtTituloEleitor";
            this.txtTituloEleitor.Size = new System.Drawing.Size(125, 20);
            this.txtTituloEleitor.TabIndex = 15;
            this.txtTituloEleitor.Tag = "";
            // 
            // lblSecaoEleitor
            // 
            this.lblSecaoEleitor.AutoSize = true;
            this.lblSecaoEleitor.Location = new System.Drawing.Point(146, 96);
            this.lblSecaoEleitor.Name = "lblSecaoEleitor";
            this.lblSecaoEleitor.Size = new System.Drawing.Size(38, 13);
            this.lblSecaoEleitor.TabIndex = 52;
            this.lblSecaoEleitor.Text = "Seção";
            // 
            // txtSecaoEleitor
            // 
            this.txtSecaoEleitor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSecaoEleitor.Location = new System.Drawing.Point(146, 112);
            this.txtSecaoEleitor.MaxLength = 20;
            this.txtSecaoEleitor.Name = "txtSecaoEleitor";
            this.txtSecaoEleitor.Size = new System.Drawing.Size(62, 20);
            this.txtSecaoEleitor.TabIndex = 16;
            this.txtSecaoEleitor.Tag = "";
            // 
            // lblZonaEleitoral
            // 
            this.lblZonaEleitoral.AutoSize = true;
            this.lblZonaEleitoral.Location = new System.Drawing.Point(217, 96);
            this.lblZonaEleitoral.Name = "lblZonaEleitoral";
            this.lblZonaEleitoral.Size = new System.Drawing.Size(72, 13);
            this.lblZonaEleitoral.TabIndex = 54;
            this.lblZonaEleitoral.Text = "Zona Eleitoral";
            // 
            // txtZonaEleitoral
            // 
            this.txtZonaEleitoral.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtZonaEleitoral.Location = new System.Drawing.Point(217, 112);
            this.txtZonaEleitoral.MaxLength = 20;
            this.txtZonaEleitoral.Name = "txtZonaEleitoral";
            this.txtZonaEleitoral.Size = new System.Drawing.Size(72, 20);
            this.txtZonaEleitoral.TabIndex = 17;
            this.txtZonaEleitoral.Tag = "";
            // 
            // lblPIS
            // 
            this.lblPIS.AutoSize = true;
            this.lblPIS.Location = new System.Drawing.Point(333, 96);
            this.lblPIS.Name = "lblPIS";
            this.lblPIS.Size = new System.Drawing.Size(24, 13);
            this.lblPIS.TabIndex = 56;
            this.lblPIS.Text = "PIS";
            // 
            // txtPis
            // 
            this.txtPis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPis.Location = new System.Drawing.Point(333, 112);
            this.txtPis.MaxLength = 20;
            this.txtPis.Name = "txtPis";
            this.txtPis.Size = new System.Drawing.Size(125, 20);
            this.txtPis.TabIndex = 18;
            this.txtPis.Tag = "";
            // 
            // lblCarteiraProfissional
            // 
            this.lblCarteiraProfissional.AutoSize = true;
            this.lblCarteiraProfissional.Location = new System.Drawing.Point(12, 137);
            this.lblCarteiraProfissional.Name = "lblCarteiraProfissional";
            this.lblCarteiraProfissional.Size = new System.Drawing.Size(99, 13);
            this.lblCarteiraProfissional.TabIndex = 58;
            this.lblCarteiraProfissional.Text = "Carteira Profissional";
            // 
            // txtCarteiraProfissional
            // 
            this.txtCarteiraProfissional.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCarteiraProfissional.Location = new System.Drawing.Point(12, 153);
            this.txtCarteiraProfissional.MaxLength = 20;
            this.txtCarteiraProfissional.Name = "txtCarteiraProfissional";
            this.txtCarteiraProfissional.Size = new System.Drawing.Size(128, 20);
            this.txtCarteiraProfissional.TabIndex = 19;
            this.txtCarteiraProfissional.Tag = "";
            // 
            // lblSerieCarteiraProfissional
            // 
            this.lblSerieCarteiraProfissional.AutoSize = true;
            this.lblSerieCarteiraProfissional.Location = new System.Drawing.Point(146, 137);
            this.lblSerieCarteiraProfissional.Name = "lblSerieCarteiraProfissional";
            this.lblSerieCarteiraProfissional.Size = new System.Drawing.Size(31, 13);
            this.lblSerieCarteiraProfissional.TabIndex = 60;
            this.lblSerieCarteiraProfissional.Text = "Série";
            // 
            // txtSerieCarteiraProfissional
            // 
            this.txtSerieCarteiraProfissional.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSerieCarteiraProfissional.Location = new System.Drawing.Point(146, 153);
            this.txtSerieCarteiraProfissional.MaxLength = 20;
            this.txtSerieCarteiraProfissional.Name = "txtSerieCarteiraProfissional";
            this.txtSerieCarteiraProfissional.Size = new System.Drawing.Size(143, 20);
            this.txtSerieCarteiraProfissional.TabIndex = 20;
            this.txtSerieCarteiraProfissional.Tag = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(12, 336);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(284, 119);
            this.txtObs.TabIndex = 34;
            // 
            // dtGridFuncionario
            // 
            this.dtGridFuncionario.AllowUserToAddRows = false;
            this.dtGridFuncionario.AllowUserToDeleteRows = false;
            this.dtGridFuncionario.AutoGenerateColumns = false;
            this.dtGridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionarioDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.comissaoDataGridViewTextBoxColumn});
            this.dtGridFuncionario.DataSource = this.funcionarioBindingSource;
            this.dtGridFuncionario.Location = new System.Drawing.Point(486, 107);
            this.dtGridFuncionario.Name = "dtGridFuncionario";
            this.dtGridFuncionario.ReadOnly = true;
            this.dtGridFuncionario.Size = new System.Drawing.Size(493, 348);
            this.dtGridFuncionario.TabIndex = 71;
            this.dtGridFuncionario.SelectionChanged += new System.EventHandler(this.dtGridFuncionario_SelectionChanged_1);
            // 
            // idFuncionarioDataGridViewTextBoxColumn
            // 
            this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "IdFuncionario";
            this.idFuncionarioDataGridViewTextBoxColumn.HeaderText = "IdFuncionario";
            this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
            this.idFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "Cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "Cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comissaoDataGridViewTextBoxColumn
            // 
            this.comissaoDataGridViewTextBoxColumn.DataPropertyName = "Comissao";
            this.comissaoDataGridViewTextBoxColumn.HeaderText = "Comissao";
            this.comissaoDataGridViewTextBoxColumn.Name = "comissaoDataGridViewTextBoxColumn";
            this.comissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(TesteFunc.ServiceReference1.Funcionario);
            // 
            // lblIdFunc
            // 
            this.lblIdFunc.AutoSize = true;
            this.lblIdFunc.Location = new System.Drawing.Point(16, 28);
            this.lblIdFunc.Name = "lblIdFunc";
            this.lblIdFunc.Size = new System.Drawing.Size(0, 13);
            this.lblIdFunc.TabIndex = 72;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 466);
            this.Controls.Add(this.lblIdFunc);
            this.Controls.Add(this.dtGridFuncionario);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblSerieCarteiraProfissional);
            this.Controls.Add(this.txtSerieCarteiraProfissional);
            this.Controls.Add(this.lblCarteiraProfissional);
            this.Controls.Add(this.txtCarteiraProfissional);
            this.Controls.Add(this.lblPIS);
            this.Controls.Add(this.txtPis);
            this.Controls.Add(this.lblZonaEleitoral);
            this.Controls.Add(this.txtZonaEleitoral);
            this.Controls.Add(this.lblSecaoEleitor);
            this.Controls.Add(this.txtSecaoEleitor);
            this.Controls.Add(this.lblTituloEleitor);
            this.Controls.Add(this.txtTituloEleitor);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblTelCel);
            this.Controls.Add(this.txtTelCel);
            this.Controls.Add(this.lblTelRes);
            this.Controls.Add(this.txtTelRes);
            this.Controls.Add(this.lblNacionalidade);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblTipoEndereco);
            this.Controls.Add(this.txtTipoEndereco);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDtNascimento);
            this.Controls.Add(this.txtDtNascimento);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblIdFuncionario);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnInserir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblIdFuncionario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.TextBox txtDtNascimento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTipoEndereco;
        private System.Windows.Forms.TextBox txtTipoEndereco;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Label lblTelRes;
        private System.Windows.Forms.TextBox txtTelRes;
        private System.Windows.Forms.Label lblTelCel;
        private System.Windows.Forms.TextBox txtTelCel;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblComissao;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblTituloEleitor;
        private System.Windows.Forms.TextBox txtTituloEleitor;
        private System.Windows.Forms.Label lblSecaoEleitor;
        private System.Windows.Forms.TextBox txtSecaoEleitor;
        private System.Windows.Forms.Label lblZonaEleitoral;
        private System.Windows.Forms.TextBox txtZonaEleitoral;
        private System.Windows.Forms.Label lblPIS;
        private System.Windows.Forms.TextBox txtPis;
        private System.Windows.Forms.Label lblCarteiraProfissional;
        private System.Windows.Forms.TextBox txtCarteiraProfissional;
        private System.Windows.Forms.Label lblSerieCarteiraProfissional;
        private System.Windows.Forms.TextBox txtSerieCarteiraProfissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.DataGridView dtGridFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.Label lblIdFunc;


    }
}


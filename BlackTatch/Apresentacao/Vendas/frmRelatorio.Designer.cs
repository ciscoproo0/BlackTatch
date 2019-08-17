namespace Apresentacao
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.tabRelatorio = new System.Windows.Forms.TabControl();
            this.Vendas = new System.Windows.Forms.TabPage();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lblTotalSoma = new System.Windows.Forms.Label();
            this.lblCodFunc = new System.Windows.Forms.Label();
            this.lblAte = new System.Windows.Forms.Label();
            this.txtData2 = new System.Windows.Forms.MaskedTextBox();
            this.txtData1 = new System.Windows.Forms.MaskedTextBox();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.gridVenda = new System.Windows.Forms.DataGridView();
            this.Compras = new System.Windows.Forms.TabPage();
            this.gridCompra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblLoginCompra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData2Compra = new System.Windows.Forms.MaskedTextBox();
            this.txtData1Compra = new System.Windows.Forms.MaskedTextBox();
            this.lblIntervaloCompra = new System.Windows.Forms.Label();
            this.txtLoginCompra = new System.Windows.Forms.TextBox();
            this.btnPesquisaCompra = new System.Windows.Forms.Button();
            this.tabRelatorio.SuspendLayout();
            this.Vendas.SuspendLayout();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenda)).BeginInit();
            this.Compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Controls.Add(this.Vendas);
            this.tabRelatorio.Controls.Add(this.Compras);
            this.tabRelatorio.Location = new System.Drawing.Point(12, 12);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.SelectedIndex = 0;
            this.tabRelatorio.Size = new System.Drawing.Size(509, 299);
            this.tabRelatorio.TabIndex = 0;
            // 
            // Vendas
            // 
            this.Vendas.Controls.Add(this.grpBox);
            this.Vendas.Controls.Add(this.gridVenda);
            this.Vendas.Location = new System.Drawing.Point(4, 22);
            this.Vendas.Name = "Vendas";
            this.Vendas.Padding = new System.Windows.Forms.Padding(3);
            this.Vendas.Size = new System.Drawing.Size(501, 273);
            this.Vendas.TabIndex = 0;
            this.Vendas.Text = "Vendas";
            this.Vendas.UseVisualStyleBackColor = true;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.lblTotalSoma);
            this.grpBox.Controls.Add(this.lblCodFunc);
            this.grpBox.Controls.Add(this.lblAte);
            this.grpBox.Controls.Add(this.txtData2);
            this.grpBox.Controls.Add(this.txtData1);
            this.grpBox.Controls.Add(this.lblIntervalo);
            this.grpBox.Controls.Add(this.txtIdUsuario);
            this.grpBox.Controls.Add(this.btnPesquisa);
            this.grpBox.Location = new System.Drawing.Point(11, 9);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(478, 100);
            this.grpBox.TabIndex = 36;
            this.grpBox.TabStop = false;
            // 
            // lblTotalSoma
            // 
            this.lblTotalSoma.AutoSize = true;
            this.lblTotalSoma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalSoma.Location = new System.Drawing.Point(325, 22);
            this.lblTotalSoma.Name = "lblTotalSoma";
            this.lblTotalSoma.Size = new System.Drawing.Size(0, 13);
            this.lblTotalSoma.TabIndex = 42;
            // 
            // lblCodFunc
            // 
            this.lblCodFunc.AutoSize = true;
            this.lblCodFunc.Location = new System.Drawing.Point(6, 22);
            this.lblCodFunc.Name = "lblCodFunc";
            this.lblCodFunc.Size = new System.Drawing.Size(124, 13);
            this.lblCodFunc.TabIndex = 41;
            this.lblCodFunc.Text = "Login do Funcionário: ";
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(222, 62);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(30, 13);
            this.lblAte.TabIndex = 40;
            this.lblAte.Text = "Até: ";
            // 
            // txtData2
            // 
            this.txtData2.Location = new System.Drawing.Point(257, 59);
            this.txtData2.Mask = "00/00/0000";
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(65, 22);
            this.txtData2.TabIndex = 2;
            this.txtData2.ValidatingType = typeof(System.DateTime);
            // 
            // txtData1
            // 
            this.txtData1.Location = new System.Drawing.Point(151, 59);
            this.txtData1.Mask = "00/00/0000";
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(65, 22);
            this.txtData1.TabIndex = 1;
            this.txtData1.ValidatingType = typeof(System.DateTime);
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoSize = true;
            this.lblIntervalo.Location = new System.Drawing.Point(6, 62);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(103, 13);
            this.lblIntervalo.TabIndex = 37;
            this.lblIntervalo.Text = "Interalo de datas:  ";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(151, 19);
            this.txtIdUsuario.MaxLength = 10;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtIdUsuario.TabIndex = 0;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(328, 57);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(124, 23);
            this.btnPesquisa.TabIndex = 3;
            this.btnPesquisa.Text = "Pesquisar Datas";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // gridVenda
            // 
            this.gridVenda.AllowUserToAddRows = false;
            this.gridVenda.AllowUserToDeleteRows = false;
            this.gridVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVenda.Location = new System.Drawing.Point(11, 115);
            this.gridVenda.Name = "gridVenda";
            this.gridVenda.ReadOnly = true;
            this.gridVenda.Size = new System.Drawing.Size(478, 150);
            this.gridVenda.TabIndex = 35;
            // 
            // Compras
            // 
            this.Compras.Controls.Add(this.gridCompra);
            this.Compras.Controls.Add(this.groupBox1);
            this.Compras.Location = new System.Drawing.Point(4, 22);
            this.Compras.Name = "Compras";
            this.Compras.Padding = new System.Windows.Forms.Padding(3);
            this.Compras.Size = new System.Drawing.Size(501, 273);
            this.Compras.TabIndex = 1;
            this.Compras.Text = "Compras";
            this.Compras.UseVisualStyleBackColor = true;
            // 
            // gridCompra
            // 
            this.gridCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompra.Location = new System.Drawing.Point(11, 114);
            this.gridCompra.Name = "gridCompra";
            this.gridCompra.Size = new System.Drawing.Size(478, 150);
            this.gridCompra.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalCompra);
            this.groupBox1.Controls.Add(this.lblLoginCompra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtData2Compra);
            this.groupBox1.Controls.Add(this.txtData1Compra);
            this.groupBox1.Controls.Add(this.lblIntervaloCompra);
            this.groupBox1.Controls.Add(this.txtLoginCompra);
            this.groupBox1.Controls.Add(this.btnPesquisaCompra);
            this.groupBox1.Location = new System.Drawing.Point(11, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 100);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalCompra.Location = new System.Drawing.Point(325, 22);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCompra.TabIndex = 42;
            // 
            // lblLoginCompra
            // 
            this.lblLoginCompra.AutoSize = true;
            this.lblLoginCompra.Location = new System.Drawing.Point(6, 22);
            this.lblLoginCompra.Name = "lblLoginCompra";
            this.lblLoginCompra.Size = new System.Drawing.Size(124, 13);
            this.lblLoginCompra.TabIndex = 41;
            this.lblLoginCompra.Text = "Login do Funcionário: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Até: ";
            // 
            // txtData2Compra
            // 
            this.txtData2Compra.Location = new System.Drawing.Point(257, 59);
            this.txtData2Compra.Mask = "00/00/0000";
            this.txtData2Compra.Name = "txtData2Compra";
            this.txtData2Compra.Size = new System.Drawing.Size(65, 22);
            this.txtData2Compra.TabIndex = 2;
            this.txtData2Compra.ValidatingType = typeof(System.DateTime);
            // 
            // txtData1Compra
            // 
            this.txtData1Compra.Location = new System.Drawing.Point(151, 59);
            this.txtData1Compra.Mask = "00/00/0000";
            this.txtData1Compra.Name = "txtData1Compra";
            this.txtData1Compra.Size = new System.Drawing.Size(65, 22);
            this.txtData1Compra.TabIndex = 1;
            this.txtData1Compra.ValidatingType = typeof(System.DateTime);
            // 
            // lblIntervaloCompra
            // 
            this.lblIntervaloCompra.AutoSize = true;
            this.lblIntervaloCompra.Location = new System.Drawing.Point(6, 62);
            this.lblIntervaloCompra.Name = "lblIntervaloCompra";
            this.lblIntervaloCompra.Size = new System.Drawing.Size(103, 13);
            this.lblIntervaloCompra.TabIndex = 37;
            this.lblIntervaloCompra.Text = "Interalo de datas:  ";
            // 
            // txtLoginCompra
            // 
            this.txtLoginCompra.Location = new System.Drawing.Point(151, 19);
            this.txtLoginCompra.MaxLength = 10;
            this.txtLoginCompra.Name = "txtLoginCompra";
            this.txtLoginCompra.Size = new System.Drawing.Size(100, 22);
            this.txtLoginCompra.TabIndex = 0;
            this.txtLoginCompra.TextChanged += new System.EventHandler(this.txtLoginCompra_TextChanged);
            // 
            // btnPesquisaCompra
            // 
            this.btnPesquisaCompra.Location = new System.Drawing.Point(328, 57);
            this.btnPesquisaCompra.Name = "btnPesquisaCompra";
            this.btnPesquisaCompra.Size = new System.Drawing.Size(124, 23);
            this.btnPesquisaCompra.TabIndex = 3;
            this.btnPesquisaCompra.Text = "Pesquisar Datas";
            this.btnPesquisaCompra.UseVisualStyleBackColor = true;
            this.btnPesquisaCompra.Click += new System.EventHandler(this.btnPesquisaCompra_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 323);
            this.Controls.Add(this.tabRelatorio);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.tabRelatorio.ResumeLayout(false);
            this.Vendas.ResumeLayout(false);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenda)).EndInit();
            this.Compras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRelatorio;
        private System.Windows.Forms.TabPage Vendas;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label lblTotalSoma;
        private System.Windows.Forms.Label lblCodFunc;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.MaskedTextBox txtData2;
        private System.Windows.Forms.MaskedTextBox txtData1;
        private System.Windows.Forms.Label lblIntervalo;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DataGridView gridVenda;
        private System.Windows.Forms.TabPage Compras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label lblLoginCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtData2Compra;
        private System.Windows.Forms.MaskedTextBox txtData1Compra;
        private System.Windows.Forms.Label lblIntervaloCompra;
        private System.Windows.Forms.TextBox txtLoginCompra;
        private System.Windows.Forms.Button btnPesquisaCompra;
        private System.Windows.Forms.DataGridView gridCompra;
    }
}
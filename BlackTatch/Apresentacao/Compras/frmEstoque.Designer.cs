namespace Apresentacao
{
    partial class frmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.gridItem = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorRevenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblDica = new System.Windows.Forms.Label();
            this.comboItens = new System.Windows.Forms.ComboBox();
            this.lblPesquisaTipo = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridItem
            // 
            this.gridItem.AllowUserToAddRows = false;
            this.gridItem.AllowUserToDeleteRows = false;
            this.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.Modelo,
            this.ValorRevenda,
            this.Quantidade});
            this.gridItem.Location = new System.Drawing.Point(6, 59);
            this.gridItem.Name = "gridItem";
            this.gridItem.ReadOnly = true;
            this.gridItem.Size = new System.Drawing.Size(446, 189);
            this.gridItem.TabIndex = 31;
            this.gridItem.Click += new System.EventHandler(this.gridItem_Click);
            // 
            // IdProduto
            // 
            this.IdProduto.HeaderText = "Código";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // ValorRevenda
            // 
            this.ValorRevenda.HeaderText = "Valor";
            this.ValorRevenda.Name = "ValorRevenda";
            this.ValorRevenda.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade em Estoque";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(226, 17);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(99, 13);
            this.lblPesquisa.TabIndex = 32;
            this.lblPesquisa.Text = "Pesquisar Modelo";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(226, 33);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(226, 22);
            this.txtPesquisa.TabIndex = 33;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Location = new System.Drawing.Point(12, 9);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(0, 13);
            this.lblDica.TabIndex = 35;
            // 
            // comboItens
            // 
            this.comboItens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboItens.FormattingEnabled = true;
            this.comboItens.Location = new System.Drawing.Point(6, 32);
            this.comboItens.Name = "comboItens";
            this.comboItens.Size = new System.Drawing.Size(214, 21);
            this.comboItens.TabIndex = 36;
            // 
            // lblPesquisaTipo
            // 
            this.lblPesquisaTipo.AutoSize = true;
            this.lblPesquisaTipo.Location = new System.Drawing.Point(6, 16);
            this.lblPesquisaTipo.Name = "lblPesquisaTipo";
            this.lblPesquisaTipo.Size = new System.Drawing.Size(149, 13);
            this.lblPesquisaTipo.TabIndex = 37;
            this.lblPesquisaTipo.Text = "Selecionar tipo de pesquisa";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.txtPesquisa);
            this.grpBox.Controls.Add(this.lblPesquisaTipo);
            this.grpBox.Controls.Add(this.gridItem);
            this.grpBox.Controls.Add(this.comboItens);
            this.grpBox.Controls.Add(this.lblPesquisa);
            this.grpBox.Location = new System.Drawing.Point(12, 9);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(461, 263);
            this.grpBox.TabIndex = 38;
            this.grpBox.TabStop = false;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 288);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lblDica);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoque";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridItem;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorRevenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.ComboBox comboItens;
        private System.Windows.Forms.Label lblPesquisaTipo;
        private System.Windows.Forms.GroupBox grpBox;
    }
}
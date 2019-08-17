using Apresentacao.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmEstoque : Form
    {
        Service1Client wcf;
        public frmEstoque()
        {
            InitializeComponent();
            wcf = new Service1Client();
            MostrarDados();
            CarregarCombobox();
        }

        #region Métodos

        /// <summary>
        /// Carrega Itens da tabela produto em memória virtual
        /// </summary>
        private void MostrarDados()
        {
             if (gridItem.DataSource != "")
            {
                gridItem.Rows.Clear();
                foreach (var item in wcf.ConsultarProdutoDataAccess())
                {
                    string[] row = new string[] { item.IdProduto.ToString(), item.DescricaoModelo.ToString(), item.ValorRevenda.ToString(), item.Quantidade.ToString() };
                   gridItem.Rows.Add(row);

                }
            }
        }

        /// <summary>
        /// Consulta dado específico através do Código do produto
        /// </summary>
        private void BuscarDadosId()
        {
            try {
                if (gridItem.DataSource != "")
                {
                    gridItem.Rows.Clear();
                    txtPesquisa.Text = txtPesquisa.CaracteresEspeciais();
                    txtPesquisa.ValidarCodigo();
                    foreach (var item in wcf.ConsultarProdutoId(int.Parse(txtPesquisa.Text)))
                    {
                        string[] row = new string[] { item.IdProduto.ToString(), item.DescricaoModelo.ToString(), item.ValorRevenda.ToString(), item.Quantidade.ToString() };
                        gridItem.Rows.Add(row);

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Consulta dado específico através do Modelo do produto
        /// </summary>
        private void BuscarDadosModelo()
        {
            try {
                if (gridItem.DataSource != "")
                {
                    gridItem.Rows.Clear();
                    txtPesquisa.Text = txtPesquisa.CaracteresEspeciais();
                    txtPesquisa.ValidarNome();
                    foreach (var item in wcf.ConsultarProdutoModelo(txtPesquisa.Text))
                    {
                        string[] row = new string[] { item.IdProduto.ToString(), item.DescricaoModelo.ToString(), item.ValorRevenda.ToString(), item.Quantidade.ToString() };
                        gridItem.Rows.Add(row);

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Carrega Itens para consulta no combobox
        /// </summary>
        private void CarregarCombobox()
        {
            try
            {
                comboItens.Items.Add("Modelo");
                comboItens.Items.Add("Código");
                comboItens.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void gridItem_Click(object sender, EventArgs e)
        {
            lblDica.Text = "";
            MostrarDados();
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                MostrarDados();
            }
            else if (comboItens.Text == "Modelo")
            {
                BuscarDadosModelo();
            }
            else if (comboItens.Text == "Código")
            {
                BuscarDadosId();
            }
        }
    }
}

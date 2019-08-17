using Apresentacao.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao

{
    public partial class frmRelatorio : Form
    {
        Service1Client wcf;
        public frmRelatorio()
        {
            InitializeComponent();
            wcf = new Service1Client();
        }

        #region Métodos
        /// <summary>
        /// Consulta Vendas no banco de dados utilizando login como parâmetro
        /// </summary>
        private void ConsultarVendaFuncionario()
        {
            lblTotalSoma.Text = "";
            gridVenda.DataSource = null;
            try
            {
                decimal TotalSoma = 0;
                if (gridVenda.DataSource != "")
                {
                    gridVenda.ColumnCount = 6;
                    gridVenda.Columns[0].Name = "Login";
                    gridVenda.Columns[1].Name = "Cod Usuário";
                    gridVenda.Columns[2].Name = "Cod Venda";
                    gridVenda.Columns[3].Name = "Data Venda";
                    gridVenda.Columns[4].Name = "Cod Cliente";
                    gridVenda.Columns[5].Name = "Valor Total";

                    gridVenda.Rows.Clear();
                    foreach (var item in wcf.ConsultarVendaId(txtIdUsuario.Text))
                    {
                        string[] row = new string[] { item.NomeFunconario, item.IdFuncionario.ToString(), item.IdVenda.ToString(), item.DataVenda.ToShortDateString(), item.IdCliente.ToString(), item.ValorTotal.ToString() };
                        gridVenda.Rows.Add(row);

                        TotalSoma += item.ValorTotal;

                        lblTotalSoma.Text = "Valor Somado: R$ " + TotalSoma.ToString() + ",00";
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados, contate o desenvolvedor. Mensagem original: "+  ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor. Mensagem original: " + ex.Message);
            }
        }

        /// <summary>
        /// Consulta Compra no banco de dados utilizando login como parâmetro
        /// </summary>
        private void ConsultarCompraFuncionario()
        {
            lblTotalCompra.Text = "";
            gridCompra.DataSource = null;
            try
            {
                decimal TotalSoma = 0;
                if (gridCompra.DataSource != "")
                {
                    gridCompra.ColumnCount = 5;
                    gridCompra.Columns[0].Name = "Login";
                    gridCompra.Columns[1].Name = "Cod Usuario";
                    gridCompra.Columns[2].Name = "Cod Compra";
                    gridCompra.Columns[3].Name = "Data Compra";
                    gridCompra.Columns[4].Name = "Valor Total";

                    gridCompra.Rows.Clear();
                    foreach (var item in wcf.ConsultarCompraId(txtLoginCompra.Text))
                    {
                        string[] row = new string[] { item.NomeFuncionario, item.IdCompraUsuario.ToString(), item.IdCompra.ToString(), item.DataCompra.ToShortDateString(), item.ValorTotalCompra.ToString() };
                        gridCompra.Rows.Add(row);

                        TotalSoma += item.ValorTotalCompra;

                        lblTotalCompra.Text = "Valor Somado: R$ " + TotalSoma.ToString() + ",00";
                    }
                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados, contate o desenvolvedor. Mensagem original: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor. Mensagem original: " + ex.Message);
            }
        }


        /// <summary>
        /// Consulta vendas no banco de dados utilizando intervalo de datas
        /// </summary>
        private void ConsultarVendaData()
        {
            lblTotalSoma.Text = "";
            gridVenda.DataSource = null;
            try
            {
                decimal TotalSoma = 0;
                if (gridVenda.DataSource != "")
                {
                    gridVenda.ColumnCount = 6;
                    gridVenda.Columns[0].Name = "Cod Usuário";
                    gridVenda.Columns[1].Name = "Login";
                    gridVenda.Columns[2].Name = "Nome Usuário";
                    gridVenda.Columns[3].Name = "Data Venda";
                    gridVenda.Columns[4].Name = "Cod Cliente";
                    gridVenda.Columns[5].Name = "Valor Total";

                    gridVenda.Rows.Clear();
                    foreach (var item in wcf.ConsultarVendaDatas(DateTime.Parse(txtData1.Text), DateTime.Parse(txtData2.Text)))
                    {
                        string[] row = new string[] { item.IdFuncionario.ToString(), item.LogIn, item.NomeFunconario, item.DataVenda.ToShortDateString(), item.IdCliente.ToString(), item.ValorTotal.ToString() };
                        gridVenda.Rows.Add(row);

                        TotalSoma += item.ValorTotal;

                        lblTotalSoma.Text = "Valor Somado: R$ " + TotalSoma.ToString() + ",00";

                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados, contate o desenvolvedor. Mensagem original: ", ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor. Mensagem original: ", ex.Message);
            }
            finally
            {
                Validacoes.limparTxt(this);
            }
        }

        private void ConsultarCompraData()
        {
            lblTotalCompra.Text = "";
            gridCompra.DataSource = null;
            try
            {
                decimal TotalSoma = 0;
                if (gridCompra.DataSource != "")
                {
                    gridCompra.ColumnCount = 5;
                    gridCompra.Columns[0].Name = "Cod Usuário";
                    gridCompra.Columns[1].Name = "Login";
                    gridCompra.Columns[2].Name = "Nome Usuário";
                    gridCompra.Columns[3].Name = "Data Compra";
                    gridCompra.Columns[4].Name = "Valor Total";

                    gridCompra.Rows.Clear();
                    foreach (var item in wcf.ConsultarCompraDatas(DateTime.Parse(txtData1Compra.Text), DateTime.Parse(txtData2Compra.Text)))
                    {
                        string[] row = new string[] { item.IdCompraUsuario.ToString(), item.LogIn, item.NomeFuncionario, item.DataCompra.ToShortDateString(), item.ValorTotalCompra.ToString() };
                        gridCompra.Rows.Add(row);

                        TotalSoma += item.ValorTotalCompra;

                        lblTotalCompra.Text = "Valor Somado: R$ " + TotalSoma.ToString() + ",00";

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados, contate o desenvolvedor. Mensagem original: ", ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor. Mensagem original: ", ex.Message);
            }
            finally
            {
                Validacoes.limparTxt(this);
            }
        }

        #endregion

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            txtData2.Text = DateTime.Today.ToShortDateString();
            txtData2Compra.Text = DateTime.Today.ToShortDateString();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtData1.Text == "" && txtData2.Text == "")
            {
                MessageBox.Show("Preencha as datas, por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { ConsultarVendaData(); }
        }
        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            ConsultarVendaFuncionario();
            if (txtIdUsuario.Text == "")
            {
                gridVenda.ColumnCount = 0;
                lblTotalSoma.Text = "";
            }
        }

        private void txtLoginCompra_TextChanged(object sender, EventArgs e)
        {
            ConsultarCompraFuncionario();
            if (txtLoginCompra.Text == "")
            {
                gridCompra.ColumnCount = 0;
                lblTotalCompra.Text = "";
            }
        }

        private void btnPesquisaCompra_Click(object sender, EventArgs e)
        {
            if (txtData1Compra.Text == "" && txtData2Compra.Text == "")
            {
                MessageBox.Show("Preencha as datas, por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { ConsultarCompraData(); }
        }
    }
}

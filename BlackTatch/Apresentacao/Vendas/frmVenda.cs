using Apresentacao.ServiceReference1;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmVenda : Form
    {
        Service1Client wcf;
        public frmVenda()
        {
            InitializeComponent();
            wcf = new Service1Client();
        }
        public frmVenda(int IdUsuario)
        {
            InitializeComponent();
            wcf = new Service1Client();
            Id = IdUsuario;
        }
        public int Id;
        #region Métodos

        /// <summary>
        /// Consulta produtos no banco e preenche labels com informações
        /// </summary>
        private void SelecionarProduto()
        { 
            try
            {
                if (txtCodigo.Text != "")
                {
                    lblDescricaoProduto.Text = wcf.SelecionarProduto(int.Parse(txtCodigo.Text)).DescricaoModelo;
                    lblCifrao.Visible = true;
                    lblPrecoUnitario.Text = wcf.SelecionarProduto(int.Parse(txtCodigo.Text)).ValorRevenda.ToString() + ",00";
                    lblQuantidadeEstoque.Text = wcf.SelecionarProduto(int.Parse(txtCodigo.Text)).Quantidade.ToString();
                    
                }
                else if (txtCodigo.Text == "")
                {
                    lblDescricaoProduto.Text = "";
                    lblPrecoUnitario.Text = "";
                    lblQuantidadeEstoque.Text = "";
                    lblCifrao.Text = "";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados, contate o desenvolvedor. Mensagem original \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor. Mensagem original \n" + ex.Message);
            }
        }

        /// <summary>
        /// Insere produtos na lista para conferência
        /// </summary>
        private void InserirLista()
        {
            try
            {
                decimal ValorTotal = 0;
                decimal ValorSubTotal;
                txtQuantidade.Text = txtQuantidade.ValidarVazio();
                txtQuantidade.ValidarCodigo();
                ValorSubTotal = ((decimal.Parse(lblPrecoUnitario.Text)) * (decimal.Parse(txtQuantidade.Text)));
                var Item = new ListViewItem(new[] { txtCodigo.Text, lblDescricaoProduto.Text, lblPrecoUnitario.Text, txtQuantidade.Text, ValorSubTotal.ToString() });
                listVenda.Items.Add(Item);
                foreach (ListViewItem i in listVenda.Items)
                {
                    ValorTotal += decimal.Parse(i.SubItems[4].Text);
                }
                lblValorTotal.Text = ValorTotal.ToString();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados, contate o desenvolvedor. Mensagem Original: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor. Mensagem Original: " + ex.Message);
            }
        }

        /// <summary>
        /// cadastra venda e deduz quantidade no estoque
        /// </summary>
        private void CadastrarVenda()
        {
            try 
            {
                    Venda NovaVenda = new Venda();
                    NovaVenda.IdFuncionario = Id;

                    txtCodCliente.Text = txtCodCliente.CaracteresEspeciais();
                    txtCodCliente.ValidarCodigo();
                    NovaVenda.IdCliente = int.Parse(txtCodCliente.Text);
                    NovaVenda.DataVenda = DateTime.Today;
                    NovaVenda.ValorTotal = decimal.Parse(lblValorTotal.Text);
                    wcf.InserirVenda(NovaVenda);
                    Validacoes.limparTxt(this);
                    lblCifrao.Visible = false;
                    Venda NovoItensVenda = new Venda();

                    Produto SubtrairProduto = new Produto();
                    foreach (ListViewItem item in listVenda.Items)
                    {
                        NovoItensVenda.IdProduto = int.Parse(item.SubItems[0].Text);
                        NovoItensVenda.PrecoUnitario = decimal.Parse(item.SubItems[2].Text);
                        NovoItensVenda.Quantidade = int.Parse(item.SubItems[3].Text);
                        wcf.InserirItensVenda(NovoItensVenda);
                    }
                    foreach (ListViewItem item in listVenda.Items)
                    {
                        SubtrairProduto.DescricaoModelo = item.SubItems[1].Text;
                        SubtrairProduto.Quantidade = int.Parse(item.SubItems[3].Text);
                        wcf.AtualizarProdutoSub(SubtrairProduto);
                    }
                    DialogResult confirmacao = MessageBox.Show("Venda efetuada com sucesso!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(confirmacao == DialogResult.OK)
                {
                    lblValorTotal.Text = "";
                }
                    listVenda.Items.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados, contate o desenvolvedor. Mensagem Original: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor. Mensagem Original: " + ex.Message);
            }
        }

        #endregion

        private void btnCadastrar_Click(object sender, System.EventArgs e)
            {
               CadastrarVenda();
            }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            SelecionarProduto();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Digite um valor válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (int.Parse(txtQuantidade.Text) > (int.Parse(lblQuantidadeEstoque.Text)) || (int.Parse(txtQuantidade.Text)) <= 0)
            {
                MessageBox.Show("Não é possível efetuar venda, quantidade solicitada é maior que o volume em estoque ou quantidade zerada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else { btnCadastrar.Enabled = true; InserirLista(); }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            frmEstoque EstoqueForm = new frmEstoque();
            EstoqueForm.ShowDialog();
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            frmCliente ClienteForm = new frmCliente();
            ClienteForm.ShowDialog();
        }

        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCliente.Checked == true)
            {
                btnPesquisarCliente.Enabled = true;
                lblCodigoCliente.Enabled = true;
                txtCodCliente.Enabled = true;
            }
            else if (chkCliente.Checked == false)
            {
                btnPesquisarCliente.Enabled = false;
                lblCodigoCliente.Enabled = false;
                txtCodCliente.Enabled = false;
            }
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            txtCodCliente.Text = "1";
        }
    }
}

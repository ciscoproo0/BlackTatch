using Apresentacao.ServiceReference1;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmFornecedor : Form
    {
        Service1Client wcf;
        public frmFornecedor()
        {
            InitializeComponent();
            wcf = new Service1Client();
            CarregarDados();
        }
        public frmFornecedor(int IdUsuario)
        {
            InitializeComponent();
            wcf = new Service1Client();
            CarregarDados();
            Id = IdUsuario;
        }
        public int Id;
        #region Métodos

        /// <summary>
        /// Carrega dados do fornecedor para o datagridview
        /// </summary>
        private void CarregarDados()
        {
            dtGridFornecedor.DataSource = wcf.ConsultarFornecedorDataAccess();
            dtGridFornecedor.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// carrega itens disponíveis da tabela produto;
        /// </summary>
        private void CarregarCombo()
        {
            try
            {
                comboProdutos.DataSource = null;
                comboProdutos.Items.Clear();
                if (comboProdutos.DataSource == null)
                {
                    foreach (var produto in wcf.ConsultarProdutoDataAccess())
                    {
                        comboProdutos.Items.Add(produto.DescricaoModelo);

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
        /// Pesquisa Fornecedor utilizando nome como parâmetro
        /// </summary>
        private void PesquisarDados()
        {

            try
            {
                this.dtGridFornecedor.DataSource = null;


                if (dtGridFornecedor.DataSource != "")
                {
                    dtGridFornecedor.ColumnCount = 5;
                    dtGridFornecedor.Columns[0].Name = "Cod Fornecedor";
                    dtGridFornecedor.Columns[1].Name = "Nome";
                    dtGridFornecedor.Columns[2].Name = "Telefone";
                    dtGridFornecedor.Columns[3].Name = "Site";
                    dtGridFornecedor.Columns[4].Name = "CNPJ";

                    dtGridFornecedor.Rows.Clear();
                    txtPesquisa.Text = txtPesquisa.CaracteresEspeciais();
                    foreach (var item in wcf.ConsultarFornecedorNome(txtPesquisa.Text))
                    {
                        string[] row = new string[] { item.IdFornecedor.ToString(), item.NomeEmpresa.ToString(), item.TelefoneFixo.ToString(), item.HomePage.ToString(), item.CNPJ.ToString() };
                        dtGridFornecedor.Rows.Add(row);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados, contate o desenvolvedor. Mensagem original: \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor. Mensagem original: \n" + ex.Message);
            }
        }

        /// <summary>
        /// Desativa todos os controles de inserção de compra, forçando o usuário a selecionar um fornecedor primeiro
        /// </summary>
        private void ControlesDesativadosNovaCompra()
        {
            btnCompra.Enabled = false;
            txtDataCompra.Enabled = false;
            txtValorCompra.Enabled = false;
            txtCompraDescricao.Enabled = false;
            txtNaturezaOperacao.Enabled = false;
            txtQuantidadeTotal.Enabled = false;
            btnInserirCompra.Enabled = false;
            comboProdutos.Enabled = false;
            txtPrecoCusto.Enabled = false;
            txtNotaFiscal.Enabled = false;
            numQuant.Enabled = false;
            btnInserirModelo.Enabled = false;
            btnlista.Enabled = false;
            gridItem.Enabled = false;
            btnItens.Enabled = false;
            btnInserirCompra.Enabled = false;
        }

        /// <summary>
        /// Ativa controles para inserção de compra
        /// </summary>
        private void ControlesAtivosNovaCompra()
        {
            txtDataCompra.Enabled = true;
            txtValorCompra.Enabled = true;
            txtCompraDescricao.Enabled = true;
            txtNaturezaOperacao.Enabled = true;
            txtQuantidadeTotal.Enabled = true;
            btnInserirCompra.Enabled = true;
        }

        /// <summary>
        /// Ativa controles para inserção de itens da compra
        /// </summary>
        private void ControlesAtivosItens()
        {
            btnInserirCompra.Enabled = false;
            comboProdutos.Enabled = true;
            txtPrecoCusto.Enabled = true;
            txtNotaFiscal.Enabled = true;
            numQuant.Enabled = true;
            btnInserirModelo.Enabled = true;
            btnlista.Enabled = true;
        }

        /// <summary>
        /// Ativa controles para listar itens
        /// </summary>
        private void controlesAtivosLista()
        {
            gridItem.Enabled = true;
            btnItens.Enabled = true;
        }

        /// <summary>
        /// Insere novo fornecedor no banco de dados
        /// </summary>
        private void InserirFornecedor()
        {
            try
            {
                Fornecedor novoFornecedor = new Fornecedor();

                txtNomeEmpresa.Text = txtNomeEmpresa.CaracteresEspeciais();
                txtNomeEmpresa.ValidarVazio();
                novoFornecedor.NomeEmpresa = txtNomeEmpresa.Text;

                txtNomeRepresentante.Text = txtNomeRepresentante.CaracteresEspeciais();
                txtNomeRepresentante.ValidarVazio();
                novoFornecedor.NomeRepresentante = txtNomeRepresentante.Text;

                txtEmailEmpresa.Text = txtEmailEmpresa.ValidarEmail();
                novoFornecedor.EmailEmpresa = txtEmailEmpresa.Text;

                txtEmailRepresen.Text = txtEmailRepresen.ValidarEmail();
                novoFornecedor.EmailRepresentante = txtEmailRepresen.Text;

                txtTelFixo.Text = txtTelFixo.ValidarTelFixo();
                novoFornecedor.TelefoneFixo = txtTelFixo.Text;

                txtTelCelRep.Text = txtTelCelRep.ValidarTelCel();
                novoFornecedor.TelefoneCelularRepresentante = txtTelCelRep.Text;

                txtHomePage.Text = txtHomePage.ValidarSite();
                novoFornecedor.HomePage = txtHomePage.Text;

                txtCNPJ.Text = txtCNPJ.ValidarCNPJ();
                novoFornecedor.CNPJ = txtCNPJ.Text;

                txtIE.Text = txtIE.CaracteresEspeciais();
                novoFornecedor.IE = txtIE.Text;

                txtEndereco.Text = txtEndereco.CaracteresEspeciais();
                novoFornecedor.Endereco = txtEndereco.Text;

                txtBairro.Text = txtBairro.CaracteresEspeciais();
                novoFornecedor.Bairro = txtBairro.Text;

                txtNumero.Text = txtNumero.CaracteresEspeciais();
                novoFornecedor.Numero = txtNumero.Text;

                txtCEP.Text = txtCEP.ValidarCEP();
                novoFornecedor.CEP = txtCEP.Text;

                DialogResult cadastro = MessageBox.Show("Confira os dados cadastrados, se tiver certeza pressione SIM para confirmar cadastro", "Cadastro de Fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cadastro == DialogResult.Yes)
                {
                    wcf.InserirFornecedor(novoFornecedor);
                    CarregarDados();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha os dados", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Atualiza fornecedor no banco de dados
        /// </summary>
        private void AtualizarFornecedor()
        {
            try
            {
                Fornecedor FornecedorAtualizar = new Fornecedor();

                FornecedorAtualizar.IdFornecedor = (int)dtGridFornecedor.CurrentRow.Cells[0].Value;
                txtNomeEmpresa.Text = txtNomeEmpresa.CaracteresEspeciais();
                txtNomeEmpresa.ValidarVazio();
                FornecedorAtualizar.NomeEmpresa = txtNomeEmpresa.Text;

                txtNomeRepresentante.Text = txtNomeRepresentante.CaracteresEspeciais();
                txtNomeRepresentante.ValidarVazio();
                FornecedorAtualizar.NomeRepresentante = txtNomeRepresentante.Text;

                txtEmailEmpresa.Text = txtEmailEmpresa.ValidarEmail();
                FornecedorAtualizar.EmailEmpresa = txtEmailEmpresa.Text;

                txtEmailRepresen.Text = txtEmailRepresen.ValidarEmail();
                FornecedorAtualizar.EmailRepresentante = txtEmailRepresen.Text;

                txtTelFixo.Text = txtTelFixo.ValidarTelFixo();
                FornecedorAtualizar.TelefoneFixo = txtTelFixo.Text;

                txtTelCelRep.Text = txtTelCelRep.ValidarTelCel();
                FornecedorAtualizar.TelefoneCelularRepresentante = txtTelCelRep.Text;

                txtHomePage.Text = txtHomePage.ValidarSite();
                FornecedorAtualizar.HomePage = txtHomePage.Text;

                txtCNPJ.Text = txtCNPJ.ValidarCNPJ();
                FornecedorAtualizar.CNPJ = txtCNPJ.Text;

                txtIE.Text = txtIE.CaracteresEspeciais();
                FornecedorAtualizar.IE = txtIE.Text;

                txtEndereco.Text = txtEndereco.CaracteresEspeciais();
                FornecedorAtualizar.Endereco = txtEndereco.Text;

                txtBairro.Text = txtBairro.CaracteresEspeciais();
                FornecedorAtualizar.Bairro = txtBairro.Text;

                txtNumero.Text = txtNumero.CaracteresEspeciais();
                FornecedorAtualizar.Numero = txtNumero.Text;

                txtCEP.Text = txtCEP.ValidarCEP();
                FornecedorAtualizar.CEP = txtCEP.Text;
                DialogResult cadastro = MessageBox.Show("Confira os dados alterados, se tiver certeza pressione SIM para confirmar cadastro", "Cadastro de Fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cadastro == DialogResult.Yes)
                {
                    wcf.AtualizarFornecedor(FornecedorAtualizar);
                    CarregarDados();
                    Validacoes.limparTxt(this);
                    dtGridFornecedor.CurrentRow.Selected = false;
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
        /// Seleciona fornecedor no grid e completa informações nos textboxes
        /// </summary>
        private void SelecionarFornecedor()
        {
            try
            {
                btnCompra.Enabled = true;
                btnInserir.Enabled = false;
                lblIdForn.Text = dtGridFornecedor.CurrentRow.Cells[0].Value.ToString();

                if (lblIdForn.Text != "")
                {
                    txtNomeEmpresa.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).NomeEmpresa;
                    txtNomeRepresentante.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).NomeRepresentante;
                    txtEmailEmpresa.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).EmailEmpresa;
                    txtEmailRepresen.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).EmailRepresentante;
                    txtTelFixo.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).TelefoneFixo;
                    txtTelCelRep.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).TelefoneCelularRepresentante;
                    txtHomePage.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).HomePage;
                    txtCNPJ.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).CNPJ;
                    txtIE.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).IE;
                    txtEndereco.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).Endereco;
                    txtBairro.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).Bairro;
                    txtNumero.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).Numero;
                    txtCEP.Text = wcf.SelecionarFornecedor(int.Parse(lblIdForn.Text)).CEP;
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
        /// Insere nova compra na tabela compra
        /// </summary>
        private void InserirNovaCompra()
        {
            try
            {
                Compra NovaCompra = new Compra();
                NovaCompra.IdCompraFornecedor = Convert.ToInt32(lblIdForn.Text);

                txtDataCompra.Text = txtDataCompra.ValidarVazio();
                txtDataCompra.ValidarData();
                NovaCompra.DataCompra = Convert.ToDateTime(txtDataCompra.Text);

                txtValorCompra.Text = txtValorCompra.ValidarVazio();
                txtValorCompra.ValidarValor();
                NovaCompra.ValorTotalCompra = Convert.ToDecimal(txtValorCompra.Text);

                txtCompraDescricao.Text = txtCompraDescricao.CaracteresEspeciais();
                txtCompraDescricao.ValidarVazio();
                NovaCompra.CompraDescricao = txtCompraDescricao.Text;

                txtNaturezaOperacao.Text = txtNaturezaOperacao.CaracteresEspeciais();
                txtNaturezaOperacao.ValidarVazio();
                NovaCompra.NaturezaOperacao = txtNaturezaOperacao.Text;

                for (int i = 1; i <= (int.Parse(txtQuantidadeTotal.Text)); i++)
                {
                    numQuant.Maximum = i;
                }

                txtQuantidadeTotal.Text = txtQuantidadeTotal.ValidarVazio();
                txtQuantidadeTotal.ValidarCodigo();
                NovaCompra.QuantidadeTotal = Convert.ToInt32(txtQuantidadeTotal.Text);

                NovaCompra.IdCompraUsuario = Id;
                DialogResult Confirmacao = MessageBox.Show("Nova Compra Iniciada, por favor, verifique se os dados inseridos estão corretos, clique em SIM e em seguida descreva os itens que foram adquiridos nessa compra", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Confirmacao == DialogResult.Yes)
                {
                    wcf.InserirCompra(NovaCompra);
                    ControlesAtivosItens();
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
        /// Insere dados da nova compra no grid de itens
        /// </summary>
        private void ListarItens()
        {
            try
            {
                gridItem.Rows.Insert(0, comboProdutos.Text, txtPrecoCusto.Text, txtNotaFiscal.Text, numQuant.Text);
                controlesAtivosLista();
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
        /// Insere itens da compra na tabela itens da compra e soma novos itens na tabela produto
        /// </summary>
        private void InserirItensCompra()
        {
            try
            {
                Compra NovaCompra = new Compra();
                NovaCompra.DescricaoModelo = gridItem.CurrentRow.Cells[0].Value.ToString();
                NovaCompra.PrecoCusto = Convert.ToDecimal(gridItem.CurrentRow.Cells[1].Value);
                NovaCompra.NotaCompra = gridItem.CurrentRow.Cells[2].Value.ToString();
                NovaCompra.QuantidadeItem = Convert.ToInt32(gridItem.CurrentRow.Cells[3].Value);
                wcf.InserirItensCompra(NovaCompra);

                Produto AtualizarProduto = new Produto();
                AtualizarProduto.DescricaoModelo = gridItem.CurrentRow.Cells[0].Value.ToString();
                AtualizarProduto.Quantidade = Convert.ToInt32(gridItem.CurrentRow.Cells[3].Value);
                wcf.AtualizarProdutoSoma(AtualizarProduto);
                DialogResult confirmacao = MessageBox.Show("Compra inserida com sucesso!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (confirmacao == DialogResult.OK)
                {
                    ControlesDesativadosNovaCompra();
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

        #endregion
        
        private void btnCompra_Click(object sender, EventArgs e)
        {
            ControlesAtivosNovaCompra();
            txtDataCompra.Text = DateTime.Today.ToShortDateString();
        }
        private void btnInserirCompra_Click(object sender, EventArgs e)
        {
            InserirNovaCompra();


        }
        private void btnlista_Click(object sender, EventArgs e)
        {
            ListarItens();
            numQuant.Maximum -= numQuant.Value;
        }
        private void btnItens_Click(object sender, EventArgs e)
        {
            InserirItensCompra();
        }
        private void btnInserirModelo_Click(object sender, EventArgs e)
        {
            frmCadastrarModelo ModeloForm = new frmCadastrarModelo();
            ModeloForm.ShowDialog();
        }
        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            CarregarCombo();
            ControlesDesativadosNovaCompra();
            btnInserir.Enabled = false;
        }
        private void comboProdutos_Click(object sender, EventArgs e)
        {
            CarregarCombo();
        }
        private void dtGridFornecedor_Click(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = true;
            SelecionarFornecedor();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            InserirFornecedor();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarFornecedor();

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Validacoes.limparTxt(this);
            btnInserir.Enabled = true;
            btnAtualizar.Enabled = false;
            ControlesDesativadosNovaCompra();
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            PesquisarDados();
        }

    }
}


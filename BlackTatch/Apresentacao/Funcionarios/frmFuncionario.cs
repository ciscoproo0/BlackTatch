using Apresentacao.ServiceReference1;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmFuncionario : Form
    {
        Service1Client wcf;

        public frmFuncionario()
        {
            InitializeComponent();
            wcf = new Service1Client();
            CarregarDados();
            btnReset.Enabled = false;

        }

        #region Métodos

        /// <summary>
        /// carrega dados do funcionário no grid
        /// </summary>
        private void CarregarDados()
        {
            dtGridFuncionario.DataSource = wcf.ConsultarFuncionarioDataAccess();
            dtGridFuncionario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// pesquisa dados do funcionario e mostra no grid, utilizando nome como parâmetro
        /// </summary>
        private void PesquisaDados()
        {
            try
            {
                this.dtGridFuncionario.DataSource = null;


                if (dtGridFuncionario.DataSource != "")
                {
                    dtGridFuncionario.ColumnCount = 5;
                    dtGridFuncionario.Columns[0].Name = "Cod Funcionario";
                    dtGridFuncionario.Columns[1].Name = "Nome";
                    dtGridFuncionario.Columns[2].Name = "CPF";
                    dtGridFuncionario.Columns[3].Name = "CEP";
                    dtGridFuncionario.Columns[4].Name = "Email";

                    dtGridFuncionario.Rows.Clear();
                    txtPesquisa.Text = txtPesquisa.CaracteresEspeciais();
                    foreach (var item in wcf.ConsultarFuncionarioNome(txtPesquisa.Text))
                    {
                        string[] row = new string[] { item.IdFuncionario.ToString(), item.Nome.ToString(), item.CPF.ToString(), item.Cep.ToString(), item.Email.ToString() };
                        dtGridFuncionario.Rows.Add(row);
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
        /// preenche textboxes com informação do usuário, clicando na célula do grid
        /// </summary>
        private void SelecionarFuncionario()
        {
            try
            {
                lblIdFunc.Text = dtGridFuncionario.CurrentRow.Cells[0].Value.ToString();

                if (lblIdFunc.Text != "")
                {
                    txtNome.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Nome;
                    txtRG.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).RG;
                    txtCPF.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).CPF;
                    txtDtNascimento.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).DataNascimento.ToShortDateString();
                    txtEmail.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Email;
                    txtNacionalidade.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Nacionalidade;
                    txtEndereco.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Endereco;
                    txtNumero.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).NumeroEndereco;
                    txtTipoEndereco.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).TipoEndereco;
                    txtComplemento.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Complemento;
                    txtBairro.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Bairro;
                    txtCidade.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Cidade;
                    txtCEP.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Cep;
                    txtUF.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).UF;
                    txtTituloEleitor.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).TituloEleitor;
                    txtSecaoEleitor.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).SecaoEleitor;
                    txtZonaEleitoral.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).ZonaEleitoral;
                    txtPis.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).PIS;
                    txtCarteiraProfissional.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).CarteiraProfissional;
                    txtSerieCarteiraProfissional.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).SerieCarteiraProfisional;
                    txtTelRes.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).TelefoneResidencial;
                    txtTelCel.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).TelefoneCelular;
                    txtCargo.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Cargo;
                    txtSalario.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Salario.ToString();
                    txtComissao.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Comissao.ToString();
                    txtObs.Text = wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).OBS;
                    if (wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Ativo == true)
                    {
                        rdoSim.Checked = true;
                        rdoNao.Checked = false;
                        AtivarControles();
                    }
                    else if (wcf.SelecionarFuncionario(int.Parse(lblIdFunc.Text)).Ativo == false)
                    {
                        rdoSim.Checked = false;
                        rdoNao.Checked = true;
                        DesativarControles();
                    }
                    btnInserir.Enabled = false;
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
        /// Insere novo funcionário no banco de dados
        /// </summary>
        private void InserirFuncionario()
        {

            try
            {
                Funcionario novoFuncionario = new Funcionario();

                txtNome.Text = txtNome.ValidarNome();
                txtNome.ValidarVazio();
                novoFuncionario.Nome = txtNome.Text;

                txtCPF.Text = txtCPF.ValidarCPF();
                txtCPF.ValidarVazio();
                novoFuncionario.CPF = txtCPF.Text;

                txtRG.Text = txtRG.ValidarRG();
                txtRG.ValidarVazio();
                novoFuncionario.RG = txtRG.Text;

                txtDtNascimento.Text = txtDtNascimento.ValidarVazio();
                txtDtNascimento.ValidarData();
                novoFuncionario.DataNascimento = Convert.ToDateTime(txtDtNascimento.Text);

                txtEmail.Text = txtEmail.ValidarEmail();
                txtEmail.ValidarVazio();
                novoFuncionario.Email = txtEmail.Text;

                txtNacionalidade.Text = txtNacionalidade.ValidarVazio();
                txtNacionalidade.CaracteresEspeciais();
                novoFuncionario.Nacionalidade = txtNacionalidade.Text;

                txtEndereco.Text = txtEndereco.CaracteresEspeciais();
                txtEndereco.ValidarVazio();
                novoFuncionario.Endereco = txtEndereco.Text;

                txtNumero.Text = txtNumero.ValidarVazio();
                txtNumero.CaracteresEspeciais();
                novoFuncionario.NumeroEndereco = txtNumero.Text;

                txtTipoEndereco.Text = txtTipoEndereco.CaracteresEspeciais();
                txtTipoEndereco.ValidarVazio();
                novoFuncionario.TipoEndereco = txtTipoEndereco.Text;

                txtComplemento.Text = txtComplemento.CaracteresEspeciais();
                txtComplemento.ValidarVazio();
                novoFuncionario.Complemento = txtComplemento.Text;

                txtBairro.Text = txtBairro.CaracteresEspeciais();
                txtBairro.ValidarVazio();
                novoFuncionario.Bairro = txtBairro.Text;

                txtCidade.Text = txtCidade.CaracteresEspeciais();
                txtCidade.ValidarVazio();
                novoFuncionario.Cidade = txtCidade.Text;

                txtCEP.Text = txtCEP.ValidarCEP();
                txtCEP.ValidarVazio();
                novoFuncionario.Cep = txtCEP.Text;

                txtUF.Text = txtUF.CaracteresEspeciais();
                txtUF.ValidarVazio();
                novoFuncionario.UF = txtUF.Text;

                novoFuncionario.TituloEleitor = txtTituloEleitor.Text;
                novoFuncionario.SecaoEleitor = txtSecaoEleitor.Text;
                novoFuncionario.ZonaEleitoral = txtZonaEleitoral.Text;
                novoFuncionario.PIS = txtPis.Text;

                txtObs.Text = txtObs.CaracteresEspeciais();
                novoFuncionario.OBS = txtObs.Text;

                novoFuncionario.CarteiraProfissional = txtCarteiraProfissional.Text;
                novoFuncionario.SerieCarteiraProfisional = txtSerieCarteiraProfissional.Text;

                txtCargo.Text = txtCargo.ValidarVazio();
                txtCargo.CaracteresEspeciais();
                novoFuncionario.Cargo = txtCargo.Text;

                txtSalario.Text = txtSalario.ValidarVazio();
                txtSalario.ValidarValor();
                novoFuncionario.Salario = Convert.ToDecimal(txtSalario.Text);

                txtComissao.Enabled = false;
                txtComissao.Text = "0";
                novoFuncionario.Comissao = Convert.ToDecimal(txtComissao.Text);

                txtTelCel.Text = txtTelCel.ValidarTelCel();
                novoFuncionario.TelefoneCelular = txtTelCel.Text;

                txtTelRes.Text = txtTelRes.ValidarTelFixo();
                novoFuncionario.TelefoneResidencial = txtTelRes.Text;

                wcf.InserirFuncionario(novoFuncionario);
                DialogResult confirmacao = MessageBox.Show("Funcionário inserido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (confirmacao == DialogResult.OK) { Validacoes.limparTxt(this); dtGridFuncionario.CurrentRow.Selected = false; }

                CarregarDados();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha os campos de cadastro", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                AtivarControles();
            }
        }
    
        /// <summary>
        /// Atualiza funcionário no banco de dados
        /// </summary>
        private void AtualizarFuncionario()
        {
            try
            {

                Funcionario FuncionarioAtualizar = new Funcionario();

                FuncionarioAtualizar.IdFuncionario = (int)dtGridFuncionario.CurrentRow.Cells[0].Value;

                txtNome.Text = txtNome.CaracteresEspeciais();
                txtNome.ValidarVazio();
                FuncionarioAtualizar.Nome = txtNome.Text;

                txtCPF.Text = txtCPF.ValidarCPF();
                txtCPF.ValidarVazio();
                FuncionarioAtualizar.CPF = txtCPF.Text;

                txtRG.Text = txtRG.ValidarRG();
                txtRG.ValidarVazio();
                FuncionarioAtualizar.RG = txtRG.Text;

                txtDtNascimento.Text = txtDtNascimento.ValidarVazio();
                txtDtNascimento.ValidarData();
                FuncionarioAtualizar.DataNascimento = Convert.ToDateTime(txtDtNascimento.Text);

                txtEmail.Text = txtEmail.ValidarEmail();
                txtEmail.ValidarVazio();
                FuncionarioAtualizar.Email = txtEmail.Text;

                txtNacionalidade.Text = txtNacionalidade.CaracteresEspeciais();
                txtNacionalidade.ValidarVazio();
                FuncionarioAtualizar.Nacionalidade = txtNacionalidade.Text;

                txtEndereco.Text = txtEndereco.CaracteresEspeciais();
                txtEndereco.ValidarVazio();
                FuncionarioAtualizar.Endereco = txtEndereco.Text;

                txtNumero.Text = txtNumero.CaracteresEspeciais();
                txtNumero.ValidarVazio();
                FuncionarioAtualizar.NumeroEndereco = txtNumero.Text;

                txtTipoEndereco.Text = txtTipoEndereco.CaracteresEspeciais();
                FuncionarioAtualizar.TipoEndereco = txtTipoEndereco.Text;

                txtComplemento.Text = txtComplemento.CaracteresEspeciais();
                FuncionarioAtualizar.Complemento = txtComplemento.Text;

                txtBairro.Text = txtBairro.CaracteresEspeciais();
                txtBairro.ValidarVazio();
                FuncionarioAtualizar.Bairro = txtBairro.Text;

                txtCidade.Text = txtCidade.CaracteresEspeciais();
                txtCidade.ValidarVazio();
                FuncionarioAtualizar.Cidade = txtCidade.Text;

                txtCEP.Text = txtCEP.ValidarCEP();
                txtCEP.ValidarVazio();
                FuncionarioAtualizar.Cep = txtCEP.Text;

                txtUF.Text = txtUF.CaracteresEspeciais();
                txtUF.ValidarVazio();
                FuncionarioAtualizar.UF = txtUF.Text;

                txtTituloEleitor.Text = txtTituloEleitor.CaracteresEspeciais();
                FuncionarioAtualizar.TituloEleitor = txtTituloEleitor.Text;

                txtSecaoEleitor.Text = txtSecaoEleitor.CaracteresEspeciais();
                FuncionarioAtualizar.SecaoEleitor = txtSecaoEleitor.Text;

                txtZonaEleitoral.Text = txtZonaEleitoral.CaracteresEspeciais();
                FuncionarioAtualizar.ZonaEleitoral = txtZonaEleitoral.Text;

                txtPis.Text = txtPis.CaracteresEspeciais();
                FuncionarioAtualizar.PIS = txtPis.Text;

                txtObs.Text = txtObs.CaracteresEspeciais();
                FuncionarioAtualizar.OBS = txtObs.Text;

                txtCargo.Text = txtCargo.CaracteresEspeciais();
                txtCargo.ValidarVazio();
                FuncionarioAtualizar.Cargo = txtCargo.Text;

                txtSalario.Text = txtSalario.ValidarVazio();
                txtSalario.ValidarValor();
                FuncionarioAtualizar.Salario = Convert.ToDecimal(txtSalario.Text);

                txtComissao.Text = txtComissao.ValidarVazio();
                txtComissao.ValidarValor();
                FuncionarioAtualizar.Comissao = Convert.ToDecimal(txtComissao.Text);

                txtTelCel.Text = txtTelCel.ValidarTelCel();
                FuncionarioAtualizar.TelefoneCelular = txtTelCel.Text;

                txtTelRes.Text = txtTelRes.ValidarTelFixo();
                FuncionarioAtualizar.TelefoneResidencial = txtTelRes.Text;

                txtCarteiraProfissional.Text = txtCarteiraProfissional.CaracteresEspeciais();
                FuncionarioAtualizar.CarteiraProfissional = txtCarteiraProfissional.Text;

                txtSerieCarteiraProfissional.Text = txtSerieCarteiraProfissional.CaracteresEspeciais();
                FuncionarioAtualizar.SerieCarteiraProfisional = txtSerieCarteiraProfissional.Text;
                if (rdoNao.Checked == true)
                {
                    FuncionarioAtualizar.Ativo = false;
                }
                else if (rdoSim.Checked == true)
                {
                    FuncionarioAtualizar.Ativo = true;
                }
                wcf.AtualizarFuncionario(FuncionarioAtualizar);
                DialogResult confirmacao = MessageBox.Show("Funcionário alterado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (confirmacao == DialogResult.OK) { Validacoes.limparTxt(this); dtGridFuncionario.CurrentRow.Selected = false; }
                CarregarDados();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados, contate o desenvolvedor. Mensagem original: \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor. Mensagem original: \n" + ex.Message);
            }
            finally
            {
                AtivarControles();
            }
        }

        /// <summary>
        /// Reseta valor de comissão no banco de dados
        /// </summary>
        private void ResetarComissao()
        {
            try
            {
                Funcionario ComissaoFunc = new Funcionario();
                ComissaoFunc.IdFuncionario = (int)dtGridFuncionario.CurrentRow.Cells[0].Value;
                DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja resetar comissão? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacao == DialogResult.Yes)
                {
                    txtComissao.Text = "0";
                    ComissaoFunc.Comissao = Convert.ToDecimal(txtComissao.Text);
                    wcf.AtualizarFuncionarioComissao(ComissaoFunc);
                    MessageBox.Show("Comissão Resetada", "Comissão", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados, contate o desenvolvedor. Mensagem Original" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor. Mensagem Original" + ex.Message);
            }
        }

        /// <summary>
        /// Ativa botões e  textboxes do form (utilizado para funcionario ativo/inativo)
        /// </summary>
        private void AtivarControles()
        {
            txtNome.Enabled = true; txtRG.Enabled = true; txtCPF.Enabled = true; txtDtNascimento.Enabled = true; txtEmail.Enabled = true; txtNacionalidade.Enabled = true; txtEndereco.Enabled = true; txtNumero.Enabled = true; txtTipoEndereco.Enabled = true; txtComplemento.Enabled = true; txtBairro.Enabled = true; txtCidade.Enabled = true; txtCEP.Enabled = true; txtUF.Enabled = true; txtTituloEleitor.Enabled = true; txtSecaoEleitor.Enabled = true; txtZonaEleitoral.Enabled = true; txtPis.Enabled = true; txtCarteiraProfissional.Enabled = true; txtSerieCarteiraProfissional.Enabled = true; txtTelRes.Enabled = true; txtTelCel.Enabled = true; txtCargo.Enabled = true; txtSalario.Enabled = true; txtComissao.Enabled = true; txtObs.Enabled = true;
        }

        /// <summary>
        /// Desativa botões e  textboxes do form (utilizado para funcionario ativo/inativo)
        /// </summary>
        private void DesativarControles()
        {
            txtNome.Enabled = false; txtRG.Enabled = false; txtCPF.Enabled = false; txtDtNascimento.Enabled = false; txtEmail.Enabled = false; txtNacionalidade.Enabled = false; txtEndereco.Enabled = false; txtNumero.Enabled = false; txtTipoEndereco.Enabled = false; txtComplemento.Enabled = false; txtBairro.Enabled = false; txtCidade.Enabled = false; txtCEP.Enabled = false; txtUF.Enabled = false; txtTituloEleitor.Enabled = false; txtSecaoEleitor.Enabled = false; txtZonaEleitoral.Enabled = false; txtPis.Enabled = false; txtCarteiraProfissional.Enabled = false; txtSerieCarteiraProfissional.Enabled = false; txtTelRes.Enabled = false; txtTelCel.Enabled = false; txtCargo.Enabled = false; txtSalario.Enabled = false; txtComissao.Enabled = false; txtObs.Enabled = false;

        }
        #endregion

        private void btnInserir_Click(object sender, EventArgs e)
        {
              InserirFuncionario();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarFuncionario();
        }
        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            btnInserir.Enabled = false;
            btnInserirUsuario.Enabled = false;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Validacoes.limparTxt(this);
            txtComissao.Enabled = false;
            btnInserir.Enabled = true;
            btnReset.Enabled = false;
            btnAtualizar.Enabled = false;
            btnInserirUsuario.Enabled = false;
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            PesquisaDados();
        }
        private void dtGridFuncionario_DoubleClick(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void dtGridFuncionario_Click(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = true;
            SelecionarFuncionario();
            btnReset.Enabled = true;
            btnInserirUsuario.Enabled = true;

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetarComissao();
        }

        private void btnInserirUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario UsuarioFrm = new frmUsuario();
            UsuarioFrm.ShowDialog(); 
        }
    }
}

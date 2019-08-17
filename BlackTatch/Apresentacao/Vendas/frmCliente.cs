using Apresentacao.ServiceReference1;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmCliente : Form
    {
        Service1Client wcf;
        public frmCliente()
        {
            InitializeComponent();
            wcf = new Service1Client();
            CarregarDados();
            AtivarControles();
        }

        #region Métodos
        private void CarregarDados()
        {
            dtGridCliente.DataSource = wcf.ConsultarClienteDataAccess();
            dtGridCliente.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void DesativarControles()
        {
            txtNome.Enabled = false; txtRG.Enabled = false; txtCPF.Enabled = false; txtCNPJ.Enabled = false; txtIE.Enabled = false; txtEndereco.Enabled = false; txtBairro.Enabled = false; txtTipoEndereco.Enabled = false; txtNumero.Enabled = false; txtComplemento.Enabled = false; txtCEP.Enabled = false; txtUF.Enabled = false; txtTelRes.Enabled = false; txtTelCom.Enabled = false; txtTelCel.Enabled = false; txtEmail.Enabled = false; txtDataCadastro.Enabled = false;
        }

        private void AtivarControles()
        {
            txtNome.Enabled = true; txtRG.Enabled = true; txtCPF.Enabled = true; txtCNPJ.Enabled = true; txtIE.Enabled = true; txtEndereco.Enabled = true; txtBairro.Enabled = true; txtTipoEndereco.Enabled = true; txtNumero.Enabled = true; txtComplemento.Enabled = true; txtCEP.Enabled = true; txtUF.Enabled = true; txtTelRes.Enabled = true; txtTelCom.Enabled = true; txtTelCel.Enabled = true; txtEmail.Enabled = true; txtDataCadastro.Enabled = true;
        }

        private void SelecionarCliente()
        {

            try
            {
                Cliente ChecarCliente = new Cliente();
                lblIdCli.Text = dtGridCliente.CurrentRow.Cells[0].Value.ToString();

                if (lblIdCli.Text != "")
                {
                    txtNome.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).Nome;
                    txtRG.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).RG;
                    txtCPF.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).CPF;
                    txtCNPJ.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).CNPJ;
                    txtIE.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).IE;
                    txtEndereco.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).Endereco;
                    txtBairro.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).Bairro;
                    txtTipoEndereco.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).TipoEndereco;
                    txtNumero.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).Numero;
                    txtComplemento.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).Complemento;
                    txtCEP.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).CEP;
                    txtUF.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).UF;
                    txtTelRes.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).TelefoneResidencial;
                    txtTelCom.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).TelefoneComercial;
                    txtTelCel.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).TelefoneResidencial;
                    txtEmail.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).Email;
                    txtDataCadastro.Text = wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).DataCadastro.ToShortDateString();
                    if (wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).Ativo == false)
                    {
                        rdoAtivoNao.Checked = true;
                        DesativarControles();
                    }
                    else if (wcf.SelecionarCliente(int.Parse(lblIdCli.Text)).Ativo == true)
                    {
                        rdoAtivoSim.Checked = true;
                        AtivarControles();
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

        private void InserirCliente()
        {

            try
            {
                Cliente novoCliente = new Cliente();

                novoCliente.Nome = txtNome.Text;
                novoCliente.RG = txtRG.Text;
                novoCliente.CPF = txtCPF.Text;
                novoCliente.CNPJ = txtCNPJ.Text;
                novoCliente.IE = txtIE.Text;
                novoCliente.Endereco = txtEndereco.Text;
                novoCliente.Bairro = txtBairro.Text;
                novoCliente.TipoEndereco = txtTipoEndereco.Text;
                novoCliente.Numero = txtNumero.Text;
                novoCliente.Complemento = txtComplemento.Text;
                novoCliente.CEP = txtCEP.Text;
                novoCliente.UF = txtUF.Text;
                novoCliente.TelefoneResidencial = txtTelRes.Text;
                novoCliente.TelefoneComercial = txtTelCom.Text;
                novoCliente.TelefoneCelular = txtTelCel.Text;
                novoCliente.DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                novoCliente.Email = txtEmail.Text;
                novoCliente.Ativo = true;
                wcf.InserirCliente(novoCliente);
                CarregarDados();
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

        private void AtualizarCliente()
        {

            try
            {
                Cliente ClienteAtualizar = new Cliente();

                ClienteAtualizar.IdCliente = (int)dtGridCliente.CurrentRow.Cells[0].Value;
                ClienteAtualizar.Nome = txtNome.Text;
                ClienteAtualizar.RG = txtRG.Text;
                ClienteAtualizar.CPF = txtCPF.Text;
                ClienteAtualizar.CNPJ = txtCNPJ.Text;
                ClienteAtualizar.IE = txtIE.Text;
                ClienteAtualizar.Endereco = txtEndereco.Text;
                ClienteAtualizar.Bairro = txtBairro.Text;
                ClienteAtualizar.TipoEndereco = txtTipoEndereco.Text;
                ClienteAtualizar.Numero = txtNumero.Text;
                ClienteAtualizar.Complemento = txtComplemento.Text;
                ClienteAtualizar.CEP = txtCEP.Text;
                ClienteAtualizar.UF = txtUF.Text;
                ClienteAtualizar.TelefoneResidencial = txtTelRes.Text;
                ClienteAtualizar.TelefoneComercial = txtTelCom.Text;
                ClienteAtualizar.TelefoneCelular = txtTelCel.Text;
                ClienteAtualizar.DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                ClienteAtualizar.Email = txtEmail.Text;
                if (rdoAtivoNao.Checked == true)
                {
                    ClienteAtualizar.Ativo = false;
                }
                else if (rdoAtivoSim.Checked == true)
                {
                    ClienteAtualizar.Ativo = true;
                }

                wcf.AtualizarCliente(ClienteAtualizar);
                CarregarDados();

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

        private void dtGridCliente_Click(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = true;
            btnInserir.Enabled = false;
            SelecionarCliente();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            InserirCliente();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarCliente();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Validacoes.limparTxt(this);
            btnInserir.Enabled = true;
            btnAtualizar.Enabled = false;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = false;

        }
    }
}

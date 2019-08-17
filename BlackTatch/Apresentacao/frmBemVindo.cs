using Apresentacao.ServiceReference1;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Apresentacao
{
    public partial class frmBemVindo : Form
    {
        Service1Client wcf;
        public frmBemVindo()
        {
            InitializeComponent();
            wcf = new Service1Client();
        }
            public int Id;

        #region Métodos

        /// <summary>
        /// Desativa todos os controles da tela inicial
        /// </summary>
        private void DesativarControles()
        {
            toolStripFuncionario.Enabled = false;
            toolStripEstoque.Enabled = false;
            toolStripFornecedor.Enabled = false;
            toolStripVendas.Enabled = false;
            toolStripRelatorios.Enabled = false;
            toolStripCliente.Enabled = false;

        }

        /// <summary>
        /// Valida usuário no sistema
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Nome"></param>
        private void Logon(string Login, string Nome)
        {
            bool resultado = false;
            string login, senha;
            login = txtLogin.Text;
            senha = txtSenha.Text;
            try
            {
                if (wcf.ValidarLogin(login, senha).Logado == true)
                {
                    btnAcesso.Enabled = false;

                    if (wcf.ValidarLogin(login, senha).Master == true)
                    {
                        toolStripFuncionario.Enabled = true;
                        toolStripEstoque.Enabled = true;
                        toolStripFornecedor.Enabled = true;
                        toolStripVendas.Enabled = true;
                        toolStripRelatorios.Enabled = true;
                        toolStripCliente.Enabled = true;

                        txtLogin.Visible = false;
                        txtSenha.Visible = false;
                        btnAcesso.Visible = false;
                        btnLogoff.Visible = true;
                        lblLoginText.Visible = false;
                        lblSenhaText.Visible = false;


                        Id = wcf.ValidarLogin(login, senha).IdUsuario;
                        lblLoginShow.Visible = true;
                        lblLoginShow.Text = "Olá, " + login + "! Seja bem vindo(a)!";
                        lblTipoShow.Visible = true;
                        lblTipoShow.Text = "Tipo de usuário:  Master";
                    }
                    else if (wcf.ValidarLogin(login, senha).Administrativo == true)
                    {
                        toolStripFuncionario.Enabled = true;
                        toolStripEstoque.Enabled = true;
                        toolStripFornecedor.Enabled = true;
                        toolStripRelatorios.Enabled = true;
                        toolStripCliente.Enabled = true;

                        txtLogin.Visible = false;
                        txtSenha.Visible = false;
                        btnAcesso.Visible = false;
                        btnLogoff.Visible = true;
                        lblLoginText.Visible = false;
                        lblSenhaText.Visible = false;
                        Id = wcf.ValidarLogin(login, senha).IdUsuario;
                        lblLoginShow.Visible = true;
                        lblLoginShow.Text = "Olá!, " + login + ". Seja bem vindo(a)";
                        lblTipoShow.Visible = true;
                        lblTipoShow.Text = "Tipo de usuário: Administrativo";
                    }
                    else if (wcf.ValidarLogin(login, senha).Vendendor == true)
                    {
                        toolStripEstoque.Enabled = true;
                        toolStripVendas.Enabled = true;
                        toolStripCliente.Enabled = true;
                        
                        txtLogin.Visible = false;
                        txtSenha.Visible = false;
                        btnAcesso.Visible = false;
                        btnLogoff.Visible = true;
                        lblLoginText.Visible = false;
                        lblSenhaText.Visible = false;
                        Id = wcf.ValidarLogin(login, senha).IdUsuario;
                        lblLoginShow.Visible = true;
                        lblLoginShow.Text = "Olá!, " + login + ". Seja bem vindo(a)";
                        lblTipoShow.Visible = true;
                        lblTipoShow.Text = "Tipo de usuário: Vendedor";
                    }

                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha inválidos, contate seu gerente. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnAcesso.Enabled = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados, contate o desenvolvedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Validacoes.limparTxt(this);
            }
        }

        /// <summary>
        /// Desloga Usuário no sistema
        /// </summary>
        private void Logoff()
        {
            DesativarControles();
            txtLogin.Visible = true;
            txtSenha.Visible = true;
            btnAcesso.Visible = true;
            btnLogoff.Visible = false;
            lblLoginShow.Text = "";
            lblLoginShow.Visible = false;
            lblTipoShow.Text = "";
            lblTipoShow.Visible = false;
            lblLoginText.Visible = true;
            lblSenhaText.Visible = true;
        }

        #endregion

        private void toolStripFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario FuncionarioForm = new frmFuncionario(); 
            FuncionarioForm.ShowDialog();

        }
        private void toolStripFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor FornecedorForm = new frmFornecedor(Id);
            FornecedorForm.ShowDialog();
        }
        private void toolStripEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque EstoqueForm = new frmEstoque();
            EstoqueForm.ShowDialog();
        }
        private void toolStripVendas_Click(object sender, EventArgs e)
        {
            frmVenda VendaForm = new frmVenda(Id);
            VendaForm.ShowDialog();
        }
        private void frmBemVindo_Load(object sender, EventArgs e)
        {
             DesativarControles();
        }
        private void toolStripRelatorios_Click(object sender, EventArgs e)
        {
            frmRelatorio RelatorioForm = new frmRelatorio();
            RelatorioForm.ShowDialog();
        }
        private void btnAcesso_Click(object sender, EventArgs e)
        {
            Logon(txtSenha.Text, txtSenha.Text);

        }
        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Logoff();
            btnAcesso.Enabled = true;
        }

        private void toolStripCliente_Click(object sender, EventArgs e)
        {
            frmCliente ClienteForm = new frmCliente();
            ClienteForm.ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmSobre SobreForm = new frmSobre();
            SobreForm.ShowDialog();
        }
    }
}

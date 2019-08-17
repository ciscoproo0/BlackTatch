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
    public partial class frmUsuario : Form
    {
        Service1Client wcf;
        public frmUsuario()
        {
            InitializeComponent();
            wcf = new Service1Client();
            MostrarDados();
            CarregarComboBox();
        }

        /// <summary>
        /// Limita tipo de usuário a ser escolhido
        /// </summary>
        private void CarregarComboBox()
        {
            try
            {
                comboTipo.Items.Add("Vendedor");
                comboTipo.Items.Add("Administrativo");
                comboTipo.Items.Add("Master");
                comboTipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na aplicação, contate o desenvolvedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carrega dados de todos os usuários cadastrados no sistema
        /// </summary>
        private void MostrarDados()
        {
            gridUsuario.DataSource = wcf.ConsultarUsuarioNoBanco();
            gridUsuario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        /// <summary>
        /// Cadastra novo usuario no sistema
        /// </summary>
        private void CadastrarUsuario()
        {
            txtCod.Enabled = true;
            try
            {
                Usuario NovoUsuario = new Usuario();

                txtCod.Text = txtCod.ValidarVazio();
                txtCod.ValidarCodigo();
                NovoUsuario.IdUsuarioIdFuncionario = int.Parse(txtCod.Text);

                txtLogin.Text = txtLogin.ValidarVazio();
                txtLogin.CaracteresEspeciais();
                NovoUsuario.Login = txtLogin.Text;

                txtSenha.Text = txtSenha.ValidarVazio();
                txtSenha.CaracteresEspeciais();
                NovoUsuario.Senha = txtSenha.Text;

                if (comboTipo.Text == "Master")
                {
                    NovoUsuario.Master = true;
                    NovoUsuario.Administrativo = false;
                    NovoUsuario.Vendendor = false;
                }
                else if (comboTipo.Text == "Vendedor")
                {
                    NovoUsuario.Master = false;
                    NovoUsuario.Administrativo = false;
                    NovoUsuario.Vendendor = true;
                }
                else if (comboTipo.Text == "Administrativo")
                {
                    NovoUsuario.Master = false;
                    NovoUsuario.Administrativo = true;
                    NovoUsuario.Vendendor = false;
                }
                wcf.CadastrarUsuario(NovoUsuario);

                DialogResult confirmacao = MessageBox.Show("Funcionário inserido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (confirmacao == DialogResult.OK) { Validacoes.limparTxt(this); gridUsuario.CurrentRow.Selected = false; }

            MostrarDados();
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
                //AtivarControles();
            }

        }

        /// <summary>
        /// Seleciona funcionario a partir do id no grid e preenche controles
        /// </summary>
        private void SelecionarUsuario()
        {
            txtCod.Enabled = false;
            btnAlterar.Enabled = true;
            try
            {
                txtCod.Text = gridUsuario.CurrentRow.Cells[0].Value.ToString();

                if (txtCod.Text != "")
                {
                    txtLogin.Text = wcf.SelecionarUsuario(int.Parse(txtCod.Text)).Login;
                    txtSenha.Text = wcf.SelecionarUsuario(int.Parse(txtCod.Text)).Senha;
                    if (wcf.SelecionarUsuario(int.Parse(txtCod.Text)).Master == true)
                    {
                        comboTipo.SelectedIndex = 2;
                    }
                    else if (wcf.SelecionarUsuario(int.Parse(txtCod.Text)).Administrativo == true)
                    {
                        comboTipo.SelectedIndex = 1;
                    }
                    if (wcf.SelecionarUsuario(int.Parse(txtCod.Text)).Vendendor == true)
                    {
                        comboTipo.SelectedIndex = 0;
                    }
                    btnCadastrar.Enabled = false;
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

        private void AlterarUsuario()
        {

            try
            {
                Usuario UsuarioAtualizar = new Usuario();
                UsuarioAtualizar.IdUsuario = (int)gridUsuario.CurrentRow.Cells[0].Value;

                txtLogin.Text = txtLogin.ValidarVazio();
                txtLogin.CaracteresEspeciais();
                UsuarioAtualizar.Login = txtLogin.Text;

                txtSenha.Text = txtSenha.ValidarVazio();
                txtSenha.CaracteresEspeciais();
                UsuarioAtualizar.Senha = txtSenha.Text;

                if (comboTipo.SelectedIndex == 2)//master
                {
                    UsuarioAtualizar.Master = true;
                    UsuarioAtualizar.Administrativo = false;
                    UsuarioAtualizar.Vendendor = false;
                }
                else if (comboTipo.SelectedIndex == 1)//adm
                {
                    UsuarioAtualizar.Administrativo = true;
                    UsuarioAtualizar.Master = false;
                    UsuarioAtualizar.Vendendor = false;
                }
                else if (comboTipo.SelectedIndex == 0)//vendedor
                {
                    UsuarioAtualizar.Vendendor = true;
                    UsuarioAtualizar.Master = false;
                    UsuarioAtualizar.Administrativo = false;
                }
                wcf.AlterarUsuario(UsuarioAtualizar);
                DialogResult confirmacao = MessageBox.Show("Usuário alterado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (confirmacao == DialogResult.OK) { Validacoes.limparTxt(this); gridUsuario.CurrentRow.Selected = false; }
                MostrarDados();
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

        private void PesquisarUsuario()
        {
            try
            {
                this.gridUsuario.DataSource = null;


                if (gridUsuario.DataSource != "")
                {
                    gridUsuario.ColumnCount = 5;
                    gridUsuario.Columns[0].Name = "Id_Usuario";
                    gridUsuario.Columns[1].Name = "Login";
                    gridUsuario.Columns[2].Name = "Senha";

                    gridUsuario.Rows.Clear();
                    txtPesquisa.Text = txtPesquisa.CaracteresEspeciais();
                    foreach (var item in wcf.ConsultarUsuarioLogin(txtPesquisa.Text))
                    {
                        string[] row = new string[] { item.IdUsuario.ToString(), item.Login.ToString(), item.Senha.ToString() };
                        gridUsuario.Rows.Add(row);
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Validacoes.limparTxt(this);
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            txtCod.Enabled = true;
        }

        private void gridUsuario_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = true;
            SelecionarUsuario();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarUsuario();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            PesquisarUsuario();
        }
    }
}

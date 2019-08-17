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
using TesteFunc.ServiceReference1;


namespace TesteFunc
{
    public partial class Form1 : Form
    {
        Service1Client wcf;
        public Form1()
        {
            InitializeComponent();
            wcf = new Service1Client();
            MostrarDados();
        }
        private void MostrarDados()
        {
            dtGridFuncionario.DataSource = wcf.ConsultarFuncionarioDataAccess();
            dtGridFuncionario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario novoFuncionario = new Funcionario();
                novoFuncionario.Nome = txtNome.Text;
                novoFuncionario.CPF = txtCPF.Text;
                novoFuncionario.RG = txtRG.Text;
                novoFuncionario.DataNascimento = Convert.ToDateTime(txtDtNascimento.Text);
                novoFuncionario.Email = txtEmail.Text;
                novoFuncionario.Nacionalidade = txtNacionalidade.Text;
                novoFuncionario.Endereco = txtEndereco.Text;
                novoFuncionario.NumeroEndereco = txtNumero.Text;
                novoFuncionario.TipoEndereco = txtTipoEndereco.Text;
                novoFuncionario.Complemento = txtComplemento.Text;
                novoFuncionario.Bairro = txtBairro.Text;
                novoFuncionario.Cidade = txtCidade.Text;
                novoFuncionario.Cep = txtCEP.Text;
                novoFuncionario.UF = txtUF.Text;
                novoFuncionario.TituloEleitor = txtTituloEleitor.Text;
                novoFuncionario.SecaoEleitor = txtSecaoEleitor.Text;
                novoFuncionario.ZonaEleitoral = txtZonaEleitoral.Text;
                novoFuncionario.PIS = txtPis.Text;
                novoFuncionario.OBS = txtObs.Text;
                novoFuncionario.CarteiraProfissional = txtCarteiraProfissional.Text;
                novoFuncionario.SerieCarteiraProfisional = txtSerieCarteiraProfissional.Text;
                novoFuncionario.Cargo = txtCargo.Text;
                novoFuncionario.Salario = Convert.ToDecimal(txtSalario.Text);
                novoFuncionario.Comissao = Convert.ToDecimal(txtComissao.Text);
                novoFuncionario.TelefoneCelular = txtTelCel.Text;
                novoFuncionario.TelefoneResidencial = txtTelRes.Text;
                wcf.InserirFuncionario(novoFuncionario);
                MostrarDados();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario FuncionarioAtualizar = new Funcionario();

                FuncionarioAtualizar.IdFuncionario = (int)dtGridFuncionario.CurrentRow.Cells[0].Value;
                FuncionarioAtualizar.Nome = txtNome.Text;
                FuncionarioAtualizar.CPF = txtCPF.Text;
                FuncionarioAtualizar.RG = txtRG.Text;
                FuncionarioAtualizar.DataNascimento = Convert.ToDateTime(txtDtNascimento.Text);
                FuncionarioAtualizar.Email = txtEmail.Text;
                FuncionarioAtualizar.Nacionalidade = txtNacionalidade.Text;
                FuncionarioAtualizar.Endereco = txtEndereco.Text;
                FuncionarioAtualizar.NumeroEndereco = txtNumero.Text;
                FuncionarioAtualizar.TipoEndereco = txtTipoEndereco.Text;
                FuncionarioAtualizar.Complemento = txtComplemento.Text;
                FuncionarioAtualizar.Bairro = txtBairro.Text;
                FuncionarioAtualizar.Cidade = txtCidade.Text;
                FuncionarioAtualizar.Cep = txtCEP.Text;
                FuncionarioAtualizar.UF = txtUF.Text;
                FuncionarioAtualizar.TituloEleitor = txtTituloEleitor.Text;
                FuncionarioAtualizar.SecaoEleitor = txtSecaoEleitor.Text;
                FuncionarioAtualizar.ZonaEleitoral = txtZonaEleitoral.Text;
                FuncionarioAtualizar.PIS = txtPis.Text;
                FuncionarioAtualizar.OBS = txtObs.Text;
                FuncionarioAtualizar.Cargo = txtCargo.Text;
                FuncionarioAtualizar.Salario = Convert.ToDecimal(txtSalario.Text);
                FuncionarioAtualizar.Comissao = Convert.ToDecimal(txtComissao.Text);
                FuncionarioAtualizar.TelefoneCelular = txtTelCel.Text;
                FuncionarioAtualizar.TelefoneResidencial = txtTelRes.Text;
                FuncionarioAtualizar.CarteiraProfissional = txtCarteiraProfissional.Text;
                FuncionarioAtualizar.SerieCarteiraProfisional = txtSerieCarteiraProfissional.Text;
                FuncionarioAtualizar.OBS = txtObs.Text;
                wcf.AtualizarFuncionario(FuncionarioAtualizar);
                MostrarDados();
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
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                wcf.ExcluirFuncionario((int)dtGridFuncionario.CurrentRow.Cells[0].Value);
                MostrarDados();
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
        private void dtGridFuncionario_SelectionChanged_1(object sender, EventArgs e)
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
    }
}

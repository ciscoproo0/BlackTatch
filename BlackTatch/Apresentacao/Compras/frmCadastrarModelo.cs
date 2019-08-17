using Apresentacao.ServiceReference1;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmCadastrarModelo : Form
    {
        Service1Client wcf;
        public frmCadastrarModelo()
        {
            InitializeComponent();
            wcf = new Service1Client();
        }

        #region Métodos

        /// <summary>
        /// Insere novo modelo no banco de dados
        /// </summary>
        private void InserirModelo()
        {
            try
            {
                Produto NovoCadastro = new Produto();

                txtModelo.Text = txtModelo.CaracteresEspeciais();
                txtModelo.ValidarVazio();
                NovoCadastro.DescricaoModelo = txtModelo.Text;

                txtValorVenda.Text = txtValorVenda.ValidarVazio();
                txtValorVenda.ValidarValor();
                NovoCadastro.ValorRevenda = Convert.ToDecimal(txtValorVenda.Text);

                DialogResult cadastro = MessageBox.Show("Confira os dados cadastrados, se tiver certeza pressione SIM para confirmar cadastro", "Cadastro de Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cadastro == DialogResult.Yes) { wcf.InserirProduto(NovoCadastro); Validacoes.limparTxt(this); }
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            InserirModelo();
        }

    }
}

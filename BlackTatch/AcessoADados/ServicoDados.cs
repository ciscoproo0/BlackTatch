using AcessoADados.Compras;
using AcessoADados.Funcionarios;
using AcessoADados.Vendas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AcessoADados
{
    public class ServicoDados
    {
        private string connString = @"Data Source=CISCOPC\SQL;Initial Catalog=BDBlackTatch;Integrated Security=True";
        private SqlConnection conexao;
        public ServicoDados()
        {
            conexao = new SqlConnection(connString);
        }

        
        #region Fornecedor
        /// <summary>
        /// Insere novo Fornecedor no banco de dados
        /// </summary>
        /// <param name="DadosFornecedor"></param>
        public void CadastrarFornecedor(Fornecedor DadosFornecedor)
        {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                try
                {
                    conexao.Open();

                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO fornecedor (nome_fornecedor, nome_representante, email_fornecedor, email_representante, tel_fornecedor, tel_celular_representante, homepage, inscricao_estadual, CNPJ, endereco_fornecedor, bairro_fornecedor, numero_endereco_fornecedor, cep_fornecedor) VALUES (@NomeEmpresa, @NomeRepresentante, @EmailEmpresa, @EmailRepresentante, @TelefoneFixo, @TelefoneCelularRepresentante, @HomePage, @IE, @CNPJ, @Endereco, @Bairro, @Numero, @CEP)";

                    comando.Parameters.Add("@NomeEmpresa", SqlDbType.Text);
                    comando.Parameters["@NomeEmpresa"].Value = DadosFornecedor.NomeEmpresa;
                    comando.Parameters.Add("@NomeRepresentante", SqlDbType.Text);
                    comando.Parameters["@NomeRepresentante"].Value = DadosFornecedor.NomeRepresentante;
                    comando.Parameters.Add("@EmailEmpresa", SqlDbType.Text);
                    comando.Parameters["@EmailEmpresa"].Value = DadosFornecedor.EmailEmpresa;
                    comando.Parameters.Add("@EmailRepresentante", SqlDbType.Text);
                    comando.Parameters["@EmailRepresentante"].Value = DadosFornecedor.EmailRepresentante;
                    comando.Parameters.Add("@TelefoneFixo", SqlDbType.Text);
                    comando.Parameters["@TelefoneFixo"].Value = DadosFornecedor.TelefoneFixo;
                    comando.Parameters.Add("@TelefoneCelularRepresentante", SqlDbType.Text);
                    comando.Parameters["@TelefoneCelularRepresentante"].Value = DadosFornecedor.TelefoneCelularRepresentante;
                    comando.Parameters.Add("@HomePage", SqlDbType.Text);
                    comando.Parameters["@HomePage"].Value = DadosFornecedor.HomePage;
                    comando.Parameters.Add("@IE", SqlDbType.Text);
                    comando.Parameters["@IE"].Value = DadosFornecedor.IE;
                    comando.Parameters.Add("@CNPJ", SqlDbType.Text);
                    comando.Parameters["@CNPJ"].Value = DadosFornecedor.CNPJ;
                    comando.Parameters.Add("@Endereco", SqlDbType.Text);
                    comando.Parameters["@Endereco"].Value = DadosFornecedor.Endereco;
                    comando.Parameters.Add("@Bairro", SqlDbType.Text);
                    comando.Parameters["@Bairro"].Value = DadosFornecedor.Bairro;
                    comando.Parameters.Add("@Numero", SqlDbType.Text);
                    comando.Parameters["@Numero"].Value = DadosFornecedor.Numero;
                    comando.Parameters.Add("@CEP", SqlDbType.Text);
                    comando.Parameters["@CEP"].Value = DadosFornecedor.CEP;

                    comando.ExecuteScalar();
                }
                catch (SqlException e)
                {
                    throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
                }
                finally
                {
                    conexao.Close();
                }
        }

        /// <summary>
        /// Altera cadastro do Fornecedor no banco de dados
        /// </summary>
        /// <param name="DadosFornecedor"></param>
        public void AlterarFornecedor(Fornecedor DadosFornecedor)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE fornecedor SET nome_fornecedor = @NomeEmpresa, nome_representante = @NomeRepresentante, email_fornecedor = @EmailFornecedor, email_representante = @EmailRepresentante, tel_fornecedor = @TelefoneFixo, tel_celular_representante = @TelefoneCelularRepresentante, homepage = @HomePage, inscricao_estadual = @IE, CNPJ = @CNPJ, endereco_fornecedor = @Endereco, bairro_fornecedor = @Bairro, numero_endereco_fornecedor = @Numero, cep_fornecedor = @CEP WHERE id_fornecedor = @IdFornecedor";

                comando.Parameters.Add("@IdFornecedor", SqlDbType.Int);
                comando.Parameters["@IdFornecedor"].Value = DadosFornecedor.IdFornecedor;
                comando.Parameters.Add("@NomeEmpresa", SqlDbType.Text);
                comando.Parameters["@NomeEmpresa"].Value = DadosFornecedor.NomeEmpresa;
                comando.Parameters.Add("@NomeRepresentante", SqlDbType.Text);
                comando.Parameters["@NomeRepresentante"].Value = DadosFornecedor.NomeRepresentante;
                comando.Parameters.Add("@EmailFornecedor", SqlDbType.Text);
                comando.Parameters["@EmailFornecedor"].Value = DadosFornecedor.EmailEmpresa;
                comando.Parameters.Add("@EmailRepresentante", SqlDbType.Text);
                comando.Parameters["@EmailRepresentante"].Value = DadosFornecedor.EmailRepresentante;
                comando.Parameters.Add("@TelefoneFixo", SqlDbType.Text);
                comando.Parameters["@TelefoneFixo"].Value = DadosFornecedor.TelefoneFixo;
                comando.Parameters.Add("@TelefoneCelularRepresentante", SqlDbType.Text);
                comando.Parameters["@TelefoneCelularRepresentante"].Value = DadosFornecedor.TelefoneCelularRepresentante;
                comando.Parameters.Add("@HomePage", SqlDbType.Text);
                comando.Parameters["@HomePage"].Value = DadosFornecedor.HomePage;
                comando.Parameters.Add("@IE", SqlDbType.Text);
                comando.Parameters["@IE"].Value = DadosFornecedor.IE;
                comando.Parameters.Add("@CNPJ", SqlDbType.Text);
                comando.Parameters["@CNPJ"].Value = DadosFornecedor.CNPJ;
                comando.Parameters.Add("@Endereco", SqlDbType.Text);
                comando.Parameters["@Endereco"].Value = DadosFornecedor.Endereco;
                comando.Parameters.Add("@Bairro", SqlDbType.Text);
                comando.Parameters["@Bairro"].Value = DadosFornecedor.Bairro;
                comando.Parameters.Add("@Numero", SqlDbType.Text);
                comando.Parameters["@Numero"].Value = DadosFornecedor.Numero;
                comando.Parameters.Add("@CEP", SqlDbType.Text);
                comando.Parameters["@CEP"].Value = DadosFornecedor.CEP;

                comando.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        /// <summary>
        /// Deleta fornecedor do banco de dados
        /// </summary>
        /// <param name="IdFornecedor"></param>
        public void DeletarFornecedor(int IdFornecedor)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            try
            {
                conexao.Open();

                comando.CommandText = "DELETE FROM fornecedor WHERE id_fornecedor = @IdFornecedor";
                comando.Parameters.Add("@IdFornecedor", SqlDbType.Int);
                comando.Parameters["@IdFornecedor"].Value = IdFornecedor;

                comando.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        /// <summary>
        /// Seleciona Fornecedor no banco de dados apartir do ID
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <returns></returns>
        public Fornecedor SelecionarFornecedor(int IdFornecedor)
        {
            Fornecedor retorno = new Fornecedor();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "SELECT * FROM fornecedor WHERE id_fornecedor = @IdFornecedor";
            comando.Parameters.Add("@IdFornecedor", SqlDbType.Int);
            comando.Parameters["@IdFornecedor"].Value = IdFornecedor;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.IdFornecedor = (int)dr["id_fornecedor"];
                    retorno.NomeEmpresa = dr["nome_fornecedor"].ToString();
                    retorno.NomeRepresentante = dr["nome_representante"].ToString();
                    retorno.EmailEmpresa = dr["email_fornecedor"].ToString();
                    retorno.EmailRepresentante = dr["email_representante"].ToString();
                    retorno.TelefoneFixo = dr["tel_fornecedor"].ToString();
                    retorno.TelefoneCelularRepresentante = dr["tel_celular_representante"].ToString();
                    retorno.HomePage = dr["homepage"].ToString();
                    retorno.IE = dr["inscricao_estadual"].ToString();
                    retorno.CNPJ = dr["CNPJ"].ToString();
                    retorno.Endereco = dr["endereco_fornecedor"].ToString();
                    retorno.Bairro = dr["bairro_fornecedor"].ToString();
                    retorno.Numero = dr["numero_endereco_fornecedor"].ToString();
                    retorno.CEP = dr["cep_fornecedor"].ToString();
                }

            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;
        }

        /// <summary>
        /// carrega informações em lista da tabela fornecedor do banco de dados
        /// </summary>
        /// <returns></returns>
        public List<Fornecedor> ConsultaFornecedorNoBanco()
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            List<Fornecedor> retorno = new List<Fornecedor>();

            try
            {
                comando.CommandText = "SELECT * FROM fornecedor";
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    retorno.Add(new Fornecedor()
                    {

                        IdFornecedor = (int)dr["id_fornecedor"],
                        NomeEmpresa = dr["nome_fornecedor"].ToString(),
                        NomeRepresentante = dr["nome_representante"].ToString(),
                        EmailEmpresa = dr["email_fornecedor"].ToString(),
                        EmailRepresentante = dr["email_representante"].ToString(),
                        TelefoneFixo = dr["tel_fornecedor"].ToString(),
                        TelefoneCelularRepresentante = dr["tel_celular_representante"].ToString(),
                        HomePage = dr["homepage"].ToString(),
                        IE = dr["inscricao_estadual"].ToString(),
                        CNPJ = dr["CNPJ"].ToString(),
                        Endereco = dr["endereco_fornecedor"].ToString(),
                        Bairro = dr["bairro_fornecedor"].ToString(),
                        Numero = dr["numero_endereco_fornecedor"].ToString(),
                        CEP = dr["cep_fornecedor"].ToString(),

                    });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;
        }

        /// <summary>
        /// Carrega insormações em lista da tabela fornecedor, utilizando nome como parâmetro
        /// </summary>
        /// <param name="Nome"></param>
        /// <returns></returns>
        public List<Fornecedor> ConsultarFornecedorNome(string Nome)
        {

            List<Fornecedor> retorno = new List<Fornecedor>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "Select id_fornecedor, nome_fornecedor, tel_fornecedor, homepage, CNPJ From fornecedor WHERE nome_fornecedor like '%' + @Nome + '%' ORDER BY id_fornecedor";
            comando.Parameters.Add("@Nome", SqlDbType.VarChar);
            comando.Parameters["@Nome"].Value = Nome;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.Add(new Fornecedor()
                    {
                        IdFornecedor = (int)dr["id_fornecedor"],
                        NomeEmpresa = dr["nome_fornecedor"].ToString(),
                        TelefoneFixo = dr["tel_fornecedor"].ToString(),
                        HomePage = dr["homepage"].ToString(),
                        CNPJ = dr["CNPJ"].ToString()

                    });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return retorno;
        }


        #endregion
        // crudCliente para uso futuro
        #region Cliente
        /// <summary>
        /// Insere novo cliente no banco de dados
        /// </summary>
        /// <param name="DadosCliente"></param>
        public void CadastrarCliente(Cliente DadosCliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            try
            {
                conexao.Open();

            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO cliente (nome_cliente, CPF, RG, CNPJ, IE, email_cliente, tel_celular_cliente, tel_comercial_cliente, tel_residencial_cliente, endereco_cliente, bairro_cliente, tipo_endereco_cliente, numero_endereco_cliente, cep_cliente, complemento_endereco_cliente, uf_cliente, dt_cadastro, ativo) VALUES (@Nome, @CPF, @RG, @CNPJ, @IE, @Email, @TelefoneCelular, @TelefoneComercial, @TelefoneResidencial, @Endereco, @Bairro, @TipoEndereco, @Numero, @CEP, @Complemento, @UF, @DataCadastro, @Ativo)";
 
            comando.Parameters.Add("@Nome", SqlDbType.Text);
            comando.Parameters["@Nome"].Value = DadosCliente.Nome;
            comando.Parameters.Add("@CPF", SqlDbType.Text);
            comando.Parameters["@CPF"].Value = DadosCliente.CPF;
            comando.Parameters.Add("@RG", SqlDbType.Text);
            comando.Parameters["@RG"].Value = DadosCliente.RG;
            comando.Parameters.Add("@CNPJ", SqlDbType.Text);
            comando.Parameters["@CNPJ"].Value = DadosCliente.CNPJ;
            comando.Parameters.Add("@IE", SqlDbType.Text);
            comando.Parameters["@IE"].Value = DadosCliente.IE;
            comando.Parameters.Add("@Email", SqlDbType.Text);
            comando.Parameters["@Email"].Value = DadosCliente.Email;
            comando.Parameters.Add("@TelefoneCelular", SqlDbType.Text);
            comando.Parameters["@TelefoneCelular"].Value = DadosCliente.TelefoneCelular;
            comando.Parameters.Add("@TelefoneComercial", SqlDbType.Text);
            comando.Parameters["@TelefoneComercial"].Value = DadosCliente.TelefoneComercial;
            comando.Parameters.Add("@TelefoneResidencial", SqlDbType.Text);
            comando.Parameters["@TelefoneResidencial"].Value = DadosCliente.TelefoneResidencial;
            comando.Parameters.Add("@Endereco", SqlDbType.Text);
            comando.Parameters["@Endereco"].Value = DadosCliente.Endereco;
            comando.Parameters.Add("@Bairro", SqlDbType.Text);
            comando.Parameters["@Bairro"].Value = DadosCliente.Bairro;
            comando.Parameters.Add("@TipoEndereco", SqlDbType.Text);
            comando.Parameters["@TipoEndereco"].Value = DadosCliente.TipoEndereco;
            comando.Parameters.Add("@Numero", SqlDbType.Text);
            comando.Parameters["@Numero"].Value = DadosCliente.Numero;
            comando.Parameters.Add("@CEP", SqlDbType.Text);
            comando.Parameters["@CEP"].Value = DadosCliente.CEP;
            comando.Parameters.Add("@Complemento", SqlDbType.Text);
            comando.Parameters["@Complemento"].Value = DadosCliente.Complemento;
            comando.Parameters.Add("@UF", SqlDbType.Text);
            comando.Parameters["@UF"].Value = DadosCliente.UF;
            comando.Parameters.Add("@DataCadastro", SqlDbType.Date);
            comando.Parameters["@DataCadastro"].Value = DadosCliente.DataCadastro;
            comando.Parameters.Add("@Ativo", SqlDbType.Bit);
            comando.Parameters["@Ativo"].Value = DadosCliente.Ativo;

                comando.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        /// <summary>
        /// Altera cadastro do cliente no banco de dados
        /// </summary>
        /// <param name="DadosCliente"></param>
        public void AlterarCliente(Cliente DadosCliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE cliente SET nome_cliente = @Nome, CPF = @CPF, RG = @RG, CNPJ = @CNPJ, IE = @IE, email_cliente = @Email, tel_celular_cliente = @TelefoneCelular, tel_comercial_cliente = @TelefoneComercial, tel_residencial_cliente = @TelefoneResidencial, endereco_cliente = @Endereco, bairro_cliente = @Bairro, tipo_endereco_cliente = @TipoEndereco, numero_endereco_cliente = @Numero, cep_cliente = @CEP, complemento_endereco_cliente = @Complemento, uf_cliente = @UF, dt_cadastro = @DataCadastro, ativo = @Ativo WHERE id_cliente = @IdCliente";

                comando.Parameters.Add("@IdCliente", SqlDbType.Int);
                comando.Parameters["@IdCliente"].Value = DadosCliente.IdCliente;
                comando.Parameters.Add("@Nome", SqlDbType.Text);
                comando.Parameters["@Nome"].Value = DadosCliente.Nome;
                comando.Parameters.Add("@CPF", SqlDbType.Text);
                comando.Parameters["@CPF"].Value = DadosCliente.CPF;
                comando.Parameters.Add("@RG", SqlDbType.Text);
                comando.Parameters["@RG"].Value = DadosCliente.RG;
                comando.Parameters.Add("@CNPJ", SqlDbType.Text);
                comando.Parameters["@CNPJ"].Value = DadosCliente.CNPJ;
                comando.Parameters.Add("@IE", SqlDbType.Text);
                comando.Parameters["@IE"].Value = DadosCliente.IE;
                comando.Parameters.Add("@Email", SqlDbType.Text);
                comando.Parameters["@Email"].Value = DadosCliente.Email;
                comando.Parameters.Add("@TelefoneCelular", SqlDbType.Text);
                comando.Parameters["@TelefoneCelular"].Value = DadosCliente.TelefoneCelular;
                comando.Parameters.Add("@TelefoneComercial", SqlDbType.Text);
                comando.Parameters["@TelefoneComercial"].Value = DadosCliente.TelefoneComercial;
                comando.Parameters.Add("@TelefoneResidencial", SqlDbType.Text);
                comando.Parameters["@TelefoneResidencial"].Value = DadosCliente.TelefoneResidencial;
                comando.Parameters.Add("@Endereco", SqlDbType.Text);
                comando.Parameters["@Endereco"].Value = DadosCliente.Endereco;
                comando.Parameters.Add("@Bairro", SqlDbType.Text);
                comando.Parameters["@Bairro"].Value = DadosCliente.Bairro;
                comando.Parameters.Add("@TipoEndereco", SqlDbType.Text);
                comando.Parameters["@TipoEndereco"].Value = DadosCliente.TipoEndereco;
                comando.Parameters.Add("@Numero", SqlDbType.Text);
                comando.Parameters["@Numero"].Value = DadosCliente.Numero;
                comando.Parameters.Add("@CEP", SqlDbType.Text);
                comando.Parameters["@CEP"].Value = DadosCliente.CEP;
                comando.Parameters.Add("@Complemento", SqlDbType.Text);
                comando.Parameters["@Complemento"].Value = DadosCliente.Complemento;
                comando.Parameters.Add("@UF", SqlDbType.Text);
                comando.Parameters["@UF"].Value = DadosCliente.UF;
                comando.Parameters.Add("@DataCadastro", SqlDbType.Date);
                comando.Parameters["@DataCadastro"].Value = DadosCliente.DataCadastro;
                comando.Parameters.Add("@Ativo", SqlDbType.Bit);
                comando.Parameters["@Ativo"].Value = DadosCliente.Ativo;

                comando.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        /// <summary>
        /// Deleta cliente do banco de dados
        /// </summary>
        /// <param name="IdCliente"></param>
        public void DeletarCliente(int IdCliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            try
            {
                conexao.Open();

                comando.CommandText = "DELETE FROM cliente WHERE id_cliente = @IdCliente";
                comando.Parameters.Add("@IdCliente", SqlDbType.Int);
                comando.Parameters["@IdCliente"].Value = IdCliente;

                comando.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
        /// <summary>
        /// Seleciona cliente no banco de dados apartir do ID
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <returns></returns>
        public Cliente SelecionarCliente(int IdCliente)
        {
            Cliente retorno = new Cliente();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM cliente WHERE id_cliente = @IdCliente";
            comando.Parameters.Add("@IdCliente", SqlDbType.Int);
            comando.Parameters["@IdCliente"].Value = IdCliente;
            conexao.Open();
            SqlDataReader dr = comando.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    retorno.IdCliente = (int)dr["id_cliente"];
                    retorno.Nome = dr["nome_cliente"].ToString();
                    retorno.CPF = dr["CPF"].ToString();
                    retorno.RG = dr["RG"].ToString();
                    retorno.CNPJ = dr["CNPJ"].ToString();
                    retorno.IE = dr["IE"].ToString();
                    retorno.Email = dr["email_cliente"].ToString();
                    retorno.TelefoneCelular = dr["tel_celular_cliente"].ToString();
                    retorno.TelefoneComercial = dr["tel_comercial_cliente"].ToString();
                    retorno.TelefoneResidencial = dr["tel_residencial_cliente"].ToString();
                    retorno.Endereco = dr["endereco_cliente"].ToString();
                    retorno.Bairro = dr["bairro_cliente"].ToString();
                    retorno.TipoEndereco = dr["tipo_endereco_cliente"].ToString();
                    retorno.Numero = dr["numero_endereco_cliente"].ToString();
                    retorno.CEP = dr["cep_cliente"].ToString();
                    retorno.Complemento = dr["complemento_endereco_cliente"].ToString();
                    retorno.UF = dr["uf_cliente"].ToString();
                    retorno .DataCadastro = (DateTime)dr["dt_cadastro"];
                    retorno.Ativo = (bool)dr["ativo"];
                }

            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;
        }
        /// <summary>
        /// carrega informações em lista da tabela cliente do banco de dados
        /// </summary>
        /// <returns></returns>
        public List<Cliente> ConsultaClienteNoBanco()
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            List<Cliente> retorno = new List<Cliente>();

            try
            {
                comando.CommandText = "SELECT * FROM cliente";
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    retorno.Add(new Cliente()
                    {
                    IdCliente = (int)dr["id_cliente"],
                    Nome = dr["nome_cliente"].ToString(),
                    CPF = dr["CPF"].ToString(),
                    RG = dr["RG"].ToString(),
                    CNPJ = dr["CNPJ"].ToString(),
                    IE = dr["IE"].ToString(),
                    Email = dr["email_cliente"].ToString(),
                    TelefoneCelular = dr["tel_celular_cliente"].ToString(),
                    TelefoneComercial = dr["tel_comercial_cliente"].ToString(),
                    TelefoneResidencial = dr["tel_residencial_cliente"].ToString(),
                    Endereco = dr["endereco_cliente"].ToString(),
                    Bairro = dr["bairro_cliente"].ToString(),
                    TipoEndereco = dr["tipo_endereco_cliente"].ToString(),
                    Numero = dr["numero_endereco_cliente"].ToString(),
                    CEP = dr["cep_cliente"].ToString(),
                    Complemento = dr["complemento_endereco_cliente"].ToString(),
                    UF = dr["uf_cliente"].ToString(),
                    DataCadastro = (DateTime)dr["dt_cadastro"],
                    Ativo = (bool)dr["ativo"],
                    });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;
        }
        #endregion

        #region Funcionarios
        /// <summary>
        /// Insere dados na tabela funcionario no banco de dados
        /// </summary>
        /// <param name="DadosFuncionario"></param>
        public void CadastrarFuncionario(Funcionario DadosFuncionario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            try
            {
                conexao.Open();

            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO funcionario (nome_funcionario, dt_nascimento, RG, CPF, PIS, titulo_eleitor, secao_eleitoral, zona_eleitoral, endereco_funcionario, numero_endereco_funcionario, tipo_endereco_funcionario, bairro_funcionario, complemento_endereco_funcionario, cep_funcionario, cidade_funcionario, uf_funcionario, nacionalidade, email_funcionario, tel_celular_funcionario, tel_residencial_funcionario, obs, cargo,  carteira_profissional, serie_carteira_profissional, salario, comissao, ativo) VALUES (@Nome,  @DataNascimento, @RG, @CPF, @PIS, @TituloEleitor, @SecaoEleitoral, @ZonaEleitoral, @Endereco, @NumeroEndereco, @TipoEndereco, @Bairro, @Complemento, @Cep, @Cidade, @UF, @Nacionalidade, @Email, @TelefoneCelular, @TelefoneResidencial, @OBS, @Cargo, @CarteiraProfissional, @SerieCarteiraProfissional, @Salario, @Comissao, 1)";
            comando.Parameters.Add("@Nome", SqlDbType.Text);
            comando.Parameters["@Nome"].Value = DadosFuncionario.Nome;
            comando.Parameters.Add("@DataNascimento", SqlDbType.Date);
            comando.Parameters["@DataNascimento"].Value = DadosFuncionario.DataNascimento;
            comando.Parameters.Add("@RG", SqlDbType.Text);
            comando.Parameters["@RG"].Value = DadosFuncionario.RG;
            comando.Parameters.Add("@CPF", SqlDbType.Text);
            comando.Parameters["@CPF"].Value = DadosFuncionario.CPF;
            comando.Parameters.Add("@PIS", SqlDbType.Text);
            comando.Parameters["@PIS"].Value = DadosFuncionario.PIS;
            comando.Parameters.Add("@TituloEleitor", SqlDbType.Text);
            comando.Parameters["@TituloEleitor"].Value = DadosFuncionario.TituloEleitor;
            comando.Parameters.Add("@SecaoEleitoral", SqlDbType.Text);
            comando.Parameters["@SecaoEleitoral"].Value = DadosFuncionario.SecaoEleitor;
            comando.Parameters.Add("@ZonaEleitoral", SqlDbType.Text);
            comando.Parameters["@ZonaEleitoral"].Value = DadosFuncionario.ZonaEleitoral;
            comando.Parameters.Add("@Endereco", SqlDbType.Text);
            comando.Parameters["@Endereco"].Value = DadosFuncionario.Endereco;
            comando.Parameters.Add("@NumeroEndereco", SqlDbType.Text);
            comando.Parameters["@NumeroEndereco"].Value = DadosFuncionario.NumeroEndereco;
            comando.Parameters.Add("@TipoEndereco", SqlDbType.Text);
            comando.Parameters["@TipoEndereco"].Value = DadosFuncionario.TipoEndereco;
            comando.Parameters.Add("@Bairro", SqlDbType.Text);
            comando.Parameters["@Bairro"].Value = DadosFuncionario.Bairro;
            comando.Parameters.Add("@Complemento", SqlDbType.Text);
            comando.Parameters["@Complemento"].Value = DadosFuncionario.Complemento;
            comando.Parameters.Add("@Cep", SqlDbType.Text);
            comando.Parameters["@Cep"].Value = DadosFuncionario.Cep;
            comando.Parameters.Add("@Cidade", SqlDbType.Text);
            comando.Parameters["@Cidade"].Value = DadosFuncionario.Cidade;
            comando.Parameters.Add("@UF", SqlDbType.Text);
            comando.Parameters["@UF"].Value = DadosFuncionario.UF;
            comando.Parameters.Add("@Nacionalidade", SqlDbType.Text);
            comando.Parameters["@Nacionalidade"].Value = DadosFuncionario.Nacionalidade;
            comando.Parameters.Add("@Email", SqlDbType.Text);
            comando.Parameters["@Email"].Value = DadosFuncionario.Email;
            comando.Parameters.Add("@TelefoneCelular", SqlDbType.Text);
            comando.Parameters["@TelefoneCelular"].Value = DadosFuncionario.TelefoneCelular;
            comando.Parameters.Add("@TelefoneResidencial", SqlDbType.Text);
            comando.Parameters["@TelefoneResidencial"].Value = DadosFuncionario.TelefoneResidencial;
            comando.Parameters.Add("@OBS", SqlDbType.Text);
            comando.Parameters["@OBS"].Value = DadosFuncionario.OBS;
            comando.Parameters.Add("@Cargo", SqlDbType.Text);
            comando.Parameters["@Cargo"].Value = DadosFuncionario.Cargo;
            comando.Parameters.Add("@CarteiraProfissional", SqlDbType.Text);
            comando.Parameters["@CarteiraProfissional"].Value = DadosFuncionario.CarteiraProfissional;
            comando.Parameters.Add("@SerieCarteiraProfissional", SqlDbType.Text);
            comando.Parameters["@SerieCarteiraProfissional"].Value = DadosFuncionario.SerieCarteiraProfisional;
            comando.Parameters.Add("@Salario", SqlDbType.Decimal);
            comando.Parameters["@Salario"].Value = DadosFuncionario.Salario;
            comando.Parameters.Add("@Comissao", SqlDbType.Decimal);
            comando.Parameters["@Comissao"].Value = DadosFuncionario.Comissao;

                comando.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                throw new Exception ("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        /// <summary>
        /// Altera dados na tabela funcionario no banco de dados
        /// </summary>
        /// <param name="DadosFuncionario"></param>
        public void AlterarFuncionario(Funcionario DadosFuncionario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            try
            {
                conexao.Open();

            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE funcionario SET nome_funcionario = @Nome, dt_nascimento = @DataNascimento, RG = @RG, CPF = @CPF, PIS = @PIS, titulo_eleitor = @TituloEleitor, secao_eleitoral = @SecaoEleitoral, zona_eleitoral = @ZonaEleitoral, endereco_funcionario = @Endereco, numero_endereco_funcionario = @NumeroEndereco, tipo_endereco_funcionario = @TipoEndereco, bairro_funcionario = @Bairro, complemento_endereco_funcionario = @Complemento, cep_funcionario = @Cep, cidade_funcionario = @Cidade, uf_funcionario = @UF, nacionalidade = @Nacionalidade, email_funcionario = @Email, tel_celular_funcionario = @TelefoneCelular, tel_residencial_funcionario = @TelefoneResidencial, obs = @OBS, cargo = @Cargo, carteira_profissional = @CarteiraProfissional, serie_carteira_profissional = @SerieCarteiraProfissional, salario = @Salario, comissao = @Comissao, ativo = @Ativo where id_funcionario = @IdFuncionario";
            comando.Parameters.Add("@Nome", SqlDbType.Text);
            comando.Parameters["@Nome"].Value = DadosFuncionario.Nome;
            comando.Parameters.Add("@DataNascimento", SqlDbType.Date);
            comando.Parameters["@DataNascimento"].Value = DadosFuncionario.DataNascimento;
            comando.Parameters.Add("@RG", SqlDbType.Text);
            comando.Parameters["@RG"].Value = DadosFuncionario.RG;
            comando.Parameters.Add("@CPF", SqlDbType.Text);
            comando.Parameters["@CPF"].Value = DadosFuncionario.CPF;
            comando.Parameters.Add("@PIS", SqlDbType.Text);
            comando.Parameters["@PIS"].Value = DadosFuncionario.PIS;
            comando.Parameters.Add("@TituloEleitor", SqlDbType.Text);
            comando.Parameters["@TituloEleitor"].Value = DadosFuncionario.TituloEleitor;
            comando.Parameters.Add("@SecaoEleitoral", SqlDbType.Text);
            comando.Parameters["@SecaoEleitoral"].Value = DadosFuncionario.SecaoEleitor;
            comando.Parameters.Add("@ZonaEleitoral", SqlDbType.Text);
            comando.Parameters["@ZonaEleitoral"].Value = DadosFuncionario.ZonaEleitoral;
            comando.Parameters.Add("@Endereco", SqlDbType.Text);
            comando.Parameters["@Endereco"].Value = DadosFuncionario.Endereco;
            comando.Parameters.Add("@NumeroEndereco", SqlDbType.Text);
            comando.Parameters["@NumeroEndereco"].Value = DadosFuncionario.NumeroEndereco;
            comando.Parameters.Add("@TipoEndereco", SqlDbType.Text);
            comando.Parameters["@TipoEndereco"].Value = DadosFuncionario.TipoEndereco;
            comando.Parameters.Add("@Bairro", SqlDbType.Text);
            comando.Parameters["@Bairro"].Value = DadosFuncionario.Bairro;
            comando.Parameters.Add("@Complemento", SqlDbType.Text);
            comando.Parameters["@Complemento"].Value = DadosFuncionario.Complemento;
            comando.Parameters.Add("@Cep", SqlDbType.Text);
            comando.Parameters["@Cep"].Value = DadosFuncionario.Cep;
            comando.Parameters.Add("@Cidade", SqlDbType.Text);
            comando.Parameters["@Cidade"].Value = DadosFuncionario.Cidade;
            comando.Parameters.Add("@UF", SqlDbType.Text);
            comando.Parameters["@UF"].Value = DadosFuncionario.UF;
            comando.Parameters.Add("@Nacionalidade", SqlDbType.Text);
            comando.Parameters["@Nacionalidade"].Value = DadosFuncionario.Nacionalidade;
            comando.Parameters.Add("@Email", SqlDbType.Text);
            comando.Parameters["@Email"].Value = DadosFuncionario.Email;
            comando.Parameters.Add("@TelefoneCelular", SqlDbType.Text);
            comando.Parameters["@TelefoneCelular"].Value = DadosFuncionario.TelefoneCelular;
            comando.Parameters.Add("@TelefoneResidencial", SqlDbType.Text);
            comando.Parameters["@TelefoneResidencial"].Value = DadosFuncionario.TelefoneResidencial;
            comando.Parameters.Add("@OBS", SqlDbType.Text);
            comando.Parameters["@OBS"].Value = DadosFuncionario.OBS;
            comando.Parameters.Add("@Cargo", SqlDbType.Text);
            comando.Parameters["@Cargo"].Value = DadosFuncionario.Cargo;
            comando.Parameters.Add("@CarteiraProfissional", SqlDbType.Text);
            comando.Parameters["@CarteiraProfissional"].Value = DadosFuncionario.CarteiraProfissional;
            comando.Parameters.Add("@SerieCarteiraProfissional", SqlDbType.Text);
            comando.Parameters["@SerieCarteiraProfissional"].Value = DadosFuncionario.SerieCarteiraProfisional;
            comando.Parameters.Add("@Salario", SqlDbType.Decimal);
            comando.Parameters["@Salario"].Value = DadosFuncionario.Salario;
            comando.Parameters.Add("@Comissao", SqlDbType.Decimal);
            comando.Parameters["@Comissao"].Value = DadosFuncionario.Comissao;
            comando.Parameters.Add("@IdFuncionario", SqlDbType.Int);
            comando.Parameters["@IdFuncionario"].Value = DadosFuncionario.IdFuncionario;
            comando.Parameters.Add("@Ativo", SqlDbType.Bit);
            comando.Parameters["@Ativo"].Value = DadosFuncionario.Ativo;

                comando.ExecuteScalar();
            }
            catch(SqlException e)
            {
                throw new Exception ("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        /// <summary>
        /// Altera dados na tabela funcionario no banco de dados
        /// </summary>
        /// <param name="DadosFuncionario"></param>
        public void AlterarFuncionarioComissao(Funcionario DadosFuncionario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            try
            {
                conexao.Open();

                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE funcionario SET comissao = @Comissao where id_funcionario = @IdFuncionario";
                comando.Parameters.Add("@IdFuncionario", SqlDbType.Int);
                comando.Parameters["@IdFuncionario"].Value = DadosFuncionario.IdFuncionario;
                comando.Parameters.Add("@Comissao", SqlDbType.Decimal);
                comando.Parameters["@Comissao"].Value = DadosFuncionario.Comissao;
                comando.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        /// <summary>
        /// Deleta dados da tabela funcionario do banco de dados, Utilizando Id como parâmetro//para uso futuro
        /// </summary>
        /// <param name="IdFuncionario"></param> 
        public void DeletarFuncionario(int IdFuncionario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            try
            {
                conexao.Open();

            comando.CommandText = "DELETE FROM funcionario WHERE id_funcionario = @IdFuncionario";
            comando.Parameters.Add("@IdFuncionario", SqlDbType.Int);
            comando.Parameters["@IdFuncionario"].Value = IdFuncionario;

                comando.ExecuteScalar();
            }
            catch(SqlException e)
            {
                throw new Exception ("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        } 

        /// <summary>
        /// Carrega dados da tabela funcionarios do banco de dados a partir do ID
        /// </summary>
        /// <param name="IdFuncionario"></param>
        /// <returns></returns>
        public Funcionario SelecionarFuncionario(int IdFuncionario)
        {
            
            Funcionario retorno = new Funcionario();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Funcionario WHERE id_funcionario = @IdFuncionario";
            comando.Parameters.Add("@IdFuncionario", SqlDbType.Int);
            comando.Parameters["@IdFuncionario"].Value = IdFuncionario;
            SqlDataReader dr = comando.ExecuteReader();
            try
            {
                while(dr.Read())
                {
                    retorno.IdFuncionario = (int)dr["id_funcionario"];
                    retorno.Nome = dr["nome_funcionario"].ToString();
                    retorno.RG = dr["RG"].ToString();
                    retorno.CPF = dr["CPF"].ToString();
                    retorno.DataNascimento = DateTime.Parse(dr["dt_nascimento"].ToString());
                    retorno.Email = dr["email_funcionario"].ToString();
                    retorno.Endereco = dr["endereco_funcionario"].ToString();
                    retorno.TipoEndereco = dr["tipo_endereco_funcionario"].ToString();
                    retorno.Complemento = dr["complemento_endereco_funcionario"].ToString();
                    retorno.NumeroEndereco = dr["numero_endereco_funcionario"].ToString();
                    retorno.Bairro = dr["bairro_funcionario"].ToString();
                    retorno.Cidade = dr["cidade_funcionario"].ToString();
                    retorno.UF = dr["uf_funcionario"].ToString();
                    retorno.Cep = dr["cep_funcionario"].ToString();
                    retorno.Nacionalidade = dr["nacionalidade"].ToString();
                    retorno.TelefoneCelular = dr["tel_celular_funcionario"].ToString();
                    retorno.TelefoneResidencial = dr["tel_residencial_funcionario"].ToString();
                    retorno.Cargo = dr["cargo"].ToString();
                    retorno.Salario = decimal.Parse(dr["salario"].ToString());
                    retorno.Comissao = decimal.Parse(dr["comissao"].ToString());
                    retorno.OBS = dr["obs"].ToString();
                    retorno.TituloEleitor = dr["titulo_eleitor"].ToString();
                    retorno.SecaoEleitor = dr["secao_eleitoral"].ToString();
                    retorno.ZonaEleitoral = dr["zona_eleitoral"].ToString();
                    retorno.PIS = dr["PIS"].ToString();
                    retorno.CarteiraProfissional = dr["carteira_profissional"].ToString();
                    retorno.SerieCarteiraProfisional = dr["serie_carteira_profissional"].ToString();
                    retorno.Ativo = bool.Parse(dr["ativo"].ToString());

                }

            }
            catch(SqlException e)
            {
                throw new Exception ("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;
        }

        /// <summary>
        /// carrega informações em lista da tabela funcionario do banco de dados
        /// </summary>
        /// <returns></returns>
        public List<Funcionario> ConsultaFuncionarioNoBanco()
        {     

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            List<Funcionario> retorno = new List<Funcionario>();

            try
            {
            comando.CommandText = "SELECT * FROM funcionario";
            conexao.Open();
            SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    retorno.Add(new Funcionario()
                    {
                        IdFuncionario = (int)dr["id_funcionario"],
                        Nome = dr["nome_funcionario"].ToString(),
                        RG = dr["RG"].ToString(),
                        CPF = dr["CPF"].ToString(),
                        DataNascimento = (DateTime)dr["dt_nascimento"],
                        Email = dr["email_funcionario"].ToString(),
                        Endereco = dr["endereco_funcionario"].ToString(),
                        TipoEndereco = dr["tipo_endereco_funcionario"].ToString(),
                        Complemento = dr["complemento_endereco_funcionario"].ToString(),
                        NumeroEndereco = dr["numero_endereco_funcionario"].ToString(),
                        Bairro = dr["bairro_funcionario"].ToString(),
                        Cidade = dr["cidade_funcionario"].ToString(),
                        UF = dr["uf_funcionario"].ToString(),
                        Cep = dr["cep_funcionario"].ToString(),
                        Nacionalidade = dr["nacionalidade"].ToString(),
                        TelefoneCelular = dr["tel_celular_funcionario"].ToString(),
                        TelefoneResidencial = dr["tel_residencial_funcionario"].ToString(),
                        Cargo = dr["cargo"].ToString(),
                        Salario = (decimal)dr["salario"],
                        Comissao = (decimal)dr["comissao"],
                        OBS = dr["obs"].ToString(),
                        TituloEleitor = dr["titulo_eleitor"].ToString(),
                        SecaoEleitor = dr["secao_eleitoral"].ToString(),
                        ZonaEleitoral = dr["zona_eleitoral"].ToString(),
                        PIS = dr["PIS"].ToString(),
                        CarteiraProfissional = dr["carteira_profissional"].ToString(),
                        SerieCarteiraProfisional = dr["serie_carteira_profissional"].ToString(),
                        Ativo = (bool)dr["ativo"],
                    });
                    
                }
            }
            catch(SqlException e)
            {
                throw new Exception ("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;
        }

        /// <summary>
        /// Seleciona Produto no venda de dados, utilizando login como parâmetro
        /// </summary>
        /// <param name="Nome"></param>
        /// <returns></returns>
        public List<Funcionario> ConsultarFuncionarioNome(string Nome)
        {

            List<Funcionario> retorno = new List<Funcionario>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "Select id_funcionario, nome_funcionario, CPF, cep_funcionario, email_funcionario FROM funcionario WHERE nome_funcionario like '%' + @Nome + '%' ORDER BY id_funcionario";
            comando.Parameters.Add("@Nome", SqlDbType.VarChar);
            comando.Parameters["@Nome"].Value = Nome;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.Add(new Funcionario()
                    {
                        IdFuncionario = (int)dr["id_funcionario"],
                        Nome = dr["nome_funcionario"].ToString(),
                        CPF = dr["CPF"].ToString(),
                        Cep = dr["cep_funcionario"].ToString(),
                        Email = dr["email_funcionario"].ToString()

                    });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return retorno;
        }
        #endregion

        #region Compra
        /// <summary>
        /// Seleciona Compra no banco de dados
        /// </summary>
        /// <param name="IdCompra"></param>
        /// <returns></returns>
        public Compra SelecionarCompra(int IdCompra)
        {
            Compra retorno = new Compra();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "SELECT * FROM compra WHERE id_compra = @IdCompra";
            comando.Parameters.Add("@IdCompra", SqlDbType.Int);
            comando.Parameters["@IdCompra"].Value = IdCompra;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.IdCompra = (int)dr["itens_compra_id_compra"];
                    retorno.IdItensCompra = (int)dr["id_itens_compra"];
                    retorno.PrecoCusto = (decimal)dr["preco_unitario_custo"];
                    retorno.DescricaoModelo = dr["modelo_descricao"].ToString();
                    retorno.NotaCompra = dr["nota_fiscal_compra"].ToString();

                }

            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;
        }

        /// <summary>
        /// Insere nova compra no banco de dados
        /// </summary>
        /// <param name="DadosCompra"></param>
        public void CadastrarCompra(Compra DadosCompra)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            try
            {
                conexao.Open();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO compra (fornecedor_id_fornecedor, usuario_id_usuario, dt_compra, valor_total_compra, descricao_compra, natureza_operacao, quantidade_produtos) VALUES (@IdFornecedor, @IdUsuario, @DataCompra, @ValorTotalCompra, @DescricaoCompra,@NaturezaOperacao, @Quantidade)";
            comando.Parameters.Add("@IdFornecedor", SqlDbType.Int);
            comando.Parameters["@IdFornecedor"].Value = DadosCompra.IdCompraFornecedor;
            comando.Parameters.Add("@IdUsuario", SqlDbType.Int);
            comando.Parameters["@IdUsuario"].Value = DadosCompra.IdCompraUsuario;
            comando.Parameters.Add("@DataCompra", SqlDbType.Date);
            comando.Parameters["@DataCompra"].Value = DadosCompra.DataCompra;
            comando.Parameters.Add("@ValorTotalCompra", SqlDbType.Decimal);
            comando.Parameters["@ValorTotalCompra"].Value = DadosCompra.ValorTotalCompra;
            comando.Parameters.Add("@DescricaoCompra", SqlDbType.Text);
            comando.Parameters["@DescricaoCompra"].Value = DadosCompra.CompraDescricao;
            comando.Parameters.Add("@NaturezaOperacao", SqlDbType.Text);
            comando.Parameters["@NaturezaOperacao"].Value = DadosCompra.NaturezaOperacao;
            comando.Parameters.Add("@Quantidade", SqlDbType.Int);
            comando.Parameters["@Quantidade"].Value = DadosCompra.QuantidadeTotal;

            comando.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        /// <summary>
        /// Cadastra Itens associados a compra do método CadastrarCompra
        /// </summary>
        /// <param name="DadosItensCompra"></param>
        public void CadastrarItensCompra(Compra DadosItensCompra)
        {
            
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            try
            {
                conexao.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO itens_compra (itens_compra_id_compra, modelo_descricao, preco_unitario_custo, nota_fiscal_compra, quantidade) values ((select IDENT_CURRENT ('compra') as id_compra), @DescricaoModelo, @PrecoUnitarioCusto, @NotaCompra, @QuantidadeItens)";
                /*comando.Parameters.Add("@IdCompra", SqlDbType.Int);
                comando.Parameters["@IdCompra"].Value = DadosItensCompra.IdCompra;*/
                comando.Parameters.Add("@DescricaoModelo", SqlDbType.Text);
                comando.Parameters["@DescricaoModelo"].Value = DadosItensCompra.DescricaoModelo;
                comando.Parameters.Add("@PrecoUnitarioCusto", SqlDbType.Decimal);
                comando.Parameters["@PrecoUnitarioCusto"].Value = DadosItensCompra.PrecoCusto;
                comando.Parameters.Add("@NotaCompra", SqlDbType.Text);
                comando.Parameters["@NotaCompra"].Value = DadosItensCompra.NotaCompra;
                comando.Parameters.Add("@QuantidadeItens", SqlDbType.Int);
                comando.Parameters["@quantidadeItens"].Value = DadosItensCompra.QuantidadeItem;
                comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        /// <summary>
        /// Lista itens comprados, buscando informação da tabela itens_compra
        /// </summary>
        /// <returns></returns>
        public List<Compra> ConsultarCompraNoBanco()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            List<Compra> retorno = new List<Compra>();
            try
            {
                comando.CommandText = "SELECT * FROM itens_compra";
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    retorno.Add(new Compra()
                    {
                        IdCompra = (int)dr["itens_compra_id_compra"],
                        IdItensCompra = (int)dr["id_itens_compra"],
                        PrecoCusto = (decimal)dr["preco_unitario_custo"],
                        DescricaoModelo = dr["modelo_descricao"].ToString(),
                        NotaCompra = dr["nota_fiscal_compra"].ToString(),
                        QuantidadeItem = (int)dr["quantidade"],

                    });
                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;

        }

        /// <summary>
        /// Seleciona compra no banco de dados, utilizando login como parâmetro
        /// </summary>
        /// <param name="Login"></param>
        /// <returns></returns>
        public List<Compra> ConsultarCompraId(string Login)
        {

            List<Compra> retorno = new List<Compra>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "Select login, id_compra, usuario_id_usuario, dt_compra, valor_total_compra FROM compra, usuario WHERE usuario_id_usuario = id_usuario and login like '%' + @Login + '%' ORDER BY id_compra";
            comando.Parameters.Add("@Login", SqlDbType.VarChar);
            comando.Parameters["@Login"].Value = Login;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.Add(new Compra()
                    {
                        NomeFuncionario = dr["login"].ToString(),
                        IdCompraUsuario = (int)dr["usuario_id_usuario"],
                        IdCompra = (int)dr["id_compra"],
                        DataCompra = (DateTime)dr["dt_compra"],
                        ValorTotalCompra = (decimal)dr["valor_total_compra"]

                    });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return retorno;
        }

        /// <summary>
        /// Seleciona Produto no venda de dados, utilizando Datas como parâmetro
        /// </summary>
        /// <param name="Data1, Data2"></param>
        /// <returns></returns>
        public List<Compra> ConsultarCompraDatas(DateTime Data1, DateTime Data2)
        {

            List<Compra> retorno = new List<Compra>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "Select login, id_compra, usuario_id_usuario, nome_funcionario, dt_compra, valor_total_compra FROM usuario, compra, funcionario WHERE id_funcionario = funcionarios_id_funcionarios and usuario_id_usuario = id_usuario and dt_compra between @Data1 and @Data2";
            comando.Parameters.Add("@Data1", SqlDbType.Date);
            comando.Parameters["@Data1"].Value = Data1;
            comando.Parameters.Add("@Data2", SqlDbType.Date);
            comando.Parameters["@Data2"].Value = Data2;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.Add(new Compra()
                    {
                        IdCompraUsuario = (int)dr["usuario_id_usuario"],
                        LogIn = dr["login"].ToString(),
                        IdCompra = (int)dr["id_compra"],
                        NomeFuncionario = dr["nome_funcionario"].ToString(),
                        DataCompra = (DateTime)dr["dt_compra"],
                        ValorTotalCompra = (decimal)dr["valor_total_compra"]
                    });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return retorno;
        }

        #endregion

        #region Produto
        /// <summary>
        /// Insere novo Produto no banco de dados
        /// </summary>
        /// <param name="DadosProduto"></param>
        public void CadastrarProduto (Produto DadosProduto)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            try
            {
                conexao.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO produto (modelo_descricao, valor_venda) VALUES (@ModeloDescricao, @ValorVenda)";
                comando.Parameters.Add("@ModeloDescricao", SqlDbType.Text);
                comando.Parameters["@ModeloDescricao"].Value = DadosProduto.DescricaoModelo;
                comando.Parameters.Add("@ValorVenda", SqlDbType.Decimal);
                comando.Parameters["@ValorVenda"].Value = DadosProduto.ValorRevenda;
                comando.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
         }

        /// <summary>
        /// Altera produto no banco de dados somando a quantidade
        /// </summary>
        /// <param name="DadosProduto"></param>
        public void AlterarProdutoSoma(Produto DadosProduto)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE produto SET quantidade = quantidade + @Quantidade WHERE modelo_descricao = @Modelo";
                comando.Parameters.Add("@Quantidade", SqlDbType.Int);
                comando.Parameters["@Quantidade"].Value = DadosProduto.Quantidade;
                comando.Parameters.Add("@Modelo", SqlDbType.VarChar);
                comando.Parameters["@Modelo"].Value = DadosProduto.DescricaoModelo;
                comando.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        /// <summary>
        /// Altera produto no banco de dados subtraindo a quantidade
        /// </summary>
        /// <param name="DadosProduto"></param>
        public void AlterarProdutoSub(Produto DadosProduto)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE produto SET quantidade = quantidade - @Quantidade WHERE modelo_descricao = @Modelo";
                comando.Parameters.Add("@Quantidade", SqlDbType.Int);
                comando.Parameters["@Quantidade"].Value = DadosProduto.Quantidade;
                comando.Parameters.Add("@Modelo", SqlDbType.VarChar);
                comando.Parameters["@Modelo"].Value = DadosProduto.DescricaoModelo;
                comando.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        /// <summary>
        /// Seleciona Produto no banco de dados, utilizando Id como Parâmetro de consulta
        /// </summary>
        /// <param name="IdProduto"></param>
        /// <returns></returns>
        public Produto SelecionarProduto(int IdProduto)
        {
            
            Produto retorno = new Produto();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "SELECT * FROM produto WHERE id_produto = @IdProduto";
            comando.Parameters.Add("@IdProduto", SqlDbType.Int);
            comando.Parameters["@IdProduto"].Value = IdProduto;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while(dr.Read())
                {
                    retorno.IdProduto = (int)dr["id_produto"];
                    retorno.DescricaoModelo = dr["modelo_descricao"].ToString();
                    retorno.ValorRevenda = (decimal)dr["valor_venda"];
                    retorno.Quantidade = (int)dr["quantidade"];
                }

            }
            catch(SqlException e)
            {
                throw new Exception ("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return retorno;
        }

        /// <summary>
        /// Seleciona Produto no banco de dados, utilizando Modelo como parâmetro
        /// </summary>
        /// <param name="Modelo"></param>
        /// <returns></returns>
        public List<Produto> ConsultarProdutoModelo(string Modelo)
        {

            List<Produto> retorno = new List<Produto>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "Select * from produto WHERE modelo_descricao like '%' + @Modelo + '%' ORDER BY id_produto";
            comando.Parameters.Add("@Modelo", SqlDbType.VarChar);
            comando.Parameters["@Modelo"].Value = Modelo;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.Add(new Produto()
                    {
                        IdProduto = (int)dr["id_produto"],
                        DescricaoModelo = dr["modelo_descricao"].ToString(),
                        ValorRevenda = (decimal)dr["valor_venda"],
                        Quantidade = (int)dr["quantidade"],

                    });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return retorno;
        }

        /// <summary>
        /// Seleciona Produto no banco de dados, utilizando Id como parâmetro
        /// </summary>
        /// <param name="IdProduto"></param>
        /// <returns></returns>
        public List<Produto> ConsultarProdutoId(int IdProduto)
        {

            List<Produto> retorno = new List<Produto>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "Select * from produto WHERE id_produto like '%' + @IdProduto + '%' ORDER BY id_produto";
            comando.Parameters.Add("@IdProduto", SqlDbType.VarChar);
            comando.Parameters["@IdProduto"].Value = IdProduto;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.Add(new Produto()
                    {
                        IdProduto = (int)dr["id_produto"],
                        DescricaoModelo = dr["modelo_descricao"].ToString(),
                        ValorRevenda = (decimal)dr["valor_venda"],
                        Quantidade = (int)dr["quantidade"],

                    });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return retorno;
        }

        /// <summary>
        /// Carrega lista de produtos cadastrados na tabela produtos
        /// </summary>
        /// <returns></returns>
        public List<Produto> ConsultarProdutoNoBanco()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            List<Produto> retorno = new List<Produto>();
            try
            {
                comando.CommandText = "SELECT * FROM produto ORDER BY modelo_descricao";
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    retorno.Add(new Produto()
                    {
                        IdProduto = (int)dr["id_produto"],
                        DescricaoModelo = dr["modelo_descricao"].ToString(),
                        ValorRevenda = (decimal)dr["valor_venda"],
                        Quantidade = (int)dr["quantidade"],

                    });
                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;

        }


        #endregion

        #region Usuário

        /// <summary>
        /// Lista usuarios utilizando Id como parâmetro
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Usuario> ConsultarUsuarioId(int IdUsuario)
        {

            List<Usuario> retorno = new List<Usuario>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "SELECT * FROM usuario WHERE id_usuario = @IdUsuario ORDER BY id_usuario";
            comando.Parameters.Add("@IdUsuario", SqlDbType.Int);
            comando.Parameters["@IdUsuario"].Value = IdUsuario;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.Add(new Usuario()
                    {

                        IdUsuario = (int)dr["id_usuario"],
                        IdUsuarioIdFuncionario = (int)dr["funcionarios_id_funcionarios"],
                        Login = dr["login"].ToString(),
                        Senha = dr["senha"].ToString(),
                        Master = (bool)dr["master"],
                        Vendendor = (bool)dr["vendedor"],
                        Administrativo = (bool)dr["administrativo"]

                    });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return retorno;
        }

        /// <summary>
        /// Lista usuarios utilizando login como parâmetro
        /// </summary>
        /// <param name="Login"></param>
        /// <returns></returns>
        public List<Usuario> ConsultarUsuario(string Login)
        {

            List<Usuario> retorno = new List<Usuario>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "SELECT * FROM usuario WHERE login Like '%' + @Login + '%' ORDER BY id_usuario";
            comando.Parameters.Add("@Login", SqlDbType.VarChar);
            comando.Parameters["@Login"].Value = Login;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.Add(new Usuario()
                    {

                    IdUsuario = (int)dr["id_usuario"],
                    IdUsuarioIdFuncionario = (int)dr["funcionarios_id_funcionarios"],
                    Login = dr["login"].ToString(),
                    Senha = dr["senha"].ToString(),
                    Master = (bool)dr["master"],
                    Vendendor = (bool)dr["vendedor"],
                    Administrativo = (bool)dr["administrativo"]

                });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return retorno;
        }

        /// <summary>
        /// Lista usuarios cadastrados
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ConsultarUsuarioNoBanco()
        {

            List<Usuario> retorno = new List<Usuario>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "SELECT * FROM usuario";
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.Add(new Usuario()
                    {

                        IdUsuario = (int)dr["id_usuario"],
                        IdUsuarioIdFuncionario = (int)dr["funcionarios_id_funcionarios"],
                        Login = dr["login"].ToString(),
                        Senha = dr["senha"].ToString(),
                        Master = (bool)dr["master"],
                        Vendendor = (bool)dr["vendedor"],
                        Administrativo = (bool)dr["administrativo"]

                    });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return retorno;
        }

        /// <summary>
        /// Método para validar login e senha
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Senha"></param>
        /// <returns></returns>
        public Usuario ValidarLogin(string Login, string Senha)
        {
                Usuario retorno = new Usuario();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                conexao.Open();
                comando.CommandText = "SELECT * FROM usuario WHERE login = @Login and senha = @Senha";
                comando.Parameters.Add("@Login", SqlDbType.VarChar);
                comando.Parameters["@Login"].Value = Login;
                comando.Parameters.Add("@Senha", SqlDbType.VarChar);
                comando.Parameters["@Senha"].Value = Senha;
                comando.CommandType = CommandType.Text;
                SqlDataReader dr = comando.ExecuteReader();

            try
            {
                if (dr.Read())
                {
                    retorno.IdUsuario = (int)dr["id_usuario"];
                    retorno.IdUsuarioIdFuncionario = (int)dr["funcionarios_id_funcionarios"];
                    retorno.Login = dr["login"].ToString();
                    retorno.Senha = dr["senha"].ToString();
                    retorno.Master = (bool)dr["master"];
                    retorno.Vendendor = (bool)dr["vendedor"];
                    retorno.Administrativo = (bool)dr["administrativo"];
                    retorno.Logado = true;
                }
                else
                {
                    retorno.Logado = false;
                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;
        }

        /// <summary>
        /// Cadastra novo usuário no sistema
        /// </summary>
        /// <param name="DadosUsuario"></param>
        public void CadastrarUsuario(Usuario DadosUsuario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            try
            {
                conexao.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO usuario (funcionarios_id_funcionarios, login, senha, master, vendedor, administrativo) VALUES (@IdFuncionario, @Login, @Senha, @Master, @Vendedor, @Administrativo)";
                comando.Parameters.Add("@IdFuncionario", SqlDbType.Int);
                comando.Parameters["@IdFuncionario"].Value = DadosUsuario.IdUsuarioIdFuncionario;
                comando.Parameters.Add("@Login", SqlDbType.VarChar);
                comando.Parameters["@Login"].Value = DadosUsuario.Login;
                comando.Parameters.Add("@Senha", SqlDbType.VarChar);
                comando.Parameters["@Senha"].Value = DadosUsuario.Senha;
                comando.Parameters.Add("@Master", SqlDbType.Bit);
                comando.Parameters["@Master"].Value = DadosUsuario.Master;
                comando.Parameters.Add("@Vendedor", SqlDbType.Bit);
                comando.Parameters["@vendedor"].Value = DadosUsuario.Vendendor;
                comando.Parameters.Add("@Administrativo", SqlDbType.Bit);
                comando.Parameters["@Administrativo"].Value = DadosUsuario.Administrativo;

                comando.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        /// <summary>
        /// Altera usuário no banco de dados
        /// </summary>
        /// <param name="DadosUsuario"></param>
        public void AlterarUsuario(Usuario DadosUsuario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE usuario SET login = @Login, senha = @Senha, master = @Master, vendedor = @Vendedor, administrativo = @Administrativo WHERE id_usuario = @IdUsuario";
                comando.Parameters.Add("@IdUsuario", SqlDbType.Int);
                comando.Parameters["@IdUsuario"].Value = DadosUsuario.IdUsuario;
                comando.Parameters.Add("@Login", SqlDbType.VarChar);
                comando.Parameters["@Login"].Value = DadosUsuario.Login;
                comando.Parameters.Add("@Senha", SqlDbType.VarChar);
                comando.Parameters["@Senha"].Value = DadosUsuario.Senha;
                comando.Parameters.Add("@Master", SqlDbType.Bit);
                comando.Parameters["@Master"].Value = DadosUsuario.Master;
                comando.Parameters.Add("@Vendedor", SqlDbType.Bit);
                comando.Parameters["@vendedor"].Value = DadosUsuario.Vendendor;
                comando.Parameters.Add("@Administrativo", SqlDbType.Bit);
                comando.Parameters["@Administrativo"].Value = DadosUsuario.Administrativo;
                comando.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        /// <summary>
        /// Seleciona usuario no banco de dados apartir do ID
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        public Usuario SelecionarUsuario(int IdUsuario)
        {
            Usuario retorno = new Usuario();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "SELECT * FROM usuario WHERE id_usuario = @IdUsuario";
            comando.Parameters.Add("@IdUsuario", SqlDbType.Int);
            comando.Parameters["@IdUsuario"].Value = IdUsuario;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.IdUsuario = (int)dr["id_usuario"];
                    retorno.IdUsuarioIdFuncionario = (int)dr["funcionarios_id_funcionarios"];
                    retorno.Login = dr["login"].ToString();
                    retorno.Senha = dr["senha"].ToString();
                    retorno.Master = (bool)dr["master"];
                    retorno.Vendendor = (bool)dr["vendedor"];
                    retorno.Administrativo = (bool)dr["administrativo"];
                }

            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;
        }

        #endregion

        #region Venda
        /// <summary>
        /// Consulta Venda no banco de dados, utilizando Id como parâmetro
        /// </summary>
        /// <param name="IdVenda"></param>
        public Venda SelecionarVenda(int IdVenda)
        {
            Venda retorno = new Venda();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "SELECT * FROM venda, itens_venda WHERE id_venda = @IdVenda";
            comando.Parameters.Add("@IdVenda", SqlDbType.Int);
            comando.Parameters["@IdVenda"].Value = IdVenda;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.IdVenda = (int)dr["id_itens_venda_id_venda"];
                    retorno.IdItensVenda = (int)dr["id_itens_venda"];
                    retorno.PrecoUnitario = (decimal)dr["preco_unitario"];
                    retorno.IdProduto = (int)dr["Id_itens_venda_id_produto"];
                    retorno.DataVenda = (DateTime)dr["data_venda"];
                    retorno.Quantidade = (int)dr["quantidade"];

                }

            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;
        }

        /// <summary>
        /// Insere nova Venda no banco de dados
        /// </summary>
        /// <param name="DadosVenda"></param>
        public void CadastrarVenda(Venda DadosVenda)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            try
            {
                conexao.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO venda(usuario_id_usuario, data_venda, valor_total, cliente_id_cliente) VALUES (@IdUsuario, @DataVenda, @ValorTotal, @IdCliente)";
                comando.Parameters.Add("@IdUsuario", SqlDbType.Int);
                comando.Parameters["@IdUsuario"].Value = DadosVenda.IdFuncionario;
                comando.Parameters.Add("@DataVenda", SqlDbType.Date);
                comando.Parameters["@DataVenda"].Value = DadosVenda.DataVenda;
                comando.Parameters.Add("@ValorTotal", SqlDbType.Decimal);
                comando.Parameters["@ValorTotal"].Value = DadosVenda.ValorTotal;
                comando.Parameters.Add("@IdCliente", SqlDbType.Int);
                comando.Parameters["@IdCliente"].Value = DadosVenda.IdCliente;

                comando.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        /// <summary>
        /// Cadastra Itens associados a Venda do método CadastrarVenda
        /// </summary>
        /// <param name="DadosItensCompra"></param>
        public void CadastrarItensVenda(Venda DadosItensVenda)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            try
            {
                conexao.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO itens_venda (id_itens_venda_id_venda, Id_itens_venda_id_produto, preco_unitario, quantidade) values ((select IDENT_CURRENT ('venda') as id_itens_venda_id_venda), @IdProduto, @PrecoUnitario, @QuantidadeItens)";
                comando.Parameters.Add("@IdProduto", SqlDbType.Int);
                comando.Parameters["@IdProduto"].Value = DadosItensVenda.IdProduto;
                comando.Parameters.Add("@PrecoUnitario", SqlDbType.Decimal);
                comando.Parameters["@PrecoUnitario"].Value = DadosItensVenda.PrecoUnitario;
                comando.Parameters.Add("@QuantidadeItens", SqlDbType.Int);
                comando.Parameters["@QuantidadeItens"].Value = DadosItensVenda.Quantidade;
                comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        /// <summary>
        /// Lista itens Vendidos, buscando informação da tabela itens_venda --> para uso futuro
        /// </summary>
        /// <returns></returns>
        public List<Venda> ConsultarVendaNoBanco()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            List<Venda> retorno = new List<Venda>();
            try
            {
                comando.CommandText = "SELECT * FROM itens_venda";
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    retorno.Add(new Venda()
                    {
                        IdVenda = (int)dr["id_itens_venda_id_venda"],
                        IdItensVenda = (int)dr["id_itens_venda"],
                        IdProduto = (int)dr["Id_itens_venda_id_produto"],
                        PrecoUnitario = (decimal)dr["preco_unitario"],
                        Quantidade = (int)dr["quantidade"],
                        DataVenda = (DateTime)dr["data_venda"],

                    });
                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return retorno;

        }

        /// <summary>
        /// Seleciona Produto no venda de dados, utilizando login como parâmetro
        /// </summary>
        /// <param name="Login"></param>
        /// <returns></returns>
        public List<Venda> ConsultarVendaId(string Login)
        {

            List<Venda> retorno = new List<Venda>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "Select login, id_venda, usuario_id_usuario, data_venda, valor_total, cliente_id_cliente FROM venda, usuario WHERE usuario_id_usuario = id_usuario and login like '%' + @Login + '%' ORDER BY id_venda";
            comando.Parameters.Add("@Login", SqlDbType.VarChar);
            comando.Parameters["@Login"].Value = Login;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.Add(new Venda()
                    {
                        NomeFunconario = dr["login"].ToString(),
                        IdFuncionario = (int)dr["usuario_id_usuario"],
                        IdVenda = (int)dr["id_venda"],
                        DataVenda = (DateTime)dr["data_venda"],
                        IdCliente = (int)dr["cliente_id_cliente"],
                        ValorTotal = (decimal)dr["valor_total"]

                    });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return retorno;
        }

        /// <summary>
        /// Seleciona Produto no venda de dados, utilizando Datas como parâmetro
        /// </summary>
        /// <param name="Data1, Data2"></param>
        /// <returns></returns>
        public List<Venda> ConsultarVendaDatas(DateTime Data1, DateTime Data2)
        {

            List<Venda> retorno = new List<Venda>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            conexao.Open();
            comando.CommandText = "select usuario_id_usuario, login, nome_funcionario, data_venda, valor_total, cliente_id_cliente from venda, usuario, funcionario where id_funcionario = funcionarios_id_funcionarios and usuario_id_usuario = id_usuario and data_venda between @Data1 and @Data2";
            comando.Parameters.Add("@Data1", SqlDbType.Date);
            comando.Parameters["@Data1"].Value = Data1;
            comando.Parameters.Add("@Data2", SqlDbType.Date);
            comando.Parameters["@Data2"].Value = Data2;
            SqlDataReader dr = comando.ExecuteReader();
            comando.CommandType = CommandType.Text;
            try
            {
                while (dr.Read())
                {
                    retorno.Add(new Venda()
                    {
                        IdFuncionario = (int)dr["usuario_id_usuario"],
                        LogIn = dr["login"].ToString(),
                        NomeFunconario = dr["nome_funcionario"].ToString(),
                        DataVenda = (DateTime)dr["data_venda"],
                        IdCliente = (int)dr["cliente_id_cliente"],
                        ValorTotal = (decimal)dr["valor_total"]

                    });

                }
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no banco de dados.\n Mensagem original: \n " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
            return retorno;
        }
        #endregion
    }
}

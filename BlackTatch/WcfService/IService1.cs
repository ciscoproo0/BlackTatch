using AcessoADados.Compras;
using AcessoADados.Funcionarios;
using AcessoADados.Vendas;
using System;
using System.Collections.Generic;
using System.ServiceModel;



namespace WcfService
{
     [ServiceContract]
    public interface IService1
    {
        #region crudFornecedor
        [OperationContract]
        List<Fornecedor> ConsultarFornecedorDataAccess();

        [OperationContract]
        List<Fornecedor> ConsultarFornecedorNome(string Nome);

        [OperationContract]
        Fornecedor SelecionarFornecedor(int IdFornecedor);

        [OperationContract]
        void ExcluirFornecedor(int IdFornecedor);

        [OperationContract]
        void AtualizarFornecedor(Fornecedor DadosFornecedor);

        [OperationContract]
        void InserirFornecedor(Fornecedor DadosFornecedor);
        #endregion

        #region crudCliente
        [OperationContract]
        List<Cliente> ConsultarClienteDataAccess();

        [OperationContract]
        Cliente SelecionarCliente(int IdCliente);

        [OperationContract]
        void ExcluirCliente(int IdCliente);

        [OperationContract]
        void AtualizarCliente(Cliente DadosCliente);

        [OperationContract]
        void InserirCliente(Cliente dadosCliente);
        #endregion

        #region crudFuncionario
        [OperationContract]
        List<Funcionario> ConsultarFuncionarioDataAccess();

        [OperationContract]
        List<Funcionario> ConsultarFuncionarioNome(string Nome);

        [OperationContract]
        Funcionario SelecionarFuncionario(int IdFuncionario);

        [OperationContract]
        void ExcluirFuncionario(int IdFuncionario);

        [OperationContract]
        void AtualizarFuncionario(Funcionario DadosFuncionario);

        [OperationContract]
        void AtualizarFuncionarioComissao(Funcionario DadosFuncionario);

        [OperationContract]
        void InserirFuncionario(Funcionario DadosFuncionario);
        #endregion

        #region Compra
        [OperationContract]
        void InserirCompra(Compra DadosCompra);

        [OperationContract]
        void InserirItensCompra(Compra DadosItensCompra);

        [OperationContract]
        Compra SelecionarCompra(int IdCompra);

        [OperationContract]
        List<Compra> ConsultarCompraNoBanco();

        [OperationContract]
        List<Compra> ConsultarCompraId(string Login);

        [OperationContract]
        List<Compra> ConsultarCompraDatas(DateTime Data1, DateTime Data2);
        #endregion

        #region Produto
        [OperationContract]
        List<Produto> ConsultarProdutoDataAccess();

        [OperationContract]
        List<Produto> ConsultarProdutoModelo(string Modelo);

        [OperationContract]
        List<Produto> ConsultarProdutoId(int IdProduto);

        [OperationContract]
        Produto SelecionarProduto(int IdProduto);

        [OperationContract]
        void AtualizarProdutoSoma(Produto DadosProduto);

        [OperationContract]
        void AtualizarProdutoSub(Produto DadosProduto);

        [OperationContract]
        void InserirProduto(Produto DadosFornecedor);
        #endregion

        #region venda
        [OperationContract]
        void InserirVenda(Venda DadosVenda);

        [OperationContract]
        void InserirItensVenda(Venda DadosItensVenda);

        [OperationContract]
        Venda SelecionarVenda(int IdVenda);

        [OperationContract]
        List<Venda> ConsultarVendaNoBanco();

        [OperationContract]
        List<Venda> ConsultarVendaId(string Login);

        [OperationContract]
        List<Venda> ConsultarVendaDatas(DateTime Data1, DateTime Data2);
        #endregion

        #region Usuário
        [OperationContract]
        List<Usuario> ConsultarUsuarioId(int IdUsuario);

        [OperationContract]
        List<Usuario> ConsultarUsuarioLogin(string Login);

        [OperationContract]
        List<Usuario> ConsultarUsuarioNoBanco();

        [OperationContract]
        Usuario ValidarLogin(string Login, string Senha);

        [OperationContract]
        void CadastrarUsuario(Usuario DadosUsuario);

        [OperationContract]
        void AlterarUsuario(Usuario DadosUsuario);

        [OperationContract]
        Usuario SelecionarUsuario(int IdUsuario);
        #endregion
    }
}

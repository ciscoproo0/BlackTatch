using AcessoADados.Funcionarios;
using AcessoADados.Vendas;
using AcessoADados.Compras;
using AcessoADados;
using System.Collections.Generic;
using System;

namespace WcfService
{
    public class Service1 : IService1
    {
        #region crudFornecedor
        public List<Fornecedor> ConsultarFornecedorDataAccess()
        {
            ServicoDados InstanciaFornecedor = new ServicoDados();
            return InstanciaFornecedor.ConsultaFornecedorNoBanco();
        }

        public List<Fornecedor> ConsultarFornecedorNome(string Nome)
        {
            ServicoDados InstanciaFornecedor = new ServicoDados();
            return InstanciaFornecedor.ConsultarFornecedorNome(Nome);
        }

        public Fornecedor SelecionarFornecedor(int IdFornecedor)
        {
            ServicoDados InstanciaFornecedor = new ServicoDados();
            return InstanciaFornecedor.SelecionarFornecedor(IdFornecedor);
        }
        public void ExcluirFornecedor(int IdFornecedor)
        {
            ServicoDados InstanciaFornecedor = new ServicoDados();
            InstanciaFornecedor.DeletarFornecedor(IdFornecedor);
        }
        public void AtualizarFornecedor(Fornecedor DadosFornecedor)
        {
            ServicoDados InstanciaFornecedor = new ServicoDados();
            InstanciaFornecedor.AlterarFornecedor(DadosFornecedor);
        }
        public void InserirFornecedor(Fornecedor DadosFornecedor)
        {
            ServicoDados InstanciaFornecedor = new ServicoDados();
            InstanciaFornecedor.CadastrarFornecedor(DadosFornecedor);
        }
        #endregion

        #region crudCliente
        public List<Cliente> ConsultarClienteDataAccess()
        {
            ServicoDados InstanciaCliente = new ServicoDados();
            return InstanciaCliente.ConsultaClienteNoBanco();
        }
        public Cliente SelecionarCliente(int IdCliente)
        {
            ServicoDados InstanciaCliente = new ServicoDados();
            return InstanciaCliente.SelecionarCliente(IdCliente);
        }
        public void ExcluirCliente(int IdCliente)
        {
            ServicoDados InstanciaCliente = new ServicoDados();
            InstanciaCliente.DeletarCliente(IdCliente);
        }
        public void AtualizarCliente(Cliente DadosCliente)
        {
            ServicoDados InstanciaCliente = new ServicoDados();
            InstanciaCliente.AlterarCliente(DadosCliente);
        }
        public void InserirCliente(Cliente DadosCliente)
        {
            ServicoDados InstanciaCliente = new ServicoDados();
            InstanciaCliente.CadastrarCliente(DadosCliente);
        }
        #endregion

        #region crudFuncionario
        public List<Funcionario> ConsultarFuncionarioDataAccess()
        {
            ServicoDados InstanciaFuncionario = new ServicoDados();
            return InstanciaFuncionario.ConsultaFuncionarioNoBanco();
        }

        public List<Funcionario> ConsultarFuncionarioNome(string Nome)
        {
            ServicoDados InstanciaFuncionario = new ServicoDados();
            return InstanciaFuncionario.ConsultarFuncionarioNome(Nome);
        }

        public Funcionario SelecionarFuncionario(int IdFuncionario)
        {
            ServicoDados InstanciaFuncionario = new ServicoDados();
            return InstanciaFuncionario.SelecionarFuncionario(IdFuncionario);
        }

        public void ExcluirFuncionario(int IdFuncionario)
        {
            ServicoDados InstanciaFuncionario = new ServicoDados();
            InstanciaFuncionario.DeletarFuncionario(IdFuncionario);
        }

        public void AtualizarFuncionario(Funcionario DadosFuncionario)
        {
            ServicoDados InstanciaFuncionario = new ServicoDados();
            InstanciaFuncionario.AlterarFuncionario(DadosFuncionario);
        }

        public void AtualizarFuncionarioComissao(Funcionario DadosFuncionario)
        {
            ServicoDados InstanciaFuncionario = new ServicoDados();
            InstanciaFuncionario.AlterarFuncionarioComissao(DadosFuncionario);
        }

        public void InserirFuncionario(Funcionario DadosFuncionario)
        {
            ServicoDados InstanciaFuncionario = new ServicoDados();
            InstanciaFuncionario.CadastrarFuncionario(DadosFuncionario);
        }
        #endregion

        #region Compra
        public void InserirCompra(Compra DadosCompra)
        {
            ServicoDados InstanciaCompra = new ServicoDados();
            InstanciaCompra.CadastrarCompra(DadosCompra);
        }

        public void InserirItensCompra(Compra DadosItensCompra)
        {
            ServicoDados InstanciaItensCompra = new ServicoDados();
            InstanciaItensCompra.CadastrarItensCompra(DadosItensCompra);
        }

        public List<Compra> ConsultarCompraNoBanco()
        {
            ServicoDados instanciaCompra = new ServicoDados();
            return instanciaCompra.ConsultarCompraNoBanco();
        }

        public Compra SelecionarCompra(int IdCompra)
        {
            ServicoDados InstanciaCompra = new ServicoDados();
            return InstanciaCompra.SelecionarCompra(IdCompra);
        }

        public List<Compra> ConsultarCompraId(string Login)
        {
            ServicoDados instanciaCompra = new ServicoDados();
            return instanciaCompra.ConsultarCompraId(Login);
        }

        public List<Compra> ConsultarCompraDatas(DateTime Data1, DateTime Data2)
        {
            ServicoDados instanciaCompra = new ServicoDados();
            return instanciaCompra.ConsultarCompraDatas(Data1, Data2);
        }
        #endregion

        #region produto
        public List<Produto> ConsultarProdutoDataAccess()
        {
            ServicoDados InstanciaProduto = new ServicoDados();
            return InstanciaProduto.ConsultarProdutoNoBanco();
        }

        public List<Produto> ConsultarProdutoModelo(string Modelo)
        {
            ServicoDados InstanciaProduto = new ServicoDados();
            return InstanciaProduto.ConsultarProdutoModelo(Modelo);
        }

        public List<Produto> ConsultarProdutoId(int IdProduto)
        {
            ServicoDados InstanciaProduto = new ServicoDados();
            return InstanciaProduto.ConsultarProdutoId(IdProduto);
        }

        public Produto SelecionarProduto(int IdProduto)
        {
            ServicoDados InstanciaProduto = new ServicoDados();
            return InstanciaProduto.SelecionarProduto(IdProduto);
        }
        public void AtualizarProdutoSoma(Produto DadosProduto)
        {
            ServicoDados InstanciaProduto = new ServicoDados();
            InstanciaProduto.AlterarProdutoSoma(DadosProduto);
        }
        public void AtualizarProdutoSub(Produto DadosProduto)
        {
            ServicoDados InstanciaProduto = new ServicoDados();
            InstanciaProduto.AlterarProdutoSub(DadosProduto);
        }
        public void InserirProduto(Produto DadosProduto)
        {
            ServicoDados InstanciaProduto = new ServicoDados();
            InstanciaProduto.CadastrarProduto(DadosProduto);
        }

        #endregion

        #region Venda
        public void InserirVenda(Venda DadosVenda)
        {
            ServicoDados InstanciaVenda = new ServicoDados();
            InstanciaVenda.CadastrarVenda(DadosVenda);
        }

        public void InserirItensVenda(Venda DadosItensVenda)
        {
            ServicoDados InstanciaItensVenda = new ServicoDados();
            InstanciaItensVenda.CadastrarItensVenda(DadosItensVenda);
        }

        public Venda SelecionarVenda(int IdVenda)
        {
            ServicoDados InstanciaVenda = new ServicoDados();
            return InstanciaVenda.SelecionarVenda(IdVenda);
        }

        public List<Venda> ConsultarVendaNoBanco()
        {
            ServicoDados InstanciaVenda = new ServicoDados();
            return InstanciaVenda.ConsultarVendaNoBanco();
        }

        public List<Venda> ConsultarVendaId(string Login)
        {
            ServicoDados InstanciaVenda = new ServicoDados();
            return InstanciaVenda.ConsultarVendaId(Login);
        }

        public List<Venda> ConsultarVendaDatas(DateTime Data1, DateTime Data2)
        {
            ServicoDados InstanciaVenda = new ServicoDados();
            return InstanciaVenda.ConsultarVendaDatas(Data1, Data2);
        }
        #endregion

        #region Usuário

        public List<Usuario> ConsultarUsuarioId(int IdUsuario)
        {
            ServicoDados InstanciaUsuario = new ServicoDados();
            return InstanciaUsuario.ConsultarUsuarioId(IdUsuario);
        }

        public List<Usuario> ConsultarUsuarioLogin(string Login)
        {
            ServicoDados InstanciaUsuario = new ServicoDados();
            return InstanciaUsuario.ConsultarUsuario(Login);
        }

        public List<Usuario> ConsultarUsuarioNoBanco()
        {
            ServicoDados InstanciaUsuario = new ServicoDados();
            return InstanciaUsuario.ConsultarUsuarioNoBanco();
        }
        public Usuario ValidarLogin(string Login, string Senha)
        {
            ServicoDados InstanciaLogin = new ServicoDados();
            return InstanciaLogin.ValidarLogin(Login, Senha);
        }

        public void CadastrarUsuario(Usuario DadosUsuario)
        {
            ServicoDados InstanciaUsuario = new ServicoDados();
            InstanciaUsuario.CadastrarUsuario(DadosUsuario);
        }
                
        public void AlterarUsuario(Usuario DadosUsuario)
        {
            ServicoDados InstanciaUsuario = new ServicoDados();
            InstanciaUsuario.AlterarUsuario(DadosUsuario);
        }

        public Usuario SelecionarUsuario(int IdUsuario)
        {
            ServicoDados InstanciaUsuario = new ServicoDados();
            return InstanciaUsuario.SelecionarUsuario(IdUsuario);
        }
        #endregion
    }
}

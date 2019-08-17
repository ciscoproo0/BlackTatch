using System;

namespace AcessoADados.Vendas
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public int IdFuncionario { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public int? IdCliente { get; set; }



        public int IdItensVenda { get; set; }
        public int IdProduto { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public string LogIn { get; set; }
        public string NomeFunconario { get; set; }
    }
}

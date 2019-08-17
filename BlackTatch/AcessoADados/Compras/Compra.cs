using System;

namespace AcessoADados.Compras
{
    public class Compra
    {
        /// <summary>
        /// descricao geral da compra
        /// </summary>
        #region compra
        public int IdCompra { get; set; }
        public int IdCompraFornecedor { get; set; } //chave estrangeira fornecedor - compra
        public int IdCompraUsuario { get; set; } //chave estrangeira usuario - compra
        public string LogIn { get; set; }
        public string NomeFuncionario { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorTotalCompra { get; set; }
        public string CompraDescricao { get; set; } //descricao geral da compra
        public string NaturezaOperacao { get; set; }
        public int QuantidadeTotal { get; set; }
        #endregion

        /// <summary>
        /// descricao unitaria da compra
        /// </summary>
        #region ItensDaCompra
        public int IdItensCompra { get; set; }
        public string DescricaoModelo { get; set; } //descricao unitaria
        public decimal PrecoCusto { get; set; }
        public string NotaCompra { get; set; }
        public int QuantidadeItem { get; set; }
        #endregion
    }
}

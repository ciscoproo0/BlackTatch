using System;

namespace AcessoADados.Funcionarios
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string TipoEndereco { get; set; }
        public string Complemento { get; set; }
        public string NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }
        public string Nacionalidade { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneResidencial { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public decimal? Comissao { get; set; }
        public string OBS { get; set; }
        public string TituloEleitor { get; set; }
        public string SecaoEleitor { get; set; }
        public string ZonaEleitoral { get; set; }
        public string PIS { get; set; }
        public string CarteiraProfissional { get; set; }
        public string SerieCarteiraProfisional { get; set; }
        public bool Ativo { get; set; }

    }
}

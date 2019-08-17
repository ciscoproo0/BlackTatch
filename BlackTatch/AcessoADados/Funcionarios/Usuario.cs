using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoADados.Funcionarios
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdUsuarioIdFuncionario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Master { get; set; }
        public bool Vendendor { get; set; }
        public bool Administrativo { get; set; }
        public bool Logado { get; set; }
    }
}

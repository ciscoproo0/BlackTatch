using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Apresentacao
{
    public static class Validacoes
    {     
        
        /// <summary>
             /// verifica se o campo está vazio
             /// </summary>
             /// <param ="txt">Caixa de texto estendida</param>
             /// <returns>O conteudo da caixa de texto validada</returns>
        #region ValidarVazio
        public static string ValidarVazio(this TextBox txt)
        {
            if (txt.Text.Trim() == "")
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Prencha o campo" + txt.AccessibleName.ToUpper());
            }
            return txt.Text.Trim();
        }

        #endregion

        /// <summary>
        /// Verifica a digitação de caractéres especiais e substitui por vazio
        /// </summary>
        /// <param name="caracteres"></param>
        /// <returns></returns>
        #region CaracteresEspeciais
        public static string CaracteresEspeciais(this TextBox caracteres)
        {
            string novoCaractere = caracteres.Text.Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("¨", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace("+", "").Replace("=", "").Replace("º", "").Replace("ª", "").Replace("°", "").Replace("|", "").Replace("¹", "").Replace("/", "").Replace("²", "").Replace("³", "").Replace("£", "").Replace("¢", "").Replace("¬", "").Replace("§", "");

            return novoCaractere;

        }
        #endregion

        /// <summary>
        /// Verifica a digitação de caractéres especiais no nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        #region ValidarNome
        public static string ValidarNome(this TextBox nome)
        {
            if (!Regex.IsMatch(nome.ValidarVazio(),
               @"^[aA-zZ]+((\s[aA-zZ]+)+)?$"))
            {
                nome.Focus();
                nome.SelectAll();
                throw new Exception("Digite nome sem acento ou qualquer caractére especial.");
            }
            return nome.Text;
        }
        #endregion

        /// <summary>
        /// Valida Telefone Fixo digitado pelo usuario
        /// </summary>
        /// <param name="TextBox"></param>
        #region ValidarTelFixo
        public static string ValidarTelFixo(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.ValidarVazio(), @"^\d{2}?-?\d{4}-?\d{4}$"))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um número fixo válido, com DDD");
            }
            return txt.Text;
        }
        #endregion

        /// <summary>
        /// Valida telefone celular digitado pelo usuario
        /// </summary>
        /// <param name="TextBox"></param>
        #region ValidarTelCel
        public static string ValidarTelCel(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.ValidarVazio(), @"^\d{2}?-?\d{5}-?\d{4}$"))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um número celular válido com DDD");
            }
            return txt.Text;
        }
        #endregion

        /// <summary>
        /// Valida CEP digitado pelo usuario
        /// </summary>
        /// <param name="TextBox"></param>
        #region ValidarCEP
        public static string ValidarCEP(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.ValidarVazio(),@"^\d{5}\-?\d{3}$"))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um CEP válido");
            }
            return txt.Text;
        }
        #endregion

        /// <summary>
        /// Valida Email digitado pelo usuario
        /// </summary>
        /// <param name="TextBox"></param>
        #region ValidarEmail
        public static string ValidarEmail(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.ValidarVazio(),
                @"^[a-zA-Z0-9\._\-]+\@+[a-zA-Z0-9\._\-]+\.[a-zA-Z]+$"))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um e-mail válido");
            }
            return txt.Text;
        }
        #endregion

        /// <summary>
        /// Valida Site digitado pelo usuario
        /// </summary>
        /// <param name="TextBox"></param>
        #region ValidarEmail
        public static string ValidarSite(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.ValidarVazio(),
                @"^[a-zA-Z]+\.+[a-zA-Z0-9\._\-]+\.+[a-zA-Z0-9\._\-]+\.[a-zA-Z]+$"))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um site válido");
            }
            return txt.Text;
        }
        #endregion

        /// <summary>
        /// Valida RG digitado pelo usuario
        /// </summary>
        /// <param name="TextBox"></param>
        #region ValidarRG
        public static string ValidarRG(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.ValidarVazio(), @"^\d{2}\.?\d{3}\.?\d{3}\-?\d{1}$"))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um RG válido");
            }
            return txt.Text;
        }
        #endregion

        /// <summary>
        /// Valida CPF digitado pelo usuario
        /// </summary>
        /// <param name="TextBox"></param>
        #region ValidarCPF
        public static string ValidarCPF(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.ValidarVazio(), @"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$"))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um CPF válido");
            }
            return txt.Text;
        }
        #endregion

        /// <summary>
        /// Valida CNPJ digitado pelo usuario
        /// </summary>
        /// <param name="TextBox"></param>
        #region ValidarCNPJ
        public static string ValidarCNPJ(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.ValidarVazio(), @"^\d{3}.?\d{3}.?\d{3}/?\d{3}-?\d{2}$"))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um CNPJ válido");
            }
            return txt.Text;
        }
        #endregion

        /// <summary>
        /// Valida Data digitada pelo usuario
        /// </summary>
        /// <param name="TextBox"></param>
        #region ValidarData
        public static DateTime ValidarData(this TextBox txt)
        {
            try
            {
                return Convert.ToDateTime(txt.ValidarVazio());
            }
            catch (Exception ex)
            {
                txt.Focus();
                txt.SelectAll();
                string msg = "";
                if (ex.Message.Substring(0, 8) == "Preencha")
                {
                    msg = ex.Message;
                }
                else
                {
                    msg = "Informe uma data válida";
                }
                throw new Exception(msg);
            }
        }

        #endregion

        /// <summary>
        /// Valida Código digitado pelo usuario
        /// </summary>
        /// <param name="TextBox"></param>
        #region ValidarCodigo
        public static int ValidarCodigo(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.ValidarVazio(), @"^[0-9]+$"))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um código válido");
            }
            return Convert.ToInt32(txt.Text);
        }

        #endregion

        /// <summary>
        /// Valida valor digitado pelo usuario
        /// </summary>
        /// <param name="TextBox"></param>
        #region ValidarCodigo
        public static decimal ValidarValor(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.ValidarVazio(), @"^\d+(?:,\d{1,2})?$"))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um valor válido");
            }
            return Convert.ToDecimal(txt.Text);
        }

        #endregion

        /// <summary>
        /// limpa textboxes
        /// </summary>
        /// <param name="Form"></param>
        #region LimparTela
        public static void limparTxt(Control controle) 
        {
            foreach (Control ctrl in controle.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = String.Empty;
                }
                else if (ctrl.Controls.Count > 0)
                {
                    limparTxt(ctrl);
                }
            }
        }

        #endregion
    }
}

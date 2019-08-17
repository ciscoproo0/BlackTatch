using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validacoes
{
   public static class Validacao
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
        /* public static string CaracteresEspeciais(this TextBox caracteres)
         {
             ArrayList carac = new ArrayList
             carac.Add("!");
              "@", "#", "$", "%", "¨", "&", "*", "(", ")", "_", "-", "+", "=", "`", "´", "{", "[", "}", "]", "~", "^", "?", "/", ":", ";", ">", "<", "|","\""};

             foreach (char c in carac[30])
             {
                 string novoCaractere = caracteres.Text.Replace(c, " ");
             }

             return novoCaractere;
         }*/
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
                throw new Exception("Informe um e-amil válido");
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

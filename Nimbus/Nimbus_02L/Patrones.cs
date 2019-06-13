using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nimbus_02L
{
    public class Patrones
    {
        #region VALIDACION_PATRON
        protected static bool ValidarPorPatron(string Entrada, string Patron)
        {
            try
            {
                MatchCollection Lista_Coincidencias = Regex.Matches(Entrada, Patron);

                if (Lista_Coincidencias.Count > 0) 
                    return true; //patron existe
                else
                    return false; //patron no existe
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static bool VALIDA_CONTEXTO(string Entrada)
        {
            //Entero
            //^(en\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s;$)|(^en\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s<\s\d{1,32000}\s;$)
            //Flotante
            //^(flo\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s;$)|(^flo\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s<\s\d{1,32000}.\d{1,3200}\s;$)
            //Cadena
            //^(cc\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s;$)|(^cc\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s<\s\'\w{1,32000}\'\s;$)
            //Caracter
            //^(ca\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s;$)|(^ca\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s<\s\'\w{1}\'\s;$)
            try
            {
                //ValidarPorPatron(INT, @"^[\s+]*en\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s;$") ||

                if (ValidarPorPatron(Entrada, @"^[\s+]*en\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s<\s\d{1,32000}\s;$"))
                {
                    return true;
                }
                if(ValidarPorPatron(Entrada, @"^[\s+]*flo\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s<\s\d{1,32000}.\d{1,999999}\s;$"))
                {
                    return true;
                }
                if (ValidarPorPatron(Entrada, @"^[\s+]*cc\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s<\s\'\w{2,32000}\'\s;$"))
                {
                    return true;
                }
                if (ValidarPorPatron(Entrada, @"^[\s+]*ca\s[_]{0,1}[A-Za-z]{0,1}\w{0,30}\s<\s\'\w{1}\'\s;$"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}

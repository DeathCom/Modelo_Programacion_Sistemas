using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Nimbus_02L
{
    public class Sentido
    {
        #region Validar_Patron
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
        #endregion
        public static bool Valida_Semantica(string oracion)
        {
            // Entero
            if (ValidarPorPatron(oracion, @"^[\s+]*en\s[A-Za-z]{1}\w{0,31}\s<\s[-]{0,1}\d{1,32000}\s;$"))
            {

                return true;
            }
            // flotante
            if (ValidarPorPatron(oracion, @"^[\s+]*flo\s[A-Za-z]{1}\w{0,31}\s<\s\d{1,32000}.\d{1,999999}\s;$"))
            {
                return true;
            }

            // Caracter
            if (ValidarPorPatron(oracion, @"^[\s+]*ca\s[A-Za-z]{1}\w{0,31}\s<\s\'\S{1}\'\s;$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

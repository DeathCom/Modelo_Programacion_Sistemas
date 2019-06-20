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
            try
            {
                //inicio programa
                if (ValidarPorPatron(Entrada, @"^<!_Nimbus_369_Code_!>$"))
                {
                    return true;
                }
                //funion principal
                if (ValidarPorPatron(Entrada, @"^Nimbus_Main\(\)$"))
                {
                    return true;
                }
                //apertura cierre ambito
                if (ValidarPorPatron(Entrada, @"^[\s+]*\[$"))
                {
                    return true;
                }
                if (ValidarPorPatron(Entrada, @"^[\s+]*\]$"))
                {
                    return true;
                }
                //Constante
                if (ValidarPorPatron(Entrada, @"^[\s+]*~\sca\s[A-Za-z]{1}\w{0,31}\s<\s\'\S{1}\'\s;$"))
                {
                    return true;
                }
                if (ValidarPorPatron(Entrada, @"^[\s+]*~\sen\s[A-Za-z]{1}\w{0,31}\s<\s[-]{0,1}\d{1,32000}\s;$"))
                {
                    return true;
                }
                if (ValidarPorPatron(Entrada, @"^[\s+]*~\sflo\s[A-Za-z]{1}\w{0,31}\s<\s\d{1,32000}.\d{1,999999}\s;$"))
                {
                    return true;
                }

                // Encapsulamiento
                if (ValidarPorPatron(Entrada, @"^[\s+]*\@\sca\s[A-Za-z]{1}\w{0,31}\s<\s\'\S{1}\'\s;$"))
                {
                    return true;
                }
                if (ValidarPorPatron(Entrada, @"^[\s+]*\@\sen\s[A-Za-z]{1}\w{0,31}\s<\s[-]{0,1}\d{1,32000}\s;$"))
                {
                    return true;
                }
                if (ValidarPorPatron(Entrada, @"^[\s+]*\@\sflo\s[A-Za-z]{1}\w{0,31}\s<\s\d{1,32000}.\d{1,999999}\s;$"))
                {
                    return true;
                }
                if (ValidarPorPatron(Entrada, @"^[\s+]*\@\sF_\w*\(\)$"))
                {
                    return true;
                }
                if (ValidarPorPatron(Entrada, @"^[\s+]*\@\sP_\w*\(\)$"))
                {
                    return true;
                }
                if (ValidarPorPatron(Entrada, @"^[\s+]*(\$|\@)\s(P_|F_)\w*\(\s[\w*\,\s\w*]+\s\)$"))
                {
                    return true;
                }
                // creacion general
                if (ValidarPorPatron(Entrada, @"^[\s+]*(en|flo|ca)\s[A-Za-z]{1}\w{0,31}\s;$"))
                {
                    return true;
                }
                // Entero
                if (ValidarPorPatron(Entrada, @"^[\s+]*en\s[A-Za-z]{1}\w{0,31}\s<\s[-]{0,1}\d{1,32000}\s;$"))
                {
                    return true;
                }
                // flotante
                if(ValidarPorPatron(Entrada, @"^[\s+]*flo\s[A-Za-z]{1}\w{0,31}\s<\s\d{1,32000}.\d{1,999999}\s;$"))
                {
                    return true;
                }

                // Caracter
                if (ValidarPorPatron(Entrada, @"^[\s+]*ca\s[A-Za-z]{1}\w{0,31}\s<\s\'\S{1}\'\s;$"))
                {
                    return true;
                }
                // Suma resta multiplicacion division modulo y exponente
                if (ValidarPorPatron(Entrada, @"^[\s+]*[A-Za-z]{0,1}\w{0,30}\s<\s\w{1,33}\s(sum|res|mult|div|modd|exp){1}\s\w{1,33}\s;$"))
                {
                    return true;
                }
                // Invocacion de Funcion o Procedimiento
                if (ValidarPorPatron(Entrada, @"(^[\s+]*inv\sF_\w*\(\)\;$)|(^[\s+]*inv\sF_\w*\(\s[\w*\,\s\w*]+\s\)\;$)"))
                {
                    return true;
                }
                if (ValidarPorPatron(Entrada, @"(^[\s+]*inv\sP_\w*\(\)\;$)|(^[\s+]*inv\sP_\w*\(\s[\w*\,\s\w*]+\s\)\;$)"))
                {
                    return true;
                }
                // funcion imprimir
                if (ValidarPorPatron(Entrada, @"(^[\s+]*#=>\(\s\w{1,32}\s\)\s;$)|(^[\s+]*#=>\(\s\'\w{1}\S*\'\s\)\s;$)|(^[\s+]*#=>\(\s\'\w{1}\S*\'\s[\%]{0,1}\s\'\w{1}\S*\'\s\)\s;$)|(^[\s+]*#=>\(\s\'\w{1}\S*\'\s[\%]{0,1}\s\'\w{1}\S*\'\s[\%]{0,1}\s\'\w{1}\S*\'\s\)\s;$)"))
                {
                    return true;
                }
                // funcion capturar
                if (ValidarPorPatron(Entrada, @"(^[\s+]*#=<\(\s\'[\w*\,\s\w*]+\'\s\)\s;$)"))
                {
                    return true;
                }
                // x<condición>[]
                if (ValidarPorPatron(Entrada, @"(^[\s+]*x<\s\w*\s(eq|dif|maq|meq)\s\w*\s>$)|(^[\s+]*x<\s\w*\s>$)|(^[\s+]*x<\s\w*\s(eq|dif|maq|meq)\s\w*\s(\+|\/)\s\w*\s(eq|dif|maq|meq)\s\w*\s>$)"))
                {
                    return true;
                }
                // Ciclo zc<
                if (ValidarPorPatron(Entrada, @"(^[\s+]*zc<\s\w*\s(eq|dif|maq|meq)\s\w*\s>$)|(^[\s+]*zc<\s\w*\s>$)|(^[\s+]*zc<\s\w*\s(eq|dif|maq|meq)\s\w*\s(\+|\/)\s\w*\s(eq|dif|maq|meq)\s\w*\s>$)"))
                {
                    return true;
                }
                // Decaracion de Funcion
                if (ValidarPorPatron(Entrada, @"(^[\s+]*F_\w*\(\)$)|(^[\s+]*F_\w*\(\s[\w*\,\s\w*]+\s\)$)"))
                {
                    return true;
                }
                // Decaracion de Procedimiento
                if (ValidarPorPatron(Entrada, @"(^[\s+]*P_\w*\(\)$)|(^[\s+]*P_\w*\(\s[\w*\,\s\w*]+\s\)$)"))
                {
                    return true;
                }
                // retorno de funcion 
                if (ValidarPorPatron(Entrada, @"^[\s+]*&\s\w{1}\w*\s;$"))
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

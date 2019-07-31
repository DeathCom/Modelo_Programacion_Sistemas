using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Nimbus_02L
{
    public class PatronSemantico
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
        public static bool Valida_Declaracion(string oracion)
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
            // funcion capturar Entero
            if (ValidarPorPatron(oracion, @"^[\s+]*en\s\w*\s<\s#<=\(\s\d{1,32000}\s\)\s\;$"))
            {
                return true;
            }
            // funcion capturar Flotante
            if (ValidarPorPatron(oracion, @"((^[\s+]*flo\s\w*\s<\s#<=\(\s\d{1,32000}.\d{1,999999}\s\)\s\;$)|(^[\s+]*flo\s\w*\s<\s#<=\(\s\d{1,32000}\s\)\s\;$))"))
            {
                return true;
            }
            // funcion capturar caracter
            if (ValidarPorPatron(oracion, @"((^[\s+]*flo\s\w*\s<\s#<=\(\s\d{1,32000}.\d{1,999999}\s\)\s\;$)|(^[\s+]*flo\s\w*\s<\s#<=\(\s\d{1,32000}\s\)\s\;$))"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Validad_Variables(string Entrada)
        {
            // Suma resta multiplicacion division 
            if (ValidarPorPatron(Entrada, @"^[\s+]*[A-Za-z]{0,1}\w{0,30}\s<\s(\w{1,33}|\d{1,32000}.\d{1,999999})\s(sum|res|mult|div){1}\s(\w{1,33}|\d{1,32000}.\d{1,999999})\s;$"))
            {
                return true;
            }
            // Invocacion de Funcion o Procedimiento
            if (ValidarPorPatron(Entrada, @"(^[\s+]*inv\sF_\w*\(\)\;$)|(^[\s+]*inv\sF_\w*\(\s[\w*\,\s\w*]+\s\)\s\;$)"))
            {
                return true;
            }
            if (ValidarPorPatron(Entrada, @"(^[\s+]*inv\sP_\w*\(\)\;$)|(^[\s+]*inv\sP_\w*\(\s[\w*\,\s\w*]+\s\)\s\;$)"))
            {
                return true;
            }
            // funcion imprimir
            if (ValidarPorPatron(Entrada, @"(^[\s+]*#=>\(\s\w{1,32}\s\)\s\;)|(^[\s+]*#=>\(\s[\']{1}[\S\s]+[\']{1}\s\)\s\;)|(^[\s+]*#=>\(\s\w{1}\S*\s(|sum|res|mult|div|modd|exp)\s\w{1}\S*\s\)\s;)|(^[\s+]*#=>\(\s[\']{0,1}[\S\s]+[\']{0,1}\s[\%]{0,1}\s[\']{0,1}[\S\s]+[\']{0,1}\s\)\s;)|(^[\s+]*#=>\(\s\'[\S\s]+[\']{0,1}\s[\%]{0,1}\s[\']{0,1}[\S\s]+\'\s[\%]{0,1}\s[\']{0,1}[\S\s]+[\']{0,1}\s\)\s;)"))
            {
                return true;
            }
            // funcion capturar
            if (ValidarPorPatron(Entrada, @"((^[\s+]*\w*\s<\s#<=\(\s\'[\w*\s\w*]+\'\s\)\s\;$)|(^[\s+]*\w*\s<\s#<=\(\s\d{1,32000}\s\)\s\;$)|(^[\s+]*\w*\s<\s#<=\(\s\d{1,32000}.\d{1,32000}\s\)\s\;$))"))
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
    }
}

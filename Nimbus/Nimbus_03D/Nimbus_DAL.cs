using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimbus_03D
{
    public class Nimbus_DAL
    {
        private string Codigo;
        private string Simbolo;
        private string Tipo_Token;
        private int Ambito;
        private Nimbus_DAL Anterior;
        private Nimbus_DAL Siguiente;

        public string CODIGO
        {
            get
            {
                return Codigo;
            }

            set
            {
                Codigo = value;
            }
        }

        public string SIMBOLO
        {
            get
            {
                return Simbolo;
            }

            set
            {
                Simbolo = value;
            }
        }

        public string TIPO_TOKEN
        {
            get
            {
                return Tipo_Token;
            }

            set
            {
                Tipo_Token = value;
            }
        }

        public int AMBITO
        {
            get
            {
                return Ambito;
            }

            set
            {
                Ambito = value;
            }
        }
        public Nimbus_DAL ANTERIOR
        {
            get
            {
                return Anterior;
            }

            set
            {
                Anterior = value;
            }
        }

        public Nimbus_DAL SIGUIENTE
        {
            get
            {
                return Siguiente;
            }

            set
            {
                Siguiente = value;
            }
        }

        
    }
}

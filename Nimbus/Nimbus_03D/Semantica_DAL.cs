using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimbus_03D
{
    public class Semantica_DAL
    {
        private string Tipo;
        private string Nombre;
        private string Valor;
        private Semantica_DAL Anterior;
        private Semantica_DAL Siguiente;

        public string TIPO
        {
            get
            {
                return Tipo;
            }

            set
            {
                Tipo = value;
            }
        }

        public string NOMBRE
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }

        public string VALOR
        {
            get
            {
                return Valor;
            }

            set
            {
                Valor = value;
            }
        }

        public Semantica_DAL ANTERIOR
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

        public Semantica_DAL SIGUIENTE
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

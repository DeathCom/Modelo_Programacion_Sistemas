using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nimbus_03D;

namespace Nimbus_02L
{
    public class Semantica_BLL
    {
        private Semantica_DAL objInitial;
        private Semantica_DAL objQueue;
        private Semantica_DAL objTmp;

        #region Method_FILL
        public Semantica_DAL FILL(string Tipo, string Nombre, string valor, Semantica_DAL Anterior, Semantica_DAL Siguiente)
        {
            Semantica_DAL dTemp = new Semantica_DAL();
            dTemp.TIPO = Tipo;
            dTemp.NOMBRE = Nombre;
            dTemp.VALOR = valor;
            dTemp.ANTERIOR = Anterior;
            dTemp.SIGUIENTE = Siguiente;
            return dTemp;
        }
        #endregion

        #region Method_Save
        public void SAVE(string Tipo, string Nombre, string valor)
        {
            if (objInitial == null)
            {
                objInitial = FILL(Tipo, Nombre, valor, null, null);
                objQueue = objInitial;
                objTmp = objInitial;
            }
            else
            {
                objQueue.SIGUIENTE = FILL(Tipo, Nombre, valor, objQueue, objInitial);
                objQueue = objQueue.SIGUIENTE;
                objInitial.ANTERIOR = objQueue;
            }
        }
        #endregion

        #region Method_Following
        public Semantica_DAL FOLLOWING()
        {
            if (objTmp.SIGUIENTE == null)
            {
                return objTmp;
            }
            else
            {
                objTmp = objTmp.SIGUIENTE;
                return objTmp;
            }
        }
        #endregion

        #region Method_Previous
        public Semantica_DAL PREVIOUS()
        {
            if (objTmp.ANTERIOR == null)
            {
                return objTmp;
            }
            else
            {
                objTmp = objTmp.ANTERIOR;
                return objTmp;
            }
        }
        #endregion

        #region Method_First
        public Semantica_DAL FIRST()
        {
            return objInitial;
        }
        #endregion

        #region Method_Last
        public Semantica_DAL LAST()
        {
            return objQueue;
        }
        #endregion

        #region Method_Search_Token
        public Semantica_DAL SEARCH_NOMBRE(Semantica_DAL Oracion)
        {
            objTmp = objInitial;
            Semantica_DAL dTemp = new Semantica_DAL();
            do
            {
                if (objTmp.NOMBRE.Equals(Oracion.NOMBRE))
                {
                    dTemp = objTmp;
                }
                objTmp = objTmp.SIGUIENTE;
            } while (objTmp != objInitial);
            return dTemp;
        }
        #endregion

        #region Method_Delete
        public void DELETE_LIST()
        {
            objInitial = null;
            objQueue = null;
            objTmp = null;
        }
        #endregion

        #region Method_Modify
        public void MODIFICAR(Semantica_DAL Oracion)
        {
            objTmp = objInitial;
            do
            {
                if (objTmp.NOMBRE.Equals(Oracion.NOMBRE))
                {
                    objTmp.VALOR = Oracion.VALOR;
                    break;
                }
                objTmp = objTmp.SIGUIENTE;
            } while (objTmp != objInitial);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nimbus_03D;

namespace Nimbus_02L
{
    public class Nimbus_BLL
    {
        private Nimbus_DAL objInitial;
        private Nimbus_DAL objQueue;
        private Nimbus_DAL objTmp;

        #region Method_FILL
        public Nimbus_DAL FILL(string Codigo, string Simbolo, string Tipo_Token, int Ambito, 
            Nimbus_DAL Anterior, Nimbus_DAL Siguiente)
        {
            Nimbus_DAL dTemp = new Nimbus_DAL();
            dTemp.CODIGO = Codigo;
            dTemp.SIMBOLO = Simbolo;
            dTemp.TIPO_TOKEN = Tipo_Token;
            dTemp.AMBITO = Ambito;
            dTemp.ANTERIOR = Anterior;
            dTemp.SIGUIENTE = Siguiente;
            return dTemp;
        }
        #endregion

        #region Method_Save
        public void SAVE(string Codigo, string Simbolo, string Tipo_Token, int Ambito)
        {
            if (objInitial == null)
            {
                objInitial = FILL(Codigo, Simbolo, Tipo_Token, Ambito, null, null);
                objQueue = objInitial;
                objTmp = objInitial;
            }
            else
            {
                objQueue.SIGUIENTE = FILL(Codigo, Simbolo, Tipo_Token, Ambito, objQueue, objInitial);
                objQueue = objQueue.SIGUIENTE;
                objInitial.ANTERIOR = objQueue;
            }
        }
        #endregion

        #region Method_Following
        public Nimbus_DAL FOLLOWING()
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
        public Nimbus_DAL PREVIOUS()
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
        public Nimbus_DAL FIRST()
        {
            return objInitial;
        }
        #endregion

        #region Method_Last
        public Nimbus_DAL LAST()
        {
            return objQueue;
        }
        #endregion

        #region Method_Search_Token
        public Nimbus_DAL SEARCH_TOKEN(Nimbus_DAL TOKEN)
        {
            objTmp = objInitial;
            Nimbus_DAL dTemp = new Nimbus_DAL();
            do
            {
                if (objTmp.SIMBOLO.Equals(TOKEN.SIMBOLO))
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
            //if (objInitial == objQueue && ext.SIMBOLO.Equals(objInitial.SIMBOLO))
            //{
            //    objInitial = null;
            //    objQueue = null;
            //}
            //else if (ext.SIMBOLO.Equals(objInitial.SIMBOLO))
            //{
            //    Nimbus_DAL tmpanterior = new Nimbus_DAL();
            //    tmpanterior = objTmp.ANTERIOR;
            //    objTmp = objTmp.SIGUIENTE;
            //    objInitial = objTmp;
            //    objTmp.ANTERIOR = tmpanterior;
            //    tmpanterior.SIGUIENTE = objTmp;
            //}
            //else if (ext.SIMBOLO.Equals(objQueue.SIMBOLO))
            //{
            //    Nimbus_DAL tmpanterior = new Nimbus_DAL();
            //    tmpanterior = objQueue.ANTERIOR;
            //    objTmp = objQueue.SIGUIENTE;
            //    objQueue = tmpanterior;
            //    objTmp.ANTERIOR = tmpanterior;
            //    tmpanterior.SIGUIENTE = objTmp;
            //}
            //else
            //{
            //    Nimbus_DAL tmpanterior = new Nimbus_DAL();
            //    objTmp = objInitial;
            //    while (objTmp.SIGUIENTE != objQueue)
            //    {
            //        if (ext.Equals(objTmp))
            //        {
            //            tmpanterior = objTmp.ANTERIOR;
            //            objTmp = objTmp.SIGUIENTE;
            //            objTmp.ANTERIOR = tmpanterior;
            //            tmpanterior.SIGUIENTE = objTmp;
            //        }
            //        else
            //        {
            //            objTmp = objTmp.SIGUIENTE;
            //        }
            //    }
            //}

        }
        #endregion

        #region Method_Modify
        public void MODIFICAR(Nimbus_DAL TOKEN)
        {
            objTmp = objInitial;
            do
            {
                if (objTmp.SIMBOLO.Equals(TOKEN.SIMBOLO))
                {
                    objTmp.AMBITO = TOKEN.AMBITO;
                    break;
                }
                objTmp = objTmp.SIGUIENTE;
            } while (objTmp != objInitial);
        }
        #endregion
    }
}

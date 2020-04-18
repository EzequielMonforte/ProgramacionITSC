using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
        public class Tarjeta
        {
            #region atributos         
            private int nrotarjeta;
            private int saldo;

            #endregion

            #region Constructor         
            public Tarjeta()
            {
                nrotarjeta = 0;
                saldo = 0;
            }
            
        
            #endregion

            #region Prop        
            public int NroTarjeta { get =>nrotarjeta; set  => nrotarjeta = value;  }
            public int Saldo { get => saldo;  set => saldo = value;  }

            #endregion
        
        
            #region Metodos
            public int Sumar(int monto)
            {
                saldo += monto;
                return saldo;  
            }
            
            public int Restar(int monto)
            {
            saldo -= monto;
            return monto;
            }
            #endregion
        }


}


using System;

namespace ProductPrecio
{
    public class Producto
    {
        System.String[] Nombre = new System.String[1];
        System.String[] Precio = new System.String[1];

        System.Int32 CantElem = 0;


        /// <summary>
        /// carga un elemento nuevo a la lista
        /// </summary>
        /// <param name="aElemento">Elemento a cargar en la lista</param>
        /// <returns></returns>
        public System.String CargarLista(System.String aNombre,
                                         System.String aPrecio)
        {
            System.String mRes = "";
            //System.Decimal mPrecio = System.Convert.ToDecimal(aPrecio);
            
            if (CantElem == Nombre.Length)
            {
                Nombre = RedimensionarStr(Nombre);
                Precio = RedimensionarStr(Precio);
            }
            if (BuscaPorNombre(aNombre) == -1)
            {
                Nombre[CantElem] = aNombre;
				Precio[CantElem] = aPrecio;
                CantElem++;
                mRes = Listado();
            }
            else
            {
                mRes = "El elemento " + aNombre + " ya existe";
            }
            return mRes;
        }
		//suma todos los items dentro de la lista precio
		public string TotalPrecio()
		{
			string res = "0";

			foreach (var item in Precio)
			{
				res = (int.Parse(res) + int.Parse(item)).ToString();
			}
			return $"precio total: {res}";
		}

		/// <summary>
		/// devuelve en un string los elemntos de laa lista
		/// </summary>
		/// <returns></returns>
		public System.String Listado()
        {
            System.String Res = $"Productos cargados:{Nombre.Length}{Environment.NewLine}\r\n";

            System.Int32 j = 0;
            foreach (System.String mElemento in Nombre)
            {
                if (mElemento == null)
                {
                    break;
                }
				Res = Res + mElemento
				+ " - $"
					+ Precio[j].ToString() + "\r\n";
                j = j + 1;
            }

            return Res;

        }

        /// <summary>
        /// devuelve la posicion donde se encuentra un elemento dentro de la lista, 
        /// si el valor devuelto es -1 significa que no se encontro
        /// </summary>
        /// <param name="aElemento">elemnto a buscar en la lista</param>
        /// <returns></returns>
        public System.Int32 BuscaPorNombre(System.String aElemento)
        {
            System.Int32 mREs = -1;

            for (int i = 0; i < Nombre.Length; i++)
            {
                if (Nombre[i] == aElemento)
                {
                    mREs = i + 1;
                    break;
                }
            }
            return mREs;
        }

        /// <summary>
        /// Agrega un elemento null a la lista al final
        /// </summary>
        /// <param name="aLista">Lista de string a redimensionar</param>
        private System.String[] RedimensionarStr(System.String[] aLista)
        {
            System.String[] Res = new System.String[aLista.Length + 1];
            System.Int32 j = 0;
            foreach (System.String mElemento in aLista)
            {
                Res[j] = mElemento;
                j++;
            }

            return Res;
        }

        /// <summary>
        /// Agrega un elemento null a la lista al final
        /// </summary>
        /// <param name="aLista">Lista de descimal a redimensionar</param>
        /// <returns></returns>
        private System.Decimal[] RedimensionarDec(System.Decimal[] aLista)
        {
            System.Decimal[] Res = new System.Decimal[aLista.Length + 1];
            System.Int32 j = 0;
            foreach (System.Decimal mElemento in aLista)
            {
                Res[j] = mElemento;
                j++;
            }

            return Res;
        }
		/// <summary>
		/// Ordena las listas por precio o alfabetiamente segun lo indicado
		/// </summary>
		/// <param name="ordenarpor">
		/// 1: ordena por precio, 2: ordena alfabeticamente
		/// </param>
		/// <returns>
		/// String, lista ordenada.
		/// </returns>
		public string OrdenadoDesc(short ordenarpor)
		{
			string res = "";
			
			//copia arreglo Precio(decimal) a precios(string)
			//string[] precios= new string[Precio.Length];
			//Precio.CopyTo(precios, 0);

			if (ordenarpor == 1)
			{
				OrdenarPorPrecio();
				//MetodoOrdenamiento(Precio, Nombre); no funciona ordena segun la primer sifra del numero
				//metodo cambiado a ordenar por precio
			}
			if (ordenarpor == 2)
			{
				MetodoOrdenamiento(Nombre, Precio);
			}
			res = Listado();

			return res;
		}

		public int PrecioTotal() {
			int devolver = 0;
			foreach (string a in Precio) {
				devolver = devolver + int.Parse(a);
			}
			return devolver;
		}

		private void OrdenarPorPrecio()
		{
			int i = 0;
			int o = 0;
			for (i = 0; i < Precio.Length; i++) {
				for (o = i+1; o < Precio.Length; o++) {
					if (!PrecioDesc(Precio[i], Precio[o])) {
						string aux = Precio[i];
						string aux2 = Nombre[i];
						Precio[i] = Precio[o];
						Nombre[i] = Nombre[o];
						Precio[o] = aux;
						Nombre[o] = aux2;
					}
				}
			}

			bool PrecioDesc(string a, string b) {
				bool devolver=true;
				char[] cifras1 = a.ToCharArray();
				char[] cifras2 = b.ToCharArray();

				if (cifras1.Length > cifras2.Length)
				{
					return true; // el primer numero tiene mas cifras que el otro por lo tanto es mas grande
					
				}
				if (cifras2.Length > cifras1.Length) {
					return false; // segundo numero tiene mas cifras qe e lotro por lo tanto es mas grande return false
				 }
				//en caso de ser iguales comprueba cifra por cifra para ver quien es mas grande
				for (int f = 0; f < cifras1.Length; f++) {
					if(cifras1[f].CompareTo(cifras2[f]) >0){
						return devolver=true;
					}
					if (cifras1[f].CompareTo(cifras2[f]) <0){
						return devolver= false;
					}
					
				}
				return devolver;
			}
		}

		private void MetodoOrdenamiento(string[] principal,string[] seguidora) {

			for (int i = 0; i < principal.Length; i++)
			{
				for (int o = i; o < principal.Length; o++)
				{
					if (principal[i].CompareTo(principal[o]) > 0)
					{
						string aux = principal[i];
						string aux2 = seguidora[i];
						principal[i] = principal[o];
						seguidora[i] = seguidora[o];
						principal[o] = aux;
						seguidora[o] = aux2;

					}
				}
			}


		}
	}
}

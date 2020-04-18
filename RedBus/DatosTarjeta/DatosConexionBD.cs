using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Data
{
    public class DatosConexionBD
    {
        public SqlConnection conexion;

        public DatosConexionBD()
        {
             conexion = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Tarje;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                   
            }
            catch (Exception e)
            {
                throw new Exception("Error al abrir la conexión", e);
            }
        }

        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                { conexion.Close(); }
            }
            catch (Exception e)
            {
                throw new Exception("Error al cerrar la conexión", e);
            }
        }
    }

}

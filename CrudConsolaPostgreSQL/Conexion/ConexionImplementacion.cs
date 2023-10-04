using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CrudConsolaPostgreSQL.Conexion
{
    public class ConexionImplementacion : ConexionInterface
    {
        public NpgsqlConnection generaConexionPostgre()
        {
            string stringConexionPostgresql = ConfigurationManager.ConnectionStrings["stringConexion"].ConnectionString;
            Console.WriteLine("Cadena de conexion: {0}", stringConexionPostgresql);

            NpgsqlConnection conexion = null; //Inicio la conexion en null.º
            string estado = ""; //Así controlaré el estado de la conexion.

            if (!string.IsNullOrWhiteSpace(stringConexionPostgresql))
            {
                try
                {
                    conexion = new NpgsqlConnection(stringConexionPostgresql);
                    conexion.Open(); //Abro conexion
                    estado = conexion.State.ToString();
                    if (estado.Equals("Open"))
                        Console.WriteLine("La conexion está abierta.");
                    else
                        conexion = null;
                }
                catch (Exception)
                {
                    Console.WriteLine("Conexion Fallida");
                    conexion = null;
                    return conexion;
                }
            }


            return conexion;
        }
    }
}

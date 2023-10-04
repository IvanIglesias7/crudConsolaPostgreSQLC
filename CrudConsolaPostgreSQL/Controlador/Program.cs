using CrudConsolaPostgreSQL.Conexion;
using CrudConsolaPostgreSQL.Consultas;
using CrudConsolaPostgreSQL.DAOs;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudConsolaPostgreSQL
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConexionInterface conexionInterface = new ConexionImplementacion();
            ConsultasInterface consultasInterface = new ConsultasImplementacion();

            NpgsqlConnection conexion = null;

            conexion = conexionInterface.generaConexionPostgre();
            conexion.Close();

            conexion.Open();
            consultasInterface.selectTodo(conexion);



            Console.ReadLine();
        }
    }
}

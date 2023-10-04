using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudConsolaPostgreSQL.Conexion
{
    public interface ConexionInterface
    {
        NpgsqlConnection generaConexionPostgre(); //Genera una conexion a bd y la devuelve.

    }
}

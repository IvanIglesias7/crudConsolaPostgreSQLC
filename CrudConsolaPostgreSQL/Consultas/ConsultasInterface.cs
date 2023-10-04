using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudConsolaPostgreSQL.Consultas
{
    public interface ConsultasInterface
    {
        void selectTodo(NpgsqlConnection conexion); //Hacemos un select a base de datos que recoja todo.



    }
}

using CrudConsolaPostgreSQL.DAOs;
using CrudConsolaPostgreSQL.DTOs;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudConsolaPostgreSQL.Consultas
{
    public class ConsultasImplementacion : ConsultasInterface
    {
        public void selectTodo(NpgsqlConnection conexion)
        {
			List<LibroDTO> listaLibros = new List<LibroDTO>();

			try
			{
				NpgsqlCommand consulta = new NpgsqlCommand("SELECT titulo, autor, isbn, edicion FROM gbp_almacen.gbp_alm_cat_libros;");
				NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();

				while (lectorConsulta.Read())
                {
					listaLibros.Add(new LibroDTO(
                    lectorConsulta[0].ToString(),
                    lectorConsulta[1].ToString(),
                    (long)lectorConsulta[2],
                    (int)lectorConsulta[3])
                    );
                }

				foreach (LibroDTO l in listaLibros)
				{
					Console.WriteLine(l.Titulo + " ");
					Console.Write(l.Autor);
					Console.WriteLine("");
				}

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				
			}
        }
    }
}

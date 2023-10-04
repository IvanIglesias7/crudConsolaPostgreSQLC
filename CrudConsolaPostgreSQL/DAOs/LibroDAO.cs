using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudConsolaPostgreSQL.DAOs
{
    public class LibroDAO
    {
        //Atributos

        int id;
        string nombre;
        string autor;
        long isbn;
        int edicion;

        //Constructor
        public LibroDAO(string nombre, string autor, long isbn, int edicion)
        {
            this.Nombre = nombre;
            this.Autor = autor;
            this.Isbn = isbn;
            this.Edicion = edicion;
        }

        public LibroDAO()
        {
        }

        //Getter and Setters
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Autor { get => autor; set => autor = value; }
        public long Isbn { get => isbn; set => isbn = value; }
        public int Edicion { get => edicion; set => edicion = value; }
    }
}

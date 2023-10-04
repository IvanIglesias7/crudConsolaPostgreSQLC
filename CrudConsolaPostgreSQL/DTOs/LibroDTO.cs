using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudConsolaPostgreSQL.DTOs
{
    public class LibroDTO
    {

        //Atributos 

        int id;
        string titulo;
        string autor;
        long isbn;
        int edicion;


        //Constructores
        public LibroDTO()
        {
        }

        public LibroDTO(string titulo, string autor, long isbn, int edicion)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Isbn = isbn;
            this.Edicion = edicion;
        }


        //Getter and Setters
        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public long Isbn { get => isbn; set => isbn = value; }
        public int Edicion { get => edicion; set => edicion = value; }
    }
}

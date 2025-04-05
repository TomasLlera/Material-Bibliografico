using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Material_Bibliografico;

namespace Practica_ProgramacionII.Clases
{
    class Material_Bibliografico
    {
        public List<Libro> libro = new List<Libro>();
        public List<Ebook> ebook = new List<Ebook>();
        public List<Revista> revista = new List<Revista>();

        protected string titulo;
        protected int año;

        public string Titulo { get => titulo; set => titulo = value; }
        public int Año { get => año; set => año = value; }

        public Material_Bibliografico(string titulo, int año)
        {
            this.titulo = titulo;
            this.año = año;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"El titulo del libro es: {titulo}. ");
            Console.WriteLine($"El año del libro es: {año}");
        }
    }
}
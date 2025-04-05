using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ProgramacionII.Clases
{
    class Libro : Material_Bibliografico
    {
        private int paginas;
        private Autor autor;

        public int Paginas { get => paginas; set => paginas = value; }

        public Libro(string titulo, int año, int paginas, Autor autor) : base(titulo, año)
        {
            this.paginas = paginas;
            this.autor = autor;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"La cantidad de paginas del libro es de: {paginas}");
            this.autor.MostrarInformacion();
        }
    }
}
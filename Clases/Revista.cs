using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ProgramacionII.Clases
{
    class Revista : Material_Bibliografico
    {
        private int volumen;
        public Autor autor;

        public int Volumen { get => volumen; set => volumen = value; }

        public Revista(string titulo, int año, int volumen, Autor autor) : base(titulo, año)
        {
            this.volumen = volumen;
            this.autor = autor;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"El volumen de la revista es: {volumen}");
            this.autor.MostrarInformacion();
        }
    }
}
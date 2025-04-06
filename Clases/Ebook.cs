using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ProgramacionII.Clases
{
    class Ebook : Material_Bibliografico
    {
        private double pesoMb;
        public Autor autor;

        public double PesoMb { get => pesoMb; set => pesoMb = value; }

        public Ebook(string titulo, int año, double pesoMb, Autor autor) : base(titulo, año)
        {
            this.pesoMb = pesoMb;
            this.autor = autor;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"El peso en MB(MegaBytes) es de: {pesoMb}");
            this.autor.MostrarInformacion();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ProgramacionII.Clases
{
    class Autor
    {
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public Autor(string nombre)
        {
            this.nombre = nombre;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"El autor es{nombre}");
        }
    }
}
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
        private Autor autor;

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
        public void AgregarEbook()
        {

            Console.WriteLine("Ingrese el titulo del ebook.");
            titulo = Console.ReadLine();
            if (string.IsNullOrEmpty(titulo))
            {
                Console.WriteLine("Ingrese un nombre correcto por favor.");
                titulo = Console.ReadLine();
            }
            bool validad = false;
            Console.WriteLine("Ingrese el año del ebook.");
            string intAño = Console.ReadLine();
            do
            {
                if (int.TryParse(intAño, out int año))
                {
                    this.año = año;
                    validad = true;
                }
                else
                {
                    Console.WriteLine("Ingrese un año correcto por favor.");
                    intAño = Console.ReadLine();
                }
            } while (!validad);

            Console.WriteLine("Ingrese el peso en MegaBytes del ebook.");
            string pesoMB = Console.ReadLine();
            if (double.TryParse(pesoMB, out double peso))
            {
                this.pesoMb = peso;
            }
            else
            {
                Console.WriteLine("Ingrese un peso correcto por favor.");
                pesoMB = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el nombre del autor");
            string newAutor = Console.ReadLine();
            if (string.IsNullOrEmpty(newAutor))
            {
                Console.WriteLine("Ingrese un nombre correcto por favor.");
                newAutor = Console.ReadLine();
            }
            this.autor = new Autor(newAutor);
            Ebook newEbook = new Ebook(titulo, año, pesoMb, autor);

            ebook.Add(newEbook);

            Console.WriteLine("Libro agregado correctamente ✅");
        }
        public void QuitarEbook()
        {
            Console.WriteLine("Seleccione el ebook a eliminar:");

            for (int i = 0; i < ebook.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Titulo:{ebook[i].Titulo} Año:{ebook[i].Año} PesoMb: {ebook[i].PesoMb} Autor:{ebook[i].autor}");
            }

            Console.Write("Ingrese el número del Ebook que desea eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= ebook.Count)
            {
                indice -= 1; 
                Ebook ebookEliminado = ebook[indice]; 
                ebook.RemoveAt(indice);  

                Console.WriteLine("Ebook eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_ProgramacionII.Clases;

namespace Material_Bibliografico.Clases
{
    internal class Biblioteca
    {

        public List<Libro> libro = new List<Libro>();
        public List<Ebook> ebook = new List<Ebook>();
        public List<Revista> revista = new List<Revista>();

        public void AgregarEbook()
        {
            string titulo;
            do
            {
                Console.WriteLine("Ingrese el título del ebook:");
                titulo = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(titulo));

            int año;
            while (true)
            {
                Console.WriteLine("Ingrese el año del ebook:");
                string inputAño = Console.ReadLine();
                if (int.TryParse(inputAño, out año)) break;
                Console.WriteLine("Año inválido. Intente nuevamente.");
            }

            double pesoMb;
            while (true)
            {
                Console.WriteLine("Ingrese el peso en MegaBytes del ebook:");
                string inputPeso = Console.ReadLine();
                if (double.TryParse(inputPeso, out pesoMb)) break;
                Console.WriteLine("Peso inválido. Intente nuevamente.");
            }

            string nombreAutor;
            do
            {
                Console.WriteLine("Ingrese el nombre del autor:");
                nombreAutor = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nombreAutor));

            Autor autor = new Autor(nombreAutor);
            Ebook newEbook = new Ebook(titulo, año, pesoMb, autor);
            ebook.Add(newEbook);

            Console.WriteLine("Ebook agregado correctamente");
        }
        public void QuitarEbook()
        {
            Console.WriteLine("Seleccione el ebook a eliminar:");

            for (int i = 0; i < ebook.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Título: {ebook[i].Titulo} | Año: {ebook[i].Año} | Peso MB: {ebook[i].PesoMb} | Autor: {ebook[i].autor.Nombre}");
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

        public void AgregarLibro()
        {
            string titulo;
            do
            {
                Console.WriteLine("Ingrese el título del libro:");
                titulo = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(titulo));

            int año;
            while (true)
            {
                Console.WriteLine("Ingrese el año del libro:");
                string inputAño = Console.ReadLine();
                if (int.TryParse(inputAño, out año)) break;
                Console.WriteLine("Año inválido. Intente nuevamente.");
            }

            int paginas;
            while (true)
            {
                Console.WriteLine("Ingrese la cantidad de paginas del libro:");
                string inputPagina = Console.ReadLine();
                if (int.TryParse(inputPagina, out paginas)) break;
                Console.WriteLine("Cantidad de paginas invalidas. Intente nuevamente.");
            }

            string nombreAutor;
            do
            {
                Console.WriteLine("Ingrese el nombre del autor:");
                nombreAutor = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nombreAutor));

            Autor autor = new Autor(nombreAutor);
            Libro newLibro = new Libro(titulo, año, paginas, autor);
            libro.Add(newLibro);

            Console.WriteLine("Libro agregado correctamente");
        }
        public void QuitarLibro()
        {
            Console.WriteLine("Seleccione el libro a eliminar:");

            for (int i = 0; i < libro.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Título: {libro[i].Titulo} | Año: {libro[i].Año} | Páginas: {libro[i].Paginas} | Autor: {libro[i].autor.Nombre}");
            }

            Console.Write("Ingrese el número del libro que desea eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= libro.Count)
            {
                indice -= 1;
                Libro libroEliminado = libro[indice];
                libro.RemoveAt(indice);

                Console.WriteLine("Libro eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }

            Console.ReadKey();
        }
        public void AgregarRevista()
        {
            string titulo;
            do
            {
                Console.WriteLine("Ingrese el título de la revista:");
                titulo = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(titulo));

            int año;
            while (true)
            {
                Console.WriteLine("Ingrese el año de la revista:");
                string inputAño = Console.ReadLine();
                if (int.TryParse(inputAño, out año)) break;
                Console.WriteLine("Año inválido. Intente nuevamente.");
            }

            int volumen;
            while (true)
            {
                Console.WriteLine("Ingrese la cantidad de volumenes de la revista:");
                string inputVolumen = Console.ReadLine();
                if (int.TryParse(inputVolumen, out volumen)) break;
                Console.WriteLine("Cantidad de paginas invalidas. Intente nuevamente.");
            }

            string nombreAutor;
            do
            {
                Console.WriteLine("Ingrese el nombre del autor:");
                nombreAutor = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nombreAutor));

            Autor autor = new Autor(nombreAutor);
            Revista newRevista = new Revista(titulo, año, volumen, autor);
            revista.Add(newRevista);

            Console.WriteLine("Libro agregado correctamente");
        }
        public void QuitarRevista()
        {
            Console.WriteLine("Seleccione la revista a eliminar:");

            for (int i = 0; i < revista.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Título: {revista[i].Titulo} | Año: {revista[i].Año} | Volumen: {revista[i].Volumen} | Autor: {revista[i].autor.Nombre}");
            }

            Console.Write("Ingrese el número de la revista que desea eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= revista.Count)
            {
                indice -= 1;
                Revista revistaEliminada = revista[indice];
                libro.RemoveAt(indice);

                Console.WriteLine("Revista eliminada exitosamente.");
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }

            Console.ReadKey();
        }
    }
}

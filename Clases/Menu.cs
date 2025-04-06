using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Material_Bibliografico.Clases;

namespace Practica_ProgramacionII.Clases
{
    class Menu
    {
        private Biblioteca biblioteca = new Biblioteca();
        public void MenuPrincipal()
        {
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Programa de Biblioteca");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Agregar un libro fisico");
                Console.WriteLine("2. Agregar un ebook");
                Console.WriteLine("3. Agregar una revista");
                Console.WriteLine("4. Quitar un libro fisico");
                Console.WriteLine("5. Quitar un ebook");
                Console.WriteLine("6. Quitar una revista");
                Console.WriteLine("7. Salir del programa");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Elija una opcion...");
                char opcion = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (opcion)
                {
                    case '1':
                        biblioteca.AgregarLibro();
                        break;
                    case '2':
                        biblioteca.AgregarEbook();
                        break;
                    case '3':
                        biblioteca.AgregarRevista();
                        break;
                    case '4':
                        biblioteca.QuitarLibro();
                        break;
                    case '5':
                        biblioteca.QuitarEbook();
                        break;
                    case '6':
                        biblioteca.QuitarRevista();
                        break;
                    case '7':
                        Console.WriteLine("Saliendo del programa...");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            } while (!salir);
        }
    }
}
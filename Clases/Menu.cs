using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ProgramacionII.Clases
{
    class Menu
    {
        public void menuprincipal()
        {


            Console.WriteLine("Programa de Biblioteca");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Agregar un libro fisico");
            Console.WriteLine("2. Agregar un ebook");
            Console.WriteLine("3. Agregar una revista");
            Console.WriteLine("4. Quitar un libro fisico");
            Console.WriteLine("5. Quitar un ebook");
            Console.WriteLine("6. Quitar una revista");
            Console.WriteLine("7. Salir del programa");
            Console.WriteLine("Elija una opcion...");
            char opcion = Console.ReadKey().KeyChar;
            switch (opcion)
            {
                case '1':
                    break;
                case '2':
                    
                    break;
                case '3':
                    break;
                case '4':
                    break;
                case '5':
                    break;
                case '6':
                    break;
                case '7':
                    break;
                default:
                    break;
            }


        }
    }
}
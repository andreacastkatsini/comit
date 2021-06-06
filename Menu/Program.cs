using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc = "";
           
            do
            {
                Console.Clear();
                imprimirmenu();
                opc = Console.ReadLine();


                switch (opc)
                {
                    case "1":
                        agregarpagina();
                        break;
                    case "2":
                        buscar_x_direccion();
                        break;
                    case "3":
                        buscar_x_url();
                        break;
                    case "4":
                        visitar();
                        break;
                    case "5":
                        Console.WriteLine("Saliendo del programa.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        Console.ReadKey();
                        Console.Clear();
                        
                        break;
                }
            }
            while (opc != "5");
            Console.ReadKey();
        }
  
        static void imprimirmenu(){
                Console.ForegroundColor = ConsoleColor.Cyan;
      
                Console.WriteLine("1- Agendar Pagina");
                Console.WriteLine("2- Buscar si existe esta pagina");
                Console.WriteLine("3- Buscar si existe esta pagina por url");
                Console.WriteLine("4- Abrir pagina en el navegador");
                Console.ResetColor();
                Console.ForegroundColor=ConsoleColor.DarkCyan;
                Console.WriteLine("5- Salir");
                Console.WriteLine("Seleccione una de las opciones anteriores.");
        }

        static void agregarpagina()
        {
            Console.WriteLine("Agendar Pagina");
            Console.ReadKey();
        }
        
        static void buscar_x_direccion()
        {
            Console.WriteLine("Buscar alguna dirección");
            Console.ReadKey();
        }
        static void buscar_x_url()
        {
            Console.WriteLine("Buscar alguna Pagina");
            Console.ReadKey();
        }
        static void visitar()
        {
            Console.WriteLine("Visitar Pagina");
            Console.ReadKey();
        }
    }
}

using System;
using Catalogo; //otro espacio de nombres
namespace Clase17_Objetos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primer objeto");

            //2. Crear objeto de clase
            //NombreClase nombreobjeto = new NombreClase(); //llama al constructor
            //c# me crea un constructor vacio por defecto
            Producto argenta = new Producto("Burguer Argenta");
            Producto aburrida = new Producto("Burguer Aburrida",150);
            
            //consolre read line "Cuanto quiere comprar"
            Console.WriteLine(aburrida.Nombre + " hay en stock:" + aburrida.Stock);
            if(aburrida.Comprar(2))
            {
                Console.WriteLine("buen provecho");

            }
            Console.WriteLine(aburrida.Nombre + " hay en stock:" + aburrida.Stock);


            Console.ReadKey();



        }
    }
}

using System;

namespace TareaGrupal
{
    class Program
    {    
        static void Main(string[] args)
        {
            string [] semana = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes"};
            float [] gastos = new float [7];
            float gastoParcial = 0;
            float promedio = 0;
            for (int i = 0; i < semana.Length; i++)
            {
                float respuesta;
                Console.WriteLine("----------------Ingreso de Datos----------------");
                Console.WriteLine("Ingrese Gasto del Dia: "+ semana[i]);
                respuesta = float.Parse(Console.ReadLine());
                gastos[i] = respuesta;
                gastoParcial += respuesta;
                promedio = gastoParcial/semana.Length;
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Gasto Parcial: "+gastoParcial);
                Console.WriteLine("Promedio : "+ promedio);
                Console.WriteLine("------------------------------------------------");

            }
            for (int i = 0; i < semana.Length; i++)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Dia : "+semana[i]);
                Console.WriteLine("Gasto = "+gastos[i]);
                Console.WriteLine("---------------------");
            }
            for (int i = 0; i < semana.Length; i++)
            {
                if(gastos[i] > (2*promedio)){
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Se paso del promedio " + semana[i]);
                    Console.WriteLine("-----------------------------------");
                }
            }
        }
    }
}

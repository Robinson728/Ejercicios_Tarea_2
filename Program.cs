using System;
//•	Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier número.

namespace Ejercicio1_Tabla_de_multiplicar_
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            int num = 0, total = 0;

            Console.Write("Digite un numero para mostrar su tabla de multiplicar: ");
            entrada = Console.ReadLine();
            num = Convert.ToInt32(entrada);

            Console.WriteLine("");

            for (int i=1; i<=10; i++)
            {
                total = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, total);
            }
        }
    }
}

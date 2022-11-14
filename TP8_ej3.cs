using System;
/*3) Desarrollar un programa que solicite al usuario ingresar 6 números y almacenar en ARRAY y
por último se lo debe recorrer para calcular y mostrar el promedio de los valores.*/
namespace TP8C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int [] nuevoArray = new int [6];
            string paraGuardar = "";
            int valor = 0;
            int promedio = 0;
            for (int i = 0; i < nuevoArray.Length; i++)
            {
                Console.WriteLine("Ingrese el "+(i+1)+"° numero entero...");
                paraGuardar = Console.ReadLine ();
                valor = Convert.ToInt32(paraGuardar); 
                nuevoArray [i] = valor;
                Console.Clear();
            }
            Console.WriteLine("Los datos ingresados son: ");
            for (int i = 0; i < nuevoArray.Length; i++)
            {
                Console.WriteLine("Dato "+(i+1)+": "+nuevoArray[i]);
                promedio = promedio + nuevoArray [i];
            }
            Console.WriteLine("Has terminado. El promedio de los numeros ingresado es: "+ promedio/nuevoArray.Length);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
    }
}

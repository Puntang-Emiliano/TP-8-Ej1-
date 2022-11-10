/*1) Definir un arreglo de tipo STRING y del tamaño de los días semana. Se debe asignar los
correspondientes días para cada posición del arreglo. Luego utilizando un bucle FOR recorrer el
arreglo mostrando cada elemento del mismo por pantalla.*/

using System;

namespace TP8_EJ1
{
    class Program
    {
        const int cantidaddias=5;
        static void Main(string[] args)
        {

          
          string[] diasSemana= {"lunes", "martes", "miercoles", "jueves", "viernes"};
          for (int i=0;i < diasSemana.Length; i++ )
          {
          Console.WriteLine( "dia: " + (i+1) + "  "+ diasSemana[i]);
          }

        Console.WriteLine("presiones una tecla para terminar...");
        Console.ReadKey();







        }
    }
}

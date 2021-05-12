using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio1
            /* int [] array =new int[] { 45, 123, 1, 15, 20 };
             int[] final = new int[] { };
             Array.Sort(array);

             Console.Write(array[0] +"\t");
             Console.Write(array[array.Length-1]+ "\n");*/

            //ejercicio 2
            /* String[] cadenas = new string[] {"hola mundo","pepe pica papas","la luna es bonita"};
             Stack auxilair = new Stack();
             for (int i = 0; i < cadenas.Length; i++)
             {
                 char[] aux = cadenas[i].ToCharArray();
                 String cadena="";
                 for (int j = 0; j < cadenas[i].Length; j++)
                 {
                     cadena = "";
                     if (j==0)
                     {
                         aux[j] = Char.ToUpper(aux[j]);
                         cadena += aux[j];
                     }else if (aux[j]==' ')
                     {
                         aux[j] = Char.ToUpper(aux[j]);
                         cadena += aux[j];
                     }

                 }
                 auxilair.Push(cadena);
             }

             while (auxilair.Count!=0)
             {
                 Console.Write(auxilair.Pop().ToString());
             }

            int[,] nuevo = metodo(new int[,] { {1,2,3},
                                               {4,5,6},
                                               {7,8,9}});

            for (int x = 0; x < nuevo.GetLength(0); x++)
            {
                for (int y = 0; y < nuevo.GetLength(1); y++)
                {
                    Console.Write(nuevo[y,x]+"\t");
                }
                Console.WriteLine();
            }*/

            calcular(920);
        }

        static int [,] metodo (int[,] primero)
        {
            int[,] salida;
             
            salida=new int[primero.GetLength(0), primero.GetLength(1)];
            for (int i = primero.GetLength(0)-1; i >= 0; i--)
             {
                 for (int j = 0; j < primero.GetLength(1); j++)
                 {
                    salida[j, i] = primero[i, j];

                 }
               
             }
           
            return salida;
        }

        static void calcular(int dias)
        {
            int años = dias / 365;
            int meses = (dias - (años * 365)) / 30;
            int dia = (-1) * (dias - (365*años)*30)/1000;

            Console.WriteLine("el numero de años es: " + años + "\tel numero de meses:"+ meses + "\tel numero de dias es"+ dia);


        }
    }
}

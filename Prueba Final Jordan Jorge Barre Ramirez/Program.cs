using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//EDITADO PARA PRUEBAS

//LINEA AGREGADA PARA RAMA

namespace Prueba_Final_Jordan_Jorge_Barre_Ramirez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingreso de filas ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingreso de columnas");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[n, m];
            //arreglos
            Console.WriteLine("Ingreso de arreglos");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] arreglo = new int[k];
            Console.WriteLine("ingreso del segundo arreglo");
            int p = Convert.ToInt32(Console.ReadLine());
            int[] arreglo2 = new int[p];

            //for filas
            for (int f = 0; f < matriz.Length; f++)
            {
                for (int c = 0; c < matriz.Length; c++)
                {
                    //    Console.Write("Ingrese posicion [" + (f + 1) + "," + (c + 1) + "]: ");
                    //    string linea;
                    //    linea = Console.ReadLine();
                    //    matriz[f, c] = int.Parse(linea);
                }

                //imprimir 
                for (int x  = 0; x < matriz.Length; x++)
                {
                   
                    for (int y = 0; y < matriz.Length; y++)
                    {
                        Console.Write(matriz[x, y]);
                        Console.Write(" ");

                    }
                }


                //llenar arreglo 1
                int aux;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    for (int j = 0; j < arreglo.Length; j++)
                    {


                        aux = arreglo[j];
                    }
                    Console.WriteLine("" + arreglo[i]);
                }
                //llenar arreglo 2
                int aco;
                for (int i = 0; i < arreglo2.Length; i++)
                {
                    for (int j = 0; j < arreglo2.Length; j++)
                    {
                        aco = arreglo2[j];
                    }
                    Console.WriteLine("" + arreglo[i]);
                }
                //comparar 

                matriz[n, n] = arreglo[0];

                for (int i = 0; i < arreglo[k]; i++)

                {

                    if (arreglo[i] == matriz[n, n])

                    {

                        matriz[n, n] = arreglo[i];

                    }

                }




                Console.ReadKey();
            }
        }
    }
}
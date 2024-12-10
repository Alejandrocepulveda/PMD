using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int[,] datos=new int[10,10];
            
            Console.WriteLine("Ingrese la medida de la matriz");
            int n = int.Parse(Console.ReadLine());

            for (i = 0;i < n; i++)
            {
                for ( j = 0; j < n; j++)
                {
                   
                    Console.WriteLine("Ingrese el dato");

                    datos[i, j] = int.Parse(Console.ReadLine());
                   
                }
                
            }
            Console.ReadLine();
           
            //for (int i = 0; i < n; i++)
            //{
      
            //    for (int j = 0; j < n; j++)
            //    {
            //        int[,] Datos = new int[i, j];

            //        Console.WriteLine("Escriba el dato");
            //        //int valor= int.Parse(Console.ReadLine());
            //        Datos[i,j]=int.Parse(Console.ReadLine());

            //        Console.ReadLine();
                  
                  
                    
            //    }
                
            //}
        }
    }
}

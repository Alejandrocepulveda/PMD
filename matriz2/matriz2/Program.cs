using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            //Creacion de un metodo hash que no permite numeros duplicados 
            HashSet<int> numerosg = new HashSet<int>();
            Random valor = new Random();//definicon de una variable de tipo random para genenrar numeroa aleatorios
            int i;
            int j;
            int[,] datos=new int[10,10];
            
            Console.WriteLine("Ingrese la medida de la matriz");
            int n = int.Parse(Console.ReadLine());

            for (i = 0;i < n; i++)
            {
                for ( j = 0; j < n; j++)
                {

                    do
                    {
                        numero = valor.Next(1, 1000);//1000 por si la matriz mide mas de 3X3
                    } while (!numerosg.Add(numero));
                    datos[i, j] = numero;
                    //datos[i, j] = valor.Next(1, 9); sirve para generar valores aleatorios pero que se repiten

                    Console.WriteLine("el valor es " + datos[i, j].ToString());

                   
                }
                
            }
            Console.ReadLine();

        }
    }
}

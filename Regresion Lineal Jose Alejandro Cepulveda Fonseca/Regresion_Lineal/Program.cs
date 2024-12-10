using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Regresion_Lineal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ola
            int N;
            Console.WriteLine("Programa en base a la actividadn 1 de la unidad 5 de la materia Probabilidad y estadistica");
            Console.WriteLine("Ingrese el numero de datos a ingresar");
            N = int.Parse(Console.ReadLine());
            int[] VectorX = new int[N];
            int[] VectorY = new int[N];
            int[] Xcuadrada = new int[N];
            int[] Ycuadrada = new int[N];
            int[] XporY = new int[N];
            int Xnormal, Ynormal;
            string respuesta;

            for (int i = 0; i < N; i++)//Mientras I sea menor a N hara este y los demas ciclos for
            {
            

                Console.Write("Ingrese el valor de x en la posicion {0}:" ,i);
                Xnormal = int.Parse(Console.ReadLine());
                VectorX[i] = Xnormal;//el vector x en su posicion i vale x normal
                Console.Write("Ingrese el valor de y en la posicion {0}:" ,i);
                Ynormal = int.Parse(Console.ReadLine());
                VectorY[i] = Ynormal;
                Console.Clear();

            }

            for (int i = 0; i < N; i++)
            {
                
                Console.WriteLine("El valor de x en la posicion {0} es: {1}" , i , VectorX[i]);
                Console.WriteLine("El valor de y en la posicion {0} es: {1}" , i , VectorY[i]);
            }
            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < N; i++)
            {
                Xcuadrada[i] = VectorX[i] * VectorX[i];
                Console.WriteLine("El cuadro de x en su posicion {0} es: {1}", i, Xcuadrada[i]);
                Ycuadrada[i] = VectorY[i] * VectorY[i];
                Console.WriteLine("El cuadro de y en su posicion {0} es: {1}", i, Ycuadrada[i]);
               
            }

            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < N; i++)
            {
                XporY[i] = VectorX[i] * VectorY[i];
                Console.WriteLine("El valor X*Y es: {0}", XporY[i]);
            }
           
            int SumatoriaX = VectorX.Sum();//Metodo Para sumar los valores del vector ahorrando lineas de codigo creo
            int SumatoriaY = VectorY.Sum();
            int SumatoriaXcua = Xcuadrada.Sum();
            int SumatoriaYcua = Ycuadrada.Sum();//clauida apurate con la beca los de mercado libre vienen por mi
            int sumatoriaXy = XporY.Sum();
            Console.WriteLine("La Sumatoria de los valores de X es:{0}", SumatoriaX);
            Console.WriteLine("La Sumatoria de los valores de y es:{0}", SumatoriaY);//No va a haber ahorro de lienas me toco convertir todas la variables a double auxilio 
            Console.WriteLine("La Sumatoria de los valores de X cuadrada es:{0}", SumatoriaXcua);
            Console.WriteLine("La Sumatoria de los valores de y cuadrada es:{0}", SumatoriaYcua);
            Console.WriteLine("La Sumatoria de los valores de X por y es:{0}", sumatoriaXy);

            Console.ReadLine();
            Console.Clear();
  

            //Para este punto tenemos los datos ahora falta aplicar las formulas

            double sx = (double)SumatoriaX;//en teoria aqui lo convierte a double
            double sy = (double)SumatoriaY;
            double sxc = (double)SumatoriaXcua;
            double syc = (double)SumatoriaYcua;
            double sxy = (double)sumatoriaXy;
            double n = (double)N;

            //A partir de aqui seria un menu
            double r1 = (n * sxy) - (sx * sy);
            double r2 = ((n * sxc) - (sx * sx)) * (((n * syc) - (sy * sy)));
            double r3 = Math.Sqrt(r2);
            double R = r1 / r3;

            Console.WriteLine("El resultado de la primera formula es: {0}", R);

            double a1 = (sxc * sy) - (sx * sxy);
            double a2 = (n * sxc) - (sx * sx);
            double A = a1 / a2;
            Console.WriteLine("El resultado de la Segunda formula es: {0}", A);

            double b1 = (n * sxy) - (sx * sy);
            double b2=(n*sxc)-(sx * sx);
            double B = b1 / b2;
            Console.WriteLine("El resultado de la Tercera  formula es: {0}", B);

            iguana:
            Console.WriteLine("Ingrese el valor que quiere asignar a x basandose en los valores metidos anteriormente");
            double y1 = double.Parse(Console.ReadLine());
            double y = A + (B * y1);
            Console.WriteLine("El resultado de la Cuarta formula es: {0}", y);
            Console.WriteLine("Desea hacerlo de nuevo? (si/no)");
            respuesta = Console.ReadLine();
            if (respuesta.ToLower()=="si")
            {
                Console.Clear();
                goto iguana;
            }
            else
            {
                Console.WriteLine("Presiona una tecla para salir");
                Console.WriteLine("Desarrollado por Jose Alejandro Cepulveda Fonseca");
                Console.ReadKey();

            }

            Console.ReadLine();
        }
    }
}

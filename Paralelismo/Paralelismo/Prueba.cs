using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralelismo
{
    class Prueba
    {
        static string line;
        static string ced;
        static string cliente;
        static string[] cedulas = new string[10];
        static string[] arr;
        static int[] comprasTot = new int[10];
        static int mayorC = 0;

        // Read the file and display it line by line.
        static System.IO.StreamReader file =
            new System.IO.StreamReader(@"C:\Users\Steven\Desktop\TEC\Progras\Progra-paralelismo-Arqui\Paralelismo\Paralelismo\Archivos\compras.txt");
        static System.IO.StreamReader file2 =
            new System.IO.StreamReader(@"C:\Users\Steven\Desktop\TEC\Progras\Progra-paralelismo-Arqui\Paralelismo\Paralelismo\Archivos\clientes.txt");
        static System.IO.StreamReader file3 =
            new System.IO.StreamReader(@"C:\Users\Steven\Desktop\TEC\Progras\Progra-paralelismo-Arqui\Paralelismo\Paralelismo\Archivos\perfiles.txt");

        public static void Buscar1() {
            var tiempo = System.Diagnostics.Stopwatch.StartNew();
            while ((line = file.ReadLine()) != null)
            {
                arr = line.Split(',');
                if (mayorC < Int32.Parse(arr[5]))
                {
                    mayorC = Int32.Parse(arr[5]);
                    ced = arr[1];
                }
                else
                    continue;
            }

                file.Close();
            System.Console.WriteLine(ced);

            while ((line = file2.ReadLine()) != null)
            {
                arr = line.Split(',');
                if (ced == " " + arr[0])
                {
                    cliente = arr[1] + arr[2] + arr[3];
                    break;
                }
                else
                    continue;
            }
            file2.Close();
            tiempo.Stop();
            TimeSpan timeSpan = tiempo.Elapsed;
            //esto se tiene que mostrar en ventana, supongo?
            Console.WriteLine("Tiempo Total: {0}h {1}m {2}s {3}ms", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
            //esto hay que cambiarlo para mostrarlo en la ventana...
            System.Console.WriteLine("La mayor compra fue de:");
            System.Console.WriteLine(mayorC);
            System.Console.WriteLine("De el/la cliente:");
            System.Console.WriteLine(cliente);
        }

        public static void BuscarCompras()
        {
            var tiempo = System.Diagnostics.Stopwatch.StartNew();
            //hay que hacer la vara del textfield que reciba el array de cedulas...
            //mientras tanto...
            cedulas[0] = "240642622";
            cedulas[1] = "224808034";
            comprasTot[0] = 0;
            comprasTot[1] = 0;
            while ((line = file.ReadLine()) != null)
            {
                arr = line.Split(',');
                System.Console.WriteLine("Hi!");
                for (int i = 0; i < cedulas.Length; i++)
                {
                    if (" " + cedulas[i] == arr[1])
                    {
                        comprasTot[i]++;
                        break;
                    }
                    else
                        continue;
                }
            }

            file.Close();
            tiempo.Stop();
            TimeSpan timeSpan = tiempo.Elapsed;
            //esto se tiene que mostrar en ventana, supongo?
            Console.WriteLine("Tiempo Total: {0}h {1}m {2}s {3}ms", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
            //se tiene que hacer que esto se muestre en la ventana con un for en ambos arrays...
            System.Console.WriteLine("Cliente:");
            System.Console.WriteLine(cedulas[0]);
            System.Console.WriteLine("El total de compras fue de:");
            System.Console.WriteLine(comprasTot[0]);
            System.Console.WriteLine("Cliente:");
            System.Console.WriteLine(cedulas[1]);
            System.Console.WriteLine("El total de compras fue de:");
            System.Console.WriteLine(comprasTot[1]);
        }

        public static void BuscarSospechosos()
        {

        }
    }
}

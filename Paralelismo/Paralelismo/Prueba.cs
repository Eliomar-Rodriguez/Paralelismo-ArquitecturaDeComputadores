using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Paralelismo
{
    class Prueba
    {
        static string line;
        public static DateTime inicio;
        public static DateTime final;
        static string ced;
        static string cliente;
        static string[] cedulas = new string[10];
        static string[] arr;
        static int[] comprasTot = new int[10];
        static int mayorC = 0;

        // Read the file and display it line by line.
        /*static System.IO.StreamReader file =
            new System.IO.StreamReader(@"C:\Users\Steven\Desktop\TEC\Progras\Progra-paralelismo-Arqui\Paralelismo\Paralelismo\Archivos\compras.txt");
        static System.IO.StreamReader file2 =
            new System.IO.StreamReader(@"C:\Users\Steven\Desktop\TEC\Progras\Progra-paralelismo-Arqui\Paralelismo\Paralelismo\Archivos\clientes.txt");
        static System.IO.StreamReader file3 =
            new System.IO.StreamReader(@"C:\Users\Steven\Desktop\TEC\Progras\Progra-paralelismo-Arqui\Paralelismo\Paralelismo\Archivos\perfiles.txt");
            */
        public static void Buscar1() {
            /*Form1.comprasTemp = Form1.compras;
            Form1.clientesTemp = Form1.clientes;*/
            var tiempo = System.Diagnostics.Stopwatch.StartNew();
            while ((line = Form1.compras.ReadLine()) != null)
            {
                arr = line.Split(',');
                if ((Convert.ToDateTime(arr[6]) >= inicio) && (Convert.ToDateTime(arr[6]) <= final))
                {
                    if (mayorC < Int32.Parse(arr[5]))
                    {
                        mayorC = Int32.Parse(arr[5]);
                        ced = arr[1];
                    }
                    else
                        continue;
                }
            }

                Form1.compras.Close();
            System.Console.WriteLine(ced);

            while ((line = Form1.clientes.ReadLine()) != null)
            {
                arr = line.Split(',');
                if (ced == " " + arr[0])
                {
                    ced = arr[0];
                    cliente = arr[1] + arr[2] + arr[3];
                    break;
                }
                else
                    continue;
            }
            Form1.clientes.Close();
            tiempo.Stop();
            TimeSpan timeSpan = tiempo.Elapsed;
            //esto se tiene que mostrar en ventana, supongo?
            Console.WriteLine("Tiempo Total: {0}h {1}m {2}s {3}ms", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
            //esto hay que cambiarlo para mostrarlo en la ventana...
            System.Console.WriteLine("La mayor compra fue de:");
            System.Console.WriteLine(mayorC);
            System.Console.WriteLine("De el/la cliente:");
            System.Console.WriteLine(cliente);
            System.Console.WriteLine("Cedula:");
            System.Console.WriteLine(ced);
        }

        public static void BuscarCompras()
        {
            var tiempo = System.Diagnostics.Stopwatch.StartNew();
            //tengo que hacer un indice...
            //hay que hacer la vara del textfield que reciba el array de cedulas...
            //mientras tanto...
            cedulas[0] = "240642622";
            cedulas[1] = "224808034";
            comprasTot[0] = 0;
            comprasTot[1] = 0;
            while ((line = Form1.compras.ReadLine()) != null)
            {
                arr = line.Split(',');
                if ((Convert.ToDateTime(arr[6]) >= inicio) && (Convert.ToDateTime(arr[6]) <= final))
                {
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
                
            }

            Form1.compras.Close();
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
            var tiempo = System.Diagnostics.Stopwatch.StartNew();
            //se tiene que recibir de un textfield de la ventana...
            ced = "224808034";
            string perfil = "";
            double limitBreak = 0;
            while ((line = Form1.compras.ReadLine()) != null)
            {
                arr = line.Split(',');
                if (ced == arr[0])
                {
                    perfil = arr[6];
                    break;
                }
                else
                    continue;
            }
            Form1.compras.Close();

            while ((line = Form1.perfiles.ReadLine()) != null)
            {
                arr = line.Split(',');
                System.Console.WriteLine(arr[0]);
                System.Console.WriteLine(perfil);
                if (perfil == " " + arr[0])
                {
                    limitBreak = Convert.ToDouble(arr[2]);
                    break;
                }
                else
                    continue;
            }
            Form1.perfiles.Close();

            while ((line = Form1.compras.ReadLine()) != null)
            {
                arr = line.Split(',');
                System.Console.WriteLine(limitBreak);
                if (" " + ced == arr[1])
                {
                    if (Int32.Parse(arr[5]) > limitBreak)
                    {
                        System.Console.WriteLine("Jojo, parece que aqui huele a chorizo!!");
                        break;
                    }
                    else
                        System.Console.WriteLine("Por el momento, todo esta limpio, como mi conciencia... XD");
                }
                else
                    continue;
            }
            Form1.compras.Close();
            tiempo.Stop();
            TimeSpan timeSpan = tiempo.Elapsed;
            //esto se tiene que mostrar en ventana, supongo?
            Console.WriteLine("Tiempo Total: {0}h {1}m {2}s {3}ms", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
            System.Console.WriteLine("Cedula: ");
            System.Console.WriteLine(ced);
            System.Console.WriteLine("Limite: ");
            System.Console.WriteLine(limitBreak);
            System.Console.WriteLine("Compra:");
            System.Console.WriteLine(arr[5]);
        }
    }
}

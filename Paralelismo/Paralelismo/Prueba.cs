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
        public static string ced;
        public static string cliente;
        public static string[] cedulas = new string[10];
        static string[] arr;
        public static string[] nombres = new string[10];
        public static int[] comprasTot = new int[10];
        public static int mayorC = 0;
        public static string tiempoTot;
        public static int ind;
        public static double limitBreak;

        public static void Buscar1() {
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

            while ((line = Form1.clientes.ReadLine()) != null)
            {
                arr = line.Split(',');
                if (ced == arr[0])
                {
                    ced = arr[0];
                    cliente = arr[1] + " " + arr[2] + " " + arr[3];
                    break;
                }
                else
                    continue;
            }
            Form1.clientes.Close();
            tiempo.Stop();
            TimeSpan timeSpan = tiempo.Elapsed;
            tiempoTot = timeSpan.Hours.ToString()+ "h, " + timeSpan.Minutes.ToString() + "m, " + timeSpan.Seconds.ToString() + "s, " + timeSpan.Milliseconds.ToString() + "ms";
        }

        public static void BuscarCompras()
        {
            var tiempo = System.Diagnostics.Stopwatch.StartNew();
            while ((line = Form1.compras.ReadLine()) != null)
            {
                arr = line.Split(',');
                if ((Convert.ToDateTime(arr[6]) >= inicio) && (Convert.ToDateTime(arr[6]) <= final))
                {
                    for (int i = 0; i < cedulas.Length; i++)
                    {
                        if (cedulas[i] == arr[1])
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

            while ((line = Form1.clientes.ReadLine()) != null)
            {
                arr = line.Split(',');
                for (int i = 0; i < nombres.Length; i++)
                {
                    if (cedulas[i] == arr[0])
                    {
                        nombres[i] = arr[1] + " " + arr[2] + " " + arr[3];
                        break;
                    }
                    else
                        continue;
                }
            }
            Form1.clientes.Close();

            tiempo.Stop();
            TimeSpan timeSpan = tiempo.Elapsed;
            tiempoTot = timeSpan.Hours.ToString() + "h, " + timeSpan.Minutes.ToString() + "m, " + timeSpan.Seconds.ToString() + "s, " + timeSpan.Milliseconds.ToString() + "ms";
        }

        public static void BuscarSospechosos()
        {
            var tiempo = System.Diagnostics.Stopwatch.StartNew();
            string perfil = "";
            limitBreak = 0;
            while ((line = Form1.clientes.ReadLine()) != null)
            {
                arr = line.Split(',');
                if (ced == arr[0])
                {
                    cliente = arr[1] + " " + arr[2] + " " + arr[3];
                    perfil = arr[6];
                    break;
                }
                else
                    continue;
            }
            Form1.clientes.Close();

            while ((line = Form1.perfiles.ReadLine()) != null)
            {
                arr = line.Split(',');
                if (perfil == arr[0])
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
                if (ced == arr[1])
                {
                    if (Int32.Parse(arr[5]) > limitBreak * 1.2)
                    {
                        mayorC = Int32.Parse(arr[5]);
                        Form1.chorizo = true;
                        break;
                    }
                    else
                    {
                        if (mayorC < Int32.Parse(arr[5]))
                           mayorC = Int32.Parse(arr[5]);
                        System.Console.WriteLine("Por el momento, todo esta limpio, como mi conciencia... XD");
                    }
                }
                else
                    continue;
            }
            Form1.compras.Close();


            tiempo.Stop();
            TimeSpan timeSpan = tiempo.Elapsed;
            tiempoTot = timeSpan.Hours.ToString() + "h, " + timeSpan.Minutes.ToString() + "m, " + timeSpan.Seconds.ToString() + "s, " + timeSpan.Milliseconds.ToString() + "ms";
        }
    }
}

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
        static string[] arr;
        static int mayorC = 0;

        // Read the file and display it line by line.
        static System.IO.StreamReader file =
            new System.IO.StreamReader(@"C:\Users\Steven\Desktop\TEC\Progras\Progra-paralelismo-Arqui\Paralelismo\Paralelismo\Archivos\compras.txt");
        static System.IO.StreamReader file2 =
            new System.IO.StreamReader(@"C:\Users\Steven\Desktop\TEC\Progras\Progra-paralelismo-Arqui\Paralelismo\Paralelismo\Archivos\clientes.txt");
        public static void Buscar1() {
            while((line = file.ReadLine()) != null)
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
            System.Console.WriteLine("La mayor compra fue de:");
            System.Console.WriteLine(mayorC);
            System.Console.WriteLine("De el/la cliente:");
            System.Console.WriteLine(cliente);
        }
    }
}

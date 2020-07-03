using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            char menu = 'n';

            double n1 = 0;

            double n2 = 0;



            while (menu != 's')

            {
                Console.WriteLine("1.-suma");
                Console.WriteLine("2.-resta");
                Console.WriteLine("3.-multiplicación");
                Console.WriteLine("4.-división");
                Console.WriteLine("5.-salir");
                Console.WriteLine("opción: ");

                op = int.Parse(Console.ReadLine());


                try

                {
                    Console.Write("ingrese el primer valor  : ");
                    n1 = int.Parse(Console.ReadLine());
                }

                catch

                {
                    Console.WriteLine("dato no valido ");
                    Console.Write("ingrese el primer valor");
                    n1 = int.Parse(Console.ReadLine());
                }

                try

                {

                    Console.Write("ingrese el segundo valor ");

                    n2 = int.Parse(Console.ReadLine());

                }

                catch

                {
                    Console.WriteLine("dato no valido");
                    Console.Write("ingrese el segundo valor ");
                    n2 = int.Parse(Console.ReadLine());
                }

                if (op == 1)

                {
                    Console.WriteLine("El resultado es: " + (n1 + n2));
                }

                else if (op == 2)

                {
                    Console.WriteLine("El resultado es: " + (n1 - n2));
                }

                else if (op == 3)

                {
                    Console.WriteLine("El resultado es: " + (n1 * n2));
                }

                else if (op == 4)

                {
                    Console.WriteLine("El resultado es: " + (n1 / n2));
                }


                else if (op == 5)

                {
                    Console.WriteLine("desea salir [s/n] ");
                    menu = char.Parse(Console.ReadLine());

                    Console.ReadKey();
                }

            }
         }

     }
       
}

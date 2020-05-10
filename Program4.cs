using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int x = 1;
          
           while (x <= 100)
            {
                Console.WriteLine(x);
                x += 3;
            }
            Console.ReadKey();
        }

    */
            /*
                    int x = 0;
                    int i;

                    Console.WriteLine("Podaj liczbe: ");

                    do
                    {
                        i = Convert.ToInt32(Console.ReadLine());
                        x = x + i;
                    } while (i != 0);

                    Console.WriteLine(x);
                    Console.ReadKey();
                }
                */

            /*
                        int x = 1;
                        int i = 1;

                        Console.WriteLine("Podaj liczbe: ");
                        x = Convert.ToInt32(Console.ReadLine());

                        while (x != 0)
                        {
                            i *= x;
                            x--;

                        } 

                        Console.WriteLine(i);
                        Console.ReadKey();

                */

            string [] tablica = new string[4];

            tablica[0] = "w1";
            tablica[1] = "w2";
            tablica[2] = "w3";

            Console.ReadKey();
        }
    }
}



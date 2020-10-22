using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStep221
{
    class Class1
    {
        public Class1()
        {
            Console.WriteLine("Class1 has been instantiated.");
            Console.ReadLine();
        }



        public void TakesTwoInt(int a, int b)
        {
            A = a;
            B = b;

            if ((a * 2 / 2) == a)
            {
                Console.WriteLine(b);
                
            }
            else
            {
                Console.WriteLine("Have a Great Day!");
            }

            Console.ReadLine();
        }
        public int A { get; set; }
           public int B { get; set; }
        }
    }


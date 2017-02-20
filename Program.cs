using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ism
{
    class Program
    {
        static void Main()
        {
            int a, b;
            Proba p;
            Console.Write("Kerek egy egesz szamot:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kerek egy egesz szamot:");
            b = Convert.ToInt32(Console.ReadLine());
            
            p = new Proba();

            p.X = a;
            p.Y = b;
            Console.WriteLine("{0}+{1}={2}",p.X, p.Y, p.Osszead());
 
            Console.ReadKey();
            
        }
    }
}

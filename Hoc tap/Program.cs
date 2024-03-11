using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoc_tap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so thang = ");
            int a = int.Parse(Console.ReadLine());
            /*if(a%2==0) Console.WriteLine("Day la so chan");

            else Console.WriteLine("Day la so le");
            

            Console.ReadKey();*/

            for (int i = 0; i < 10; i++) {
                if (i % 2 != 0)
                {
                    continue;
                }            
                else
                {
                    Console.WriteLine(i);
                }
            }
            //Console.WriteLine(a%2==0? "so chan" : "So le");
            Console.ReadKey();
        }
    }
}

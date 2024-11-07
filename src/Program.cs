using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" To'rt xonali son kiriting:");
            var tortxona=Convert.ToInt32(Console.ReadLine());
            int r1 = tortxona % 10;
            int r2=tortxona / 10%10;
            int r3=tortxona / 100%10;
            int r4=tortxona / 1000%10;
            Console.WriteLine(r1+r2+r3+r4);
            Console.ReadLine();

        }
    }
}

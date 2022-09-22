using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program2
    {
        public static void Main() 
        {
            Console.Write("섭씨 온도 입력 : ");
            double C = Double.Parse(Console.ReadLine());
            double F = 9 / 5 * C + 32;
            Console.WriteLine("화씨 온도는 {0:F} 입니다.", F);
        }
    }
}

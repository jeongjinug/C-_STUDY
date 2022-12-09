using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("세 변의 길이를 입력하세요.");
            Console.Write("1번째 길이 : "); 
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("2번째 길이 : ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.Write("3번째 길이 : ");
            int num3 = Int32.Parse(Console.ReadLine());
            num3 = Int32.Parse(Console.ReadLine());

            int l = num1 + num2 + num3;

            double s = Math.Sqrt(l * (l - num1) * (l - num2) * (l - num3));
            Console.WriteLine("삼각형의 넓이는 {0:F} 입니다.", s);
        }
    }
}

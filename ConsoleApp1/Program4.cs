using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program4
    {
        public static void Main()
        {
            Console.WriteLine("정수들을 입력하세요.");
            string num = Console.ReadLine();
            string[] nums = num.Split(' ');

            int MAX = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                int number = int.Parse(nums[i]);
                if(number > MAX)
                    MAX = number;
            }

            Console.WriteLine("가장 큰 수는 " + MAX + " 입니다.");
            Console.WriteLine("가장 큰 수는 " + MAX + " 입니다.");
        }
    }
}

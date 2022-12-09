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
            // 3차배열 선언
            string[,,] arr = new string[,,] {
            { {"1", "2"}, {"11","22"} },
            { {"3", "4"}, {"33", "44"} }
    };

            //for 루프 : 3번 루프를 만들어 돌림
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Debug.WriteLine(arr[i, j, k]);
                    }
                }
            }

            //foreach 루프 : 한번에 3차배열 모두 처리
            foreach (var s in arr)
            {
                Debug.WriteLine(s);
            }
        }
    }
}

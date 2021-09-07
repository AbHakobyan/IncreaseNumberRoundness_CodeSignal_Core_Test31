using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreaseNumberRoundness_CodeSignal_Core_Test31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(increaseNumberRoundness(input));
        }

        static bool increaseNumberRoundness(int n)
        {
            int count = 0;
            List<int> list = new List<int>();
            while (n > 0)
            {
                list.Add(n % 10);
                n = n / 10;
            }
            list.Reverse();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == 0 && list[i + 1] != 0)
                {
                    int temp = list[i + 1];
                    list[i + 1] = list[i];
                    list[i] = temp;
                    count++;
                }
            }
            if (count > 0)
            {
                return true;
            }
            return false;
        }
    }
}

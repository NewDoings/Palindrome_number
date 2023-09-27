using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalendrome(-1221));
            Console.ReadKey();
        }
        public static bool IsPalendrome(int x)
        {
            bool palendrome = true;
            //string array_x = x.ToString(); Можно создать одельную переменную для меньших датрат памяти, но будет выше рантайм
            for (int i = 0; i < x.ToString().Length/2; i++)
            {
                if (x.ToString()[i] != x.ToString()[x.ToString().Length - 1 - i])
                {
                    palendrome = false; 
                    break;
                }
            }
            return palendrome;
        }
    }
}

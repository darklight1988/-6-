using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6._2
{
    internal class Program// Программа определения является ли ввведенноя старока палиндромом.
    {
        static bool IsPalindrome(string str)
        {
            return str == new string(str.Reverse().ToArray());
        }

        static void Main()
        {
            const string f = "result.txt";
            Console.Write("Введи строку: ");
            string str = Console.ReadLine();
            var result = IsPalindrome(str);
            var message = "Строка '" + str + "' является палиндромом: " + result;

            Console.WriteLine(message);
            File.WriteAllText(f, message);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_строки
{
    internal class Program // Программа ввода строки и определения самого длинного слова.
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            string wordWithMaxLength = string.Empty;
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > wordWithMaxLength.Length)
                    wordWithMaxLength = words[i];
            Console.Write("Самое длинное слово: ");
            Console.WriteLine(wordWithMaxLength);
            Console.ReadKey();
        }
    } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24
{ 
    class Program
    {
        static void Main (string[] args)
        {
            //Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.

            ValueTuple<int, string, char, string, ulong> kortege = (22, "Xenia", '!', "cat", 569);

            //Выведите кортеж на консоль целиком и выборочно ( например 1, 3, 4 элементы)

            Console.WriteLine("Кортеж:");
            Console.WriteLine(kortege);
            Console.WriteLine("1,3,4 элементы:");
            Console.WriteLine(kortege.Item1 + " " + kortege.Item3 + " " + kortege.Item4);

            //Выполните распаковку кортежа в переменные.

            (int one, string two, char three) = (90, "dog", 'o');
            Console.WriteLine($"unpackage {one} {two} {three}");

            //Сравните два кортежа.

            Console.WriteLine((3, 9).CompareTo((9, 3)));//-1
            Console.WriteLine((3, 9).CompareTo((3, 9)));//0
            Console.WriteLine((9, 3).CompareTo((3, 9)));//1
        }
    }
}
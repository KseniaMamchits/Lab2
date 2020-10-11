using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создайте локальную функцию в main и вызовите ее. Формальные
          параметры функции – массив целых и строка. Функция должна вернуть
          кортеж, содержащий: максимальный и минимальный элементы массива,
          сумму элементов массива и первую букву строки.*/
            string word = "Hello";
            int[] array = new int[4] { 144, 322, 891, 767 };

            var result = GetResult(array, word);
            Console.WriteLine(result);
            Console.Read();
        }

        private static (int, int, int, string) GetResult(int[] array, string word)
        {
            int S = 0;
            int max = 0;
            int min = 1000;
            for (int i = 0; i < 4; i++)
            {
               S = S + array[i];
            }
            for (int i = 0; i < 4; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            string newword = word.Remove(1, 4);
            var result = (max, min, S, newword);
            return result;
        }
    }

}
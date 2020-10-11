using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица). 

            Console.WriteLine("Введите размер массива");
            int n = Int32.Parse(Console.ReadLine());//ввод строк
            int m = Int32.Parse(Console.ReadLine());//ввод столбцов

            int[,] massive = new int[n, m];//создание массива

            Random ran = new Random();//использование рандомных чисел

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    massive[i, j] = ran.Next(1, 100);//заполняем массив числами, к-е варьируются от 1 до 100
                    Console.Write("{0}\t", massive[i, j]);//вывод через табуляцию
                }
                Console.WriteLine();
            }

            /*Создайте одномерный массив строк. Выведите на консоль его
            содержимое, длину массива. Поменяйте произвольный элемент
            (пользователь определяет позицию и значение).*/

            string word = "cat";
            string[] array = new[] { "dog", "fish", "spring", "bird" };
            Console.WriteLine("Элементы массива:");
            foreach (string i in array)
            {

                Console.WriteLine(i);
            }
            Console.WriteLine("Длина массива: " + array.Length);
            array[2] = word;
            foreach (string i in array)
            {

                Console.WriteLine(i);
            }

            /*Создайте ступечатый (не выровненный) массив вещественных
            чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов
            соответственно.Значения массива введите с консоли.*/

            double[][] mass = new double[3][];
            mass[0] = new double[2];
            mass[1] = new double[3];
            mass[2] = new double[4];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Введите элемент");
                int element = Int32.Parse(Console.ReadLine());
                mass[0][i] = element;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите элемент");
                int element = Int32.Parse(Console.ReadLine());
                mass[1][i] = element;
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите элемент");
                int element = Int32.Parse(Console.ReadLine());
                mass[2][i] = element;
            }
            for (int i = 0; i < 2; i++)
                Console.Write(mass[0][i] + " ");
                Console.WriteLine();
            for (int i = 0; i < 3; i++)
                Console.Write(mass[1][i] + " ");
                Console.WriteLine();
            for (int i = 0; i < 4; i++)
                Console.Write(mass[2][i] + " ");
                Console.WriteLine();

            //Создайте неявно типизированные переменные для хранения массива и строки.

            var massivchic = new[] { 4, 24, 35 };
            Console.WriteLine("Тип массива - {0}", massivchic.GetType());
            var masic = new[] { "cat", "fish", "bird" };
            Console.WriteLine("Тип массива - {0}", masic.GetType());
        }
    }
}
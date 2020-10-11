using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявите строковые литералы. Сравните их.

            string first_string = "Ksenia";
            string second_string = "Mamchits";
            string string_first = "Ksenia";
            Console.WriteLine(string.Compare(first_string, string_first));//0
            Console.WriteLine(string.Compare(first_string, second_string));//-1
            Console.WriteLine(string.Compare(second_string, string_first));//1

            /*Создайте три строки на основе String. 
             Выполните: сцепление, копирование, выделение подстроки, разделение строки на слова, 
             вставки подстроки в заданную позицию, удаление заданной подстроки.*/

            String S1 = "Ты любила ";
            String S2 = "бросаться в глаза";
            Console.WriteLine(String.Concat(S1, S2));//сцепление строк
            String S3 = String.Copy(S1);//копирование строки
            Console.WriteLine(S3);
            Console.WriteLine(S1.Substring(3,6));//выделение подстроки
            const string Text = "Это куча каких-то слов";//разделение строки на слова
            string[] words = Text.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(S2.Insert(11," мои" ));//вставка подстроки в заданную позицию
            Console.WriteLine(S2.Remove(0, 10));//удаление заданной подстроки

            //Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками.

            string sn = null;
            string s = "";
            Console.WriteLine(String.IsNullOrEmpty(sn));//возвращает true если пустая или null
            Console.WriteLine(String.IsNullOrWhiteSpace(s));//проверяет еще и пробел

            //Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.

            StringBuilder ns = new StringBuilder("Ах, как много на свете кошек");
            Console.WriteLine(ns.Remove(4, 4));//удаление
            Console.WriteLine(ns.Insert(0, "ААА"));//добавить в начало
            Console.WriteLine(ns.AppendFormat(" и собак"));//добавить в конце
        }
    }
}
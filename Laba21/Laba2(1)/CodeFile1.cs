using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace second_laboratory1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определите переменные всех возможных примитивных типов С# и проинициализируйте их. 

            sbyte SB = 12; //целое число от -128 до 127 ( 1 байт)
            short SH = 30000; //целое число от -32768 до 32767 (2 байта)
            int IN = 34; //целое число от -2147483648 до 2147483647 (4 байта)
            long LO = 906784; //целое число от -9223372036854775808 до 9223372036854775807 (8 байт)
            byte BY = 14; //целое число от 0 до 255 (1 байт)
            ushort US = 676; //целое число от 0 до 65535 (2 байта)
            uint UI = 879695959; //целое число от 0 до 4294967295 (4 байта)
            ulong UL = 1456789; //целое число от 0 до 18446744073709551615 (8 байт)
            char CH = 'A'; //одиночный символ в кодировке Unicode (2 байта)
            bool BO = false; //логические литералы (1 байт)
            float FL = 1.7F; //число с плавающей точкой от -3.4*10^38 до 3.4*10^38 (4 байта)
            double DO = 3.147; //число с плавающей точкой от +(-)5*10^-324 до +(-)1.7*10^308 (8 байт)
            decimal De = 78.9089m; //десятичное дробное число (16 байт)
            string ST = "Hello, World"; //набор символов Unicode
            object OB = "Hi"; //значение любого типа данных

            //Выполните 5 операций явного и 5 неявного приведения.

            //Явные преобразования
            float k = (float)IN;
            sbyte s = (sbyte)IN;
            long e = (long)IN;
            short n = (short)IN;
            double ia = (double)IN;

            //Неявные преобразования
            int old = 3;
            Int64 g = old;
            Single r = old;
            Object h = old;
            float w = old;
            double q = old;

            //Выполните упаковку и распаковку значимых типов.

            int xen = 404;
            Object X = xen;//упаковка xen
            byte xe = (byte)(int)xen;//распаковка xen

            //Продемонстрируйте работу с неявно типизированной переменной.

            var mark = 8;
            var name = "Ivanov";
            Type marktype = mark.GetType();
            Type nametype = name.GetType();
            Console.WriteLine("Type name: {0}", nametype);
            Console.WriteLine("Type mark: {0}", marktype);

            //Продемонстрируйте пример работы с Nullable переменной.

            Nullable<int> piece = 9;
            Console.WriteLine(piece.Value);
        }
    }
}
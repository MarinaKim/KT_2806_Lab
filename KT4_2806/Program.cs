using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4_2806
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
        }

        static void task1()
        {
            /*Даны два целых положительных числа произвольной длины (стоящие из любого количества цифр).
Например,:
123456788901234567889012345678890123
4567889012345678890123456788901234567 
8890123456788901234567889012345678890
Вывести сумму этих чисел. В решении нельзя использовать BigInteger, Integer. Ввод чисел через standard input. 
Примеры 
Входные данные
111 
123
Выходные данные
234
*/


            Console.Write("Введите число ch1: ");
            ulong ch1 = 0,ch2=0;
            if (!UInt64.TryParse(Console.ReadLine(), out ch1))
                Console.WriteLine("Слишком большое число: ");

            Console.Write("Введите число ch2: ");
            if (!UInt64.TryParse(Console.ReadLine(), out ch2))
                Console.WriteLine("Слишком большое число: ");

            Console.WriteLine("Cумма: {0}", ch1 + ch2);
        }

        static void task2()
        {
            /*Задача 2.
Дано целое положительное число, не превышающее Integer. Посчитать сумму всех его цифр
В решении нельзя использовать цикл и работу со строками. Ввод чисел через standard input. 
Примеры 
Входные данные 
123
Выходные данные 
6
*/
            Console.Write("Введите число ch2: ");
            string ch = Console.ReadLine();
            var chAr = ch.ToArray();
            Console.WriteLine("Sum: {0}",int32chAr.Sum());





        }
    }
}

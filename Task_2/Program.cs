using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введите значение n - количестов элементов массива:");
            int n;

            if (int.TryParse(Console.ReadLine(), out n))
            {

            }

            else
            {
                Console.WriteLine("Неверное значение n!");
            }

            double[] arr = new double[n];
            string[] str = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                if (double.TryParse(str[i], out arr[i]))
                {

                }
                else
                {
                    Console.WriteLine("Неверное значение!");
                    break;
                }
            }

            MyArray solver = new MyArray();

            double productTask1 = solver.Task1(arr);
            Console.WriteLine($"Произведение элементов массива, которые расположены после наименьшего элемента: {productTask1}");

            double sumTask2 = solver.Task2(arr);
            Console.WriteLine($"Сума элементов массива, которые расположены между первым отрицательным и вторым положительным элементов: {sumTask2}");

            double sumTask3 = solver.Task3(arr);
            Console.WriteLine($"Сума элементов массива, которые расположены между первым и вторым нулевыми элементами: {sumTask3}");

            double productTask4 = solver.Task4(arr);
            Console.WriteLine($"Произведение элементов массива, которые расположены между наибольшим и наименьшим по модулую элементами: {productTask4}");

        }
    }
}

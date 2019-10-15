using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace Task_1
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
                arr[i] = double.Parse(str[i]);
            }

            MyArray solver = new MyArray();

            double sumOfNegatives = solver.SumOfNegatives(arr);
            Console.WriteLine($"Сума отрицательных элементов массива: {sumOfNegatives}");

            double maxNumber = solver.MaxNumber(arr);
            Console.WriteLine($"Наибольшее число массива: {maxNumber}");

            int maxNumberIndex = solver.MaxNumberIndex(arr);
            Console.WriteLine($"Индекс наибольшего числа: {maxNumberIndex}");

            double maxNumberAbs = solver.MaxNumberAbs(arr);
            Console.WriteLine($"Наибольший по модулю элемент массива: {maxNumberAbs}");

            double sumOfIndexes = solver.SumOfIndexes(arr);
            Console.WriteLine($"Сума индексов позитивных элементов массива: {sumOfIndexes}");

            double numberOfIntegers = solver.NumberOfIntegers(arr);
            Console.WriteLine($"Количество целых элементов массива: {numberOfIntegers}");

        }
    }
}

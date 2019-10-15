using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class MyArray
    {

        public double SumOfNegatives(double[] arr)
        {
            double sumOfNegatives = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    sumOfNegatives += 0;
                }
            }

            return sumOfNegatives;
        }

        public double MaxNumber(double[] arr)
        {
            double maxNumber = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxNumber)
                {
                    maxNumber = arr[i];
                }
            }

            return maxNumber;
        }

        public int MaxNumberIndex(double[] arr)
        {
            double maxNumber = arr[0];
            int maxNumberIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxNumber)
                {
                    maxNumber = arr[i];
                    maxNumberIndex = i;
                }
            }

            return maxNumberIndex;
        }

        public double MaxNumberAbs(double[] arr)
        {
            double maxNumberAbs = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > maxNumberAbs)
                {
                    maxNumberAbs = Math.Abs(arr[i]);
                }
            }

            return maxNumberAbs;
        }

        public int SumOfIndexes(double[] arr)
        {
            int sumOfIndexes = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sumOfIndexes += i;
                }
            }

            return sumOfIndexes;
        }

        public int NumberOfIntegers(double[] arr)
        {
            int numberOfIntegers = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (int.TryParse(arr[i].ToString(), out i))
                {
                    numberOfIntegers++;
                }
            }

            return numberOfIntegers;
        }

        public double Task1(double[] arr)
        {
            double minNumber = arr[0];
            int indexOfMin = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minNumber)
                {
                    minNumber = arr[i];
                    indexOfMin = i;
                }
            }

            double productTask1 = 1;

            for (int i = indexOfMin + 1; i < arr.Length; i++)
            {
                productTask1 *= arr[i];
            }

            return productTask1;
        }

        public double Task2(double[] arr)
        {
            int indexOfNegative = 0;
            int indexOfPositive = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    indexOfNegative = 0;
                    break;
                }

                if (arr[i] > 0)
                {
                    count++;
                    if(count == 2)
                    {
                        indexOfPositive = i;
                        break;
                    }
                }

            }

            double sumTask2 = 0;
            for(int i = Math.Min(indexOfNegative, indexOfPositive)+1; i <Math.Max(indexOfNegative, indexOfPositive); i++)
            {
                sumTask2 += arr[i];
            }

            return sumTask2;
        }

        public double Task3(double[] arr)
        {
            int firstZeroIndex = -1;
            int secondZeroIndex = -1;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    count++;

                    if (count == 1)
                    {
                        firstZeroIndex = i;
                    }
                    else if(count == 2)
                    {
                        secondZeroIndex = i;
                        break;
                    }
                }
            }

            if(firstZeroIndex!= -1 && secondZeroIndex != -1)
            {

            }

            double sumTask3 = 0;
            for (int i =firstZeroIndex; i <secondZeroIndex; i++)
            {
                sumTask3 += arr[i];
            }

            return sumTask3;
        }

        public double Task4(double[] arr)
        {
            int indexOfMax = 0;
            int indexOfMin = 0;

            double maxNumberAbs = arr[0];
            double minNumberAbs = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > maxNumberAbs)
                {
                    maxNumberAbs = Math.Abs(arr[i]);
                    indexOfMax = i;
                }

                if (Math.Abs(arr[i]) < minNumberAbs)
                {
                    minNumberAbs = Math.Abs(arr[i]);
                    indexOfMin = i;
                }
            }


            double productTask4 = 1;

            for (int i = Math.Min(indexOfMax, indexOfMin) + 1; i < Math.Max(indexOfMin, indexOfMax); i++)
            {
                productTask4 *= arr[i];
            }

            return productTask4;
        }
    }
}

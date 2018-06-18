using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 50);
                
            }
            Console.WriteLine("Before Sliced");
            PrintArray(array);

            Console.WriteLine("After Sliced");
            PrintArray(GetArraySlice(array, 1, 3));
            Console.ReadKey(true);

        }
        static int[] GetArraySlice(int[] array, int from, int to)
        {
            int Length = (to - from) + 1;
            int[] newArray = new int [Length];
            int counter = 0;
            for (int i = from; i <= to; i++)
            {
                newArray[counter] = array[i];
                counter++;

            }
            return newArray;
        }
        static void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }
    }
}

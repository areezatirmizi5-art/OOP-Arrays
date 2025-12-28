using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Program to find the largest of 5 numbers
                int[] numbers = new int[5];

                Console.WriteLine("Enter 5 numbers:");

                for (int i = 0; i < 5; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                int largest = numbers[0];

                for (int i = 1; i < 5; i++)
                {
                    if (numbers[i] > largest)
                    {
                        largest = numbers[i];
                    }
                }

                Console.WriteLine("Largest number is: " + largest);

                Console.ReadLine();
            }

            {
                // Program to count even and odd numbers in an array
                int[] numbers = new int[10];
                int evenCount = 0;
                int oddCount = 0;

                Console.WriteLine("Enter 10 numbers:");

                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < 10; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }

                Console.WriteLine("Even numbers count: " + evenCount);
                Console.WriteLine("Odd numbers count: " + oddCount);

                Console.ReadLine();


                {
                    // Program to find the largest element in a matrix
                    int[,] matrix = new int[3, 3];

                    Console.WriteLine("Enter elements of 3x3 matrix:");

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    int largest = matrix[0, 0];

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (matrix[i, j] > largest)
                            {
                                largest = matrix[i, j];
                            }
                        }
                    }

                    Console.WriteLine("Largest element is: " + largest);

                    Console.ReadLine();
                }



            }
        }
    }

}
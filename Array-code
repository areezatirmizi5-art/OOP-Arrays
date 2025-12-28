using System;

class Program
{
    static void Main()
    {
        int[] marks = new int[5];
        int sum = 0;

        Console.WriteLine("Enter marks of 5 students:");

        for (int i = 0; i < marks.Length; i++)
        {
            marks[i] = Convert.ToInt32(Console.ReadLine());
            sum += marks[i];
        }

        int highest = marks[0];
        int lowest = marks[0];

        for (int i = 1; i < marks.Length; i++)
        {
            if (marks[i] > highest)
                highest = marks[i];

            if (marks[i] < lowest)
                lowest = marks[i];
        }

        double average = sum / (double)marks.Length;

        Console.WriteLine("\nResults:");
        Console.WriteLine("Total Marks: " + sum);
        Console.WriteLine("Average Marks: " + average);
        Console.WriteLine("Highest Marks: " + highest);
        Console.WriteLine("Lowest Marks: " + lowest);

        Console.ReadLine();
    }
}


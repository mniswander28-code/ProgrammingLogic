using System;

class Program
{
    static void Main()
    {
        // Problem 1
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Problem 2
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Problem 3
        int count = 5;
        while (count >= 1)
        {
            Console.WriteLine(count);
            count--;
        }

        // Problem 4
        int multiple = 10;
        while (multiple <= 1000)
        {
            Console.WriteLine(multiple);
            multiple += 10;
        }

        // Problem 5
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

        // Problem 6
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number from 1 to 7: ");
        int dayNumber = int.Parse(Console.ReadLine());

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine(days[dayNumber - 1]);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

        // Problem 7
        string[] books = { "Harry Potter", "1984", "The Hunger Games" };
        string[] authors = { "J.K. Rowling", "George Orwell", "Suzanne Collins" };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i] + " by " + authors[i]);
        }

        // Problem 8
        int[] temperatures = { 72, 65, 88, 59, 77 };
        Array.Sort(temperatures);

        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }

        Console.WriteLine("Highest: " + temperatures[temperatures.Length - 1]);
        Console.WriteLine("Lowest: " + temperatures[0]);

        // Problem 9
        int[] countdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(countdown);

        for (int i = 0; i < countdown.Length; i++)
        {
            Console.WriteLine(countdown[i]);
        }
    }
}
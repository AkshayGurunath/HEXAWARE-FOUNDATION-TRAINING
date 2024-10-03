using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//9. Program to display numbers in reverse order from 50 to 1 using a for loop:
namespace Lab_Exercise_looping
{
    class Program
    {
        static void Main()
        {
            for (int i = 50; i >= 1; i--)
            {
                Console.WriteLine(i);
               
            }
            Console.ReadLine();
        }
    }
}

//10.Odd Numbers between 1 to 50 using do -while loop:
class Program
{
    static void Main()
    {
        int i = 1;
        do
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
            i++;
        } while (i <= 50);

        Console.ReadLine();  // Keeps the console open
    }
}

//11. Even Numbers between 1 to 50 using while loop:
class Program
{
    static void Main()
    {
        int i = 1;
        while (i <= 50)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

        Console.ReadLine();  // Keeps the console open
    }
}


//12. Print Table of a Given Number:
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }

        Console.ReadLine();  // Keeps the console open
    }
}


//13. Even Numbers from a Given Array:
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Even numbers in the array are: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        Console.ReadLine();  // Keeps the console open
    }
}


using System;

namespace OnlyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Java", "C++", "Python", "C#", "JavaScript", "Go" };
            string[] newArray = {};

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    if (i < array.Length - 1)
                    {
                        Console.Write($"{array[i]}, ");
                    }
                    else
                    {
                        Console.Write(array[i]);
                    }
                }
                
            }
        }
    }
}

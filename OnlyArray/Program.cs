using System;

namespace OnlyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Java", "C++", "Python", "C#", "JavaScript", "Go" };
            string[] newArray = new string[array.Length];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    newArray[index] = array[i];
                    index++;
                }
            }

            for (int i = 0; i < index; i++)
            {
                if(i < index - 1)
                {
                    Console.Write($"{newArray[i]}, ");
                }
                else
                {
                    Console.Write(newArray[i]);
                }
            }
        }
    }
}

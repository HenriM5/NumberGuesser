using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 98; i > 1; i--) //int i = 0 - start; i < 10 - end; i++ - step/iteration
                if(i != 1)

                {
                    Console.WriteLine($"{i} bottles of bear on the wall, {i} bottles of beer. take one down and pass it around, {i - 1} bottles of bear on the wall");
                }
                else
                {
                    Console.WriteLine($"{i} bottles of bear on the wall, {i} bottles of beer. take one down and pass it around, {i - 1} bottles of bear on the wall");
                }
            Console.WriteLine("no more bottles of bear on the wall go to the story and buy some mroe");
            
           

        }
    }
}

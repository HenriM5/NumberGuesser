﻿using System;

namespace HelloWorldString
{
    class Program
    {
        static void Main(string[] args)
        {

            string helloWorld = "hello World!";
             
            for(int i = 0; i < helloWorld.Length; i++)
            {
                Console.WriteLine($"Kohal {i} on {helloWorld[i]} "); 
            }
        }
    }
}
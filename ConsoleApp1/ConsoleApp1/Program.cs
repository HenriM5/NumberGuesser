using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja läest eesnime
            //programm küsib kasutaja käest perekonna nime
            //programm tervitab kasutajat kasutades neid andmeid
            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("And what is your last name?");
            string LastName = Console.ReadLine();
            Console.WriteLine("Hello," + FirstName + " " + LastName);
        


        }

    }
}

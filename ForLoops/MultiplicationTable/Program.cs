using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //progreamm küsib kasutajalt sisestada numbrit;
            //programm kuvab korrutustabelit 1 kuni 10 sisestatud numbri jaoks
            //usernumber = 5
            //1 * 5 = 5;
            //2 * 5 = 10;
            //jne
            int i, num;

            
            Console.WriteLine("Sisesta number mida korrutada: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                            
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);
            }
            Console.ReadLine();

        }
    }
}

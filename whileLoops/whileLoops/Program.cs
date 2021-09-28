using System;

namespace whileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada pin koodi;
            // programm võrdleb sisestatud pin koodi arvuga 1234;
            //Kui sisestatud PIN kood on 1234, siis konsool kuvab "Tere tulemast!"
            //Kui sisestatud PIN kood on midagi muud, konsool kuvab "Vale PIN. proovi uuesti.
            //1. katsete arv on piiramatu
            //2. Kasutajal on kolm katset
            //boolean = true/false

            int i = 0;

            /*while (true) 
            {
                Console.WriteLine("Sisesta PIN kood");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;

                }
                else
                {
                    Console.WriteLine("Vale PIN. Proovi uuesti.");
                }*/


        }

        int i = 0
            while(i > 3)
              Console.WriteLine("Sisesta PIN kood:");
              int userPIN = Convert.ToInt32(Console.ReadLine());
              if(userPIN == 1234)
            

                Console.WriteLine("Tere tulemast!");
       

             
           
          
       
}   }
            
        



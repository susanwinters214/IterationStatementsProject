using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
// For Loop
            Console.WriteLine("START For Loop");

            for (int i=0; i<5; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("END For Loop");
            Console.WriteLine("    ");


///////////// INITIALIZE VARIABLES FOR ALL LOOPS /////////////////////

            var numbers = new List<int>();
            int myNumber = 0;


//////// DoWhile Loop - at the end  //////////

            Console.WriteLine("START DoWhile Loop");
            Console.WriteLine("Add myNumber to the numbers list (starting with 0 and ending at 100).");

            do
             {
                    myNumber++;
                    Console.WriteLine(myNumber);
                    numbers.Add(myNumber);
              }
                while (myNumber < 100) ; 
                Console.WriteLine("END DoWhile Loop");  
                Console.WriteLine("    ");


 ///////////////////////      While Loop      ///////////////////////////////////////

            Console.WriteLine("START While Loop");
            Console.WriteLine("Print myNumber until you reach 200");

            while (myNumber < 200)
            {
              Console.WriteLine($"myNumber: {myNumber}");
               myNumber++;
               numbers.Add(myNumber); 
            }
            
            Console.WriteLine("END While Loop");
            Console.WriteLine("    ");


 ///////////////////////      ForEach Loop   /////////////////////////////////////////

            Console.WriteLine("START ForEach Loop");
            Console.WriteLine("Print each number in the numbers list");            

            foreach (var item in numbers)
                
            {
              Console.WriteLine($"Item: {item}"); 
            }
          
            Console.WriteLine("END ForEachLoop");
            Console.WriteLine("    ");


/////////////////////         For Loop        /////////////////////////////////////////

            Console.WriteLine("START For Loop");
            Console.WriteLine("Print every number in the numbers list - backwards");


            for (int i = 199; i <=numbers.Count && i >=0; i--)
            {
                Console.WriteLine($"Number: {numbers[i]}");
               
            }

            Console.WriteLine("End of ForLoop");
        }


    }
}

using System;
using System.Linq;

//coments

/* 
    coments 
*/

namespace ConsoleApp1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, count;
            
            string operation = GetOperation();
            
            
            
            Console.WriteLine("Please enter number operation element, or exit fo exit");
            string temp = Console.ReadLine();
            count = Int32.Parse(temp);
            int[] numbers = new int[count];

            Console.WriteLine("Please start add namber for math operations: ");

            for (var i = 0; i < count; i++) 
            {
                numbers[i] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your give number is: " +numbers[i]);
                if (i != (numbers.Length - 1)) 
                {
                    Console.WriteLine("Please enter next number");
                }
            }

            Console.WriteLine("next you will see your array list:");
            
            foreach (int i in numbers)
            {
                Console.Write(i+", ");
            }
            Console.WriteLine("");
            
            //using switch to choose math operations

            switch (operation)
            {
                case "plus":
                    
                    Console.WriteLine("Your sum results is: "+numbers.Sum());
                    break;
                              
            };
                                   
            
        }

        static string GetOperation()
        {
            string operation;
            Console.WriteLine("Please enter the operations!(plus/minus/mult/division)");
            operation = Console.ReadLine();

            return operation;
        }

    }
}

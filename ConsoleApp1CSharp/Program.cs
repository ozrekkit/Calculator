using System;
using System.Linq;
using System.Diagnostics;

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
            string op;
             
            op =  GetOperation();
                    
            count = QuantityNumbers();

            int[] numbers = new int[count];

            Console.WriteLine("Please start add number for math operations: ");

            for (var i = 0; i < count; i++) 
            {
                numbers[i] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your give number is: " +numbers[i]);
                if (i != (numbers.Length - 1)) 
                {
                    Console.WriteLine("Please enter next number");
                }
            }

            ShowYourInputNumbers(numbers);
            

                       
            //using switch to choose math operations

            switch (op)
            {
                case "plus":
                    
                    Console.WriteLine("Your sum results is: "+numbers.Sum());
                    break;

                case "subtraction":
                    Console.WriteLine("Your subtraction results is: " + subtractionFunc(numbers));
                    break;

                default:
                    Console.WriteLine("somthing wromng with your switch system!");
                    break;
                              
            };
    
                                   
            
        }

        static string GetOperation()
        {
            string operation;
            Console.WriteLine("Please enter the operations!(plus/subtraction/mult/division)");
            operation = Console.ReadLine();
            operation = CheckValidOperation(operation);
            return operation;
        }
        static string CheckValidOperation(string op)
        {
            if (op == "plus" || op == "subtraction" || op == "mult" || op == "division")
            {
                return op;
            }
            else 
            {
                Console.WriteLine("Sorry, your need to input corect opreratins, please try onece more");
                GetOperation();
                return "";
            }

            
        }

        static int QuantityNumbers() 
        {
            Console.WriteLine("Please enter number operation element, or press q to quit");
            int qNum = 0;
            string sInput;
           
            sInput = Console.ReadLine();
            if (sInput == "q")
            {
                endProg();
            }
            else
            {
                if (!int.TryParse(sInput, out qNum))
                {
                    Console.WriteLine("Input Error! ");
                    QuantityNumbers();
                }
                else
                {

                    
                }

            }
                

            

            Console.WriteLine("Hello");
            //System.Convert.ToInt32();

            //int count = Int32.Parse(countNum);
            
            return qNum;
        }

        static void ShowYourInputNumbers(Array numbers) 
        {

            Console.WriteLine("next you will see your numbers input before:");

            foreach (int i in numbers)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("");
        }


        //function calculete divi

        static int subtractionFunc(int[] arr)
        {
            int tempResult = arr[0];

            for (var i = 1; i <= arr.Length - 1; i++)
            {
                tempResult -= arr[i];
            };

            return tempResult;
        }

        //function for close program

        static void endProg()
        {
            Console.WriteLine("Program ready to close! Good bye!");
            Process.GetCurrentProcess().Kill();
        }
    }
}

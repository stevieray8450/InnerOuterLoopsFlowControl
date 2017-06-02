using System;

namespace InnerOuterLoopsFlowControl
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string userInput = Console.ReadLine();
            int userNum = Int32.Parse(userInput);

            for (int i = 1; i <= userNum; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}


using System;

namespace pendule
{
    class MainClass
    {

        public static int UserInput()
        {
            int userInput = -1;
            string receiveInput = "";
            bool condition = true; 

            do
            {
                Console.WriteLine("Enter a number between 0 and 100");
                receiveInput = Console.ReadLine();
                // convert the user input and check if the range is ok
                condition = int.TryParse(receiveInput, out userInput) && (userInput > 0 && userInput <= 100);

                if(!condition)
                {
                    Console.WriteLine("Incorrect number entered");
                }

            } while (!condition);

            return userInput;
        }


        public static void Main(string[] args)
        {
            Random rand = new Random();
            int generated_number = rand.Next(100);
            bool exit = false;
            int userInput = -1;

            while(!exit)
            {
                userInput = UserInput();

                if (generated_number == userInput)
                {
                    Console.WriteLine("Congratulation you Guess the number");
                    exit = !exit;
                }
                else if( generated_number < userInput)
                {
                    Console.WriteLine("{0} is greater than the generated number", userInput);
                }
                else
                {
                    Console.WriteLine("{0} is less than the generated number", userInput);
                }
            }
        }
    }
}
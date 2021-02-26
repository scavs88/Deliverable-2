using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string choice = "True";
            bool myBool = Convert.ToBoolean(choice);


            do
            {

                Console.WriteLine("What would you like to say to chatbot5000?");
                string input = Console.ReadLine();
                choice = input.ToLower();

                if (choice == "hello")
                {
                    Console.WriteLine("Hi good to see you");

                }
                if (choice == "bye")
                {
                    Console.WriteLine("Good Bye!");
                    break;

                }
                if (choice == "sup")
                {
                    Console.WriteLine("I am good");
                }
                if (choice == "hello there")
                {
                    Console.WriteLine("General Kenobi");
                }
            } while (true);
        }
    }
}

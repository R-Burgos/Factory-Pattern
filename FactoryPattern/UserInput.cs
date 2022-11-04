using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class UserInput
    {
        public static int CheckingUserInput()
        {
            int userInput;
            bool condition;
            do
            {
                condition = int.TryParse(Console.ReadLine(), out userInput);

                if (userInput < 0)
                {
                    Console.WriteLine("Very funny, a negative number. You know I'm just trying to give you a car or something.\nWhy not try again for me....");
                }
            } while (!condition || userInput < 0);
            return userInput;
        }

    }
}

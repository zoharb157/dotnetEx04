using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    namespace Actions
    {
        public class CountSpaces : ActionInterface
        {
            public void Invoke()
            {
                Console.WriteLine("Please write something:");

                string userInput = Console.ReadLine();
                int spacesCount = 0;

                foreach (char currentChar in userInput)
                {
                    if (currentChar == ' ')
                    {
                        ++spacesCount;
                    }
                }

                Console.WriteLine(string.Format("Number of spaces: {0}", spacesCount));
            }
        }

        public class ShowVersion : ActionInterface
        { 
            public void Invoke()
            {
                Console.WriteLine("Version: 21.3.4.8933");
            }
        }

        public class ShowDate : ActionInterface
        {
            public void Invoke()
            {
                Console.WriteLine(DateTime.Now.Date.ToString("dd/MM/yyyy"));
            }
        }

        public class ShowTime : ActionInterface
        {
            public void Invoke()
            {
                Console.WriteLine(DateTime.Now.ToString("HH:mm"));
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Student_Database
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] names = new string[5] { "Bill", "Jen", "Erik", "Alex", "Sam" };
            string[] homes = new string[5] { "Phoenix", "Atlana", "Boston", "Toledo", "Detroit" };
            string[] foods = new string[5] { "Cheese Burger", "Pizza", "Pasta", "Fruit", "Chili" };

            var inside = true;

            while (inside)
            {
                Console.WriteLine("Hello. What student from the following list would you like to learn about? Enter 1-5");

                var userInput = int.Parse(Console.ReadLine());

                userInput = userInput - 1;
                Console.WriteLine("This student's name is " + names[userInput]);

                bool option = true;

                while (option)
                {
                    Console.WriteLine("Type hometown to see their hometown or food to see their favorite food");
                    var answer = Console.ReadLine();


                    if (answer == "hometown")
                    {
                        Console.WriteLine(names[userInput] + "'s hometown is " + homes[userInput]);
                        option = false;
                    }

                    else if (answer == "food")
                    {
                        Console.WriteLine(names[userInput] + "'s favorite food is " + foods[userInput]);
                        option = false;
                    }

                    else
                    {
                        Console.WriteLine("This is not a valid response. Please try again by entering hometown or food");
                        continue;
                    }

                }

                Console.WriteLine("Would you like to continue (y/n)");

                var yn = Console.ReadLine();

                if (yn == "y")
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("Fine, I didnt like you anyway!!");
                    break;
                }
            }
        }
    }
}

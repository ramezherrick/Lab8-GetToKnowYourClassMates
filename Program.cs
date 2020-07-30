using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Lab8_GetToKnowYourClassMates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Ramez", "Curtis", "Steven", "Curtis", "Andoni" };
            List<string> homeTown = new List<string> { "Ann Arbor, MI", "Chicago, IL", "New York, NY", "Dallas, TX", "Ann Arbor, MI" };
            List<string> favfood = new List<string> { "burgers", "chicken", "beef", "pasta", "tacos" };

            string more = "";
            string answer = "";
            string input = "";
            string cont = "y";

            bool contNameNumber = true; bool condition = true;

            int index = 0;
            Console.WriteLine("1.Ramez " + "2.Curtis " +"3.Steven " +"4.Curtis " +"5.Andoni");

            while (cont == "y")
            {

                while (true)
                {
                    string search = Get("Would you like to search for a student by (name/number?)");
                    
                    if (search.Contains("num"))
                    {
  
                        input = Get("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1 - 5): ");

                        while (!int.TryParse(input, out index) || index > names.Count || index < 1)
                        {
                            input = Get("Please enter and integer, try again(enter a number 1 - 5): ");
                        }
                        break;
                    }
                    else if (search.Contains("nam"))
                    {
                        while (true)
                        {
                            Console.Write("Enter a name: ");
                            index = names.IndexOf(Console.ReadLine()) + 1;
                            if (index < 1)
                            {
                                Console.WriteLine("Invalid name");
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    }
                }
                while (condition)
                {
                    Console.Write($"Student {index} is {names[index - 1]}. What would you like to know about {names[index - 1]}? (enter “hometown” or “favorite food”): ");


                    answer = Console.ReadLine().ToLower().Trim();

                    if (answer.Contains("home") || answer.Contains("town"))
                    {
                        Console.Write($"{names[index - 1]} is from {homeTown[index - 1]}. Would you like to know more? (enter “yes” or “no”): ");
                        more = Console.ReadLine().ToLower();
                        if (more == "yes") continue;
                        else condition = false;

                    }
                    else if (answer.Contains("food") || answer.Contains("fav"))
                    {
                        Console.Write($"{names[index - 1]} favorite food is {favfood[index - 1]}. Would you like to know more? (enter “yes” or “no”): ");
                        more = Console.ReadLine();
                        if (more == "yes") continue;
                        else condition = false;

                    }
                    else
                    {
                        Console.Write("Invalid entry\n");
                    }

                }
                cont = Continue("Do you want to contnue (y/n)? ");
            }

        }
        public  static string Get (string str)
        {
            Console.Write("Would you like to search for a student by (name/number?)");
            string search = Console.ReadLine().ToLower();
            return search;
        }
        public static string Continue (string str)
        {
            bool condition = true; string input = "y";

          
            while (condition)
            {
                Console.Write(str);
                input = Console.ReadLine().ToLower();

                if (input =="y"||input =="n")
                {
                    condition=false;
                 
                }
  
            }
            return input;
        }
    }
}

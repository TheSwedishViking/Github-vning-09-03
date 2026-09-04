using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ToDoAppTest.Functionality
{
    public static class UserCreation
    {
        public static Models.User CreateUser()
        {
            //Loop until valid
            while (true)
            {
                Console.WriteLine("Please enter your name (NO NUMBERS ALLOWED!)");
                string input = Console.ReadLine();
                /*
                 
            Models.User user = new Models.User();
            user = UserCreation.CreateUser();
                 
                 */
                Regex validNameRegex = new Regex("^[A-Z][A-Za-z]*$");

                //If there's a capital letter and no numbers
                if (validNameRegex.IsMatch(input))
                {
                    Models.User user = new Models.User
                    {
                        UserName = input,
                        Tasks = new List<Models.Task>()
                    };
                    return user;
                }
                //Loop until the end of the earth, or valid name comes around
                else
                {
                    Console.WriteLine("Invalid name. Please enter a valid name (NO NUMBERS ALLOWED!)");
                }
            }



        }
    }
}

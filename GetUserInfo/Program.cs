using System;
using System.Collections.Generic;

namespace GetUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many users are there?");

            string userCountResponse = Console.ReadLine();
            int userCount = int.Parse(userCountResponse);

            List<Person> users = new List<Person>();
            for (int i = 0; i < userCount; i++)
            {

                Person user = new Person();

                user.FirstName = user.AnswerQuestion("What is your first name?");

                user.LastName = user.AnswerQuestion("What is your last name?");

                user.FavoriteNumber = user.AnswerQuestionWithInteger("What is your favorite number?");

                user.FavoriteAnimal = user.AnswerQuestion("What is your favorite animal?");

                users.Add(user);
            }

            Console.Clear();
            foreach (Person user in users)
            {

                if (user.FavoriteNumber >= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Hello {user.FirstName} {user.LastName}." +
                        $"Your favorite number is {user.FavoriteNumber}" +
                        $" and your favorite animal is a {user.FavoriteAnimal}.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Hello {user.FirstName} {user.LastName}." +
                        $"Your favorite number is {user.FavoriteNumber}." +
                        $" And your favorite animal is a {user.FavoriteAnimal}.");
                }
            }

        }
    }
}




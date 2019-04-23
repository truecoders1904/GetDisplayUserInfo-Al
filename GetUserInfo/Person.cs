using System;
namespace GetUserInfo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FavoriteNumber { get; set; }
        public string FavoriteAnimal { get; set; }
      

        public string AnswerQuestion(string question)
        {
            Console.WriteLine($"Hey {FirstName} {LastName}, I have a question for you!");
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public int AnswerQuestionWithInteger(string question)
        {
            string stringAnswer = AnswerQuestion(question);
            return int.Parse(stringAnswer);
        }
    }
}

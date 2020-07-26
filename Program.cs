using System;
using System.Collections.Generic;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Surveys = new List<Survey>();

            while(true)
            {
                Survey newSurvey = new Survey();
                newSurvey.Name = newSurvey.Ask("Enter Name: ");
                newSurvey.Age = int.Parse(newSurvey.Ask("Enter Age: "));
                newSurvey.Month = newSurvey.Ask("Enter Birth Month: ");
                Surveys.Add(newSurvey);

                if (newSurvey.Ask("Do you wish to contine? y/n ") != "y")
                {
                    break;
                }
            }

            foreach (var survey in Surveys)
            {
                Console.WriteLine("Name: {0} - Age: {1} - Birth Month: {2}", survey.Name, survey.Age, survey.Month);
                survey.Sign();
            }
        }
    }

    class Survey
    {
        public string Name;
        public int Age;
        public string Month;

        public string Ask(string question)
        {
            Console.Write(question);
            return (Console.ReadLine());
        }

        public void Sign()
        {
            switch(Month)
            {
                case "April":
                    Console.WriteLine("Aries");
                    break;
                default:
                    Console.WriteLine("Grue");
                    break;
            }
        }
    }
}

using System;

namespace VariablesExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Ralf";
            int dogAge = 10;
            char nickName = 'R';
            bool lovesHiking = true;
            double tennisBalls = 32;
            decimal weight = 70.3m;


            Console.WriteLine($"My dog's name is {dogName}. He is {dogAge} years old and he has {tennisBalls} tennis balls and it is {lovesHiking} that he loves to hike, which keeps him at his weight of {weight} pounds");

            Console.WriteLine($"");

            if (lovesHiking == true)
            {
                Console.WriteLine($"{dogName} loves to hike!");
            }
            else
            {
                Console.WriteLine($"{dogName} hates hiking!");
            }

        }
    }
}
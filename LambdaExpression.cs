using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionWork
{
    internal class LambdaExpression
    {
        //1) Write a program that filters out all people who are 18 years old or older from a list of persons using a lambda expression.Each person should have Name and Age properties.
        public void Filter18YearsOld()
        {
            List<Person> persons = new List<Person>
            {
                new Person { Name = "Piyush", Age = 24 },
                new Person { Name = "Karan", Age = 18 },
                new Person { Name = "Alex", Age = 25 },
                new Person { Name = "David", Age = 16 }
            };

            //var filteredPersons = persons.Where(p => p.Age >= 18).ToList();
            var filteredPersons = persons.FindAll(p => p.Age >= 18);
            
            Console.WriteLine("Person with age above or equal to 18: ");
            foreach (var person in filteredPersons)
            {
                Console.WriteLine(person);
            }
        }


        //2) Write a program that counts the occurrences of a specific character in a list of strings using a lambda expression.
        public void CountCharacterOccurrences()
        {
            char character = 'a';

            List<string> strings = new List<string> { "visual", "ruby", "python", "java" };

            int count = strings.Sum(str => str.Count(c => c == character));

            Console.WriteLine($"The character '{character}' has appeared {count} times.");
        }

        //3) Write a program that performs various aggregate operations(sum, average, minimum, maximum) on a list of numbers using lambda expressions.
        public void AggregateOperations()
        {
            List<int> num = new List<int> { 10, 20, 30, 40, 50 };

            int sum = num.Sum();
            double average = num.Average();
            int min = num.Min();
            int max = num.Max();

            Console.WriteLine($"Sum: {sum}, Average: {average}, Min: {min}, Max: {max}");
        }


        //4) Write a program that finds all words in a list that start with the letter 'A' using LINQ. 
        public void FindWordsStartsWithA()
        {
            List<string> words = new List<string> { "laptop", "mobile", "charger", "bottle", "tablet" };
            var wordsStartsWithA = words.Where(word => word.StartsWith("A", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Words starting with 'A':");
            foreach (var word in wordsStartsWithA)
            {
                Console.WriteLine(word);
            }
        }

        //5) Write a program that finds the top 3 highest scores from a list of integers using LINQ. 
        public void FindTop3Scores()
        {
            var scores = new List<int> { 15, 55, 25, 35, 45, 54, 88 };

            var sortedScores = scores.OrderByDescending(s => s).Take(3);
            foreach (var item in sortedScores)
            {
                Console.WriteLine(item);
            }

            //---------------------OR------------------------

            //var sortedScores = scores.OrderByDescending(s => s).ToList();
            //Console.WriteLine("Top 3 highest scores:");
            //for (int i = 0; i < 3 && i < sortedScores.Count; i++)
            //{
            //    Console.WriteLine(sortedScores[i]);
            //}
        }

        //6) Write a program that groups a list of Person objects by their age using LINQ.
        public void GroupPersonsByAge()
        {
            List<Person> persons = new List<Person>
            {
                new Person { Name = "Piyush", Age = 24 },
                new Person { Name = "David", Age = 16 },
                new Person { Name = "Karan", Age = 18 },
                new Person { Name = "Alex", Age = 25 },
                new Person { Name = "Tarun", Age = 25 },
                new Person { Name = "David", Age = 16 }
            };
            var groupByAge = persons.GroupBy(p => p.Age);
            foreach (var group in groupByAge)
            {
                //Group(Key,Element) 
                Console.WriteLine($"Age Group: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine(person);
                }
            }
        }

    }
}

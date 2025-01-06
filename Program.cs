using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LambdaExpression l = new LambdaExpression();
            //l.Filter18YearsOld();
            //l.CountCharacterOccurrences();
            //l.AggregateOperations();
            l.FindWordsStartsWithA();
            //l.FindTop3Scores();
            //l.GroupPersonsByAge();





            //Customer customer = new Customer
            //{
            //    FirstName="Piyush",
            //    LastName="Kumar",
            //    PhoneNumber="9852276519",
            //    Email="piyushkumar@gmail.com"

            //};
            //ValidationContext context = new ValidationContext(customer);
            //List<ValidationResult> results = new List<ValidationResult>();
            //bool isValid = Validator.TryValidateObject(customer, context, results, true);

            //if (isValid)
            //{
            //    Console.WriteLine("customer data validated successfully");
            //}
            //else
            //{
            //    Console.WriteLine("customer not valid");
            //    //It will print the error messages for each validation stored in a list of Validation Results
            //    foreach (var i in results)
            //    {
            //        Console.WriteLine(i.ErrorMessage);
            //    }
            //}

        }
    }
}

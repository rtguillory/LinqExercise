using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var NumSum = numbers.Sum();
            Console.WriteLine(NumSum);
            Console.WriteLine();

            //TODO: Print the Average of numbers
            var NumAvg = numbers.Average();
            Console.WriteLine(NumAvg);
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console
            var NumAscend = numbers.OrderBy(x => x);
            foreach (var num in NumAscend) { Console.WriteLine(num); }
            Console.WriteLine();

            //TODO: Order numbers in decsending order and print to the console
            var NumDescend = numbers.OrderByDescending(x => x);
            foreach (var num in NumDescend) { Console.WriteLine(num); }
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            var GreaterThan6 = numbers.Where(x => x > 6);
            foreach (var num in GreaterThan6) { Console.WriteLine(num); }
            Console.WriteLine();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var First4 = numbers.OrderBy((x) => x).Take(4);
            foreach (var num in First4) { Console.WriteLine(num); }
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 59;  //Is there a way to do this with Linq?
            var DescendWithAge = numbers.OrderByDescending((x) => x);
            foreach (var num in DescendWithAge) { Console.WriteLine(num); }
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var CorS = employees.Where(x => x.FirstName.FirstOrDefault() == 'C' || x.FirstName.FirstOrDefault() == 'S').OrderBy(x => x.FirstName);
            foreach (var employee in CorS) { Console.WriteLine(employee); }
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var Over26 = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var employee in Over26) { Console.WriteLine(employee.FullName + ", age: " + employee.Age); }
            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var SumYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(SumYOE);
            Console.WriteLine();
            var AverageYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(AverageYOE);
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()
            var AddToEnd = employees.Append(new Employee());
            foreach (var employee in AddToEnd) { Console.WriteLine(employee); }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}

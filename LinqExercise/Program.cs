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


            //TODO: Print the Sum of numbers
             var sum = numbers.Sum();
            Console.WriteLine(sum);

            //TODO: Print the Average of numbers
            var average = numbers.Average();
            Console.WriteLine(average);
            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Ascending");
            var array=  numbers.OrderBy(num => num).ToArray();
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("descending");
            var descending = numbers.OrderByDescending(num => num);
            foreach(var num in descending)
            {
                Console.WriteLine(num);
            }
            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("numbers which are greater then 3");

            var greaterNum = numbers.Where(x => x > 3);        
            foreach(int number in greaterNum)
            {
                Console.WriteLine(number);
            }
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Only 4 out of them");
            var fourNum =  numbers.OrderByDescending(b => b).Take(4);
            foreach(int number in fourNum)                             
            {
                Console.WriteLine(number);
            }
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("New Assigned Index 4 to Age: ");
            numbers[4] = 32;
           var indexFour = numbers.OrderByDescending(m => m);
            foreach(int num in indexFour)
            {
                Console.WriteLine(num);
            }
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only
            //if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Full Name of employees");
            var fullName=  employees.Where(a => a.FirstName.StartsWith("C") || a.FirstName.StartsWith("S")).OrderBy(a => a.FirstName);
            foreach(Employee employee in fullName)
            {
                Console.WriteLine(employee.FullName);
            }
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console
            //and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employees full name with over 26 age");
          var nameAge =  employees.Where(x => x.Age > 26).OrderBy(x => x.Age).OrderBy(x => x.FirstName);
            foreach( Employee employee in nameAge)
            {
                Console.WriteLine(employee.FullName);
                Console.WriteLine(employee.Age);
            }
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than
            //or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Sum of employees experince");
            var sumOfEmployees = employees.Where(n => n.YearsOfExperience <= 10 && n.Age > 35).Sum(n => n.YearsOfExperience);
                                 
         
            {
                Console.WriteLine(sumOfEmployees);
            }

            //TODO: Now print the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Average Years of experience");
            var averageYears =  employees.Where(m => m.YearsOfExperience <= 10 && m.Age > 35).Average(m => m.YearsOfExperience);
            Console.WriteLine(averageYears);

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Added Name on the list");
            var newAddedName =   employees.Where(m => m.FullName.StartsWith("H") || m.FullName.StartsWith("S"));
            foreach(Employee employee in newAddedName) 
            {
                Console.WriteLine(employee.FullName);
            }
                
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>() {
           new Employee("Cruz", "Sanchez", 25, 10),
        new Employee("Steven", "Bustamento", 56, 5),
        new Employee("Micheal", "Doyle", 36, 8),
        new Employee("Daniel", "Walsh", 72, 22),
        new Employee("Jill", "Valentine", 32, 43),
        new Employee("Yusuke", "Urameshi", 14, 1),
        new Employee("Big", "Boss", 23, 14),
        new Employee("Solid", "Snake", 18, 3),
        new Employee("Chris", "Redfield", 44, 7),
        new Employee("Faye", "Valentine", 32, 10),
        new Employee("Hafiz", "Amiri", 30, 10)
            };
            return employees;
        }
        #endregion
    }
}

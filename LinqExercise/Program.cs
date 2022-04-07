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
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers -DONE////
            var sum = numbers.Sum();
            var avg = numbers.Average();  
            Console.WriteLine($"the sum of the numbers:{sum}");
            Console.WriteLine($"The average of the numbers:{avg}");

            //Order numbers in ascending order and decsending order. Print each to console. (list needs foreach loop)-DONE///
            var ascend = numbers.OrderBy(x => x);
            foreach (var x in ascend)
            {
                Console.WriteLine($"Ascending numbers:{x}");
            }
            Console.WriteLine("------------------");
            var decsend = numbers.OrderByDescending(z => z);
            foreach (var z in decsend)
            {

                Console.WriteLine($"Decsending numbers:{z}");

            }

           
            //Print to the console only the numbers greater than 6-DONE////
            var lgerThanSix = numbers.Where(x => x > 6);
            foreach (var x in lgerThanSix)
            {
                Console.WriteLine($"post numbers larger than six: {x}"); 
            }

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!** -DONE//////
            foreach (var z in decsend.Take (4))
            {
                    Console.WriteLine($"Print four numbers: {z}");
            }

            //, then print the numbers in decsending order   ///??????
            // go to the numbers at the top and go to 4th index number listed (1-9). change the 4th index to your age. 
            // Change the value at index 4 to your age
            // ??????
            Array.switch(4,35); //???????????????????????????????????????????????
            var myAgeChange = numbers.OrderByDescending(age => age);
            foreach (var ageChange in myAgeChange)
            {
                Console.WriteLine($"Edit to Age change along with descending numbers: {ageChange}");
            }

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.
            var cFullNames = employees.???

            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            var overTwentySix = employees.??

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            var sumAndAvgOfEmpYOE = employees. ??

            //Add an employee to the end of the list without using employees.Add()

                employees = employees.Append(new Employee("Hannah", "Willis", 35, 0)).ToList();
            foreach (var teamMember in employees)
            {
                Console.WriteLine($"New Team member; {teamMember.FullName}");
            }

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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset._04_SortedList
{
    internal class clsSortedList
    {
        /*
                Characteristics of SortedList : 

        Automatically Sorted: The elements in a SortedList are sorted by the key as soon as they are added.

        Key-Value Pairs: Similar to a dictionary, it stores elements as key-value pairs.

        Unique Keys: Keys must be unique, and an exception is thrown if a duplicate key is added.

        Slower for addition and Faster for Search because it uses binary search algorithm.


         */

        static void WorkWithSortedList()
        {
            var sortedList = new SortedList<string, int>();


            // Adding elements

            sortedList.Add("banana", 2);
            sortedList.Add("Orange", 3);
            sortedList.Add("apple", 3);

            // Accessing elements
            Console.WriteLine("\nQuantity of apples: " + sortedList["apple"]);


            Console.WriteLine("\nIterating SortedList Elements:");
            // Iterating through elements
            foreach (var item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }


            // Removing an element
            sortedList.Remove("apple");

            Console.WriteLine("\nSortedList Elements removing apple:");

            foreach (var item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

        }

        static void WorkWithLinq()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>()
            {
                { 1, "One" },
                { 3, "Three" },
                { 2, "Two" },
                { 4, "Four" }
            };


            var queryExpressionSyntax = from kvp in sortedList
                                        where kvp.Key > 1 // Filter keys greater than 1
                                        select kvp;

            Console.WriteLine("Query Expression Syntax Results:");
            foreach (var item in queryExpressionSyntax)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


            var methodSyntax = sortedList.Where(kvp => kvp.Key > 1); // Filter keys greater than 1
            Console.WriteLine("\nMethod Syntax Results:");
            foreach (var item in methodSyntax)
            {
                Console.WriteLine($"{item.Key}: {item.Value}"); // Expected: 2, 3, 4
            }


            // Filter key-value pairs with keys greater than a specific value

            int specificValue = 2;
            var filteredByKey = sortedList.Where(kvp => kvp.Key > specificValue); // Filter keys greater than 2
            Console.WriteLine($"\nEntries with keys greater than {specificValue}:");
            foreach (var item in filteredByKey)
            {
                Console.WriteLine($"{item.Key}: {item.Value}"); // Expected: 3, 4
            }

        }

        static void AdvancedLinq()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>()
            {
                { 1, "Apple" },
                { 2, "Banana" },
                { 3, "Cherry" },
                { 4, "Date" },
                { 5, "Grape" },
                { 6, "Fig" },
                { 7, "Elderberry" }
            };


            // Grouping fruits by the length of their names
            Console.WriteLine("Grouping fruits by the length of their names:");

            var groups = sortedList.GroupBy(kvp => kvp.Value.Length);

            foreach (var group in groups)
            {
                Console.WriteLine($"Name Length {group.Key}: {string.Join(", ", group.Select(kvp => kvp.Value))}");

            }
        }

        static void AdvanceComplexObjectOperationsUsingLinq()
        {
            SortedList<int, Employee> employees = new SortedList<int, Employee>()
            {
                { 1, new Employee("Alice", "HR", 50000) },
                { 2, new Employee("Bob", "IT", 70000) },
                { 3, new Employee("Charlie", "HR", 52000) },
                { 4, new Employee("Daisy", "IT", 80000) },
                { 5, new Employee("Ethan", "Marketing", 45000) }
            };

            var query = employees.Where(p => p.Value.Department == "IT")
                .OrderByDescending(p => p.Value.Salary)
                .Select(p => p.Value.Name);

            Console.WriteLine("IT Department Employees sorted by Salary (Descending):");
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }


        }

        public static void TestSortedList()
        {
            //WorkWithSortedList();

            //AdvancedLinq();

            AdvanceComplexObjectOperationsUsingLinq();

        }

    }

    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }


        public Employee(string name, string department, decimal salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
    }
}

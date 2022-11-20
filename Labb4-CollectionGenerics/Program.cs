using System;
using System.Collections.Generic;

namespace Labb4_CollectionGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack: \n");

            // Create 5 objects of the Employee class
            Employee employee = new Employee(1001, "Filip", "M", 20000);
            Employee employee1 = new Employee(1002, "Alvin", "M", 25000);
            Employee employee2 = new Employee(1003, "Isabella", "F", 20000);
            Employee employee3 = new Employee(1003, "Joakim", "M", 30000);
            Employee employee4 = new Employee(1003, "Ulrika", "F", 35000);

            // Create a stack of Employee and add 5 users to the stack
            Stack<Employee> EmpStack = new Stack<Employee>();
            EmpStack.Push(employee);
            EmpStack.Push(employee1);
            EmpStack.Push(employee2);
            EmpStack.Push(employee3);
            EmpStack.Push(employee4);

            // Write out all the users in the stack, with the help of ToString override
            foreach (Employee emp in EmpStack)
            {
                Console.WriteLine(emp);
                Console.WriteLine($"Items in lsit: {EmpStack.Count}\n");

            }

            Console.WriteLine("\n----------------------------------\n");
            
            // Removing people with POP
            for (int i = EmpStack.Count; i > 0; i--)
            {
                Employee Deleate = EmpStack.Pop();
                Console.WriteLine(Deleate); 
                Console.WriteLine($"Items in lsit: {EmpStack.Count}\n");
            }

            // Adding all the users to the stack again
            EmpStack.Push(employee);
            EmpStack.Push(employee1);
            EmpStack.Push(employee2);
            EmpStack.Push(employee3);
            EmpStack.Push(employee4);

            Console.WriteLine("\n----------------------------------\n");

            // Check the first person in the stack
            Employee Check = EmpStack.Peek();
            Console.WriteLine(Check);

            Console.WriteLine($"Items in lsit: {EmpStack.Count}\n");

            Employee Check2 = EmpStack.Peek();
            Console.WriteLine(Check2);

            Console.WriteLine($"Items in lsit: {EmpStack.Count}\n");


            Console.WriteLine("\n----------------------------------\n");

            // Check if employee2 is in the stack
            if (EmpStack.Contains(employee2))
            {
                Console.WriteLine("Emp2 is in the stack!");
            }
            else
            {
                Console.WriteLine("Emp2 is not in the stack!");
            }

            Console.WriteLine("\n----------------------------------\n\n\n\n");

            Console.WriteLine("List:\n");
            // List of Employee
            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(employee);
            EmpList.Add(employee1);
            EmpList.Add(employee2);
            EmpList.Add(employee3);
            EmpList.Add(employee4);

            // Check if employee 2 is in the list
            if (EmpList.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exists in the list!\n");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list!\n");
            }

            // Finds the first person with gender Male in the list 
            Console.WriteLine("First Male User");
            Employee Find = EmpList.Find(x => x.Gender == "M");
            Console.WriteLine(Find);

            // Finds all the users with the gender Male in the list
            Console.WriteLine("\nAll Male Users");
            List<Employee> FindAll = EmpList.FindAll(x => x.Gender == "M");

            foreach (Employee emp in FindAll)
            {
                Console.WriteLine(emp);
            }
            

            Console.ReadKey();
        }
    }
}

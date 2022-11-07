using System;
using System.Collections.Generic;

namespace Labb4_CollectionGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1001, "Filip", "M", 20000);
            Employee employee1 = new Employee(1002, "Alvin", "M", 25000);
            Employee employee2 = new Employee(1003, "Isabella", "F", 20000);
            Employee employee3 = new Employee(1003, "Joakim", "M", 30000);
            Employee employee4 = new Employee(1003, "Ulrika", "F", 35000);

            Stack<Employee> EmpList = new Stack<Employee>();
            EmpList.Push(employee);
            EmpList.Push(employee1);
            EmpList.Push(employee2);
            EmpList.Push(employee3);
            EmpList.Push(employee4);

            Console.WriteLine("List of all users:");
            foreach (Employee emp in EmpList)
            {
                Console.WriteLine(emp);
                //Console.WriteLine($"ID = {emp.Id}, Name = {emp.Name}, Gender = {emp.Gender}, Salary = {emp.Salary}");
                Console.WriteLine($"Items in lsit: {EmpList.Count}");

            }

        }
    }
}

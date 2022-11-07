using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4_CollectionGenerics
{
    internal class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public Employee(int _Id, string _Name, string _Gender, double _Salary)
        {
            this.Id = _Id;
            this.Name = _Name;
            this.Gender = _Gender;
            this.Salary = _Salary;
        }
        public override string ToString()
        {
            return $"ID = {Id}, Name = {Name}, Gender = {Gender}, Salary = {Salary}";
        }
    }
}

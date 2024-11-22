using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public abstract class Person
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int Age { get; set; }
        public Person(string name, string familyName, int age = 76)
        {
            Name = name;
            FamilyName = familyName;
            Age = age;
            Console.WriteLine("Parent Constructor was called");
        }

        public abstract int CalculateNumbers(int a, int b);
        //{
        //    return a + b;
        //}


    }
    public class Student : Person
    {
        public int Id { get; set; }
        public Student(string name, string familyName, int age) : base(name, familyName, age)
        {
            Console.WriteLine("Student Constructor 1 was called");
            Age = (byte)(age + 5.8);
        }

        public Student(string name, string familyName, int age, int grade) : this(name, familyName, age)
        {
            Console.WriteLine("Student Constructor 2 was called");
            Grade = grade;
        }
        public int Grade { get; set; }
        public byte Age { get; set; } = 25;

        public void DoSomething()
        {
            bool Age = true;
            Console.WriteLine($"My Name is {Name}.I am student with Id {Id}. My Personal Id is {base.Id.Substring(0, 4) + "******"}");
        }

        public override int CalculateNumbers(int a, int b)
        {
            return a / b + 13534;
        }
    }

    public class Employee : Person
    {
        public Employee(string name, string familyName, int age = 76) : base(name, familyName, age)
        {
        }

        public override int CalculateNumbers(int a, int b)
        {
            return a - b;
        }

        public virtual void DoMagic()
        {
            Console.WriteLine("Alohomora");
        }
    }

    public class Intern : Employee
    {
        public Intern(string name, string familyName, int age = 76) : base(name, familyName, age)
        { }

        public override int CalculateNumbers(int x, int y)
        {
            Console.WriteLine("Welcome");
            int result1 = base.CalculateNumbers(x, y);
            Console.WriteLine(result1);
            return  99;
        }


        public override void DoMagic()
        {
            Console.WriteLine("Hello ot Intern");
            base.DoMagic();
            Console.WriteLine("Goodbye ot Intern");
        }
    }


    public class Duck
    {
        public Duck(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"I am duck. My name is {Name}";
        }
    }


}

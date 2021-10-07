using System;

namespace s6cpo
{
    public class Personne
    {
        private string name_ { get;}
        private string surname_ { get;}
        private DateTime birthday_ { get; }

        public Personne(string name, string surname, DateTime birthday)
        {
            this.name_ = name;
            this.surname_ = surname;
            this.birthday_ = birthday;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name : {this.name_}\nSurname : {this.surname_}\nBirthday : {this.birthday_.Date}");
        }
    }

    public class Employee : Personne
    {
        private double salary_ { get; }

        public Employee(string name, string surname, DateTime birthday, double salary) : base(name, surname, birthday)
        {
            this.salary_ = salary;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Salary : {this.salary_}");
        }
    }
    public class Chief : Employee
    {
        private string service_ { get; }

        public Chief(string name, string surname, DateTime birthday, double salary, string service) : base(name, surname, birthday, salary)
        {
            this.service_ = service;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Service : {this.service_}");
        }
    }
    public class CEO : Chief
    {
        private string company_ { get; }

        public CEO(string name, string surname, DateTime birthday, double salary, string service, string company) : base(name, surname, birthday, salary, service)
        {
            this.company_ = company;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Company : {this.company_}");
        }
    }
}
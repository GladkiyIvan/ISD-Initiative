using System;

namespace _2._7
{
    class Employee
    {
        public string Name { get; }
        public string Surname { get; }
        public Position EmployeesPosition { get; set; }
        int experience;
        public int Experience
        {
            get { return experience; }
            set
            {
                if (value >= 0 && value <= 50)
                    experience = value;
                else
                    experience = 0;
            }
        }
        public int ExperienceBonus { get; private set; }
        public int Salary { get; private set; }
        public int Tax { get; private set; }

        public Employee() { }
        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Employee(string name, string surname, Position position, int experience) : this(name, surname)
        {
            EmployeesPosition = position;
            Experience = experience;

            GetSalary();
        }

        const int baseSalary = 700;
        const double tax = 0.05;
        void GetSalary()
        {
            if (EmployeesPosition == Position.Junior)
                Salary = baseSalary;
            else if (EmployeesPosition == Position.Middle)
                Salary = (int)(baseSalary * 1.5);
            else
                Salary = (int)(baseSalary * 2.5);

            ExperienceBonus = Salary * baseSalary / 10000;
            Salary += ExperienceBonus;
            Tax = (int)(Convert.ToDouble(Salary) * tax);
        }

        public override string ToString()
        {
            return "Имя: " + Name + "\nФамилия: " + Surname + "\nДолжность: " + EmployeesPosition.ToString() +
                   "\nСтаж: " + Experience + "\nОклад: " + Salary + "$\nНадбавка за стаж: " + ExperienceBonus +
                   "$\nНалог: " + Tax + "$\nПосле вычета налога: " + (Salary - Tax) + "$\n---";
        }
    }
}

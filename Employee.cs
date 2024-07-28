namespace LibraryForPersonnelManagement
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public DateTime HireData { get; set; }
        public bool IsActive {  get; set; }

        public Employee(int id, string firstName, string lastName, int age, string position, decimal salary, string department)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Position = position;
            Salary = salary;
            Department = department;
            HireData = DateTime.Now;
            IsActive = true;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void GetFullInfo()
        {
            Console.WriteLine($"{GetFullName()}:\n Position: {Position}\n Age: {Age}\n Salary: {Salary}\n Department: {Department}\n Hire Data: {HireData}");
        }

        public decimal CalculateBonus(decimal percentSalary, decimal percentTime = 45)
        {
            return percentSalary * Salary + percentTime * DateTime.Now.Subtract(HireData).Days;
        }

        public void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }
    }
}

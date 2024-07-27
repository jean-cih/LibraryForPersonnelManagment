namespace LibraryForPersonnelManagement
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public DateTime HireData { get; set; }
        public bool IsActive {  get; set; }

        public Employee(int id, string firstName, string lastName, string position, decimal salary, string department)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Salary = salary;
            Department = department;
            HireData = DateTime.Now;
            IsActive = true;
        }

        public void GetFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public decimal CalculateBonus(decimal percentage)
        {
            return percentage * Salary;
        }

        public void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }
    }
}

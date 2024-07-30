namespace LibraryForPersonnelManagement
{
    public class Department
    {
        public string Name {  get; set; }
        public List<Manager> Managers { get; set; }
        public List<Employee> Employees { get; set; }

        public Department(string name)
        {
            Name = name;
            Managers = new List<Manager>();
            Employees = new List<Employee>();
        }

        public decimal GetTotalSalary()
        {
            decimal totalSalary = 0;
            foreach (var employee in Employees)
            {
                totalSalary += employee.Salary;
            }

            return totalSalary;
        }
    }
}

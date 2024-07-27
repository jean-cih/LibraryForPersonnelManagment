namespace LibraryForPersonnelManagement
{
    public class Company
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
        public List<Employee> Employees { get; set; }

        public Company(string name)
        {
            Name = name;
            Departments = new List<Department>();
            Employees = new List<Employee>();
        }

        public int GetTotalEmployees()
        {
            return Employees.Count;
        }

        public decimal GetAverageSalary()
        {
            if (GetTotalEmployees() == 0)
                return 0;

            decimal averageSalary = 0;
            foreach (var employee in Employees)
            {
                averageSalary += employee.Salary;
            }

            return averageSalary / GetTotalEmployees();
        }

        public Department GetMostProductiveDepartment()
        {
            if (Departments.Count == 0)
                return null;

            int i = -1;
            decimal totalSalesResult = 0;
            foreach (var department in Departments)
            {
                decimal totalSales = 0;
                foreach(var manager in department.Managers)
                {
                    foreach(var employee in manager.Teams)
                    {
                        if (employee is Salesperson salesperson)
                            totalSales += salesperson.TotalSales;
                    }
                }
                if (totalSalesResult < totalSales)
                {
                    totalSalesResult = totalSales;
                }
                i++;
            }
            return Departments[i];
        }
    }
}

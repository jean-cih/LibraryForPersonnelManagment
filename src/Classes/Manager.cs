namespace LibraryForPersonnelManagement
{
    public class Manager : Employee
    {
        public List<Employee> Teams { get; set; }

        public Manager(int id, string firstName, string lastName, int age, string position, decimal salary, string department)
            : base(id, firstName, lastName, age, position, salary, department)
        {
            Teams = new List<Employee>();

        }

        public int GetTeamSize()
        {
            return Teams.Count;
        }

        public decimal GetAverageSalary()
        {
            decimal general = 0;
            foreach(Employee emp in Teams)
            {
                general += emp.Salary;
            }

            return general / GetTeamSize();
        }
    }
}

namespace LibraryForPersonnelManagement
{
    public class Manager : Employee
    {
        public List<Employee> Teams { get; set; }

        public Manager(int id, string firstName, string lastName, string position, decimal salary, string department, List<Employee> team)
            : base(id, firstName, lastName, position, salary, department)
        {
            Teams = team;
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

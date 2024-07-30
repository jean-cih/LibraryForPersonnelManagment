namespace LibraryForPersonnelManagement
{
    public class Information
    {
        public Information() { }

        public void InformationOfCompanies(List<Company> companies)
        {
            foreach(Company company in companies)
            {
                Console.WriteLine($" \u001b[31mCompany:\u001b[0m {company.Name}");
                Console.WriteLine($"  \u001b[32mDepartments:\u001b[0m {company.GetTotalDepartments()} " +
                    $"\n  \u001b[33mThe G.O.A.T. Department:\u001b[0m {company.GetMostProductiveDepartment().Name}");

                Console.WriteLine($"  \u001b[34mAll The Employees in company:\u001b[0m {company.GetTotalEmployees()} " +
                    $"\n  \u001b[35mThe Average of the salary:\u001b[0m {(int)company.GetAverageSalary()}$");


                foreach(Department department in company.Departments)
                {
                    Console.WriteLine($"\n\t\u001b[32m{department.Name} \u001b[36m- Monthly expenses on Employees:\u001b[0m {department.GetTotalSalary()}$");

                    foreach(Employee employee in department.Employees)
                    {
                        employee.GetFullInfo();

                        if (employee is Manager manager)
                        {
                            Console.WriteLine($"\tIn the team: {manager.GetTeamSize()} person");
                        }
                        else if(employee is Developer developer)
                        {
                            Console.WriteLine($"\tEmployee knows technologies: {developer.GetProgrammingLanguage()}");
                        }
                        else if(employee is Salesperson salesperson)
                        {
                            Console.WriteLine($"\tThe Target Of Sales: {salesperson.SalesTarget} Now Has: {salesperson.TotalSales}");
                        }

                        Console.WriteLine($"\tThe Personal Bonus: {(int)employee.CalculateBonus(1.2m)}$");
                    }
                }
            }
        }
    }
}

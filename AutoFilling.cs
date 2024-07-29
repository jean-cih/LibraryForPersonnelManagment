namespace LibraryForPersonnelManagement
{
    public class AutoFilling
    {
        public AutoFilling()
        {

        }
        public List<Company> AutoFillingProgram()
        {
            string? key = "";

            Task.Run(() => {
                while (key != "`")
                {
                    key = Console.ReadLine();
                }
            });

            Console.WriteLine("\n\t\u001b[31mTap to start any button");
            Console.ReadLine();
            Random rand = new Random();

            List<Company> listCompanies = new List<Company>();

            while (key != "`")
            {
                int numberCompany = rand.Next(0, 20);
                string nameCompany = File.ReadAllLines("..\\..\\..\\Naming\\CompanyName.txt")[numberCompany];
                Company company = new Company(nameCompany.Substring(4, nameCompany.Length - 4));

                Console.WriteLine($"\n\t\u001b[31mNew Company has been created:\u001b[0m {company.Name}");

                Thread.Sleep(1000);

                while (key.ToLower() != "c" && key != "`")
                {
                    int numberDep = rand.Next(0, 11);
                    string nameDepartment = File.ReadAllLines("..\\..\\..\\Naming\\DepartmentName.txt")[numberDep];
                    Department department = new Department(nameDepartment.Substring(4, nameDepartment.Length - 4));

                    company.Departments.Add(department);
                    Console.WriteLine($"\t  \u001b[32mDepartment has been added:\u001b[0m {department.Name}");

                    Thread.Sleep(1000);

                    int i = 0;
                    while (key.ToLower() != "d" && key.ToLower() != "c" && key != "`")
                    {
                        i++;
                        int numberNameManager = rand.Next(0, 50);
                        string[] nameManager = File.ReadAllLines("..\\..\\..\\Naming\\FirstName.txt")[numberNameManager].Split(' ');
                        string[] surnameManager = File.ReadAllLines("..\\..\\..\\Naming\\LastName.txt")[numberNameManager].Split(' ');
                        int ageManager = rand.Next(18, 50);
                        decimal salaryManager = rand.Next(180000, 300000);
                        Manager manager = new Manager(i, nameManager[1], surnameManager[1], ageManager, "Manager", salaryManager, department.Name);

                        department.Managers.Add(manager);
                        department.Employees.Add(manager);
                        company.Employees.Add(manager);
                        Console.WriteLine($"\t    \u001b[33mManager has been hired:\u001b[0m {manager.FirstName} {manager.LastName}  \u001b[33With Salary {manager.Salary}$");

                        Thread.Sleep(1000);

                        while (key.ToLower() != "m" && key.ToLower() != "d" && key.ToLower() != "c" && key != "`")
                        {
                            i++;
                            int numberPos = rand.Next(0, 55);
                            string position = File.ReadAllLines("..\\..\\..\\Naming\\Position.txt")[numberPos];
                            int numberNameEmployee = rand.Next(0, 50);
                            string[] nameEmployee = File.ReadAllLines("..\\..\\..\\Naming\\FirstName.txt")[numberNameEmployee].Split(' ');
                            string[] surnameEmployee = File.ReadAllLines("..\\..\\..\\Naming\\LastName.txt")[numberNameEmployee].Split(' ');
                            int ageEmployee = rand.Next(18, 50);
                            decimal salaryEmployee = rand.Next(50000, 250000);
                            if (position.Contains("Sales"))
                            {
                                decimal salesTarget = rand.Next(1000000, 4000000);
                                Salesperson salesperson = new Salesperson(i, nameEmployee[1], surnameEmployee[1], ageEmployee, position.Substring(4, position.Length - 4), salaryEmployee, department.Name, salesTarget, 0.8m * salesTarget);
                                company.Employees.Add(salesperson);
                                department.Employees.Add(salesperson);
                                manager.Teams.Add(salesperson);
                                Console.WriteLine($"\t\t\u001b[34mSalesperson has been hired for the position\u001b[0m {salesperson.Position}: {salesperson.FirstName} {salesperson.LastName} \u001b[34mWith Salary {salesperson.Salary}$");
                            }
                            else if (position.Contains("Developer"))
                            {
                                int numberLanguage = rand.Next(0, 20);
                                string[] language = File.ReadAllLines("..\\..\\..\\Naming\\TechnologyName.txt")[numberLanguage].Split(' ');
                                int skillLevel = rand.Next(0, 6);
                                Developer developer = new Developer(i, nameEmployee[1], surnameEmployee[1], ageEmployee, position.Substring(4, position.Length - 4), salaryEmployee, department.Name, language[1], skillLevel);
                                company.Employees.Add(developer);
                                department.Employees.Add(developer);
                                manager.Teams.Add(developer);
                                Console.WriteLine($"\t\t\u001b[35mDeveloper has been hired for the position\u001b[0m {developer.Position}: {developer.FirstName} {developer.LastName} \u001b[35mWith Salary {developer.Salary}$");
                            }
                            else
                            {
                                Employee employee = new Employee(i, nameEmployee[1], surnameEmployee[1], ageEmployee, position.Substring(4, position.Length - 4), salaryEmployee, department.Name);
                                company.Employees.Add(employee);
                                department.Employees.Add(employee);
                                manager.Teams.Add(employee);
                                Console.WriteLine($"\t\t\u001b[36mEmployee has been hired for the position\u001b[0m {employee.Position}: {employee.FirstName} {employee.LastName} \u001b[36mWith Salary {employee.Salary}$");
                            }
                            key = "";
                            Thread.Sleep(1000);
                        }
                        if (key.ToLower() == "d" || key.ToLower() == "c" || key == "`")
                            break;
                        key = "";
                        Thread.Sleep(1000);
                    }
                    if (key.ToLower() == "c" || key == "`")
                        break;
                    key = "";
                    Thread.Sleep(1000);
                }

                listCompanies.Add(company);

                if (key.ToLower() == "`")
                    break;
                key = "";
                Thread.Sleep(1000);

            }

            Console.WriteLine("\n\t\u001b[31mAll Objects in this World have been filled in using Autofill\u001b[0m\n");

            return listCompanies;
        }
      
    }
}

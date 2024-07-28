using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace LibraryForPersonnelManagement
{
    public class AutoFilling
    {
        public AutoFilling()
        {

        }

        public void AutoFillingProgram()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            ConsoleKeyInfo emptyInfo = new ConsoleKeyInfo();

            Task.Run(() => {
                cki = Console.ReadKey(true);
            });

            Random rand = new Random();

            while (cki.Key != ConsoleKey.R)
            {
                int numberCompany = rand.Next(0, 20);
                string[] nameCompany = File.ReadAllLines("..\\..\\..\\Naming\\CompanyName.txt")[numberCompany].Split(' ');
                Company company = new Company(nameCompany[1]);

                Console.WriteLine($"\n\tNew Company has been created: {company.Name}");

                while (cki.Key != ConsoleKey.E)
                {
                    int numberDep = rand.Next(0, 11);
                    string[] nameDepartment = File.ReadAllLines("..\\..\\..\\Naming\\DepartmentName.txt")[numberDep].Split(' ');
                    Department department = new Department(nameDepartment[1]);

                    company.Departments.Add(department);
                    Console.WriteLine($"\t\tDepartment has been added: {department.Name}");

                    int i = 0;
                    while (cki.Key != ConsoleKey.W)
                    {
                        i++;
                        int numberNameManager = rand.Next(0, 50);
                        string[] nameManager = File.ReadAllLines("..\\..\\..\\Naming\\FirstName.txt")[numberNameManager].Split(' ');
                        string[] surnameManager = File.ReadAllLines("..\\..\\..\\Naming\\LastName.txt")[numberNameManager].Split(' ');
                        int ageManager = rand.Next(18, 50);
                        decimal salaryManager = rand.Next(180000, 300000);
                        Manager manager = new Manager(i, nameManager[1], surnameManager[1], ageManager, "Manager", salaryManager, department.Name);

                        department.Managers.Add(manager);
                        Console.WriteLine($"\t\tManager has been hired: {manager.FirstName} {manager.LastName}");

                        while(cki.Key != ConsoleKey.Q)
                        {
                            i++;
                            int numberPos = rand.Next(0, 55);
                            string[] position = File.ReadAllLines("..\\..\\..\\Naming\\Position.txt")[numberPos].Split(' ');
                            int numberNameEmployee = rand.Next(0, 50);
                            string[] nameEmployee = File.ReadAllLines("..\\..\\..\\Naming\\FirstName.txt")[numberNameEmployee].Split(' ');
                            string[] surnameEmployee = File.ReadAllLines("..\\..\\..\\Naming\\LastName.txt")[numberNameEmployee].Split(' ');
                            int ageEmployee = rand.Next(18, 50);
                            decimal salaryEmployee = rand.Next(50000, 250000);
                            if (position.Contains("Sales"))
                            {
                                decimal salesTarget = rand.Next(1000000, 4000000);
                                Salesperson salesperson = new Salesperson(i, nameEmployee[1], surnameEmployee[1], ageEmployee, position[1], salaryEmployee, department.Name, salesTarget, 0.8m * salesTarget);
                                company.Employees.Add(salesperson);
                                department.Employees.Add(salesperson);
                                manager.Teams.Add(salesperson);
                                Console.WriteLine($"\t\tSalesperson has been hired for the position {salesperson.Position}: {salesperson.FirstName} {salesperson.LastName}");
                            }
                            else if (position.Contains("Developer"))
                            {
                                int numberLanguage = rand.Next(0, 20);
                                string[] language = File.ReadAllLines("..\\..\\..\\Naming\\TechnologyName.txt")[numberLanguage].Split(' ');
                                int skillLevel = rand.Next(0, 6);
                                Developer developer = new Developer(i, nameEmployee[1], surnameEmployee[1], ageEmployee, position[1], salaryEmployee, department.Name, language[1], skillLevel);
                                company.Employees.Add(developer);
                                department.Employees.Add(developer);
                                manager.Teams.Add(developer);
                                Console.WriteLine($"\t\tDeveloper has been hired for the position {developer.Position}: {developer.FirstName} {developer.LastName}");
                            }
                            else
                            {
                                Employee employee = new Employee(i, nameEmployee[1], surnameEmployee[1], ageEmployee, position[1], salaryEmployee, department.Name);
                                company.Employees.Add(employee);
                                department.Employees.Add(employee);
                                manager.Teams.Add(employee);
                                Console.WriteLine($"\t\tEmployee has been hired for the position {employee.Position}: {employee.FirstName} {employee.LastName}");
                            }


                            cki = emptyInfo;
                            Thread.Sleep(1000);
                        }
                        cki = emptyInfo;
                        Thread.Sleep(1000);
                    }
                    cki = emptyInfo;
                    Thread.Sleep(1000);
                }
                cki = emptyInfo;
                Thread.Sleep(1000);
            }
        }
      
    }
}

namespace LibraryForPersonnelManagement
{
    public class AutoFilling
    {
        public AutoFilling()
        {

        }

        public void AutoFillingProgram()
        {
            Company company = new Company("Jean Inc.");

            Department salesDepartment = new Department("Sales Dep.");
            Department developmentDepartment = new Department("Development Dep.");


        
            Manager salesManager = new Manager(1, "Victoria", "Bone", 36, "Sales Manager", 320000, salesDepartment.Name);
            Manager developmentManager = new Manager(2, "Pavel", "Moan", 25, "Development Manager", 360000, developmentDepartment.Name);


            Employee employee1 = new Employee(3, "Jinx", "Rock", 20, "Software Engineer", 180000, salesDepartment.Name);
            Employee employee2 = new Salesperson(4, "Post", "Monal", 31, "Sales Representative", 160000, salesDepartment.Name, 3000000, 2000000);
            Employee employee3 = new Developer(5, "John", "Postel", 21, "Middle Developer", 160000, developmentDepartment.Name, "Rust", 3);
            Employee employee4 = new Developer(6, "Coin", "Toin", 41, "Senior Software Engineer", 450000, developmentDepartment.Name, "C#", 5);
            
            salesDepartment.Managers.Add(salesManager);
            developmentDepartment.Managers.Add(developmentManager);
            
            salesDepartment.Employees.Add(employee1);
            salesDepartment.Employees.Add(employee2);
            developmentDepartment.Employees.Add(employee3);
            developmentDepartment.Employees.Add(employee4);

            company.Departments.Add(salesDepartment);
            company.Departments.Add(developmentDepartment);
            
            company.Employees.Add(salesManager);
            company.Employees.Add(developmentManager);
            company.Employees.Add(employee1);
            company.Employees.Add(employee2);
            company.Employees.Add(employee3);
            company.Employees.Add(employee4);
        }
      
    }
}

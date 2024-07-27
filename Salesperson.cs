namespace LibraryForPersonnelManagement
{
    public class Salesperson : Employee
    {
        public decimal SalesTarget {  get; set; }
        public decimal TotalSales {  get; set; }

        public Salesperson(int id, string firstName, string lastName, string position, decimal salary, string department, decimal salesTarget, decimal totalSales)
            : base(id, firstName, lastName, position, salary, department)
        {
            SalesTarget = salesTarget;
            TotalSales = totalSales;
        }

        public void IncreaseSalesTarget(decimal amountTarget)
        {
            SalesTarget += amountTarget;
        }

        public void IncreaseSales(decimal amount)
        {
            TotalSales += amount;
        }
    }
}

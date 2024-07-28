namespace LibraryForPersonnelManagement
{
    internal class LibraryForPersonnelManagement
    {
        static void Main(string[] args)
        {
            Employee person = new Employee(1, "Jean", "Pochka", 21, "Developer", 150000, "TeslaImprove");

            Console.ReadLine();
            Console.WriteLine(DateTime.Now.Subtract(person.HireData).Days);
            Console.WriteLine(person.CalculateBonus(0.1m));
        }
    }
}
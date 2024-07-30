namespace LibraryForPersonnelManagement
{
    internal class LibraryForPersonnelManagement
    {
        static void Main(string[] args)
        {
            AutoFilling auto = new AutoFilling();
            List<Company> companies = auto.AutoFillingProgram();

            Information info = new Information();
            info.InformationOfCompanies(companies);
        }
    }
}
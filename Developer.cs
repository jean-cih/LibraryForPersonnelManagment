namespace LibraryForPersonnelManagement
{
    public class Developer : Employee
    {
        public List<string> ProgrammingLanguage { get; set; }
        public List<int> SkillLevel {  get; set; }

        public Developer(int id, string firstName, string lastName, int age, string position, decimal salary, string department, string programmingLanguage, int skillLevel)
            : base(id, firstName, lastName, age, position, salary, department)
        {
            ProgrammingLanguage = new List<string>() { programmingLanguage };
            SkillLevel = new List<int>() { skillLevel };
        }

        public void LearnNewSkill(string skill)
        {
            ProgrammingLanguage.Add(skill);
            SkillLevel.Add(1);
        }

        public void ImproveSkillLevel(string skill)
        {
            int count = 0;
            foreach(var item in ProgrammingLanguage)
            {
                if (skill == ProgrammingLanguage[count])
                    break;
                count++;
            }
            SkillLevel[count]++;
        }
    }
}

using System.Drawing;

namespace English_ZP3_Project.Models
{
    public class Swimmer
    {
        public Swimmer(string first, string last, int birthDay, int month, int year)
        {
            FirstName = first;
            MiddleName = "";
            LastName = last;
            Birthday = SetBirthday(birthDay, month, year);
            Age = SetAge(birthDay, month, year);
        }

        public Swimmer(string first, string middle, string last, int birthDay, int month, int year)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
            Birthday = SetBirthday(birthDay, month, year);
            Age = SetAge(birthDay, month, year);
        }

        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public string Name
        {
            get
            {
                if (MiddleName == null)
                {
                    return FirstName + " " + LastName;
                }
                else
                {
                    return FirstName + " " + MiddleName + " " + LastName;
                }
            }
        }
        public string Initials { get => FirstName[0] + "" + MiddleName[0] + "" + LastName[0]; }

        public string Birthday { get; }
        static string SetBirthday(int birthDate, int month, int year)
        {
            string date = "";

            if (birthDate < 10)
            {
                date += "0";
            }

            date += birthDate + ".";

            if (month < 10)
            {
                date += 0;
            }

            date += month + ".";
            date += year.ToString()[2] + year.ToString()[3];

            return date;
        }

        public int Age { get; }
        static int SetAge(int birthDate, int month, int year)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - year;

            if (today.Month < month || (today.Month == month && today.Day < birthDate))
            {
                age--;
            }

            return age;
        }

        public string Description
        {
            get
            {
                string file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", "biographies", Initials + Birthday + ".txt");
                return System.IO.File.ReadAllText(file);
            }
        }
    }
}

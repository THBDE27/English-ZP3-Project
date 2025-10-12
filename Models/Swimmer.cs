namespace English_ZP3_Project.Models
{
    public class Swimmer
    {
        public Swimmer(string first, string last, int birthDay, int month, int year, string country, int gold, int silver, int bronze)
        {
            FirstName = first;
            MiddleName = "";
            LastName = last;
            Birthday = SetBirthday(birthDay, month, year);
            Age = SetAge(birthDay, month, year);
            Country = country;
        }

        public Swimmer(string first, string middle, string last, int birthDay, int month, int year, string country, int gold, int silver, int bronze)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
            Birthday = SetBirthday(birthDay, month, year);
            Age = SetAge(birthDay, month, year);
            Country = country;
        }

        #region Name
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
        #endregion Name

        #region Birthday
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
        #endregion Birthday

        public string Country { get; set; }

        #region Medals
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Bronze { get; set; }
        #endregion Medals

        #region Text
        public string Facts { get => FillPath("facts"); }

        public string Body { get => FillPath("body"); }

        public string Achievements { get => FillPath("achievements"); }

        public string FillPath(string section)
        {
            string file = Path.Combine(Directory.GetCurrentDirectory(),
                                      "wwwroot",
                                      "files",
                                      "biographies",
                                      section,
                                      Initials +
                                      Birthday +
                                      ".txt");
            return System.IO.File.ReadAllText(file);
        }
        #endregion Text
    }


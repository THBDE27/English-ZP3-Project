using System.CodeDom;
using System.Drawing;

namespace English_ZP3_Project.Models
{
   
    public class Swimmer
    {

        const int FACTS = 0;
        const int BODY = 1;
        const int ACHIEVEMENTS = 2;

        public Swimmer(string first, string last, 
                       int birthDay, int month, int year, 
                       string country, string bestSwim,
                       int gold, int silver, int bronze,
                       bool died)
        {
            FirstName = first;
            MiddleName = "";
            LastName = last;
            Country = country;
            Best = bestSwim;

            Gold = gold;
            Silver = silver;
            Bronze = bronze;

            Birthday = SetBirthday(birthDay, month, year);
            Age = SetAge(birthDay, month, year);
        }

        public Swimmer(string first, string middle, string last, 
                       int birthDay, int month, int year, 
                       string country, string bestSwim,
                       int gold, int silver, int bronze,
                       bool died)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
            Country = country;
            Best = bestSwim;

            Gold = gold;
            Silver = silver;
            Bronze = bronze;

            Birthday = SetBirthday(birthDay, month, year);
            Age = SetAge(birthDay, month, year);
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
        public string Initials
        {
            get
            {
                if (MiddleName == "")
                {
                    return FirstName[0] + "" + LastName[0];
                }
                else
                {
                    return FirstName[0] + "" + MiddleName[0] + "" + LastName[0];
                }
            }
        }
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

        public bool Passed { get; set; }
        #endregion Birthday

        public string Country
        {
            get;set;
        }

        public string Best { get; set; }

        #region Medals
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Bronze { get; set; }
        #endregion Medals

        #region Text
        public string Facts { get => Information[FACTS]; }

        public string Body { get => Information[BODY]; }

        public string Achievements { get => Information[ACHIEVEMENTS]; }

        public string FilePath
        {
            get => GetPath("files", "txt");
        }
       

        public string[] Information
        {
            get
            {
                string text = File.ReadAllText(FilePath);

                return [.. text
                .Split(new string[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())];
            }
        }

        public string Image
        {
            get => GetPath("images", "png");
        }

#endregion Text

        // METHODS
        string GetPath(string folder, string type)
        {
            return Path.Combine(Directory.GetCurrentDirectory(),
                                          "wwwroot",
                                          folder,
                                          "biographies",
                                          Initials +
                                          Birthday +
                                          "." +
                                          type);
        }



    }
}


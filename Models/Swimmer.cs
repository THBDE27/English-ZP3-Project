using Microsoft.AspNetCore.Mvc.Abstractions;

namespace English_ZP3_Project.Models
{
    public class Swimmer
    {
        public Swimmer(string first, string last)
        {
            FirstName = first;
            MiddleName = "";
            LastName = last;
        }

        public Swimmer(string first, string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Name
        {
            get
            {
                return FirstName + " " + MiddleName + " " + LastName;
            }
        }


        public string Initials
        {
            get
            {
                return FirstName[0] + "" + MiddleName[0] + "" + LastName[0];
            }
        }

        public string Description
        {
            get
            {
                string file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", "biographies", Initials + ".txt");
                return System.IO.File.ReadAllText(file);
            }
        }
    }
}

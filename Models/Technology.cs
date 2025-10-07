using System.Drawing;

namespace English_ZP3_Project.Models
{
    public class Technology
    {

        public Technology(string fileName)
        {
            FileName = fileName;
        }

        public string FileName { get; set; }
        public string Name
        {
            get
            {
                string name = FileName;
                int i = 1;

                do
                {
                    if (char.IsUpper(name[i]) || name[i] == ':')
                    {
                        name.Insert(i, " ");
                        ++i;
                    }
                    ++i;
                }
                while (i < name.Length);
                return name;
            }
        }
        public string Info
        {
            get
            {
                string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");
                string file = Path.Combine(folderPath, FileName);
                return System.IO.File.ReadAllText(file);
            }
        }
    }
}


using System.Drawing;

namespace English_ZP3_Project.Models
{
    public class Technology
    {

        public Technology(string path)
        {
            FilePath = path;
        }

        public string FilePath { get; set; }
        public string FileName
        {
            get
            {
                return Path.GetFileName(FilePath);
            }
        }
        public string Name
        {
            get
            {
                string name = FileName;
                int i = 1;

                name = name.Replace(Date, "");
                name = name.Replace(".txt", "");
                do
                {
                    if (char.IsUpper(name[i]) || name[i] == ':')
                    {
                        name = name.Insert(i, " ");
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
                return System.IO.File.ReadAllText(FilePath);
            }
        }
        public string Date
        {
            get
            {
                string date = FileName;
                bool isDate = true;
                int i = 0;

                while (isDate)
                {
                    if (char.IsUpper(date[i]))
                    {
                        isDate = false;
                        date = date.Remove(i);
                    }
                    else
                    {
                        i++;
                    }
                }
                return date;
            }
        }
    }
}
using System.Drawing;

namespace English_ZP3_Project.Models.Technologies
{
    public class TechUpdate
    {
        
        public TechUpdate(string path)
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

                name = name.Replace(".txt", "");
                char stopChar = '-';

                int index = name.IndexOf(stopChar);
                string result = index >= 0 ? name.Substring(index + 1) : name;
                for (int i = 1; i<result.Length; i++)
                {
                    if (char.IsUpper(result[i]))
                    {
                        result = result.Insert(i, " ");
                        i += 2;
                    }
                }

                return result;
            }
        }
        public string Info
        {
            get
            {
                return File.ReadAllText(FilePath);
            }
        }
        
        }
    }

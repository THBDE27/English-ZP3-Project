namespace English_ZP3_Project.Models
{
    public class ReportFile
    {
        public ReportFile(string path)
        {
            FilePath = path;
        }

        public string FilePath { get; set; }

        public string DisplayName
        {
            get
            {
                string name = Path.GetFileNameWithoutExtension(FilePath);

                name = name.Replace("Report", " Report");
                return name;
            }
        }

        public string Name {  get => Path.GetFileName(FilePath); }

        public string Url
        {
            get
            {
                return "/files/reports/" + Name;
             
            }
        }
    }
}

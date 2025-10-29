namespace English_ZP3_Project.Models.Technologies
{
    public class Technology
    {
        private readonly IWebHostEnvironment _env;

        public Technology(string id, IWebHostEnvironment env)
        {
            _env = env;
            Name = id;
        }

        public string Name { get; set; }

        public string FolderPath { get => Path.Combine(_env.WebRootPath, "files", "technologies", Name); }

        public List<TechUpdate> Updates
        {
            get
            {
                string[] fileNames = Directory.GetFiles(FolderPath, "*.txt");
                List<TechUpdate> files = new();

                foreach (string fileName in fileNames)
                {
                    files.Add(new TechUpdate(fileName));
                }
                return files;
            }
        }
    }
}

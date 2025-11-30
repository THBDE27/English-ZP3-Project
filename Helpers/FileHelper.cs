using English_ZP3_Project.Models;

namespace English_ZP3_Project.Helpers
{
    public class FileHelper
    {
        private readonly string _webRootPath;

        public FileHelper(IWebHostEnvironment env)
        {
            _webRootPath = env.WebRootPath;
        }


        public List<string> GetFileNames(string relativeFolderPath, string extension)
        {
            string startFolder = Path.Combine(_webRootPath, relativeFolderPath);

            if (!Directory.Exists(startFolder))
                return new List<string>();

            List<string> allFolders = new List<string>();
            allFolders.AddRange(Directory.GetFiles(startFolder, "*" + extension, SearchOption.AllDirectories));

            List<string> names = new List<string>();
            foreach (var folder in allFolders)
            {
                names.Add(Path.GetFileName(folder));
            }
            return names;
        }


        public List<string> GetVideoSources(string folderPath)
        {
            List<string> srcs = new();
           
            foreach (string name in GetFileNames(folderPath, "mp4"))
            {
                srcs.Add("/videos/" + name);
            }
            return srcs;
        }
}
}

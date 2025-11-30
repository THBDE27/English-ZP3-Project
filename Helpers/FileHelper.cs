using English_ZP3_Project.Models;

namespace English_ZP3_Project.Helpers
{
    public class FileHelper(IWebHostEnvironment env)
    {
        private readonly string _webRootPath = env.WebRootPath;

        public List<string> GetFileNames(string relativeFolderPath, string extension)
        {
            string startFolder = Path.Combine(_webRootPath, relativeFolderPath);

            if (!Directory.Exists(startFolder))
                return [];

            List<string> allFolders = [.. Directory.GetFiles(startFolder, "*" + extension, SearchOption.AllDirectories)];

            List<string> names = [];
            foreach (var folder in allFolders)
            {
                names.Add(Path.GetFileName(folder));
            }
            return names;
        }


        public List<string> GetVideoSources(string folderPath)
        {
            List<string> srcs = [];
           
            foreach (string name in GetFileNames(folderPath, "mp4"))
            {
                srcs.Add("/videos/" + name);
            }
            return srcs;
        }
}
}

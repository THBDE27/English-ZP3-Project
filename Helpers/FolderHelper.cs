namespace English_ZP3_Project.Helpers
{
    using Microsoft.AspNetCore.Hosting;
    using System.Collections.Generic;
    using System.IO;
    using static NuGet.Packaging.PackagingConstants;

    public class FolderHelper(IWebHostEnvironment env)
    {
        private readonly string _webRootPath = env.WebRootPath;

        public List<string> GetSubFolderNames(string relativeFolderPath)
        {
            string startFolder = Path.Combine(_webRootPath, relativeFolderPath);

            if (!Directory.Exists(startFolder))
                return []; 

            List<string> allFolders = [.. Directory.GetDirectories(startFolder, "*", SearchOption.AllDirectories)];

            List<string> names = [];
            foreach (var folder in allFolders)
            {
                names.Add(Path.GetFileName(folder));
            }
            return names;
        }
    }

}

namespace English_ZP3_Project.Helpers
{
    using Microsoft.AspNetCore.Hosting;
    using System.Collections.Generic;
    using System.IO;
    using static NuGet.Packaging.PackagingConstants;

    public class FolderHelper
    {
        private readonly string _webRootPath;

        public FolderHelper(IWebHostEnvironment env)
        {
            _webRootPath = env.WebRootPath;
        }

       
        public List<string> GetSubFolderNames(string relativeFolderPath)
        {
            string startFolder = Path.Combine(_webRootPath, relativeFolderPath);

            if (!Directory.Exists(startFolder))
                return new List<string>(); 

            List<string> allFolders = new List<string> ();
            allFolders.AddRange(Directory.GetDirectories(startFolder, "*", SearchOption.AllDirectories));

            List<string> names = new List<string>();
            foreach (var folder in allFolders)
            {
                names.Add(Path.GetFileName(folder));
            }
            return names;
        }
    }

}

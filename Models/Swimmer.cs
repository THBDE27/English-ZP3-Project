using System.CodeDom;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace English_ZP3_Project.Models
{
   
    public class Swimmer
    {

        const int FACTS = 0;
        const int ACHIEVEMENTS = 1;
        const int SPECIALIZATION = 2;
        const int BIOLOGY = 3;

        public Swimmer(string first, string last, 
                       int birthDay, int month, int year, 
                       string country, string bestSwim,
                       int gold, int silver, int bronze,
                       bool died)
        {
            FirstName = first;
            MiddleName = "";
            LastName = last;
            Country = country;
            Best = bestSwim;

            Gold = gold;
            Silver = silver;
            Bronze = bronze;

            Birthday = SetBirthday(birthDay, month, year);
            Age = SetAge(birthDay, month, year);
            Passed = died;
        }

        public Swimmer(string first, string middle, string last, 
                       int birthDay, int month, int year, 
                       string country, string bestSwim,
                       int gold, int silver, int bronze,
                       bool died)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
            Country = country;
            Best = bestSwim;

            Gold = gold;
            Silver = silver;
            Bronze = bronze;

            Birthday = SetBirthday(birthDay, month, year);
            Age = SetAge(birthDay, month, year);
            Passed = died;
        }
        
        
        

        #region Name


        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public string Name
        {
            get
            {
                if (MiddleName == null)
                {
                    return FirstName + " " + LastName;
                }
                else
                {
                    return FirstName + " " + MiddleName + " " + LastName;
                }
            }
        }
        public string Initials
        {
            get
            {
                if (MiddleName == "")
                {
                    return FirstName[0] + "" + LastName[0];
                }
                else
                {
                    return FirstName[0] + "" + MiddleName[0] + "" + LastName[0];
                }
            }
        }
        #endregion Name

        #region Birthday
        public string Birthday { get; }
        static string SetBirthday(int birthDate, int month, int year)
        {
            string date = "";

            if (birthDate < 10)
            {
                date += "0";
            }

            date += birthDate + ".";

            if (month < 10)
            {
                date += 0;
            }

            date += month + ".";
            date += year.ToString()[2];
            date+= year.ToString()[3];

            return date;
        }
        public int Age { get; }
        static int SetAge(int birthDate, int month, int year)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - year;

            if (today.Month < month || (today.Month == month && today.Day < birthDate))
            {
                age--;
            }

            return age;
        }

        public bool Passed { get; set; }
        #endregion Birthday

        public string Country
        {
            get;set;
        }

        public string Best { get; set; }

        #region Medals
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Bronze { get; set; }
        #endregion Medals

        #region Text




        public string FilePath
        {
            get => GetPath("files", "txt");
        }

        // caches to avoid re-reading file repeatedly
        private string _infoCachedPath = string.Empty;
        private string[]? _informationCache;
        private string[]? _subtitlesCache;

        // Returns paragraphs with leading "(Title)" removed.
        public string[] Information
        {
            get
            {
                EnsureParsed();
                return _informationCache ?? Array.Empty<string>();
            }
        }

        // Returns the titles that were inside parentheses at the start of each paragraph.
        // If a paragraph had no title, the corresponding entry is an empty string.
        public string[] Subtitles
        {
            get
            {
                EnsureParsed();
                return _subtitlesCache ?? Array.Empty<string>();
            }
        }

        private static readonly Regex _leadingTitleRx = new Regex(@"^\s*[\(\uFF08]([^)\uFF09]+)[\)\uFF09]\s*", RegexOptions.Compiled | RegexOptions.CultureInvariant);

private void EnsureParsed()
{
    var path = FilePath ?? "";
    if (string.Equals(path, _infoCachedPath, StringComparison.OrdinalIgnoreCase) && _informationCache != null && _subtitlesCache != null)
        return;

    _infoCachedPath = path;
    var paras = new List<string>();
    var subs = new List<string>();

    if (!System.IO.File.Exists(path))
    {
        _informationCache = Array.Empty<string>();
        _subtitlesCache = Array.Empty<string>();
        return;
    }

    string text;
    try { text = System.IO.File.ReadAllText(path); }
    catch { text = string.Empty; }

    var split = text
        .Split(new string[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries)
        .Select(p => p.Trim())
        .ToArray();

    foreach (var p in split)
    {
        if (string.IsNullOrWhiteSpace(p))
        {
            paras.Add(string.Empty);
            subs.Add(string.Empty);
            continue;
        }

        var s = p;
        string title = string.Empty;

        // New: use regex to capture leading "(Title)" (supports ASCII and fullwidth parentheses), and allows leading whitespace
        var m = _leadingTitleRx.Match(s);
        if (m.Success)
        {
            title = m.Groups[1].Value.Trim();
            s = s.Substring(m.Length).TrimStart();
        }

        subs.Add(title);
        paras.Add(s);
    }

    _informationCache = paras.ToArray();
    _subtitlesCache = subs.ToArray();
}

        public string Image
        {
            get => GetPath("images", "png");
        }

        public string ID { get => Initials + Birthday + ""; }

#endregion Text

        // METHODS
        string GetPath(string folder, string type)
        {
            return Path.Combine(Directory.GetCurrentDirectory(),
                                          "wwwroot",
                                          folder,
                                          "biographies",
                                          ID +
                                          "." +
                                          type);
        }



    }
}


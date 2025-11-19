using Humanizer;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Mono.TextTemplating;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;

namespace English_ZP3_Project.Models
{
    public class Word
    {
        string _text = " ";
        public string Text
        {
            get => _text
            ; set
            {
                _text = value;
            }
        }            
        public string? Plural { get; set; }
        public string Definition { get; set; }
        public string WordClass { get; set; }
        public string Id { get; set; }
        public string Link { get; set; }

        // Constructor
        public Word(string text, string definition, string wordClass)
        {
            Text = text;
            Definition = definition;
            WordClass = wordClass;

            // Normalize id: lowercase, remove all non-alphanumeric characters
            Id = Regex.Replace(Text.ToLowerInvariant(), @"[^a-z0-9]", "");
            Link = $"/Conclusion/Glossary#{Id}";
        }

        // Glossary words
        public static List<Word> GetGlossary()
        {
           List<Word> words = new
           List<Word>
            {
               new Word("neuromuscular coordination", " It is the brain-to-muscle communication that allows the body to execute movement effectively. It is the harmonious interaction between the nervous system and the muscles. ", "noun"),
 new Word("central nervous system", "It is the main control center of the body. It is made up of two primary structures: the brain and the nervous system. It receives sensory input, processes the information, and sends out motor signals to control the body’s actions and functions. ", "noun"),
 new Word("fast-twitch muscle fiber", "Also known as “Type II fibers” are muscle cells specialized for short, powerful, and explosive movements. They are the “sprint” muscles, designed for speed and strength rather than endurance. ", "noun"),
 new Word("polyurethane", "It is a highly versatile class of polymers (a type of plastic) known for its ability to be customized into materials ranging from soft, flexible foam, to hard, durable solid. ", "noun"),
 new Word("hydrophobic", "Meaning water-fearing. In the context of chemistry and materials science, it describes a substance, molecule, or surface that lacks an affinity for water and tends to repel it. ", "adjective"),
 new Word("lactic acid", "It is a chemical byproduct created when the body’s cell (like muscle cells or red blood cells) or certain bacteria break down from glucose for energy without enough oxygen. It is produced rapidly during intense exercise when oxygen supply can’t keep up with energy demand. It is quickly converted to lactate and used by other cells as an alternative fuel source.  ", "noun"),
 new Word("FINA", "Stands for “International Swimming Federation”. It was the original name of the international governing body for aquatic sports. It was the organization responsible for establishing the rules, verifying world records, and managing the international competitions for all the aquatic sports. In December 2022, they officially rebranded and changed their name to “World Aquatics”. ", "organization"),
new Word("NCAA", "Stands for “National Collegiate Athletic Association“. It is a non-profit organization that regulates and organizes student athletics over 1,100 colleges and universities in the United States. It governs the eligibility, competition, and championships for close to a million college athletes across three divisions", "organization"), 
new Word("distance swimming", "Groups the freestyle events of a longer distance: the 200m, 400m, 800m, 1500m events. They require more endurance and pacing", "noun"),
new Word("sprint swimming", "Groups the distances of the 50m and 100m of all strokes. They require more explosivity and aggressiveness", "noun"),
new Word("aerobic capacity", "It is the maximum rate at which the body can effectively use oxygen during intense, sustained exercise and the ability of the cardiovascular and respiratory systems to supply oxygen to the muscles", "noun"),
new Word("anchored", "The action of closing the relay team, holding down the effort for a strong finish to the wall during your part of the race, anchoring", "verb"),
new Word("short course", "Meaning that the distances swam are in a 25-meter pool", "noun"),
new Word("long course", "Meaning that the distances swam are in a 50-meter pool", "noun"),
 new Word("a-final", "It is the last and most important race of a specific event at a competition where the podium medals are awarded afterwards and features the fastest (top 8) after the preliminaries, quarterfinals and semi-finals.  ", "noun"),
 new Word("freestyle", "Also known as crawl or front crawl. It is the fastest and the most popular swimming stroke. It is a stroke performed face down and it is characterized by an alternating overarm movement combined with an alternating up and down kick.", "noun"),
 new Word("backstroke", "It is the only competitive swimming stroke performed on the back. Characterized by an alternating overarm movement and alternating up and down kick. This stroke allows for easy breathing, which makes it a popular stroke for rest and recreation.", "noun"),
 new Word("breaststroke", "It is the slowest competitive stroke. Breaststroke is performed face down characterized by its simultaneous arm movement and frog like leg movements. The arms always stay underwater", "noun"),
 new Word("butterfly", "Swimming stroke performed face down. Characterized by a simultaneous overarm movement and a simultaneous dolphin like kick.", "noun"),
 new Word("individual medley", "Involves the four swimming strokes in a specific order: butterfly, backstroke, breaststroke, and freestyle", "noun"),
 new Word("drag", "Resistance caused by the water slowing the swimmer down. Drag depends on the position of the swimmer, the speed, the equipment used and the technique.", "noun"),
 new Word("momentum", "Forward movement generated by the arms or the kick.", "noun"),
 new Word("streamline position", "Body position that creates the least amount of resistance, in which the swimmer’s body is in a long and stretched position. The arms are overhead with the hand on top of each other, biceps are tucked against the eras, the chin is tucked, the legs are straight and toes are pointed. This position is used at the start of a race, after a turn and during glide phases.", "noun"),
 new Word("propulsive phase", "Part of the stroke where the swimmer generates forward movement by pushing against the water with its arms and legs.", "noun"),
 new Word("glide phase", "Part of the stroke where the swimmer stays in a streamlined position and moves through the water without doing any movement to conserve momentum. The glide phase often comes after a turn or between stroke cycles.", "noun"),
new Word("recovery phase", " Part of the stroke where the swimmer brings its arm back to the front to prepare for the next stroke.", "noun"),
new Word("Swedish goggle", "A classic, minimalist, and low-profile swimming goggle, originally designed in the 1970s. They have no gaskets nor seals, using pressure and suction for a watertight seal and have a custom assembly for a perfect fit on a swimmer’s face.", "noun"),
new Word("resistance training", "Type of training where swimmers intentionally use factors to create more drag in order to increase strength, endurance and power.", "noun"),
new Word("major muscles group", " Major muscles group: The five major muscles group are: chest, back, arms abdominals, legs and shoulders. These muscles are essential for exercise and movement. ", "noun"),
new Word("low impact exercise", "Activity that puts less stress or pressure on the articulations while still building strength and improving cardiovascular health. The most known are swimming, walking and cycling. ", "noun"),
new Word("arthritis", "Disease that often affects people over the age of 50 and that cause the swelling, stiffness or pain of one or more joint.  The joints commonly affected are the knees, hips, feet, ankles, hands, wrists, lower back and shoulders. There’s a lot of types of arthritis, but the most common one is osteoporosis which breaks down the cartilage that protects the joint at the end of the bone over time. ", "noun "),
new Word("stroke", "Methods of moving the body through the water by repeating a specific movement that typically involves the arms and the legs. Competitive swimming has four strokes: freestyle, backstroke, breaststroke and butterfly. ", "noun "),
new Word("wingspan", " The length from one hand to the other when both arms are raised at shoulder height. ", "noun"),
new Word("hyperextended", " When a joint moves past its normal range of motion. ", "adjective"),
new Word("touchpad", "electronic pad placed at the end of the pool that records the split times and finish time of the swimmer and are activated by the swimmer touching them. ", "noun"),
new Word("limited mobility", "difficulty in moving freely or without pain due to a physical disability. Can be caused by aging, chronic illnesses or injuries.", "noun"),
new Word("start", "Beginning of a race where the swimmers dive off the blocks at the signal which is a loud noise and a flash.", "noun"),
new Word("turn", "Change of direction when the swimmer reaches the wall at the end of the pool, but still has more lengths to do. ", "noun"),
new Word("block", "Raised platform at one end of the pool used for the swimmer to dive off when starting the race. Usually covered in an anti slippering coating with a wedge for the swimmer to rest on of its feet on. Blocks often have a handle just above water level for backstroke starts, where the swimmers start the race already in water. ", "noun"),
new Word("sprint velocity", "Speed of the swimmer over a really short distance. Influenced by technique and power. Often expressed as meters per second. ", "noun ")

            };

            return words.OrderBy(p => p.Text).ToList();
        }
    }
    public class RelatedWord
    {
        string _text = " ";
        public string Text
        {
            get => _text
            ; set
            {
                _text = value;
            }
        }            
        public string Original { get; set; }
    

        // Constructor
        public RelatedWord(string text, string original) 
            
        {
            Text = text;
            Original = original;
            
        }

        public static List<RelatedWord> GetRelatedWords()
        {
            List<RelatedWord> rw = new();
            char[] punctuation = new[] {'.', ',','?','!','"', ')', 's' };
            foreach (Word w in Word.GetGlossary())
            {
                    rw.Add(new(w.Text, w.Text));

                
            }
            foreach (Word w in Word.GetGlossary())
            {
                foreach (char p in punctuation)
                {
                    rw.Add(new(w.Text+"" + p, w.Text));

                }
                rw.Add(new("(" + w.Text, w.Text));
            }
            // Use a snapshot of the current list to generate additional forms without causing recursion.
            var snapshot = rw.ToList();
            foreach (RelatedWord w in snapshot)
            {
                foreach (char p in punctuation)
                {
                    rw.Add(new(w.Text + "s" + p, w.Original));
                }
            }

            return rw;
        }

        // New: scan Views for first occurrence of each glossary word and return a map word -> link
        public static Dictionary<string, string> BuildFirstAppearanceMap(string viewsRoot)
        {
            var map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            if (string.IsNullOrEmpty(viewsRoot) || !Directory.Exists(viewsRoot)) return map;

            var glossary = Word.GetGlossary();

            // Build variant -> original map (includes RelatedWord variants)
            var variantToOriginal = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var w in glossary) variantToOriginal[w.Text] = w.Text;
            foreach (var rel in RelatedWord.GetRelatedWords())
            {
                if (!string.IsNullOrWhiteSpace(rel.Text) && !string.IsNullOrWhiteSpace(rel.Original))
                    variantToOriginal[rel.Text] = rel.Original;
            }

            var projectRoot = Directory.GetParent(viewsRoot)?.FullName ?? viewsRoot;
            var wwwroot = Path.Combine(projectRoot, "wwwroot");

            // Index cshtml files and their content
            var cshtmlContent = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            try
            {
                var cshtmlFiles = Directory.GetFiles(viewsRoot, "*.cshtml", SearchOption.AllDirectories);
                foreach (var csf in cshtmlFiles)
                {
                    var fileName = Path.GetFileName(csf);
                    if (fileName.StartsWith("_", StringComparison.OrdinalIgnoreCase)) continue;
                    if (fileName.Equals("Glossary.cshtml", StringComparison.OrdinalIgnoreCase)) continue;
                    string content;
                    try { content = File.ReadAllText(csf); }
                    catch { continue; }
                    cshtmlContent[csf] = content;
                }
            }
            catch
            {
                // no cshtml to scan
            }

            // Helper to build route for a cshtml path
            static string RouteForCshtml(string viewsRootLocal, string file)
            {
                var relative = Path.GetRelativePath(viewsRootLocal, file).Replace(Path.DirectorySeparatorChar, '/');
                var rootName = Path.GetFileName(viewsRootLocal.TrimEnd(Path.DirectorySeparatorChar));
                if (string.Equals(rootName, "Pages", StringComparison.OrdinalIgnoreCase))
                {
                    var r = relative.Replace(".cshtml", "");
                    if (r.EndsWith("/Index", StringComparison.OrdinalIgnoreCase))
                        r = r.Substring(0, r.Length - "/Index".Length);
                    return "/" + r.Trim('/');
                }
                else
                {
                    var parts = relative.Split('/');
                    var controller = parts.Length >= 1 ? parts[0] : "Home";
                    var action = Path.GetFileNameWithoutExtension(parts[parts.Length - 1]);
                    return $"/{controller}/{action}";
                }
            }

            static bool IsForbidden(string route)
            {
                if (string.IsNullOrWhiteSpace(route)) return true;
                var r = route.Split('#')[0].Trim();
                if (string.IsNullOrEmpty(r)) return true;
                if (string.Equals(r, "/", StringComparison.OrdinalIgnoreCase)) return true;
                if (r.EndsWith("/Index", StringComparison.OrdinalIgnoreCase)) return true;
                if (r.IndexOf("/Conclusion", StringComparison.OrdinalIgnoreCase) >= 0) return true;
                return false;
            }

            // 1) FIRST: look for explicit data-glossary markers in cshtml
            var dataAttrRx = new Regex(@"data-glossary\s*=\s*""([^""]+)""", RegexOptions.IgnoreCase);
            foreach (var kv in cshtmlContent)
            {
                var csPath = kv.Key;
                var csText = kv.Value;
                var m = dataAttrRx.Match(csText);
                if (!m.Success) continue;

                var list = m.Groups[1].Value.Split(',', StringSplitOptions.RemoveEmptyEntries);
                var route = RouteForCshtml(viewsRoot, csPath);
                if (IsForbidden(route)) continue;

                foreach (var raw in list)
                {
                    var term = raw.Trim();
                    if (string.IsNullOrEmpty(term)) continue;

                    if (!variantToOriginal.TryGetValue(term, out var original)) continue;
                    if (map.ContainsKey(original)) continue;

                    var safeId = Regex.Replace(original.ToLowerInvariant(), @"[^a-z0-9]", "");
                    map[original] = $"{route}#{safeId}";

                    // stop early if all assigned
                    if (map.Count >= glossary.Count) return map;
                }
            }

            // 2) FALLBACK: scan cshtml content for terms/variants (prefer pages that contain the text)
            // build regexes for all variants
            var termRegexes = new Dictionary<string, Regex>(StringComparer.OrdinalIgnoreCase);
            foreach (var term in variantToOriginal.Keys)
            {
                termRegexes[term] = new Regex($@"(?<!\w){Regex.Escape(term)}(?!\w)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
            }

            foreach (var kv in cshtmlContent)
            {
                var csPath = kv.Key;
                var csText = kv.Value;

                foreach (var tr in termRegexes)
                {
                    if (!tr.Value.IsMatch(csText)) continue;

                    if (!variantToOriginal.TryGetValue(tr.Key, out var original)) continue;
                    if (map.ContainsKey(original)) continue;

                    var route = RouteForCshtml(viewsRoot, csPath);
                    if (IsForbidden(route)) continue;

                    var safeId = Regex.Replace(original.ToLowerInvariant(), @"[^a-z0-9]", "");
                    map[original] = $"{route}#{safeId}";

                    if (map.Count >= glossary.Count) return map;
                }
            }

            // 3) LAST: inspect .txt files (only if a cshtml references the txt filename OR that cshtml contains the term)
            try
            {
                var txtFiles = Directory.GetFiles(projectRoot, "*.txt", SearchOption.AllDirectories);
                foreach (var txt in txtFiles)
                {
                    string txtContent;
                    try { txtContent = File.ReadAllText(txt); }
                    catch { continue; }

                    foreach (var tr in termRegexes)
                    {
                        if (!tr.Value.IsMatch(txtContent)) continue;
                        if (!variantToOriginal.TryGetValue(tr.Key, out var original)) continue;
                        if (map.ContainsKey(original)) continue;

                        // find cshtml that references this txt filename or contains the term
                        var txtName = Path.GetFileName(txt);
                        string chosenCs = null;
                        foreach (var cs in cshtmlContent)
                        {
                            if (cs.Value.IndexOf(txtName, StringComparison.OrdinalIgnoreCase) >= 0
                                || termRegexes[tr.Key].IsMatch(cs.Value))
                            {
                                chosenCs = cs.Key;
                                break;
                            }
                        }

                        if (string.IsNullOrEmpty(chosenCs)) continue;
                        var route = RouteForCshtml(viewsRoot, chosenCs);
                        if (IsForbidden(route)) continue;

                        var safeId = Regex.Replace(original.ToLowerInvariant(), @"[^a-z0-9]", "");
                        map[original] = $"{route}#{safeId}";

                        if (map.Count >= glossary.Count) return map;
                        break;
                    }
                }
            }
            catch
            {
                // ignore txt scanning errors
            }

            return map;
        }

    }
}










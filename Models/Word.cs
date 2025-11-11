using System.Collections.Generic;

namespace English_ZP3_Project.Models
{
    public class Word
    {
        public string Text { get; set; }
        public string? Plural { get; set; }
        public string Definition { get; set; }
        public string WordClass { get; set; }
        public string Id { get; set; }      // unique bookmark ID
        public string Link { get; set; }    // absolute link to glossary with bookmark

        // Constructor
        public Word(string text, string definition, string wordClass, string? plural = null)
        {
            Text = " " + text;
            Definition = definition;
            WordClass = wordClass;
            Plural = plural;
            
            Id =  Text.Replace(" ", "").ToLower();        // simple ID, lowercase
            Link = $"/Conclusion/Glossary#{Id}";       // absolute path
        }

        // Returns all words for the glossary
        public static List<Word> GetGlossary()
        {
            return new List<Word>
            {
                new Word("neuromuscular coordination", "Brain-to-muscle communication...", "noun"),
                new Word("central nervous system", "Main control center of the body...", "noun"),
                new Word("fast-twitch muscle fiber", "Specialized for short, powerful movements.", "noun", "fast-twitch muscle fibers"),
                new Word("polyurethane", "Versatile polymer...", "noun"),
                new Word("hydrophobic", "Water-fearing...", "adjective"),
                new Word("lactic acid", "Byproduct when cells break down glucose without oxygen.", "noun", "lactic acids"),
                new Word("FINA", "International Swimming Federation, now World Aquatics.", "organization"),
                new Word("resistance", "Opposition a body encounters moving through a medium.", "noun")
            };
        }
    }
}

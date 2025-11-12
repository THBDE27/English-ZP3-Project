using Humanizer;
using Humanizer.Localisation;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.Extensions.Logging;
using Mono.TextTemplating;
using NuGet.Protocol;
using System;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace English_ZP3_Project.Models
{
    public class Word
    {
        public string Text { get; set; }
        public string? Plural { get; set; }
        public string Definition { get; set; }
        public string WordClass { get; set; }
        public string Id { get; set; }
        public string Link { get; set; }

        // Constructor
        public Word(string text, string definition, string wordClass, string? plural = null)
        {
            Text = text;
            Definition = definition;
            WordClass = wordClass;
            Plural = plural;

            Id = Text.Replace(" ", "").ToLower();
            Link = $"/Conclusion/Glossary#{Id}";
        }

        // Glossary words
        public static List<Word> GetGlossary()
        {
            return new List<Word>
            {
                new Word("neuromuscular coordination", " It is the brain-to-muscle communication that allows the body to execute movement effectively. It is the harmonious interaction between the nervous system and the muscles. ", "noun"),
                new Word("central nervous system", "It is the main control center of the body. It is made up of two primary structures: the brain and the nervous system. It receives sensory input, processes the information, and sends out motor signals to control the body’s actions and functions. ", "noun"),
                new Word("fast-twitch muscle fiber", "Also known as “Type II fibers” are muscle cells specialized for short, powerful, and explosive movements. They are the “sprint” muscles, designed for speed and strength rather than endurance. ", "noun", "fast-twitch muscle fibers"),
                new Word("polyurethane", "It is a highly versatile class of polymers (a type of plastic) known for its ability to be customized into materials ranging from soft, flexible foam, to hard, durable solid. ", "noun"),
                new Word("hydrophobic", "Meaning water-fearing. In the context of chemistry and materials science, it describes a substance, molecule, or surface that lacks an affinity for water and tends to repel it. ", "adjective"),
                new Word("lactic acid", "It is a chemical byproduct created when the body’s cell (like muscle cells or red blood cells) or certain bacteria break down from glucose for energy without enough oxygen. It is produced rapidly during intense exercise when oxygen supply can’t keep up with energy demand. It is quickly converted to lactate and used by other cells as an alternative fuel source.  ", "noun", "lactic acids"),
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
                new Word("individual medley", "Involves the four swimming strokes in a specific order: butterfly, backstroke, breastroke, and freestyle", "noun"),
                new Word("drag", "Resistance caused by the water slowing the swimmer down. Drag depends on the position of the swimmer, the speed, the equipment used and the technique.", "noun"),
                new Word("momentum", "Forward movement generated by the arms or the kick.", "noun"),
                new Word("streamline position", "Body position that creates the least amount of resistance, in which the swimmer’s body is in a long and stretched position. The arms are overhead with the hand on top of each other, biceps are tucked against the eras, the chin is tucked, the legs are straight and toes are pointed. This position is used at the start of a race, after a turn and during glide phases.", "noun"),
                new Word("propulsive phase", "Part of the stroke where the swimmer generates forward movement by pushing against the water with its arms and legs.", "noun"),
                new Word("glide phase", "Part of the stroke where the swimmer stays in a streamlined position and moves through the water without doing any movement to conserve momentum. The glide phase often comes after a turn or between stroke cycles.", "noun"),
                new Word("recovery phase", " Part of the stroke where the swimmer brings its arm back to the front to prepare for the next stroke.", "noun"),
                new Word("Swedish goggle", "A classic, minimalist, and low-profile swimming goggle, originally designed in the 1970s. They have no gaskets nor seals, using pressure and suction for a watertight seal and have a custom assembly for a perfect fit on a swimmer’s face.", "noun")

            };
        }
    }
}

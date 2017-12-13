using System;
using System.Collections.Generic;

namespace GroupDJ
{
    /// <summary>
    /// The Main Playlist for the Party
    /// Contains a list of the songs to be played
    /// Controls updating the ranking of each song in the list
    /// </summary>
    public class Playlist : List<Song>
    {
        static Playlist Instance;

        private Playlist()
        {

        }

        // Temporary until playlist from 3rd party (will modify this method)
        // Can reuse for unit tests
        public static Playlist GetInstance ()
        {
            if (Instance == null)
            {
                Instance = new Playlist ();
                Instance.Add(new Song("Blue Christmas", "Elvis", 1950));
                Instance.Add(new Song("Jingle Bell Rock", "John Doe", 1982));
                Instance.Add(new Song("Sad Songs", "Avicci", 2017));
                Instance.Add(new Song("Love Story", "Taylor Swift", 2010));
                Instance.Add(new Song("Can't Stop the Feeling", "Justin Timberlake", 2016));
                Instance.Add(new Song("Cry", "Rhianna", 2008));
                Instance.Add(new Song("What the Hell", "Avril Lavigne", 2009));
                Instance.Add(new Song("Barley Breathing", "Dunkan Sheik", 1999));
                Instance.Add(new Song("I Want A Hippopotamus For Christmas", "Gayla Peevey", 1953));
                Instance.Add(new Song("What is Love", "Night at the Roxbury", 1985));
            }
            return Instance;
        }
    }
}

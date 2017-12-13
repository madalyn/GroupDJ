using System;
namespace GroupDJ
{
    /// <summary>
    /// The individual Song object are the composition of the main Playlist
    /// Contains the Song's info
    /// Keeps track of the rank
    /// </summary>
    public class Song
    {
        /// <summary>
        /// The current position of the Song in the Playlist
        /// Only the Playlist should be able to control the change of the Rank for a Song
        /// </summary>
        /// <value>A number that indicates where in the list the song is (?10 base)</value>
        public int Rank { get; private set; }

        // FIXME: not sure if this is the best way to access these for now
        public string Title { get; private set; }
        public string Artist { get; private set; }
        public int Year { get; private set; }

        // TODO: include song info accessors (Album Art, Artist Name, Title, etc --> check with Spotify API)

        // TODO: who creates the song objects?
        public Song (string title, string artist, int year)
        {
            Title = title;
            Artist = artist;
            Year = year;
        }
    }
}

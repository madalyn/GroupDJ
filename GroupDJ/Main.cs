using System;
using System.Collections.Generic;

namespace GroupDJ
{
    /// <summary>
    /// The core control of the app
    /// </summary>
    public class Main
    {
        public Main()
        {
            Playlist.GetInstance();
        }

        // TODO: playlist + search


        // TODO: deal with edge cases
        // Same song being added twice (doesn't add the song, just upvotes it)
        // do we scan the playlist for duplicates or allow them?


        /* SETTINGS */
        // One upvote/downvote per song per user (unlimited votes on playlist)
    }
}

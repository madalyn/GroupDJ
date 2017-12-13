using System;
namespace GroupDJ
{
    /// <summary>
    /// A user of the playlist who is not the owner
    /// </summary>
    public class Guest : User
    {
        public Guest()
        {
        }

        // TODO: VoteUp(song) & VoteDown(song)
        // Playlist should be global/universal
    }
}

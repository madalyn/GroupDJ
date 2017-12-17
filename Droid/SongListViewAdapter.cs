using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;

namespace GroupDJ.Droid
{
    public class SongListViewAdapter : BaseAdapter<Song>
    {
        public List<Song> songItems;
        private Context context;

        public SongListViewAdapter(Context context, List<Song> songItems)
        {
            this.context = context;
            this.songItems = songItems;
        }

        public override Song this[int position]
        {
            get { return songItems[position]; }
        }

        public override int Count
        {
            get { return songItems.Count; }
        }

        public override long GetItemId (int position)
        {
            return position;
        }

        public override View GetView (int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            // recycle, otherwise new instance
            if (row == null)
            {
                row = LayoutInflater.From(context).Inflate(Resource.Layout.song_item, null, false);
            }

            TextView rankingTextView = row.FindViewById<TextView>(Resource.Id.rankingTextView);
            rankingTextView.Text = songItems[position].Rank.ToString();

            TextView titleTextView = row.FindViewById<TextView>(Resource.Id.titleTextView);
            titleTextView.Text = songItems[position].Title;

            // FIXME: these two will always be the same; where-else can we set these?
            // maybe set them on the UI directly (will need I/O for these)
            Button upVoteButton = row.FindViewById<Button>(Resource.Id.upVoteButton);
            Button downVoteButton = row.FindViewById<Button>(Resource.Id.downVoteButton);

            return row;
        }
    }
}

using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;

namespace GroupDJ.Droid
{
    [Activity(Label = "GroupDJ", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { button.Text = $"{count++} clicks!"; };

            ListView playlistListView = FindViewById<ListView>(Resource.Id.playlistListView);

            // get the list from Playlist and display each piece of Song information
            List<string> titles = new List<string>();
            foreach (var song in Playlist.GetInstance())
            {
                titles.Add(song.Title);
            }

            //var playlist = Intent.Extras.GetStringArrayList("learned_words") ?? new string[0];

            // In Android, the Adapter is used to populate a ListView
            // use a SimpleListItem for now, can make more specific later
            var adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, titles);
            playlistListView.Adapter = (adapter);

        }
    }
}


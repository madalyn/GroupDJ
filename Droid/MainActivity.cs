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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // and attach an event to it
            //button.Click += delegate { button.Text = $"{count++} clicks!"; };

            ListView playlistListView = FindViewById<ListView>(Resource.Id.playlistListView);

            // get the list from Playlist and display each piece of Song information

            // In Android, the Adapter is used to populate a ListView
            // use a SimpleListItem for now, can make more specific later
            var adapter = new SongListViewAdapter(this, Playlist.GetInstance());
            playlistListView.Adapter = (adapter);

        }
    }
}


using System;

// create a namespace
namespace MusicPlayer244
{  
    // class will hold all code about music player
    class MusicPlayer
    {
        static void Main(string[] args)
        {
            // main method
            
            // Create a console-based Music Player application that
            // uses a linked list to manage a playlist of songs. The
            // program should allow the user to add, remove, navigate,
            // and play songs in sequence.

            // title, artist, duration, toString(display details), next song, 

            // building a linked list we need to build nodes first
        }

        class SongNode<T1, T2, T3, T4>
        {

            // properties
            public T1 Title { get; set; }
            public T2 Artist { get; set; }
            public T3 Duration { get; set; }

            public SongNode(T1 songTitle, T2 artistName, T3 songDuration)
            {
                Title = songTitle;
                Artist = artistName;
                Duration = songDuration;
                NextSong = null;
            }

            public override string ToString()
            {
                string output = "Song Name : " + Title + "\nArtist : " + Artist + "\nDuration : " + Duration;
                return output;
            }

            class MusicPlayerLinkedList<T1, T2, T3>
            {
                // init the head
                private SongNode<T1, T2, T3> head;

                // add
                public void AddSong(T1 songTitle, T2 artistName, T3 songDuration)
                {
                    // create the song using the constructor
                    SongNode<T1, T3, T3> newSong = new(songTitle, artistName, songDuration);

                    if (head == null)
                    {
                        head = newSong;
                    }
                    else
                    {
                        // find the end, then add the song
                        SongNode<T1, T2, T3>
                    }
                }
            }
        }
    }
}
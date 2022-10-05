﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_4.Constants;

namespace Lab_4
{
    internal class Song
    {
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string ArtistName
        {
            get { return artistName; }
            private set 
            { 
                if (value.Length <3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                artistName = value; 
            }
        }
        public string SongName
        {
            get { return songName; }
           private set
            {
                if(value.Length <3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }
                songName = value;
            }
        }
        public int Minutes
        {
            get { return minutes; }
            private set
            {
                if(value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                minutes = value;
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if(value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                seconds = value;
            }
        }
    }
}

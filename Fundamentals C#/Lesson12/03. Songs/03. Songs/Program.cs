﻿using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Song
    {
        public string Name { get; set; }

        public string TypeList { get; set; }

        public string Time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] tokens = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);
                string typeList = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Song newSong = new Song()
                {
                    Name = name,
                    TypeList = typeList,
                    Time = time
                };
                songs.Add(newSong);
            }
            string typeLIstToSearch = Console.ReadLine();
            if (typeLIstToSearch == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songs.FindAll(song => song.TypeList == typeLIstToSearch);
                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}

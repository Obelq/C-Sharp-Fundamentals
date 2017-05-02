using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numberOfSongs = 0;
            var totalSongsLenghtInSeconds = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(';')
                    .ToList();
                var artistName = input[0];
                var songName = input[1];
                var length = input[2];
                try
                {
                    var songLength = length
                        .Split(':')
                        .Select(int.Parse)
                        .ToList();
                    var minutes = songLength[0];
                    var seconds = songLength[1];
                    var song = new Song(artistName, songName, minutes, seconds);
                    Console.WriteLine("Song added.");
                    numberOfSongs++;
                    totalSongsLenghtInSeconds += seconds + minutes * 60;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine($"Songs added: {numberOfSongs}");
            Console.WriteLine($"Playlist length: {totalSongsLenghtInSeconds/3600}h {totalSongsLenghtInSeconds/60%60}m {totalSongsLenghtInSeconds%60}s");
        }
    }
}

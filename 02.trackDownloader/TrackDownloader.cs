using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.trackDownloader
{
    public class TrackDownloader
    {
        public static void Main()
        {
            var blacklist = Console.ReadLine().Split(' ').ToList();
            var downloadedTracks = new List<string>();

            var line = Console.ReadLine();

            while (line != "End")
            {
                var isInBlacklist = false;
                foreach (var blacklistedWord in blacklist)
                {
                    if (line.Contains(blacklistedWord))
                    {
                        isInBlacklist = true;
                        break;
                    }

                }

                if (!isInBlacklist)
                {
                    downloadedTracks.Add(line);
                }
                line = Console.ReadLine();

            }

            downloadedTracks.Sort();

            Console.WriteLine(string.Join(Environment.NewLine, downloadedTracks));
            //foreach (var track in downloadedTracks)
            //{
            //    Console.WriteLine(track);
            //}

        }
    }
}

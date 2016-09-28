using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer ap = new AudioPlayer();
            ap.play("mp3", "Beyonce.mp3");
            ap.play("mp4", "Beyonce.mp4");
            ap.play("vlc", "Beyonce.vlc");
            ap.play("avi", "Beyonce.avi");

            Console.ReadKey();
        }
    }
}

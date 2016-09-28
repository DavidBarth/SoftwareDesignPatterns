using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;
        public void play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3"))
            {
                Console.WriteLine("Playing mp3 file :" + fileName);

            }else if (audioType.Equals("vlc") || (audioType.Equals("mp4"))) {
                mediaAdapter = new MediaAdapter(audioType);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported.");
            }
        }
    }
}

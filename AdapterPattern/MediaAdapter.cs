using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class MediaAdapter : MediaPlayer 
    {
        AdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer = new VlcPlayer();
            }else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer = new VlcPlayer();
            }
        }

        public void play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer.playVlc(fileName);
            }else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer.playVlc(fileName);
            }
        }

       
    }
}

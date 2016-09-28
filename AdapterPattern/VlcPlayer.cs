using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class VlcPlayer : AdvancedMediaPlayer
    {
        public void playVlc(string fileName)
        {
            Console.WriteLine("Playing Vlc file. Name :" + fileName);
        }

        public void playMp4(string fileName)
        {

        }
    }
}

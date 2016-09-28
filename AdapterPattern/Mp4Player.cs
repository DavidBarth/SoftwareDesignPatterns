using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Mp4Player : AdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            Console.WriteLine("Playing Mp4 file. Name :" + fileName);
        }

        public void playVlc(string fileName)
        {

        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface AdvancedMediaPlayer
    {
        void playVlc(string fileName);
        void playMp4(string fileName);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ConsoleNumberGuessingGame1
{
    static class AudioController
    {
        static SoundPlayer MenuMusic = new("D:\\csharp\\ConsoleNumberGuessingGame1\\MenuMusic.wav");
        static SoundPlayer GameMusic = new("D:\\csharp\\ConsoleNumberGuessingGame1\\GameMusic.wav");
        public static void PlayMenuMusic()
        {
            MenuMusic.PlayLooping();
        }
        public static void StopMenuMusic()
        {
            MenuMusic.Stop();
        }
        public static void PlayGameMusic()
        {
            GameMusic.PlayLooping();
        }
        public static void StopGameMusic()
        {
            GameMusic.Stop();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NAudio.Wave;

namespace PianoPlayer
{
    class KeyboardPiano
    {
        static void Main(string[] args)
        {
            KeyboardPiano p = new KeyboardPiano();
            p.Run();
        }

        void Run()
        {
            int samplingRate = 44100;
            Audio player = new Audio();
            Piano piano = new Piano("q2we4r5ty7u8i9op-[=zxdcfvgbnjmk,.;/' ", samplingRate);
            int count = 0;
            while (true)
            {
                // check if the user has typed a key; if so, process it  
                if (Console.KeyAvailable)
                {
                    var input = Console.ReadKey();
                    char key = char.ToLower(input.KeyChar);
                    piano.StrikeKey(key);
                }
                player.Play(piano.Play());
                count++; //count number of samples
                if (count > samplingRate * 3)
                {
                    count = 0;
                    Thread.Sleep(400); //delay
                }
            }
        }

    }
 
}

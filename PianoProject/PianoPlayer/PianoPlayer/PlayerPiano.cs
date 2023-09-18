using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace PianoPlayer
{
    class PlayerPiano
    {
        public static void Main(String[] args)
        {
            String[] chopsticksLines = File.ReadAllLines("../../chopsticks.txt");
            Audio player = new Audio();
            Piano myPiano = new Piano(chopsticksLines[0], 44100);
            foreach(String line in chopsticksLines)
            {
                if (line != chopsticksLines[0])
                {
                    Char[] lineLetters = line.ToCharArray();
                    foreach (Char letter in lineLetters)
                    {
                        myPiano.StrikeKey(letter);
                    }
                    for(int i = 0; i < 44100 * 3; i++)
                    {
                        player.Play(myPiano.Play());
                    }
                    System.Threading.Thread.Sleep(400);
                }
            }
        }
    }
}

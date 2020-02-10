using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

//This class depends on NAudio library. To get it:
//Tools - Nuget package manager - Manage nuget packages for solution - search for NAudio
//It will create a new folder NAudio in your solution

namespace PianoPlayer
{
    /// <summary>
    /// This class is used to play a stream of doubles that represent audio samples
    /// </summary>
    class Audio
    {
        private WaveOutEvent waveOut;  //audio output in separate thread
        private BufferedWaveProvider bufferedWaveProvider;  //used for streaming audio

        private int bufferCount = 0;
        private byte[] buffer;

        /// <summary>
        /// Audio constructor
        /// </summary>
        /// <param name="bufferSize">Length of buffer held in this class, default is 4096</param>
        /// <param name="samplingRate">Audio sampling rate,, default value is 44100</param>
        public Audio(int bufferSize = 4096, int samplingRate = 44100)
        {
            waveOut = new WaveOutEvent();
            bufferedWaveProvider = new BufferedWaveProvider(new WaveFormat(samplingRate, 16, 1));
            bufferedWaveProvider.BufferLength = bufferSize * 16;
            bufferedWaveProvider.DiscardOnBufferOverflow = true;
            buffer = new byte[bufferSize];

            waveOut.Init(bufferedWaveProvider);
            waveOut.Play();
        }

        /// <summary>
        /// Used to play a double representing an audio sample. The double will be added to the buffer
        /// </summary>
        /// <param name="input">Smaple to be played</param>
        public void Play(double input)
        {
            // clip if outside [-1, +1]
            if (input < -1.0) input = -1.0;
            if (input > +1.0) input = +1.0;
            short s = (short)(short.MaxValue * input);
            byte[] temp = BitConverter.GetBytes(s);
            buffer[bufferCount++] = temp[0];
            buffer[bufferCount++] = temp[1]; //little Endian

            // send to sound card if buffer is full        
            if (bufferCount >= buffer.Length)
            {
                bufferCount = 0;
                bufferedWaveProvider.AddSamples(buffer, 0, buffer.Length);
            }

        }
    }
}

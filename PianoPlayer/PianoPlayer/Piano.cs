﻿using System;
namespace PianoPlayer
{
	public class Piano
	{
		private string keys;
		private int samplingRate;
		private List<IMusicalInstrument> wireList;

		/// <summary> 
        /// This constructor takes 2 params to create a Piano object
        /// </summary>
        /// <param name="keys">String of keys</param>
        /// <param name="samplingRate">Smpling rate value</param>
		public Piano(string keys = "q2we4r5ty7u8i9op-[=zxdcfvgbnjmk,.;/' ", int samplingRate = 44100)
		{
			this.keys = keys;
			this.samplingRate = samplingRate;
		}

		/// <summary>
        /// This method associates a char in the keys string with a note and its frequency.
        /// </summary>
		public void CharacterKey()
		{	
			foreach (char c in keys.ToCharArray())
			{
				wireList.Add(new PianoWire(Math.Pow(2, (keys.IndexOf(c) - 24) / 12) * 440), samplingRate);
			}
		}

		/// <summary> This method strikes the piano key corresponding to the specified character.
		/// If it returns -1, a message will be displayed
        /// </summary>
		/// <param name="key"> Char in the string </param>
		public void StrikeKey(char key)
		{
			if (keys.IndexOf(key) == -1)
			{
				Console.WriteLine("out of bounds, returns -1");
			}
		}

		/// <summary>
        /// This method goes through piano wires and returns sum of their sample
		/// </summary>
        /// <returns>Sum of the samples</returns>
		public double Play()
		{ 
			double sum = 0;
			foreach (var i in wireList)
			{
				sum =+ i.Sample(0.996);
			}
			return sum;
		}
	}
}

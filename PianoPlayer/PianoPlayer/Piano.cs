using System;
namespace PianoPlayer
{
	public class Piano
	{
		private string keys;
		private int samplingRate;
		private List<IMusicalInstrument> wireList;

		public Piano(string keys = "q2we4r5ty7u8i9op-[=zxdcfvgbnjmk,.;/' ", int samplingRate = 44100)
		{
			this.keys = keys;
			this.samplingRate = samplingRate;
		}

		//associates a char in the keys string with a note and its frequency
		public void CharacterKey()
		{
			
			foreach (char c in keys.ToCharArray())
			{
				wireList.Add(new PianoWire(Math.Pow(2, (keys.IndexOf(c) - 24) / 12) * 440), samplingRate);
			}
		}

		//strikes piano key corresponding to the specified character
		//if it returns -1, a message will be displayed
		public void StrikeKey(char key)
		{
			if (keys.IndexOf(key) == -1)
			{
				Console.WriteLine("out of bounds, returns -1");
			}
		}

		//goes through piano wires and returns sum of their sample
		public double Play()
		{ 
			double sum = 0;
			foreach (int i in wireList)
			{
				sum += wireList.get(i);
			}
			return sum;
		}
	}
	
}

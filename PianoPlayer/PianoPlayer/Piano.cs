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
		public void characterKey()
		{
			foreach (char c in keys.ToCharArray())
			{
				wireList.Add(new PianoWire(Math.Pow(2, (keys.IndexOf(c) - 24) / 12) * 440), samplingRate);
			}
		}

		
	}
}
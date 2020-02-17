using System;

namespace PianoPlayer
{
	public class PianoWire : IMusicalInstrument
	{
		private int frequency;
		private int samplingRate;
		private CircularArray circularArray;
		public PianoWire(int frequency, int samplingRate)
		{
			this.frequency = frequency;
			this.samplingRate = samplingRate;
			this.circularArray = new CircularArray(this.samplingRate / this.frequency);
		}
		/// <summary>
		/// This method adds a new value to the rear, which is the average of the two
		/// first values multiplied by the decay factor. It removes the value  
		/// currently at the front, and  returns it.
		/// </summary>
		/// <param name="decay">Factor</param>
		/// <returns>First value in queue, between -0.5 and 0.5</returns>
		public double Sample(double decay)
		{
			return this.circularArray.Shift((this.circularArray[0] + this.circularArray[1])/2 * decay);
		}
		/// <summary>
		/// This method simulates striking the wire by replacing all of the values
		/// in the ring buffer with random values from the range -0.5 to 0.5.
		/// <summary>
		public void Strike() 
		{
			Random random = new Random();
			double[] buffer = new double[this.circularArray.Length];
			for(int i = 0; i < this.circularArray.Length; i++)
			{
				buffer[i] = random.NextDouble() - 0.5;
			}
			this.circularArray.Fill(buffer);
		}

		//Circular array missing in here
	}
}

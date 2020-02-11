using System;

namespace PianoPlayer
{
	public class CircularArray: IRingBuffer
	{
		private double[] CircleArray;
		
		public CircularArray(int ArrLength)
		{
			CircleArray = new double[ArrLength];
		}

		public double this[int index] => throw new NotImplementedException();

		public int Length => throw new NotImplementedException();

		public void Fill(double[] array)
		{
			for (int i = 0; i < CircleArray.Length; i++)
			{
				array[i] = CircleArray[i];
			}
			throw new NotImplementedException();
		}

		public double Shift(double value)
		{
			throw new NotImplementedException();
		}
	}
}
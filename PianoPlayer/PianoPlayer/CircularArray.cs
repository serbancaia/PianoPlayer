using System;

namespace PianoPlayer
{
	public class CircularArray: IRingBuffer
	{
		private double[] buffer;
		//buffer length
		public int Length { get { return buffer.Length; } }

		//constructor creates array with a given param
		public CircularArray(int ArrLength)
		{
			this.buffer = new double[ArrLength];
		}

		public double this[int index]
		{
			get { return this.buffer[index]; }
		}		

		public void Fill(double[] array)
		{
			this.buffer = new double[array.Length];
			//array param = circleArray
			for (int i = 0; i < buffer.Length; i++)
			{
				buffer[i] = array[i];
			}
		}

		public double Shift(double value)
		{
			double firstElement = buffer[0];
			double[] tempBuffer = new double[buffer.Length];
			for (int i = 1; i < buffer.Length; i++)
			{
				tempBuffer[i-1] = buffer[i];
			}
			buffer = tempBuffer;
			buffer[buffer.Length - 1] = value;
			return firstElement;
		}
	}
}
using System;

namespace PianoPlayer
{
	public class CircularArray: IRingBuffer
	{
		private double[] buffer;
		
		/// <summary>
		/// Defines a fixed size ring, or circular, buffer
		/// </summary>
        /// <returns>Length of the buffer array</return>
		public int Length { get { return buffer.Length; } }

		/// <summary>
        /// Constructor that creates a buffer 
        /// </summary>
        /// <param name="ArrLength">Length of the array to be created</param>
		public CircularArray(int ArrLength)
		{
			this.buffer = new double[ArrLength];
		}

		/// <summary>
        /// Indexer to go through elements in the buffer starting at the front to the value at the end
        /// </summary>
        /// <param name="index">index, where 0 indicates front of the ring buffer</param>
        /// <returns>element at the index</returns>
		public double this[int index]
		{
			get { return this.buffer[index]; }
		}		

		/// <summary>
        /// Performs a deep copy of the array into the buffer
        /// </summary>
        /// <param name="array">array of doubles to be copied</param>
		public void Fill(double[] array)
		{
			this.buffer = new double[array.Length];
			//array param = circleArray
			for (int i = 0; i < buffer.Length; i++)
			{
				buffer[i] = array[i];
			}
		}

		/// <summary>
        /// Returns and removes the first element in the buffer. Adds value to the end of the buffer
        /// </summary>
        /// <param name="value">Value to be added at the end of the buffer</param>
        /// <returns>First element in the buffer</returns>
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
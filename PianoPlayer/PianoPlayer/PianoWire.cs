namespace PianoPlayer
{
	public class PianoWire : IMusicalInstrument
	{
		private int frequency;
		private int samplingRate;
		public PianoWire(int frequency, int samplingRate)
		{
			this.frequency = frequency;
			this.samplingRate = samplingRate;
		}
		public double Sample(double decay)
		{
			throw new System.NotImplementedException();
		}
		public void Strike() 
		{
			throw new System.NotImplementedException();
		}

		//Circular array missing in here
	}
}

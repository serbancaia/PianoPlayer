namespace PianoPlayer
{
    public interface IMusicalInstrument
    {
        /// <summary>
        /// This method simulates striking the wire by replacing all of the values
        /// in the ring buffer with random values from the range -0.5 to 0.5. 
        /// </summary>
        void Strike();

        /// <summary>
        /// This method adds a new value to the rear, which is the average of the two
        /// first values multiplied by the decay factor. It removes the value  
        /// currently at the front, and  returns it.
        /// </summary>
        /// <param name="decay">Factor</param>
        /// <returns>First value in queue, between -0.5 and 0.5</returns>
        double Sample(double decay);
    }
}
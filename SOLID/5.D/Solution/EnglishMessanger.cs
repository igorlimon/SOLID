using System;

namespace SOLID._5.D.Solution
{
    public class EnglishMessanger : IMessanger
    {
        public void Message(double volume)
        {
            Console.WriteLine("The total Volume is " + volume);
        }
    }
}

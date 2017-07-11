using System;

namespace SOLID._5.D.Solution
{
    public class FrenchMessanger : IMessanger
    {
        public void Message(double volume)
        {
            Console.WriteLine("Le volume total est " + volume);
        }
    }
}

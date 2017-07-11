using System.Collections.Generic;

namespace SOLID._5.D.Solution
{
    public class VolumeCalculator : IVolumeCalculator
    {
        IMessanger messager;
        public VolumeCalculator(IMessanger msg)
        {
            messager = msg;
        }

        public double CalculateVolume(IList<IVolume> shapes)
        {
            double totalVolume = 0;
            foreach (var shape in shapes)
            {
                totalVolume += shape.GetVolume();
            }

            messager.Message(totalVolume);

            return totalVolume;
        }
    }
}

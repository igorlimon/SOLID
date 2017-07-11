using System.Collections.Generic;

namespace SOLID._5.D
{
    public class VolumeCalculator : IVolumeCalculator
    {
        Messanger messager;
        public VolumeCalculator()
        {
            messager = new Messanger();
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

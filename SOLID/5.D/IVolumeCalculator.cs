using System.Collections.Generic;

namespace SOLID._5.D
{
    public interface IVolumeCalculator
    {
        double CalculateVolume(IList<IVolume> shapes);
    }
}

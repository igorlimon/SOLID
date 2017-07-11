using System;

namespace SOLID._4.I
{
    public class InpersionOrder : IOrder
    {
        public void Purchase()
        {
            //Do purchase
        }

        public void ProcessCreditCard()
        {
            //Not required for inperson purchase
            throw new NotImplementedException();
        }
    }
}

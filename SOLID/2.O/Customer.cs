namespace SOLID.O
{
    public class Customer
    {
        private int _custType;

        public int CustType
        {
            get { return _custType; }
            set { _custType = value; }
        }

        public double GetDiscount(double totalSales)
        {
            if (_custType == 1)
            {
                return totalSales - 100;
            }
            else
            {
                return totalSales - 50;
            }
        }
    }
}

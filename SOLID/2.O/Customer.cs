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

        public double GetDiscount(double TotalSales)
        {
            if (_custType == 1)
            {
                return TotalSales - 100;
            }
            else
            {
                return TotalSales - 50;
            }
        }
    }
}

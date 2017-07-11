namespace SOLID.O.Solution
{
    public class SilverCustomer : Customer
    {
        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 50;
        }
    }
}

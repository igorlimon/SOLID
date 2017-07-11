namespace SOLID.O.Solution
{

    public class GoldCustomer : Customer
    {
        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 100;
        }
    }
}

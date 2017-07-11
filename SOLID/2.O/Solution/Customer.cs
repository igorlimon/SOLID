namespace SOLID.O.Solution
{
    public class Customer
    {
        public virtual double GetDiscount(double totalSales)
        {
            return totalSales;
        }
    }

    public class Main
    {
        public void Calculalte(Customer c)
        {
            var a = c.GetDiscount(200);
        }

        public void Execute()
        {
            var c1 = new SilverCustomer();
            var c2 = new GoldCustomer();
            Calculalte(c1);
            Calculalte(c2);
        }
    }
}

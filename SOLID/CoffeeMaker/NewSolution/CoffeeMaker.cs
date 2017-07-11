namespace SOLID.CoffeeMaker.NewSolution
{
    public class CoffeeMaker
    {
        public CoffeeMaker()
        {
        }

        public float Temperature { get; set; }
        public IFilterHolder FilterHolder { get; set; }
        public IFilter Filter { get; set; }
        public ITank Tank { get; set; }
        public IButton Brew { get; set; }
    }
}

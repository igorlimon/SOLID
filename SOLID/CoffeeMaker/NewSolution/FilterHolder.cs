namespace SOLID.CoffeeMaker.NewSolution
{
    public class FilterHolder : IFilterHolder
    {
        public FilterHolderStatus FilterStatus { get; private set; }

        public bool ExistFilter()
        {
            return FilterHolderStatus.On == FilterStatus;
        }
    }
}
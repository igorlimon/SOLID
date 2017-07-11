namespace SOLID.CoffeeMaker.NewSolution
{
    public interface IFilterHolder
    {
        FilterHolderStatus FilterStatus { get; }
        bool ExistFilter();
    }
}
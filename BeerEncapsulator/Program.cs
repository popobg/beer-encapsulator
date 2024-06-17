namespace BeerEncapsulator
{
    internal class Program
    {
        static void Main()
        {
            BeerEncapsulator machine = new BeerEncapsulator(1600, 4, 20);
            int bottlesProduct1 = machine.ProduceEncapsulatedBeerBottles(4);
            Console.WriteLine();
            int bottlesProduct2 = machine.ProduceEncapsulatedBeerBottles(10);
        }
    }
}

using System.Security.Cryptography.X509Certificates;

namespace BeerEncapsulator
{
    internal class Program
    {
        static void Main()
        {
            static void DisplayBottleProduct(int bottles)
            {
                if (bottles == 0)
                {
                    Console.WriteLine("No bottle has been product.");
                }
                Console.WriteLine($"{bottles} beer bottle(s) of 33cL have been product.");
            }

            var machine = new BeerEncapsulator(1600, 4, 20);
            int bottlesProduct1 = machine.ProduceEncapsulatedBeerBottles(4);
            DisplayBottleProduct(bottlesProduct1);

            Console.WriteLine();

            int bottlesProduct2 = machine.ProduceEncapsulatedBeerBottles(10);
            DisplayBottleProduct(bottlesProduct2);
        }
    }
}

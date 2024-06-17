namespace BeerEncapsulator
{
    internal class BeerEncapsulator
    {
        // in cL
        private double _beerVolume = 0;
        private int _bottles = 0;
        private int _capsules = 0;

        public BeerEncapsulator(double beerVolume, int numberOfBottles, int numberOfCapsules)
        {
            this.BeerVolume = beerVolume;
            this.Bottles = numberOfBottles;
            this.Capsules = numberOfCapsules;
        }

        internal double BeerVolume
        {
            get { return this._beerVolume; }
            set
            {
                // the user can only add more beer,
                // so the value must be bigger than the actual value
                if (value <= this._beerVolume)
                {
                    return;
                }
                this._beerVolume = value;
            }
        }

        internal int Bottles
        {
            get { return this._bottles; }
            set
            {
                if (value <= this._bottles)
                {
                    return;
                }
                this._bottles = value;
            }
        }

        internal int Capsules
        {
            get { return this._capsules; }
            set
            {
                if (value <= this._capsules)
                {
                    return;
                }
                this._capsules = value;
            }
        }

        internal void AddBeer(double beer)
        {
            if (beer > 0)
            {
                this._beerVolume += beer;
            }
        }

        internal void AddBottles(int bottles)
        {
            if (bottles > 0)
            {
                this._bottles += bottles;
            }
        }

        internal void AddCapsules(int capsules)
        {
            if (capsules > 0)
            {
                this._capsules += capsules;
            }
        }

        private bool FillBottle()
        {
            if (this._bottles > 0 && this._capsules > 0 && this._beerVolume > 33)
            {
                this._bottles--;
                this._capsules--;
                this._beerVolume -= 33;
                return true;
            }
                return false;
        }

        private void DisplayMissingItems(int bottlesLeftToProduce)
        {
            if (this._bottles == 0)
            {
                Console.WriteLine($"There is no bottle left. Please add {bottlesLeftToProduce} bottle(s).");
            }
            if (this._capsules == 0)
            {
                Console.WriteLine($"There is no capsule left. Please add {bottlesLeftToProduce} capsule(s).");
            }
            if (this._beerVolume < 33)
            {
                double beerVolumeNeeded = (bottlesLeftToProduce * 33) - this._beerVolume;
                Console.WriteLine($"There is only {this._beerVolume}cL of beer left. Please add {beerVolumeNeeded}cL into the machine.");
            }
        }

        internal int ProduceEncapsulatedBeerBottles(int bottlesToProduce)
        {
            if (bottlesToProduce <= 0 )
            {
                Console.WriteLine("The number of bottle to produce is incorrect.");
                return 0;
            }

            int BottlesProduct = 0;

            for (int i = 0; i < bottlesToProduce; i++)
            {
                if (!this.FillBottle())
                {
                    DisplayMissingItems(bottlesToProduce - i);

                    if (i == 0)
                    {
                        Console.WriteLine("No bottle has been product.");
                        return BottlesProduct;
                    }

                    Console.WriteLine($"Only {i} bottle(s) of 33cL have been product.");
                    return BottlesProduct;
                }
                else
                {
                    BottlesProduct++;
                }
            }

            Console.WriteLine($"{bottlesToProduce} beer bottle(s) of 33cL have been product. There is {this._bottles} bottle(s), {this._capsules} capsule(s) and {this._beerVolume}cL of beer left in the machine.");
            return BottlesProduct;
        }
    }
}

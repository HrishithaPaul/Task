//!Fish Inventory
namespace FishInventory
{
    public class Program
    {
        public class Fish
        {
            public string Species { get; set; }
            public double PricePerFish { get; set; }
        }

        public class FishUtility : Fish
        {
            public void AddFish(string species, double pricePerFish)
            {
                Species = species;
                PricePerFish = pricePerFish;
            }

            public bool BuyFish()
            {
                return Species == "GoldFish" || Species == "ClownFish";
            }

            public double CalculatePrice(int numberOfFishes)
            {
                double additionalCharges = 0;
                switch (Species)
                {
                    case "ClownFish":
                        additionalCharges = 100;
                        break;
                    case "GoldFish":
                        additionalCharges = 150;
                        break;
                }
                return numberOfFishes * PricePerFish + additionalCharges;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Enter the species to buy");
                string species = Console.ReadLine();

                Console.WriteLine("Enter the price per fish");
                //double pricePerFish = Convert.ToDouble(Console.ReadLine());
                double pricePerFish = double.Parse(Console.ReadLine());

                FishUtility fish = new FishUtility();
                fish.AddFish(species, pricePerFish);

                if (!fish.BuyFish())
                {
                    Console.WriteLine($"{species} species not found");
                    return;
                }

                Console.WriteLine("Enter the number of fishes you need to buy");
                int numberOfFishes = int.Parse(Console.ReadLine());

                double totalPrice = fish.CalculatePrice(numberOfFishes);
                Console.WriteLine($"Total cost is {totalPrice}");
            }
        }
    }
}









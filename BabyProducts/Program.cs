// !Cart Dresses
using System;

namespace BabyProducts
{
    public class Program
    {
        public static void Main(String[] args)
        {
            bool bl = true;
            while (bl)
            {
                Console.WriteLine("1. Add Dress to Cart");
                Console.WriteLine("2. Remove Dress from Cart");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        //AddDresstoCart();
                        Console.WriteLine("Enter the dress Size ");
                        int size = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the dress color ");
                        string color = Console.ReadLine();
                        Console.WriteLine("Enetr the dress brand");
                        string brand = Console.ReadLine();
                        Console.WriteLine("Enter the dress price");
                        double price = int.Parse(Console.ReadLine());

                        BabyDress bdress = new BabyDress()
                        {
                            Size = size,
                            Color = color,
                            Brand = brand,
                            Price = price
                        };

                        Console.WriteLine("Successfully addedd to the dress cart");
                        break;

                    case 2:
                        //RemoveDressFromCart();
                        Console.WriteLine("Enter the dress brand to remove the dress from cart");
                        string Brand = Console.ReadLine();
                        bool Removed = BabyDressUtility.RemoveDressFromCart(Brand);

                        if (Removed)
                        {
                            Console.WriteLine("Successfully removed from the cart");
                        }
                        else
                        {
                            Console.WriteLine("Dress not found");
                        }
                        break;
                    //case 3:
                    //    Console.WriteLine("Thank you!");
                    //    break;
                    case 3:
                        bl = false;
                        break;

                    default:
                        Console.WriteLine("Enter another Choice");
                        break;
                }
            }
        }


        public static List<BabyDress> DressesCart { get; set; } = new List<BabyDress>();

        public class BabyDress
        {
            public int Size { get; set; }
            public string Color { get; set; }

            public string Brand { get; set; }
            public double Price { get; set; }

        }

        public class BabyDressUtility
        {
            public static void AddDressToCart(BabyDress dress)
            {
                DressesCart.Add(dress);
            }


            public static bool RemoveDressFromCart(string brand)

            {
                BabyDress dressToRemove = DressesCart.FirstOrDefault(d => d.Brand == brand);
                if (dressToRemove != null)
                {
                    DressesCart.Remove(dressToRemove);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //private static void AddDresstoCart()
            //{
            //    Console.WriteLine("Enter the dress Size ");
            //    int size = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the dress color ");
            //    string color = Console.ReadLine();
            //    Console.WriteLine("Enetr the dress brand");
            //    string brand = Console.ReadLine();
            //    Console.WriteLine("Enter the dress price");
            //    double price = int.Parse(Console.ReadLine());

            //    BabyDress bdress = new BabyDress()
            //    {
            //        Size = size,
            //        Color = color,
            //        Brand = brand,
            //        Price = price
            //    };


            //}
            //private static void RemoveDresstoCart()
            //{
            //    Console.WriteLine("Enter the dress brand to remove the dress from cart");
            //    string brand = Console.ReadLine();
            //    bool Removed = BabyDressUtility.RemoveDressFromCart(brand);

            //    if (Removed)
            //    {
            //        Console.WriteLine("Successfully removed from the cart");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Dress not found");
            //    }

            //}
        }
    }
}


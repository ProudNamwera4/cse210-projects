using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");


        Console.WriteLine("Welcome to the Shopping Cart Program!");
        string playAgain = "yes";
        Cart cart = new Cart();
        List<Item> shoppingCart = cart.GetShoppingCart();

        do{
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine(" 1. Add item.");
            Console.WriteLine(" 2. View cart.");
            Console.WriteLine(" 3. Remove item");
            Console.WriteLine(" 4. Compute Total");
            Console.WriteLine(" 5. Pay Total");
            Console.WriteLine(" 6. Save Cart");
            Console.WriteLine(" 7. Load Cart");
            Console.WriteLine(" 8.Load and view saved transactions.");
            Console.WriteLine(" 9. Quit");

            Console.Write("Please enter an action: ");
            string action = Console.ReadLine();
            
            if (action == "1"){
                Console.WriteLine("Which type of item would you like to add?");
                Console.WriteLine(" 1.Basic item");
                Console.WriteLine(" 2.Bulk item");
                Console.WriteLine("\nAnswer '1' or '2'" );
                string itemType = Console.ReadLine();
                if (itemType == "1"){
                    Console.WriteLine("What is the name of the item?");
                    String productName = Console.ReadLine();
                    Console.WriteLine("What is the price of the item?");
                    int price = int.Parse(Console.ReadLine());
                    BasicItem bsItem = new BasicItem(productName,price);
                    shoppingCart.Add(bsItem);
                }else if (itemType == "2"){
                    Console.WriteLine("What is the name of the item?");
                    String productName = Console.ReadLine();
                    Console.WriteLine("What is the price of the item?");
                    int price = int.Parse(Console.ReadLine());

                    Console.WriteLine("Quantity? ");
                    int quantity = int.Parse(Console.ReadLine());
                    
                    BulkItem bkItem = new BulkItem(productName,price,quantity);
                    shoppingCart.Add(bkItem);

                }

                
            }else if(action == "2") {
                cart.DisplayCart();


            }else if(action == "6"){
                Console.WriteLine("\nThank you fo using this our shopping cart.");
                playAgain = "no";
                
            }

        }while(playAgain == "yes");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");


        Console.WriteLine("Welcome to the Shopping Cart Program!");
        Console.Write("Please enter your first name: ");
        string cName = Console.ReadLine();
        Console.Write("Your Surname: ");
        string cSurname = Console.ReadLine();
        BankAccount customerAcc = new BankAccount(cName,cSurname,0,0);
        BulkItem bkItem = new BulkItem("",0,0);
        BasicItem bsItem = new BasicItem("",0);
        DateAndTime dTime = new DateAndTime();
        Animations animations = new Animations();
        string playAgain = "yes";
        
        List<Item> shoppingCart = new List<Item>();
        SaveFile file = new SaveFile("");
        LoadFile lFile = new LoadFile("");
        
        

        do{
        
            float totalPrice = 0;

            Console.WriteLine("\nPlease select one of the following: ");
            Console.WriteLine(" 1. Add item.");
            Console.WriteLine(" 2. View cart.");
            Console.WriteLine(" 3. Remove item");
            Console.WriteLine(" 4. Compute Total");
            Console.WriteLine(" 5. Provide Banking Details");
            Console.WriteLine(" 6. Pay Total");
            Console.WriteLine(" 7. Save Cart");
            Console.WriteLine(" 8. Load Cart");
            Console.WriteLine(" 9. View saved transactions.");
            Console.WriteLine(" 10. Quit");

            Console.Write("Please enter an action: ");
            string action = Console.ReadLine();
            
            if (action == "1"){
                Console.WriteLine("Which type of item would you like to add?");
                Console.WriteLine(" 1.Basic item");
                Console.WriteLine(" 2.Bulk item");
                Console.Write("\nAnswer '1' or '2': ");
                string itemType = Console.ReadLine();
                if (itemType == "1"){
                    Console.Write("What is the name of the item?");
                    String productName = Console.ReadLine();
                    Console.Write("What is the price of the item? $");
                    int price = int.Parse(Console.ReadLine());
                    bsItem = new BasicItem(productName,price);
                    shoppingCart.Add(bsItem);
                    Console.WriteLine("Item Successfully added to cart.\n");
                }else if (itemType == "2"){
                    Console.Write("What is the name of the item?");
                    String productName = Console.ReadLine();
                    Console.Write("What is the price of the item? $");
                    int price = int.Parse(Console.ReadLine());

                    Console.WriteLine("Quantity? ");
                    int quantity = int.Parse(Console.ReadLine());
                    
                    bkItem = new BulkItem(productName,price,quantity);
                    shoppingCart.Add(bkItem);
                    Console.WriteLine("Item Successfully added to cart.\n");

                }

                
            }else if(action == "2") {
                Console.WriteLine();
                
                if (shoppingCart.Count() == 0){
                    Console.WriteLine("You Shopping Cart is currently empty.");                
                }else{

                    Console.Write("Loading cart ");animations.PauseCountDown(7);Console.WriteLine("");
                    Console.Clear();
                    for (int i = 0; i< shoppingCart.Count();i++){
                        shoppingCart[i].DisplayProduct();
                    }
                }
                Console.WriteLine();


            }else if(action == "3"){
                Console.WriteLine();
                if (shoppingCart.Count() == 0){
                    Console.WriteLine("You Shopping Cart is currently empty.");
                }else{
                    for (int i = 0; i< shoppingCart.Count();i++){
                        Console.WriteLine($"{i+1}. {shoppingCart[i].GetProductName()}");
                    }
                    Console.Write("Which item would you like to remove? ");
                    int itemToRemove = int.Parse(Console.ReadLine());
                    if (itemToRemove -1 <= shoppingCart.Count() && itemToRemove > -1){
                        Console.Write("Removing Item ");animations.PauseSpinner(5);
                        Console.Clear();
                        shoppingCart.RemoveAt(itemToRemove-1);
                        Console.WriteLine("Item Successfuly removed from your Cart.\n");
                    }
                }

            }else if(action == "4"){
                for (int i = 0; i< shoppingCart.Count();i++){
                    Console.Write("Calculating ");animations.PauseSpinner(5);
                    Console.Clear();
                   float price = shoppingCart[i].GetPrice();
                   totalPrice += price;
                }
                
                Console.WriteLine($"The total price for the items in your Cart is ${totalPrice}");
                customerAcc.SetCartPrize(totalPrice);

            }else if (action == "5"){
                Console.WriteLine("Please enter your responds to the following details: ");
                Console.Write("Account Number: ");
                int accountNumber = int.Parse(Console.ReadLine());

                Console.Write("Account Type: ");
                string accountType = Console.ReadLine();

                Console.Write("Total amount in the account: ");
                int accountTotal = int.Parse(Console.ReadLine());

                Console.Write("Verifying Account ");animations.PauseSpinner(8);
                Console.Clear();

                customerAcc = new BankAccount(cName, cSurname, accountNumber, accountTotal);
                Console.WriteLine("Thank you for providing your Banking details.");


            }else if (action == "6"){
                if (customerAcc.GetCartPrize() == 0){
                    Console.WriteLine("Please Compute the total price of items in your shopping cart before you proceed your payment.");
                }else if(customerAcc.GetTotalAmount() < customerAcc.GetCartPrize()){
                    Console.WriteLine("Error! Please provide banking details with sufficient funds!");
                }else{
                    customerAcc.Pay();
                    dTime.SetDate();
                    string timeOfTransaction = dTime.GetDate();
                    Console.WriteLine($"Transaction at {timeOfTransaction}");
                    file.SaveTransaction(customerAcc.GetCartPrize(),timeOfTransaction);
                }
                


            }else if(action == "7"){
                Console.Write("What is the filename for the Cart? ");
                string filename = Console.ReadLine();
                file.SetFilename(filename);
                Console.Write("Please be patient while we save your items! In ");animations.PauseCountDown(6);
                Console.Clear();
                file.SaveItems(shoppingCart);

            }else if (action == "8"){
                Console.Write("\nWhat is the filename for the previously saved Cart? ");
                string filename = Console.ReadLine();
                lFile.SetFilename(filename);
                shoppingCart.Clear();
                Console.Write("Items will be loaded in ");animations.PauseCountDown(8);
                lFile.LoadItems(shoppingCart,bsItem,bkItem);


            }else if (action == "9"){
                lFile.ViewTransactions();


            }else if(action == "10"){
                animations.PauseSpinner(8);
                Console.Clear();
                Console.WriteLine($"\nThank you {customerAcc.GetFullName()} for using the shopping cart.");
                playAgain = "no";
                
            }

        }while(playAgain == "yes");
    }
}
/* I feel I have outdone myself in completing this program. I have done so many things exceed requirements and 
make it as realistic as I can. For Example, the program loads with a spinner when the user provide their banking details
in an attempt to make it appear as though the program has an interface in the real wolrd while it verifies your banking details.
The program automatically saves any payment made and you can review your previous reciept details including the date and exact time
of your previous transaction. The program also has 10 classes in reference to the 8 required. With some having child classes and
having all our the principles of programming with classes.*/  
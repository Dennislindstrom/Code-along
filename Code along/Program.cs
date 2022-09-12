//-----------------PSEUDOKOD---------------------

// Welcome user to the app.
// SHow available products to the user.
// Show what is in the shopping cart to the user.
// Ask the user for what they want to buy, or if they want to leave the store. 
// IF the product the user want to buy is available.
// Put the product in the shopping cart.
// Remove the product from the available products.
// ELSE
// tell the user that the product is not available.
//-----------------------------------------------

bool isShopping = true;

List<string> availableProducts = new() {"Peaunut butter ", "Grapes", "Popcorn", "Soap", "Coffee", "Bread", "Apples", "Cabbage", "Tomatoes", "Milk", "Onions", "Butter", "Cheese"};

List<string> shoppingCart = new() {""};

while (isShopping)
{
    WelcomeUserToStore();                                             // Skriv metoden för att kalla. 
    PrintAvailableProducts();
    PrintshoppingCart();
    string response = AskForInput();
    if(response == "Done")
    {
        Console.WriteLine("Bye bye");
        break;
    }
    CheckAvailability(response);
    bool isAvailable = CheckAvailability(response);
    if (isAvailable)
    {
        //Buy product.
        BuyProduct(response);

    }
    else
    {
        //availableProducts.Remove(response); // Tell the user that the product doesnt exist.
        Console.WriteLine();
        Console.WriteLine("Product doesnt exist. ");
        Console.ReadLine();
        isShopping = false;
    }
    Console.WriteLine();
    Console.WriteLine();
}





// Att ta bort availableProducts.RemoveAt(5);   //----------------------------------METHODS-----------------------------
void WelcomeUserToStore()
{
        Console.WriteLine("-------------------------");
        Console.WriteLine($"WELCOME TO THE STORE");
        Console.WriteLine("-------------------------");
}

void PrintAvailableProducts()
{
    Console.WriteLine();
    Console.WriteLine("Available producs:");
    Console.WriteLine();

    foreach (string availableProduct in availableProducts)
    {
        Console.WriteLine(availableProduct);
    }
}

void PrintshoppingCart()
{
    Console.WriteLine();
    Console.WriteLine("Shopping cart: ");
    Console.WriteLine();

    foreach (string productInShoppingcart in shoppingCart)
    {
        Console.WriteLine(productInShoppingcart);
    }
}

string AskForInput()
{
    Console.WriteLine();
    Console.WriteLine("What do you want to buy? ");
    Console.WriteLine(" or type \"Done\" to leave the store");
    Console.WriteLine("");

    Console.WriteLine("reply:");
    string input = Console.ReadLine();

    return input;

}
bool CheckAvailability(string productToCheck)
{
    bool isAvailable = false;

    foreach (string availableProduct in availableProducts)
    {
        if (availableProduct == productToCheck)
        {
            isAvailable = true;
        }
    }

    return isAvailable; 
}

void BuyProduct(string productToBuy)
{
    //Add procct to shopping cart.
    shoppingCart.Add(productToBuy);
    //Remove product from availble products. 
}

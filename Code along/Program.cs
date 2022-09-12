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

List<string> availableProducts = new() {"Peaunut butter ", "Grapes", "Popcorn", "Soap", "Coffee", "Bread", "Apples", "Cabbage", "Tomatoes", "Milk", "Onions", "Butter", "Cheese"};

List<string> shoppingCart = new() {""};




WelcomeUserToStore();                                             // Skriv metoden för att kalla. 
PrintAvailableProducts();
PrintshoppingCart();




// Att ta bort availableProducts.RemoveAt(5); 
//----------------------------------METHODS-----------------------------
void WelcomeUserToStore()                                //Rad 18-20 beskriver metoden. 
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

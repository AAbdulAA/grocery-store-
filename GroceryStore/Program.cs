

//                                          -------------------PseduCode------------------                      ---------------------ShoppingCart-----------------

// Welcome the user to the app
// Show available product to the user 
// Show what is in the shopping cart to user 
// Aske the user for what they want to buy, or if they want to leave the store
// IF the product the user want to buy is available 
// Put the product in the shoppin cart 
// Remove the product from available products
// ELSE
//Tell the user that the product is not available


bool isShopping = true;


// Andra steget 

List<string> availableProducts = new();

availableProducts.Add("Peanut Butter");
availableProducts.Add("Grapes");
availableProducts.Add("Popcorn");
availableProducts.Add("Soap");
availableProducts.Add("Coffee");
availableProducts.Add("Bread");
availableProducts.Add("Apples");
availableProducts.Add("Cabbage");
availableProducts.Add("Tomatos");
availableProducts.Add("Milk");
availableProducts.Add("Onions");
availableProducts.Add("Butter");
availableProducts.Add("Cheese");


// Fjärde steget (2)

List<string> shoppingCart = new();


// 7 steget, lägg den högst upp som bool

while (isShopping)
{
    Console.Clear();
    WelcomeUserToStore();
    PrintAvailablePoducts();
    PrintShoppingCart();
    string response = AskForInput();
    if (response != "Done")
    {
        bool isAvailable = CheckAvailability(response);
        if (isAvailable)
        {
            // buy product 
            BuyProduct(response);
        }
        else
        {
            // Tell user that the product doesnt exist 
            Console.WriteLine();
            Console.WriteLine(" Product doesnt exist ");
            Console.WriteLine(" Press enter to continue");
            Console.ReadLine();
        }

    }
    else
    {
        isShopping = false;
    }

}

Console.WriteLine();
Console.WriteLine(" Thanks for shopping! ");
Console.WriteLine(" See you again soon! ");
Console.ReadLine();


// Definera metoderna 

//                    ------------METODER-----------

// Första steget  
void WelcomeUserToStore()
{
    Console.WriteLine("-----------------");
    Console.WriteLine("HELLO & WELLCOME!");
    Console.WriteLine("-----------------");
}



// tredje steget................ sträng för att visa user vad som finns att handla 
void PrintAvailablePoducts()
{
    Console.WriteLine();
    Console.WriteLine(" Available products");
    Console.WriteLine();
    foreach (string availableProduct in availableProducts)
    {
        Console.WriteLine(availableProduct);
    }


}
// fjärde steget (1)
void PrintShoppingCart()
{
    Console.WriteLine();
    Console.WriteLine(" Shopping Cart ");
    Console.WriteLine();
    foreach(string productInShoppingCart in shoppingCart)
    {
        Console.WriteLine(productInShoppingCart);
    }
}

// femte steget 
string AskForInput()
{
    Console.WriteLine();
    Console.WriteLine(" What do you want to buy? ");
    Console.WriteLine(" Or type \"Done\"  to leave the store");
    Console.WriteLine();


    Console.Write(" Reply: ");
    string input = Console.ReadLine();

    return input;
}

// Femte steget 
bool CheckAvailability(string preoductToCheck)
{
    bool isAvailable = false;

    foreach(string availableProduct in availableProducts)
    {
        if(availableProduct== preoductToCheck)
        {
            isAvailable = true;
        }
    }
    return isAvailable;
}
// 6 steget
void BuyProduct(string productToBuy)
{
    // add product to shopping cart 

    shoppingCart.Add(productToBuy);

    // Remove Product from available products

    availableProducts.Remove(productToBuy);
}
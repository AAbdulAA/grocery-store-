

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



// Andra steget 

List<string> availableProducts = new();

availableProducts.Add(" Peanut Butter ");
availableProducts.Add(" Grapes ");
availableProducts.Add(" Popcorn ");
availableProducts.Add(" Soap ");
availableProducts.Add(" Coffe ");
availableProducts.Add(" Bread ");
availableProducts.Add(" Apples ");
availableProducts.Add(" Cabbage ");
availableProducts.Add(" Tomatos ");
availableProducts.Add(" Milk ");
availableProducts.Add(" Onions ");
availableProducts.Add(" Butter ");
availableProducts.Add(" Cheese ");


// fjärde steget 

List<string> shoppingCart = new();


// definera metoderna 

WelcomeUserToStore();
PrintAvailablePoducts();    
PrintShoppingCart();

// Första steget  (metoder)
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
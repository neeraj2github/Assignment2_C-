using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Making the new Inventory
        List<Product> inventory = new List<Product>();

        // Add products to the inventory which I have made : 
        inventory.Add(new Product("lettuce", 10.5, 50, "Leafy green"));
        inventory.Add(new Product("cabbage", 20, 100, "Cruciferous"));
        inventory.Add(new Product("pumpkin", 30, 30, "Marrow"));
        inventory.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
        inventory.Add(new Product("zucchini", 20.5, 50, "Marrow"));
        inventory.Add(new Product("yam", 30, 50, "Root"));
        inventory.Add(new Product("spinach", 10, 100, "Leafy green"));
        inventory.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
        inventory.Add(new Product("garlic", 30, 20, "Leafy green"));
        inventory.Add(new Product("silverbeet", 10, 50, "Marrow"));
       
       // Print the total number of products in the list.
        int totalProducts = inventory.Count;
        Console.WriteLine($"(1). Total products: {totalProducts}");
        Console.WriteLine();

      // Add a new product (Potato,10RS, 50, Root)
         inventory.Add(new Product("Potato", 10, 50, "Root"));

      // print the list of all products and a total number of products(integer).
          Console.WriteLine("(2). Current Product in the Inventory:");
          Console.WriteLine("-------------------");
        foreach (Product product in inventory)
        {
             Console.WriteLine(product);
        }
          Console.WriteLine();

     // Print the total number of products in the inventory
         totalProducts = inventory.Count;
         Console.WriteLine($"Total products after Adding Potato: {totalProducts}");

         Console.WriteLine();


     // Print all the products of which have the type Leafy green.
         Console.WriteLine("(3). Leafy green products:");
         Console.WriteLine("----------------------");
        foreach (Product product in inventory)
         {
         if (product.Type == "Leafy green")
         {
              Console.WriteLine(product);
         }
       }
        

       // As all the garlic is sold out, Remove Garlic from the list and print the total number of products that are left on the list.
         inventory.RemoveAll(product => product.Name == "garlic");  

         Console.WriteLine();

        totalProducts = inventory.Count;
        Console.WriteLine($"(4). Total products after Removing Garlic: {totalProducts}");

        // Add 50 cabbages to the inventory
        Product cabbage = inventory.Find(product => product.Name == "cabbage");
        cabbage.Quantity += 50;

        Console.WriteLine();

       // Print the final quantity of cabbage
        int cabbageQuantity = cabbage.Quantity;
       Console.WriteLine($"(5). Final quantity of cabbage: {cabbageQuantity}");

       // Calculate the total price for the purchase
decimal  lettucePrice=0;
decimal zucchiniPrice=0;
decimal  broccoliPrice=0;

 foreach (Product product in inventory)
        {
           if(product.Name=="lettuce"){
            lettucePrice=(decimal)product.Price;
           }
           else if(product.Name == "zucchini"){
            zucchiniPrice=(decimal)product.Price;
           }
           else if(product.Name == "broccoli"){
            broccoliPrice=(decimal)product.Price;
           }
        }

decimal totalPrice = 1 * lettucePrice + 2 * zucchiniPrice + 1 * broccoliPrice;


// Display the total price for the purchase
Console.WriteLine($"(6). Total price: {totalPrice} RS");
    
    }
}

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Type { get; set; }

    public Product(string name, double price, int quantity, string type)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        Type = type;
    }

    public override string ToString()
    {
        return $"{Name}, {Price} RS, {Quantity}, {Type}";
    }
}
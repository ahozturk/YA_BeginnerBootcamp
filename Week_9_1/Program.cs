Console.WriteLine("Yazılım Academy - Example Project!");

//List
//Add

//ProductToUpdate (Şu anki hali) -> Eraaser
//UpdatedProduct (Yeni hali) -> Eraser

List<string> products = LoadProductsFromCSV(); //"Eraaser", "Pen"

while (true)
{
    //Console.WriteLine("1-List Products\n2-Add Product");
    //Console.Write("User: ");
    //string selection = Console.ReadLine();

    string selection = TakeInputFromUser("1-List Products\n2-Add Product\n3-Delete\n4-Update");

    //2

    if (selection == "1")
    {
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine(products[i]);
        }
    }

    else if (selection == "2")
    {
        //Console.WriteLine("Please Enter Product Name:");
        //Console.Write("User: ");
        //string newProduct = Console.ReadLine();

        string newProduct = TakeInputFromUser("Please Enter Product Name:");

        products.Add(newProduct);
    }

    else if (selection == "3")
    {
        string deleteProduct = TakeInputFromUser("Please Enter Product Name to Delete:");

        bool isDeleted = products.Remove(deleteProduct);

        if (isDeleted)
            Console.WriteLine($"{deleteProduct} is deleted!");
        else
            Console.WriteLine("Product Not Found!");

    }

    else if (selection == "4")
    {
        string productToUpdate = TakeInputFromUser("Please Enter Product Name to Update:"); //"Eraaser"

        string updatedProduct = TakeInputFromUser("Please Enter Product Name to Update:"); //"Eraser"

        int index = products.IndexOf(productToUpdate); //0

        if (index == -1)
        {
            Console.WriteLine("Product Not Found!");
            continue;
        }

        products[index] = updatedProduct;

        //products[1] = "Pencil"; //Update on Lists

        Console.WriteLine($"{productToUpdate} is updated as {updatedProduct}!");
    }

    //3-Delete
    //4-Update
    SaveProductsToCSV(products);
    SeparateLines();
}

void SeparateLines()
{
    Console.WriteLine("-----------------");
    //Console.WriteLine("\n\n\n");
}

string TakeInputFromUser(string message)
{
    string input;

    while (true)
    {
        Console.WriteLine(message);
        Console.Write("user: ");
        input = Console.ReadLine(); //"     "

        if (!string.IsNullOrWhiteSpace(input)) //"", " ", string.Empty, null
        {
            break;
        }

        Console.WriteLine("Invalid Input:");
    }

    return input;
}

// Method to save products to a CSV file
void SaveProductsToCSV(List<string> products)
{
    File.WriteAllLines("products.csv", products);
}

// Method to load products from a CSV file
List<string> LoadProductsFromCSV()
{
    if (File.Exists("products.csv"))
    {
        return File.ReadAllLines("products.csv").ToList();
    }
    else
    {
        return new List<string>();
    }
}

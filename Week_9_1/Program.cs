Console.WriteLine("Yazılım Academy - Example Project!");

//List
//Add

List<string> products = new(); //"Eraser", "Pen"

while (true)
{
    //Console.WriteLine("1-List Products\n2-Add Product");
    //Console.Write("User: ");
    //string selection = Console.ReadLine();

    string selection = TakeInputFromUser("1-List Products\n2-Add Product");

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
    SeparateLines();
}

void SeparateLines()
{
    Console.WriteLine("-----------------");
    //Console.WriteLine("\n\n\n");
}

string TakeInputFromUser(string message)
{
    Console.WriteLine(message);
    Console.Write("user: ");
    string input = Console.ReadLine();

    return input;
}

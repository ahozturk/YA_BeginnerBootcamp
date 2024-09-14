Console.WriteLine("Yazılım Academy - Example Project!");

//List
//Add

List<string> products = new(); //"Eraser", "Pen"

while (true)
{
    Console.WriteLine("1-List Products\n2-Add Product");

    string selection = Console.ReadLine();

    if (selection == "1")
    {
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine(products[i]);
        }
    }

    else if (selection == "2")
    {
        Console.WriteLine("Please Enter Product Name:");
        string newProduct = Console.ReadLine();

        products.Add(newProduct);
    }
}

Console.WriteLine("Hello, World!");

//WriteMenu();
//WriteMenu();
//WriteMenu();
//WriteMenu();
//WriteMenu();

//Parametre almayan, geri değer döndürmeyen
void WriteMenu()
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1-Login");
    Console.WriteLine("2-Register");
    //Console.WriteLine("3-Contact Us");
    Console.WriteLine("3-Exit");
}

//Parametre almayan, geri değer döndüren
double GetPi()
{
    return 3.14;
}

double r = 3;
double calculation = r * 2 * GetPi(); //r*2*pi

//Parametre alan, geri değer döndürmeyen
void WriteMenuWithName(string name)
{
    Console.WriteLine($"Hello {name}");
    Console.WriteLine("Menu:");
    Console.WriteLine("1-Login");
    Console.WriteLine("2-Register");
    //Console.WriteLine("3-Contact Us");
    Console.WriteLine("3-Exit");
}

WriteMenuWithName("Merve");

//Parametre alan, geri değer döndüren

double CalculateArea(double r)
{
    double calculation = r * 2 * GetPi();
    Console.WriteLine($"Raw Calcualtion:{calculation}");
    return Math.Round(calculation, 1);
}

Console.WriteLine(CalculateArea(7));

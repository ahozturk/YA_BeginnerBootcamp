Console.WriteLine("Hello, World!");

//5!
//5*4*3*2

//3!
//3*2

Console.WriteLine("Faktoriyel hesaplamak için sayı giriniz:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int total = 1;

for (int i = userNumber; i > 1; i--)
{
    total = total * i;
}

Console.WriteLine($"{userNumber} faktoriyel = {total}");

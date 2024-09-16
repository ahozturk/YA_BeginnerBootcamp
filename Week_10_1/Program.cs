// Console.WriteLine("Hello, World!");

// string car1 = "Toyota";
// string car1Model = "Camry";
// string car1Year = "2020";
// string car1license = "ABC123";

// string car2 = "Honda";
// string car2Model = "Civic";
// string car2Year = "2019";
// string car2Color = "Red";

// string car3 = "Ford";
// string car3Model = "Fusion";
// string car3Year = "2018";
// string car3price = "20000";

// System.Console.WriteLine($"Car 1 Color: {car1license}");
// System.Console.WriteLine($"Car 2 Color: {car2Color}");
// System.Console.WriteLine($"Car 3 Color: {car3price}");

Car car1 = new();
car1.Brand = "Toyota";
car1.Model = "Camry";
car1.Year = "2020";
car1.Plate = "ABC123";
car1.Color = "Black";
car1.Price = 25000;

Car car2 = new();
car2.Brand = "Honda";
car2.Model = "Civic";
car2.Year = "2019";
car2.Plate = "XYZ123";
car2.Color = "Red";
car2.Price = 20000;

Car car3 = new();
// car3.Brand = "Ford";
// car3.Model = "Fusion";
// car3.Year = "2018";
// car3.Plate = "DEF123";
// car3.Color = "Blue";
// car3.Price = 15000;
car3.SetCarProperties("Ford", "Fusion", "2018", "Blue", 15000, "DEF123");

Car car4 = new();
car4.SetCarProperties("Chevrolet", "Malibu", "2017", "White", 18000, "GHI123");

List<Car> cars = new();
cars.Add(car1);
cars.Add(car2);
cars.Add(car3);
cars.Add(car4);

for(int i = 0; i < cars.Count; i++)
{
    if (cars[i].Price < 22000)
    {
        Console.WriteLine($"Car {i + 1} Brand: {cars[i].Brand}, Model: {cars[i].Model}, Year: {cars[i].Year}, Plate: {cars[i].Plate}, Color: {cars[i].Color} Price: {cars[i].Price}");
    }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public string Plate { get; set; }

    public void SetCarProperties(string brand, string model, string year, string color, decimal price, string plate)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
        Price = price;
        Plate = plate;
    }
}

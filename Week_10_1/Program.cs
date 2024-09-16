// Console.WriteLine("Hello, World!");

// string car1 = "Toyota";
// string car1model = "Camry";
// string car1year = "2020";
// string car1license = "ABC123";

// string car2 = "Honda";
// string car2model = "Civic";
// string car2year = "2019";
// string car2color = "Red";

// string car3 = "Ford";
// string car3model = "Fusion";
// string car3year = "2018";
// string car3price = "20000";

// System.Console.WriteLine($"Car 1 color: {car1license}");
// System.Console.WriteLine($"Car 2 color: {car2color}");
// System.Console.WriteLine($"Car 3 color: {car3price}");

Car car1 = new();
car1.brand = "Toyota";
car1.model = "Camry";
car1.year = "2020";
car1.plate = "ABC123";
car1.color = "Black";

Car car2 = new();
car2.brand = "Honda";
car2.model = "Civic";
car2.year = "2019";
car2.plate = "XYZ123";
car2.color = "Red";

Car car3 = new();
car3.brand = "Ford";
car3.model = "Fusion";
car3.year = "2018";
car3.plate = "DEF123";
car3.color = "Blue";

List<Car> cars = new();
cars.Add(car1);
cars.Add(car2);
cars.Add(car3);

for(int i = 0; i < cars.Count; i++)
{
    Console.WriteLine($"Car {i + 1} brand: {cars[i].brand}, model: {cars[i].model}, year: {cars[i].year}, plate: {cars[i].plate}, color: {cars[i].color}");
}

class Car
{
    public string brand;
    public string model;
    public string year;
    public string color;
    public string price;
    public string plate;
}

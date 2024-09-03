Console.WriteLine("Hello, World!");

//string csvLine = "id,name,surname,birthyear";

//string[] data = csvLine.Split(','); //["id", "name", "surname", "birthyear"]

//Console.WriteLine($"Id: {data[0]}");
//Console.WriteLine($"Name: {data[1]}");
//Console.WriteLine($"Surname: {data[2]}");
//Console.WriteLine($"Birthyear: {data[3]}");

string rawData = File.ReadAllText("C:\\Users\\Hakan\\Documents\\GitHub\\YA_BeginnerBootcamp\\Lesson_7_1\\Data.txt");

//Console.WriteLine(rawData);

string[] csvLines = rawData.Split('\n', StringSplitOptions.RemoveEmptyEntries);
//["id,name,surname,birthyear", "1,John,Doe,1990", "2,Jane, Smith,1985"]

//Console.WriteLine(csvLines[0]);

for (int i = 1; i < csvLines.Length; i++)
{
    string[] data = csvLines[i].Split(','); //"1", "John", "Doe", "1990"

    Console.WriteLine(data[3]);
    int year = Convert.ToInt32(data[3]);

    int age = 2024 - year;

    Console.WriteLine($"Age: {age}");
}

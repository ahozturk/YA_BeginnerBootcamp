Console.WriteLine("Hello, World!");

//id,name,surname,exam1,exam2

//Verini ham halini oku!
string rawData = File.ReadAllText("C:\\Users\\Hakan\\Documents\\GitHub\\YA_BeginnerBootcamp\\Lesson_7_2\\StudentData.txt");

//Okunan ham veriyi satılara böl
string[] lines = rawData.Split('\n', StringSplitOptions.RemoveEmptyEntries);

//Bölünen satırları virgüllerinden ayır
for (int i = 1; i < lines.Length; i++)
{
    string[] data = lines[i].Split(',');

    int exam1 = Convert.ToInt32(data[3]);
    int exam2 = Convert.ToInt32(data[4]);

    Console.WriteLine($"Exam1: {exam1} - Exam2: {exam2}");
}

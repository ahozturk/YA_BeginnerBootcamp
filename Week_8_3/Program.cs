﻿Console.WriteLine("Hello, World!");

//string[] names = new string[3];

//names[0] = "Hakan";
//names[1] = "Tolga";
//names[2] = "Mehmet";

//string[] names2 = new string[4];
//names2[0] = names[0];
//names2[1] = names[1];
//names2[2] = names[2];
//names2[3] = "Melisa";

//for (int i = 0; i < names2.Length; i++)
//{
//    Console.WriteLine(names2[i]);
//}

List<string> names = new();

names.Add("Hakan");
names.Add("Mehmet");
names.Add("Uğur");
names.Add("Tolga");

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}
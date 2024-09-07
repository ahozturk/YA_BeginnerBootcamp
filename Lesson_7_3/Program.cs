Console.WriteLine("Hello, World!");

#region No-loop
//kontrol - 1. müşteri
//indirim ise indirim yap
//çek ise para ver
//...

//kontrol - 2. müşteri
//indirim ise indirim yap
//çek ise para ver
//...

//kontrol - 3. müşteri
//indirim ise indirim yap
//çek ise para ver
//...

//kontrol - 4. müşteri
//indirim ise indirim yap
//çek ise para ver
//...

//kontrol - 5. müşteri
//indirim ise indirim yap
//çek ise para ver
//...

//kontrol - 6. müşteri
//indirim ise indirim yap
//çek ise para ver
//...

//kontrol - 7. müşteri
//indirim ise indirim yap
//çek ise para ver
//...

//kontrol - 8. müşteri
//indirim ise indirim yap
//çek ise para ver
//...
#endregion

#region for-loop-1
//for (int i = 10; i >= 0; i -= 1) //değişken tanımlama (başlangıç noktası), kontrol (limit), adım
//{
//    Console.WriteLine(i);
//    //i--;

//    //if (!(i >= 0))
//    //    break;

//}
#endregion

#region for-loop-2

//int i = 0;

//for (;;)
//{
//    Console.WriteLine(i);

//    if (i == 1000)
//        break;

//    i++;
//}

#endregion

#region While-loop

//int i = 0;

//while (i <= 1000)
//{
//    Console.WriteLine(i);

//    i++;
//}

#endregion

#region Arrays-1

int[] numbers = new int[] {10, 20, 30, 10, 20, 30 , 10, 20, 30 };

//Console.WriteLine(numbers[0]);
//Console.WriteLine(numbers[1]);
//Console.WriteLine(numbers[2]);
//Console.WriteLine(numbers[3]);
//Console.WriteLine(numbers[4]);
//Console.WriteLine(numbers[5]);
//Console.WriteLine(numbers[6]);
//Console.WriteLine(numbers[7]);
//Console.WriteLine(numbers[8]);

for (int i = 0; i <= 8; i++)
{
    Console.WriteLine(numbers[i]);
}

#endregion

#region Arrays-2

string[] names = new string[3];

names[0] = "Huriye";
names[1] = "Fatih";
names[2] = "Furkan";
names[3] = "Hakan";

#endregion

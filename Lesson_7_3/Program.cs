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

//int[] numbers = new int[] {10, 20, 30, 10, 20, 30 , 10, 20, 30 };

////Console.WriteLine(numbers[0]);
////Console.WriteLine(numbers[1]);
////Console.WriteLine(numbers[2]);
////Console.WriteLine(numbers[3]);
////Console.WriteLine(numbers[4]);
////Console.WriteLine(numbers[5]);
////Console.WriteLine(numbers[6]);
////Console.WriteLine(numbers[7]);
////Console.WriteLine(numbers[8]);

//for (int i = 0; i <= 8; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

#endregion

#region Arrays-2

//string[] names = new string[5];

//names[0] = "Huriye";
//names[1] = "Fatih";
//names[2] = "Furkan";
//names[3] = "Hakan";
//names[4] = "Merve";

//for (int i = 0; i < 5; i++)
//{
//    names[i] = names[i] + " Yılmaz";
//    Console.WriteLine(names[i]);
//}

//string name1 = "Huriye";
//string name2 = "Fatih";
//string name3 = "Furkan";
//string name4 = "Furkan";
//string name5 = "Furkan";

//name1 = name1 + " Yılmaz";
//name2 = name2 + " Yılmaz";
//name3 = name3 + " Yılmaz";
//name4 = name4 + " Yılmaz";
//name5 = name5 + " Yılmaz";

#endregion

#region Arrays-3

Console.WriteLine("Lütfen kapasite giriniz:");
string usersCount = Console.ReadLine(); //"3"

Console.WriteLine($"Kapasite: {usersCount}");

int usersCountInt = Convert.ToInt32(usersCount); //3

string[] users = new string[usersCountInt];
//{ "Huriye", "Huriye", "Huriye"}

for (int i = 0; i < usersCountInt; i++)
{
    Console.WriteLine("Lütfen isim giriniz:");

    string newName = Console.ReadLine(); //"Huriye"

    users[i] = newName;

    Console.WriteLine($"Kullanıcı Kayıt Edildi: {newName}");
}

#endregion

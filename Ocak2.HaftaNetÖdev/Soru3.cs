//Soru3: Kullanıcıdan iki sayı alıp toplamını ekrana yazdıran bir program yazın.

Console.WriteLine("İki Adet Sayı Giriniz: ");
int no1 = Convert.ToInt32(Console.ReadLine());
int no2 = Convert.ToInt32(Console.ReadLine());

int toplam = no1 + no2;

Console.WriteLine($"{no1} + {no2} = {toplam}");
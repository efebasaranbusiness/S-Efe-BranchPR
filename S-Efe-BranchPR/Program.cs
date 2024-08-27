Console.WriteLine("Lütfen Bir Sayı Giriniz");
int UserNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Tahmin Edilecek Sayı");
int CatchNumber = Convert.ToInt32(Console.ReadLine());

if (UserNumber == CatchNumber)
{
    Console.WriteLine("Sonuç Doğru");

}
else
{
    Console.WriteLine("Tahminin Yanlış !");
}
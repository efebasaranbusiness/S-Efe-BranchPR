using S_Efe_BranchPR;

Console.WriteLine("Lütfen Bir Sayı Giriniz");
int UserNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Tahmin Edilecek Sayı");
int CatchNumber = Convert.ToInt32(Console.ReadLine());

if (UserNumber == CatchNumber)
{
    Console.WriteLine("Sonuç Doğru İşte Bilgileriniz\n");
    XMethodClass xMethodClass = new XMethodClass();
    xMethodClass.GetUserData();
}
else
{
    Console.WriteLine("Tahminin Yanlış !");
}

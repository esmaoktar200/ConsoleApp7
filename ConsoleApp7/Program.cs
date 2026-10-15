//kullanıcıdan bir sayı iste girilen sayının çift mi tek mi olduğunu bul
//klavyede n harfine basana kadar oyun tekrar etsin



//string deger = "";
//int sayi;
//do
//{
//    Console.Write("Bir sayı giriniz:");
//    deger = Console.ReadLine();
//    if (int.TryParse(deger, out sayi))
//    {


//        if (sayi % 2 == 0)
//        {
//            Console.WriteLine("Girdiğiniz sayı çifttir.");
//        }
//        else
//        {
//            Console.WriteLine("Girdiğiniz sayı tektir.");
//        }
//    }

//}
//while (deger != "N" && deger != "n");

//bu kodu nesne tabanlı hale getir:



using System;

class SayiKontrol
{
    private int sayi;

    public int Sayi
    {
        get { return sayi; }
        set { sayi = value; }
    }

    public string TekCiftKontrol()
    {
        if (sayi % 2 == 0)
        {
            return "Girdiğiniz sayı çifttir.";
        }
        else
        {
            return "Girdiğiniz sayı tektir.";
        }
    }
}

class Program
{
    static void Main()
    {
        SayiKontrol kontrol = new SayiKontrol();
        string deger;

        do
        {
            Console.Write("Bir sayı giriniz (Çıkış için N): ");
            deger = Console.ReadLine();

            if (deger == "N" || deger == "n")
            {
                break;
            }

            int sayi;

            if (int.TryParse(deger, out sayi))
            {
                kontrol.Sayi = sayi;
                Console.WriteLine(kontrol.TekCiftKontrol());
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            }

        } while (true);
    }
}


using System;

class Kitap
{
    public string _kitap_adı;
    public string _yazar_adı;
    public string _yazar_soyadı;
    public int _sayfa_sayısı;
    public string _yayınevi;
    public DateTime _kayıt_tarihi;

    public Kitap()
    {
        _kayıt_tarihi = DateTime.Now;
    }

    public Kitap(string kitap_adı, string yazar_adı, string yazar_soyadı, int sayfa_sayısı, string yayınevi)
    {
        _kitap_adı = kitap_adı;
        _yazar_adı = yazar_adı;
        _yazar_soyadı = yazar_soyadı;
        _sayfa_sayısı = sayfa_sayısı;
        _yayınevi = yayınevi;
        _kayıt_tarihi = DateTime.Now;
    }


}



public class Program
{
    static void Main(string[] args)
    {
        Kitap kitap1 = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Ramzi Yayınevi");
        //Console.WriteLine(kitap1._kayıt_tarihi);

    }


}

//class bir nesneyi temsil etmektedir ve bu nesneye ait özellikleri ve bu özelliklerin metodlarını içermektedir.Bu örnekte class Kitap 'tır.
//property değişkenkenler üzerinden doğrulama veya kontrol işlemi yapar.
//new bir class'tan yeni bir obje yaratmak için kullanılır.Bu örnekte:kitap1
//Constructor  başlangıç verileriyle classtan yeni bir obje yaratmayı sağlar.




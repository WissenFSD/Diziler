//Birden çok değişkeni bir arada tutan yapılara dizi denir.
// Her bir dizinin bir eleman sayısı olmak zorundadır.
// Diziler aynı tipteki değişkenleri bir arada tutarlar
// dizi oluştururken dizinin tipi belirlenir



// basit dizi tanımı 

//int[] ilkDizi = new int[5];

//// eleman atama
//ilkDizi[0] = 10;
//ilkDizi[1] = 11;
//ilkDizi[2] = 12;



//Console.WriteLine("Dizinin eleman sayısı {0}", ilkDizi.Length);
////int tipinde dizi içerisine string alır mı ?

////ilkDizi[3] = "Deneme";

//// içerisine elemanı convert ederek koyabiliriz.
//ilkDizi[3] = Convert.ToInt32("10");



// dizinin elemanlarını for ile dönmek
//for (int i = 0; i < ilkDizi.Length; i++)
//{
//    Console.WriteLine(ilkDizi[i]);
//}





// int tipinde bir dizi tanımlanıp değer atanmazsa her bir elemanının başlangıç değeri sıfır olacaktır
int[] ikinciDizi = new int[10];

//for (int i = 0; i < ikinciDizi.Length; i++)
//{
//    Console.WriteLine(ikinciDizi[i]);
//}


//String dizi tanımlayalım
//string[] isimler = new string[5];
//isimler[0] = "Ali";
//isimler[1] = "MEhmet";
//isimler[2] = "Hakan";
//isimler[3] = "Suat";
//isimler[4] = "Merve";

//// Farklı dizi tanımlama şekilleri
//int[] dizi = new int[] {
//2,6,9,47,8,4,1,2,5,2,0,6,3,1,5,2,6,0,

//};
//Console.WriteLine(dizi.Length);


// döngü içerisinde dizi doldurma

//int[] donguDizi = new int[10];

//for (int i = 0; i < donguDizi.Length; i++)
//{
//    Console.WriteLine("{0} elemanı giriniz", i);
//    donguDizi[i] = Convert.ToInt32(Console.ReadLine());
//}
//for (int i = 0; i < donguDizi.Length; i++)
//{
//    Console.WriteLine(donguDizi[i]);
//}

// sayısal loto uygulaması
// 6 tane sayıyı ekrandan alacaz
// 6 tane rakamı random oluşturacağız
// sonrasında bu rakamları karşılaştırıp kaç adet rakam bildiğimizi ekrana yazdıracağız



//int[] manuelDizi = new int[6];
//int[] randomDizi = new int[6];

//int bulunanSayi = 0;
//Random rnd = new Random();
//for (int i = 0; i < manuelDizi.Length; i++)
//{
//    // kullanıcıdan alınıyor
//    Console.WriteLine("{0}. tahmini yapınız", i);
//    manuelDizi[i] = Convert.ToInt32(Console.ReadLine());

//    // random oluşturuluyor
//    randomDizi[i] = rnd.Next(1, 50);

//}
//for (int i = 0; i < manuelDizi.Length; i++)
//{
//    for (int k = 0; k < randomDizi.Length; k++)
//    {
//        if (manuelDizi[i] == randomDizi[k])
//        {
//            Console.WriteLine("doğru tahmin : {0}", manuelDizi[i]);
//            bulunanSayi++;
//        }
//    }
//}

//Console.WriteLine("Bulunan sayi  : {0}", bulunanSayi);



// Yaptığımız sayısal lotoyu bir döngü içerisine alıp sonsuz kere oynatınız

// iki tane dizi olluşturun bu dizilerden birine isimler diğerine soyisimler ekleyiniz.

// sonra her iki diziendee random olarak ad soyad oluşturun 



// isimler dizisi
//string[] isimler = new string[] { "Ayhan", "Selçuk","Hilmi","Bahadır","Hakan","Mesut" };
//string[] soyisimler = new string[] { "Ayaz", "Dedekoca", "Kılıçdaroğlu", "Sarıgül", "Tatlıses", "Mesut" };

//Random rnd = new Random();
//for (int i = 0; i < isimler.Length; i++)
//{
//    int random = rnd.Next(0, 6);

//    string isim = isimler[random];
//    string soyisim = soyisimler[rnd.Next(0, 6)];

//    Console.WriteLine("{0} {1}", isim, soyisim);
//}

//Console.ReadLine();


// int dizisi tanımlayabildiğimize göre char diziside tanımlayabilir

// içerisinde türkçe karakterlerin bulunduğu bir char dizisi tanımlayın
// sonrasında ekrandan 20 adet char alın
// ekrandan aldığın charların türkçe karakter mi olup olmadığını ekrana yazdırın

//char[] harfler = new char[] { 'ş', 'ç', 'ü', 'ı', 'ğ' };
//for (int i = 0; i < 100; i++)
//{

//    Console.WriteLine("Lütfen bir harf giriniz");
//    char selectedHarf =Convert.ToChar(Console.ReadLine());
//    for (int k = 0; k < harfler.Length; k++)
//    {
//        if (selectedHarf == harfler[k])
//        {

//            Console.WriteLine("Girdiğiniz harf türkçe karakter {0}", selectedHarf);

//        }
//    }


//} 

// klavyeden girilen küçük harflerin büyük halini ekrana yazdıran kod örneği
// 1. yöntem
//char[] kucukHarf = new char[] {'a','b','c','d','e' };
//char[] buyukHarf = new char[] { 'A', 'B', 'C', 'D', 'E' };


//for (int i = 0; i < 100; i++)
//{
//	Console.WriteLine("harf giriniz");
//    char harf = Convert.ToChar(Console.ReadLine());
//	for (int k = 0; k < kucukHarf.Length; k++)
//	{
//		if (harf == kucukHarf[k]) {
//			Console.WriteLine(buyukHarf[k]);
//		}
//	}

//}
//2. Yöntem

for (int i = 0; i < 100; i++)
{
    Console.WriteLine("Harf giriniz");
    int karakter = Convert.ToInt32(Convert.ToChar(Console.ReadLine()));

    int newKarakter = karakter - 32;
    char buyukHarf = Convert.ToChar(newKarakter);

    Console.WriteLine(buyukHarf);



}

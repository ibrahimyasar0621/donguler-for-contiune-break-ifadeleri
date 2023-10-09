namespace donguler_for_loop;

class Program
{
    static void Main(string[] args)
    {
        //ekrana girilen sayılara kadar olan tek sayıalrı yazdır
        Console.WriteLine("Lütfen Bir Sayı Giriniz:");
        int sayac = int.Parse(Console.ReadLine());   //  sadece consolereadline yazarsam hata verir çünkü consolereadline string okuması yapar. bu sebeple integer'i parse'a kest ediyırum. PARSE string ifadeleri çevirmede kullanılır.
        for (int i = 1; i <= sayac; i++)
        {
            if(i%2 == 1);
            Console.WriteLine(i);


        }

        // // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır
        int tekToplam = 0;
        int ciftToplam = 0;
        for (int i =1; i < 1000; i++)
        {
            if(i%2 == 1)         
             tekToplam += i;             // tektoplam = tektoplam + i 
            else
             ciftToplam += i;           // cifttoplam = cifttoplam + i
            


        }
        Console.WriteLine("Tek Toplam:" + tekToplam);
        Console.WriteLine("Cift Toplam:" + ciftToplam);

        //BREAK VE CONTİUNE
        //BREAK =DÖNGÜYÜ SONLANDIRMAK İSTİYORSANIZ BREAK İFADESİNİ KULLANIRSINIZ
        //CONTİUNE=MEVCUT DÖNGÜDE ATLAMAK İSTEDİĞİNİZ ŞARTI YAZIYORUZ VE DÖNGÜ ORAYI ATLAYIP DEVAM EDİYOR.
        
        for (int i = 1; i < 10; i++)
        {
            if(i==4)
             break;
            Console.WriteLine(i);  //SONUÇ=1  2  3  YAZACAK ÇÜNKÜ  4 E EŞİT OLUNCA DURDUR DEDİK. BREAK İÇ İÇE BİRDEN FALZA LOOP VARSA SADECE KENDİ İÇİNE YAZILDIĞI LOOP U DURDURUR.
        }
        for (int i = 1; i < 10; i++)
        {
            if(i==4)
             continue;
            Console.WriteLine(i);  //SONUÇ=1 2 3 5 6 7 8 9  YAZDI ÇÜNKÜ 4 Ü ATLA VE DEVAM ET DEDİK.  
        }


        //HACKERRANK ÖDEVİ
//         using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("");
//         int n = int.Parse(Console.ReadLine());

//         for (int i = 1; i <= 10; i++)
//         {
//             int result = n * i;
//             Console.WriteLine($"{n} x {i} = {result}");
//         }
    }
}



    }
}

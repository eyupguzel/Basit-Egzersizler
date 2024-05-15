using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace _14_Alışveriş_Listesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alışveriş Listesi Oluşturucuya Hoşgeldiniz...");
            Console.WriteLine("Listenizi Oluşturduktan Sonra 'tamam' yazmayı unutmayınız! Aksi takdirde listeniz oluşturulamayacaktır.");
            string[] liste = new string[10];
            string urun = default;
            string tamamKelimesi = "tamam";
            int silinecekSecim = default;
            int secim = default;
            int i = 0;
            while (true)
            {
                for (; i < liste.Length; i++)
                {
                    Console.WriteLine("Ürün Ekleyiniz");
                    if (i == 9)
                        Console.WriteLine("Son 1 ürün ekleme hakınız kalmıştır...");
                    urun = Console.ReadLine();
                    if (urun == tamamKelimesi)
                        break;
                    liste[i] = urun;
                }
                Console.WriteLine("Listeniz Başarıyla Oluşturulmuştur...");
                a:
                if (i == 10)
                    Console.WriteLine("Listenizi Görüntülemek için 1'e ,listeden ürün silmek için 3'e,işlemi bitirmek için 4'e basınız.");
                else
                    Console.WriteLine("Listenizi Görüntülemek için 1'e, tekrar ürün eklemek için 2'ye ,listeden ürün silmek için 3'e,işlemi bitirmek için 'e basınız.");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        for(i = 0; i < liste.Length; i++)
                        {
                            Console.WriteLine(liste[i]);
                        }
                        Console.WriteLine("Başka Bir İşlem Yapmak İstiyor musunuz ? (Evet => 1 / Hayır => 2)");
                        int _secim = int.Parse(Console.ReadLine());
                        switch (_secim)
                        {
                            case 1: continue;
                            case 2: break;
                        }
                        break;
                    case 2:
                        continue;
                    case 3:
                        while (true)
                        {
                            for (i = 0; i < liste.Length; i++)
                            {
                                Console.WriteLine((i + 1) + "=> " + liste[i]);
                            }
                            Console.WriteLine("Silmek İstediğiniz Ürünü Seçiniz...");
                            silinecekSecim = int.Parse(Console.ReadLine());

                            switch (silinecekSecim)
                            {
                                case 1:
                                    liste[0] = null;
                                    break;
                                case 2:
                                    liste[1] = null;
                                    break;
                                case 3:
                                    liste[2] = null;
                                    break;
                                case 4:
                                    liste[3] = null;
                                    break;
                                case 5:
                                    liste[4] = null;
                                    break;
                                case 6:
                                    liste[5] = null;
                                    break;
                                case 7:
                                    liste[6] = null;
                                    break;
                                case 8:
                                    liste[7] = null;
                                    break;
                                case 9:
                                    liste[8] = null;
                                    break;
                                case 10:
                                    liste[9] = null;
                                    break;
                            }
                            Console.WriteLine("Silmek İstediğiniz Başka Bir Ürün Var mı ? (Evet => 1 / Hayır => 2)");
                            int baskaIslem = int.Parse(Console.ReadLine());
                            switch (baskaIslem)
                            {
                                case 1: continue;
                                case 2:
                                    Console.WriteLine("Başka İşlem Yapmak İstiyor musunuz ? (Evet => 1 / Hayır => 2)");
                                    baskaIslem = int.Parse(Console.ReadLine());
                                    switch (baskaIslem)
                                    {
                                        case 1: goto a;
                                        case 2:break;
                                    }
                                    break;
                            }
                            break;
                        }
                        break;
                    case 4:break;
                }
                break;
            }
            Console.WriteLine("İşleminiz Bitmiştir...Bizi tercih ettiğiniz için teşekkür ederiz");
           

            Console.ReadKey();
            
        }
    }
}

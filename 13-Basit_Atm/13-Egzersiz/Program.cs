using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _13_Egzersiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir banka hesabı uygulaması geliştirin ve hesap işlemlerini gerçekleştirin.

            Console.WriteLine("Bankamıza Hoşgeldiniz...");
            Console.WriteLine("Lütfen Bir Seçenek Seçiniz !");
            int secenek = default;
            int _secenek = default;
            int bakiye = 45000;
            int yatirilanTutar = default;


            while (true)
            {
                Console.WriteLine("1-Para Çekme \n" + "2-Para Yatırma \n" + "3-Bakiye Sorgulama \n" + "4-Fatura Ödeme \n");
                try
                {
                    secenek = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz ***Error : " + ex.Message);
                    continue;
                }
                switch (secenek)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz");
                            int cekilenTutar = int.Parse(Console.ReadLine());

                            if (cekilenTutar < bakiye)
                            {
                                bakiye -= cekilenTutar;
                                Console.WriteLine(cekilenTutar + " TL Çekilmiştir...");
                            }
                            else
                            {
                                Console.WriteLine("Bakiyeniz Yetersiz!");
                                continue;
                            }
                            break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Yatırmak İstediğiniz İstediğiniz Tutarı Giriniz");
                        yatirilanTutar = int.Parse(Console.ReadLine());
                        bakiye += yatirilanTutar;
                        Console.WriteLine(yatirilanTutar + " TL Yatırılmıştır...");

                        break;
                    case 3:
                        Console.WriteLine("Toplam Bakiyeniz :" + bakiye);
                       
                        break;
                    case 4:
                        Console.WriteLine("Hangi Faturayı Ödemek İstediğinizi Seçiniz");
                        Console.WriteLine("1-Telefon\n" + "2-Doğalgaz\n" + "3-Elektrik\n" + "4-Su\n" + "5-İnternet\n");
                        _secenek = int.Parse(Console.ReadLine());
                        while (true)
                        {
                            switch (_secenek)
                            {
                                case 1:
                                    Console.WriteLine("Faturanız 320 TL'dir...Ödemek İstiyorsanız 1'e Ödemek İstemiyorsanız 2'ye basınız.");
                                    while (true)
                                    {
                                        try
                                        {
                                            _secenek = int.Parse(Console.ReadLine());
                                        }
                                        catch (FormatException ex)
                                        {
                                            Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz ***Error : " + ex.Message);
                                            continue;
                                        }
                                        break;
                                    }
                                    switch (_secenek)
                                    {
                                        case 1:
                                            Console.WriteLine("Faturanız Ödenmiştir");
                                            bakiye -= 320;
                                            break;
                                        case 2: break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Faturanız 1800 TL'dir...Ödemek İstiyorsanız 1'e Ödemek İstemiyorsanız 2'ye basınız.");
                                    while (true)
                                    {
                                        try
                                        {
                                            _secenek = int.Parse(Console.ReadLine());
                                        }
                                        catch (FormatException ex)
                                        {
                                            Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz ***Error : " + ex.Message);
                                            continue;
                                        }
                                        break;
                                    }
                                    switch (_secenek)
                                    {
                                        case 1:
                                            Console.WriteLine("Faturanız Ödenmiştir");
                                            bakiye -= 1800;
                                            break;
                                        case 2: break;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Faturanız 400 TL'dir...");
                                    Console.WriteLine("Ödemek İstiyorsanız 1'e Ödemek İstemiyorsanız 2'ye basınız.");
                                    while (true)
                                    {
                                        try
                                        {
                                            _secenek = int.Parse(Console.ReadLine());
                                        }
                                        catch (FormatException ex)
                                        {
                                            Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz ***Error : " + ex.Message);
                                            continue;
                                        }
                                        break;
                                    }
                                    switch (_secenek)
                                    {
                                        case 1:
                                            Console.WriteLine("Faturanız Ödenmiştir");
                                            bakiye -= 400;
                                            break;
                                        case 2: break;
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Faturanız 80 TL'dir...Ödemek İstiyorsanız 1'e Ödemek İstemiyorsanız 2'ye basınız.");
                                    while (true)
                                    {
                                        try
                                        {
                                            _secenek = int.Parse(Console.ReadLine());
                                        }
                                        catch (FormatException ex)
                                        {
                                            Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz * **Error : " + ex.Message);
                                            continue;
                                        }
                                        break;
                                    }
                                    switch (_secenek)
                                    {
                                        case 1:
                                            Console.WriteLine("Faturanız Ödenmiştir");
                                            bakiye -= 80;
                                            break;
                                        case 2: break;
                                    }
                                    break;
                                case 5:
                                    Console.WriteLine("Faturanız 380 TL'dir...Ödemek İstiyorsanız 1'e Ödemek İstemiyorsanız 2'ye basınız.");
                                    while (true)
                                    {
                                        try
                                        {
                                            _secenek = int.Parse(Console.ReadLine());
                                        }
                                        catch (FormatException ex)
                                        {
                                            Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz ***Error : " + ex.Message);
                                            continue;
                                        }
                                        break;
                                    }
                                    switch (_secenek)
                                    {
                                        case 1:
                                            Console.WriteLine("Faturanız Ödenmiştir");
                                            bakiye -= 380;
                                            break;
                                        case 2: break;
                                    }
                                    break;
                            }
                            break;
                        }
                        break;
                }
                Console.WriteLine("Yapmak İstediğiniz Başka Bir İşlem Var mı ? (Evet => 1 / Hayır=> 2)");
                while (true)
                {
                    try
                    {
                        _secenek = int.Parse(Console.ReadLine());

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz ***Error : " + ex.Message);
                        continue;
                    }
                    break;
                }
                switch (_secenek)
                {
                    case 1: continue;
                    case 2: break;
                }
                break;
            }
            Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz...");
            Console.ReadKey();
        }
        
        }
    }


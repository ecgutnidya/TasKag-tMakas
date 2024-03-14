using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tas_Kagıt_Makas
{
    internal class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Oyuna Başlayabilirsiniz:");
            Console.WriteLine("seçiminizi yapın: (T) Taş, (K) Kağıt , (M) Makas , (Ç) Çıkış");
           
            int oyuncu_puanı = 0;
            while (true)
            {
                char oyuncu_secimi = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (oyuncu_secimi == 'Ç')
                {
                    Console.WriteLine("Oyunu Sonlandırınız.");
                }
                else if (oyuncu_secimi != 'T' && oyuncu_secimi != 'K' && oyuncu_secimi != 'M')
                {
                    Console.WriteLine("Hatalı seçim yaptınız. Lütfen geçerli bir seçim yapın.");
                }
                Random rnd = new Random();
                int pc_secim = rnd.Next(1, 4);

                if (oyuncu_secimi == 'T')
                {
                    Console.WriteLine("taş seçtiniz" );
                    if (pc_secim == 1)
                    {
                        Console.WriteLine("pc taş seçti: Berabere");
                    }
                    else if (pc_secim == 2)
                    {
                        Console.WriteLine("pc kağıt seçti: Kaybettiniz.");
                        oyuncu_puanı -= 10;
                    }
                    else
                    {
                        Console.WriteLine("pc makas seçti: Kazandınız.");
                        oyuncu_puanı += 10;
                    }
                }
                else if (oyuncu_secimi == 'K')
                {
                    Console.WriteLine("kağıt seçtiniz");
                    if (pc_secim == 1)
                    {
                        Console.WriteLine("pc taş seçti: Kazandınız");
                        oyuncu_puanı += 10;
                    }
                    else if (pc_secim == 2)
                    {
                        Console.WriteLine("pc kağıt seçti: Berabere");
                    }
                    else
                    {
                        Console.WriteLine("pc makas seçti: Kaybettiniz");
                        oyuncu_puanı -= 10;
                    }
                }
                else if (oyuncu_secimi == 'M')
                {
                    Console.WriteLine("makas seçtiniz");
                    if (pc_secim == 1)
                    {
                        Console.WriteLine("pc taş seçti: Kaybettiniz");
                        oyuncu_puanı -= 10;
                    }
                    else if (pc_secim == 2)
                    {
                        Console.WriteLine("pc kağıt seçti: Kazandınız");
                        oyuncu_puanı += 10;
                    }
                    else
                    {
                        Console.WriteLine("pc makas seçti: Berabere");
                    }
                }
                Console.WriteLine("Oyuncu puanı:" + oyuncu_puanı);
                Console.WriteLine();
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i + "...");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.WriteLine("Toplam Oyuncu puanı:" + oyuncu_puanı);
            }

            Console.ReadKey();
        }
    }
}
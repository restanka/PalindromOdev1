using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_Ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Baslik();
            string palin = " ";
            string sonuc = "";
            palin = Console.ReadLine();
            while (palin != "q")
            {
              
                if (palin.Length >= 2)
                {
                    sonuc = "";
                    for (int g = palin.Length - 1; g >= 0; g--) 
                    {
                        sonuc += palin[g];
                    }
                    if (sonuc == palin)
                    {
                        Console.WriteLine("Girdiğiniz ifade palindromdur." + sonuc);
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz ifade palindrom değildir.");
                    }

                }
                else
                {
                    Console.WriteLine("2 veya 2'den fazla deger girinizz!!!");
                }

                Console.WriteLine("..Metin veya Sayı giriniz..");               
                palin = Console.ReadLine();


               
                
            }
            
            


        }

         static void Baslik()
        {
            Console.WriteLine("..Metin veya Sayı giriniz..");
        }
    }
}

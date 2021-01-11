using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            StringToCharArray();
            Console.WriteLine(" ");
            Console.WriteLine("-------Next--------");
            Console.WriteLine(" ");
            Contains();
            Console.WriteLine(" ");
            Console.WriteLine("-------Next--------");
            Console.WriteLine(" ");
            Split();
            Console.WriteLine(" ");
            Console.WriteLine("-------Next--------");
            Console.WriteLine(" ");
            StartsWith();
            Console.WriteLine(" ");
            Console.WriteLine("-------Next--------");
            Console.WriteLine(" ");
            CharMix();


            Console.ReadLine();
        }


       static  public void StringToCharArray()
        {

            string sentence = ".Net'e Aşığımm <3 ";
            char[] charArr = sentence.ToCharArray();
            foreach (char letter in charArr)
            {

                Console.WriteLine(letter);
            }

        }
        static public void Contains()
        {
            string sentence1 = "Ey .Net !!";
            string sentence2 = "Sen mi daha büyüksün ?";
            string sentence3 = "Ben mi ?";
            string sentence4 = "Tabii ben :)";


            bool result1 = sentence1.Contains("C#");
            bool result2 = sentence2.Contains("büyüksün");
            bool result3 = sentence3.Contains("?");
            bool result4 = sentence4.Contains("sen");

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

        }

        // kodlarda türkçe kullanınca bazen kendimizi epey karmaşık bir hale soktuğumuzu göstermek istemiştim hocam :)
        static public void Split()
        {
            char[] turkishLetter = { 'ç', 'Ç', 'Ğ', 'ğ', 'İ', 'ı', 'ş', 'Ş', 'ö', 'Ö', 'ü', 'Ü' };
            string text = "Türkay hoca dersİnde de dediği gibi, o kodu yazarsanız nükleer füze krizine neden olmuyorsunuz ;)";
            Console.WriteLine($"Asıl metin : {text}");
            string[] text2 = text.Split(turkishLetter);
            Console.WriteLine($"Bölünmüş metin : {text2}");
            foreach (var word in text2)
            {
                Console.WriteLine($"<{word}>");
            }
        }

        // Çokta yaratıcı olamadım bu kısımda :(
        static public void StartsWith()
        {

            string value1 = "Acaba büyük/küçük harfe duyarlı bir dil miiğ??";
            Console.WriteLine(value1.StartsWith("a"));
            Console.WriteLine(value1.StartsWith("m"));
            Console.WriteLine(value1.StartsWith("A"));

        }

        static public void CharMix()
        {
            Console.WriteLine("Pandemiden sonra ilk görmek istediğiniz ülke hangisi? ");
            string ulke = Console.ReadLine();
            bool isValid = true;
            for (int i = 0; i < ulke.Length; i++)
            {
                char letter = ulke[i];
                if ((i == 0) && ((!Char.IsLetter(letter)) || (!Char.IsUpper(letter))))
                {
                    Console.WriteLine("İlk karakter büyük harf ile başlamalı!");
                    isValid = false;
                    break;
                }
            }
            if (isValid)
                Console.WriteLine($"İnanmıyoruum!! Benimde en çok görmek istediğim ülke {ulke} :P ");

        }




    }
}

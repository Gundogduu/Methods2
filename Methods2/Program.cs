using System;
using System.Linq;

namespace Methods2
{
    class Program
    {   //fonksiyonların çalıştırıldığı ve kullanıcıdan veri alınan yer Main
        static void Main(string[] args)
        {
            
            //parametresiz kullanımı
            Add();
            //parametreli kullanımı
            Add2(3,6);       
            //default kullanımı
            Add3(20);

            //Ref kullanımı
            int number1 = 20;                     
            int number2 = 100;                              //Mevzu tamamen degiskenin degeriyle ilgilidir.
            int result2 = Add4(ref number1,number2);        //üstteki number1 in burayla tek alakası metoda 20'yi koyması ve artık hicbir sekilde devreye girmemek seklinde olur.Baska hicbir bağı yok.
            Console.WriteLine(result2);
            Console.WriteLine(number1);                    //number1 in durumunu ogrenmek icin
            
            //Params kullanımı
            Console.WriteLine(Add5(2, 4, 6, 5, 8, 54));
            Console.ReadLine();

        
        }

        //parametresiz metod

        static void Add()
        {
            Console.WriteLine("Eklendi!");              
        }

        //parametreli metod
        static int Add2(int number1 , int number2)
        {
            var result = number1 + number2;
            return result;
        }

        //Default parametreli metod
        static int Add3(int number1 , int number2=50)
        {
            var result = number1 + number2;
            return result;
        }

        //Ref keyword
        //burada,number1 de iki tane deger tanımlıyoruz ya, bunu yapma direkt olarak yukaridaki number1'in referansını kullan demek ref. Yani yukarıdakinin refransı 101 ise metodun icindeki 102,
        static int Add4(ref int number1,int number2)                                                                                    //ama ref dedigimizde yukaridaki number1'de 102 olur.
        {                               //ref eklemeden de result'a etki ediyor ama number1'i referans tip'e ceviremiyor.
            number1 = 30;              //bu islemin yukaridaki number1 ile hicbir iliskisi yok.Ama ben metodun icindeki deger degistiginde üstteki number1'i de etkilesin istiyorum diyorsanız, Ref eklemek gerekiyor.
            return number1 + number2;

            //neden böyle bir seye ihtiyac duyuyoruz gercek hayat uygulamalarinda?
            //ornegin bir kredi hesaplama yapıyorsunun ve bir kredi orani var  -->  int number1 = 20;
            //sonra metodun icine girdiniz,musteri tipine gore indirim kazandıgında onun kredi orani degistirdiginizde, ---> number1 = 30;
            //eger metodun devaminda degismis versiyonuyla devam etme ihtiyaciniz varsa o zaman onu ref olarak gonderiyorsunuz.
            //

            //Out keyword
            //ref ile aynı mantıkta fakat ref'te   ---->  int number1 = 20;          diye set etmeniz gerekiyor.
            //out ta boyle bir zorunluluk yoktur.sadece     ---->    int number1;    yazilir.
            //Out ta metodun icinde bir kere set edilmesi gerekir.Tek farki bu.

            //Eger degeri bastan set etme ihtiyacı duyuyorsak ref kullanırız.Boyle bir ihtiyac yoksa out kullaniriz.
        }

        //method overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //Params keyword
        static int Add5(params int[] numbers)         //params ile bu sekilde istedigimiz kadar deger verebiliriz.
        {
            return numbers.Sum();                     //.Sum() ---> toplama metodu.
        }

    }
}

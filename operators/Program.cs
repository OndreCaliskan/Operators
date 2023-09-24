using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------WEEK -1- (06.08.2023)----------------------------//
            //**About: (+) add (-) subtract (*) multiply (/) divide**//
            //******************************************************************************//

            /*int number = 10;
            int number1 = 5;

            int sum = number + number1;   // add
            Console.WriteLine(sum);

            int dif = number - number1;     // subtract 
            Console.WriteLine(dif);

            int impact = number * number1;      //multiply     
            Console.WriteLine(impact);

            int bol = number / number1;         // divide
            Console.WriteLine(bol); */


            //------------------------------EXPONENTİAL OPERATİONS--------------------------------------//

            /* int number3 = 10;
             int number4 = 2;

             double result = Math.Pow(number3, number4);     // !!!! math.pow(karesi) kullandığında double kullan !!!!
             Console.WriteLine(result);*/

            /*int result1 = 1;

            for (int i = 1; i <= number4; i++)
            {
                result1 = result1 * number3;        // math.pow işleminin for döngüsü ile yapılışıu
                Console.WriteLine(result1);
            }*/

            /*Console.WriteLine("üstlü işlem yapmak istediğiniz bir tam sayı giriniz;");
            int number5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kaçıncı üstünü bulmak istiyorsunuz;");
            int number6 = Convert.ToInt32(Console.ReadLine());

            int result2 = 1;

            for (int x = 1; x <= number6; x++)
            {

                result2 = result2 * number5;
                Console.WriteLine(result2);
            }*/


            //---------------------------------------------equivalence ==/!=/</>/ -----------------------------------------------//

            /*Console.WriteLine("Birinci sayıyı Giriniz:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz;");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Girilen sayılar birbirine eşittir");
            }

            if (num1 != num2)
            {
                Console.WriteLine("Girilen sayılar birbirine eşit değildir.");
            }

            if (num1 < num2)
            {
                Console.WriteLine("Girilen ilk sayısı ikinci sayısından Küçüktür.");
            }
            if (num1 > num2)
            {
                Console.WriteLine("Girilen ilk sayısı ikinci sayısından Büyüktür.");
            }

            if (num1 <= num2)
            {
                Console.WriteLine("Girilen ilk sayısı ikinci sayısından Küçük veya eşittir.");
            }

            if (num1 >= num2)
            {
                Console.WriteLine("Girilen ilk sayısı ikinci sayısından büyük veya eşittir.");
            }*/

            //---------------------------------------------LOGİCAL && || ! -----------------------------------------------//

            /*bool sonuc;
            int firstnum = 10, secondnum = 20;

            // VEYA operatörü
            sonuc = (firstnum == secondnum) || (firstnum > 5);
            Console.WriteLine(sonuc);

            // VE operatörü
            sonuc = (firstnum == secondnum) && (firstnum > 5);
            Console.WriteLine(sonuc);

            sonuc = !(firstnum == secondnum) && (firstnum > 5);
            Console.WriteLine(sonuc);*/

            //--------------------------------------------- EXAMPLES -----------------------------------------------//

            // istenilen adet kadar iş bilgisi gir , yaşı 25 den büyük ve maaşı 1000 tl olan işçileri ekrana yazdır. 

            /* Console.WriteLine("Kaç Adet İşçi Bilgisi Giricelektir:");
             int n = Convert.ToInt32(Console.ReadLine());

             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine($"İşçi{i + 1} Yaşını Giriniz;");
                 int old = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine($"İşçi{i + 1} Maaşını Giriniz;");
                 int salary = Convert.ToInt32(Console.ReadLine());

                 if (old > 25 && salary == 1000)
                 {
                     Console.WriteLine($"İşçi{i + 1} Bilgileri");
                     Console.WriteLine($"Yaş{old}");
                     Console.WriteLine($"Maaş{salary}");
                 }




             }
             Console.WriteLine("Proggram bitti");*/

            //-----------------------------------------EXAMPLE2----------------------------------------//
            //Girilen Bir sayının tek veya çift olduğunu bulan programı yazınız.

            /* Console.WriteLine("Enter an Integer;");
             int number = Convert.ToInt32(Console.ReadLine());


             if (number == 1 || number == -1)
             {
                 Console.WriteLine($"This integer is an odd number:{number}");
             }

             else if (number % 2 == 0) 
             {

                 Console.WriteLine($"This integer is an even number:{number}");
             }


             else 
                 Console.WriteLine($"This integer is an odd number:{number}");*/


            //-----------------------------------------EXAMPLE3----------------------------------------//
            //Girilen öğrenci verileri ile öğrencilerin ilgili derslerden başarılı veya başarısız olduğunu bulan program

            /*Console.WriteLine("Kaç Öğrenci  bilgisi verilecek:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Öğrenci{i + 1} Algoritma aldığı not;");
                int alg = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Öğrenci{i + 1} Veri aldığı not;");
                double veri = Convert.ToDouble(Console.ReadLine());

                if (alg >= 60 && veri >= 60)   // (&&;ve) (||;veya) ()

                {
                    Console.WriteLine($"Öğrenci{i + 1} Bilgi");
                    Console.WriteLine($"Algoritma Sınav Sonucu{alg}");
                    Console.WriteLine($"Veri Sınav Sonucu{veri}");
                    Console.WriteLine("Başaralı");
                }

                else
                {
                    Console.WriteLine("Başarısız");
                 }*/

            //-----------------------------------------EXAMPLE4----------------------------------------//
            //Girilen öğrenci verileri ile öğrencilerin ilgili derslerden başarılı veya başarısız olduğunu bulan program

            /*Console.WriteLine("Kaç Öğrenci  bilgisi verilecek:");
             int n = Convert.ToInt32(Console.ReadLine());

             for (int i = 0; i < n; i++)
             {


                 Console.WriteLine($"Öğrenci{i + 1} İsim Ve Soyadı;");
                 string name = Console.ReadLine();


                 Console.WriteLine($"Öğrenci{i + 1} Algoritma aldığı not;");
                 int alg = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine($"Öğrenci{i + 1} Veri aldığı not;");
                 double veri = Convert.ToDouble(Console.ReadLine());

                 Console.WriteLine($"Öğrenci{i + 1} İnternet dersinden aldığı not;");
                 double diger = Convert.ToDouble(Console.ReadLine());

                 if (alg >= 70 && (veri >= 65 || diger >= 65))   // (&&;ve) (||;veya) ()

                 {
                     Console.WriteLine($"Öğrenci{i + 1} Bilgi");
                     Console.WriteLine($"********************************");
                     Console.WriteLine($"Algoritma Sınav Sonucu{alg}:");
                     Console.WriteLine($"Veri Sınav Sonucu{veri}:");
                     Console.WriteLine($"İnternet Sınav Sonucu{diger}:");
                     Console.WriteLine($"{name} Başarılı");
                     Console.WriteLine($"********************************");
                 }
                 else 
                 {
                     Console.WriteLine("Başarısız");
                 }*/

            Console.ReadLine();
            
        }
    }
}

using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace _16_dec_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş string dəyərindəki bütün sözlərin arasında bir
            //boşluq qalacaq vəziyyətə salan metod.(Metoda "  Men   rusca
            //bilmirem" dəyəri göndərilərsə onu "Men rusca bilmirem" halına gətirməlidir.
            Console.WriteLine("task1");
            string statement = "  Men   rusca   bilmirem  ";
            OneSpace(ref statement);
            Console.WriteLine(statement);

            //Verilmiş string dəyərdəki sözlərin sayını tapan metod
            Console.WriteLine("task2");
            string words = "salam kitab defter kod alqoritm";

            words = words.Trim();

            string NewOne = "";
            int count = 1;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != ' ')
                {
                    NewOne += words[i];
                }
                else
                {
                    count++;
                }

            }
            Console.WriteLine(count);

            // Parameter olaraq integer array variable - ı(reference)
            //  və bir integer value qəbul edən və həmin integer value-nu
            //   integer array-ə yəni element kimi əlavə edən metod.

            int[] arr = { 1, 2, 3, 4 };
            int num = 6;
            Newarr(ref arr, ref num);




            //Gonderilmis fullname arrayinden yeni bir names arrayi duzeldib geri qaytaran metod.Fullname
            //arrayinin icindeki butun value-lar ad+" "+soyad formatindadir.Misalcun "Hikmet Abbasov".
            //Misalcun gelen arraydeki deyerler {"Hikmet Abbasov","Abdulla Qulamov","Cemile Hikmetova"}
            //olarsa return olunan arraydeki deyerler {"Hikmet","Abdulla","Cemile"} olmalidir


            //string[] array = { "Hikmet Abbasov", "Abdulla Qulamov", "Cemile Hikmetova" };
            //MakeNameOnly(ref array);
            //Console.WriteLine(array);



            //Verilmiş string dəyərin bir fullname olub olmadığını
            //yoxlayan metod.(Dəyərin fullname olma şərti daxilində yalnız hərflərin ola
            //bilməsi, yalnız 2 sözdən ibarət olması və hər bir sözün böyük hərfə başlayıb
            //kiçik hərflərlə davam etməsidir.



        }

        // static void OneSpace(ref string statement)
        //{
        //   statement = statement.Trim();

        // string NewStr= Regex.Replace(statement.Trim(), " +", " ");


        //statement = NewStr;
        //}
        static void OneSpace(ref string statement)
        {
            statement = statement.Trim();

            string NewStr = "";
            NewStr = statement.Trim().Replace("  ", "");
            statement = NewStr;

        }


        static void Newarr(ref int[] arr, ref int num)
        {
            int[] NewArr = new int[arr.Length + 1];
            int newindex = NewArr.Length - 1;

            for (int i = 0; i < arr.Length + 1; i++)
            {
                if (i < NewArr.Length - 1)
                    NewArr[i] = arr[i];
                else if (i == NewArr.Length - 1)
                    NewArr[i] = num;

                arr = NewArr;
            }

        }
        //static void MakeNameOnly(ref string[] array)
        //{
        //  int count = 0;


        //  for (int i = 0; i < array.Length; i++)
        //  {
        //     if (array[i] == " ")
        //    {
        //       count++;
        //       var wordsArr = array[i].Split(' ');
        //      var newSentence = string.Join("-", wordsArr);
        //  }

        // }



        //string[] newOne = new string[count];
        //for (int i = 0; i < array.Length; i++)
        //{
        //   if (array[i] != "-")
        //   {
        //      newOne[i] = array[i];
        //  else
        //{
        // break;
        //}
        // }
        // array = newOne;
        //}

        

        }





       
          
    }





}
    
      





       




    


       








         
    







using System;
using System.Linq;
using System.Reflection.Emit;

namespace Method_practice_reference_and_value_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1  -Verilmiş yazının əvvəlindəki boşluqları silib qayataran metod:

            ///Console.WriteLine(rmEmptyLine("  Azerbaycan Torpaqlari Artiq Azaddir."));
            ///
            Console.WriteLine(rmEmptyLine("      Elcin Mellimden birdenedir)")); 

            //  Task 2  -Verilmiş ədədlər siyahısından yalnız müsbət ədədlərindən ibarət yeni bir array düzəldib qaytaran metod

            //int[] numbers = new int[] { -3,5, 19,-22 };

            //positivNums(numbers);
        }

        // Method of Task 1

        static string rmEmptyLine(string word)
        {
            string empty = "";
            string alphabet = "qwertyuiopasdfghjklzxcvbnm";
            string newStr = word.ToLower();

            for (int i = 0; i < newStr.Length; i++)
            {
                if (word[i] != ' ')
                {
                    for (int j = 0; i < alphabet.Length; j++)
                    {
                        if (newStr[i] == alphabet[j])
                        {
                            for (int l = i; l < word.Length; l++)
                            {
                                empty += word[l];
                            }
                            return empty;
                        }
                    }
                }
            }
            return "0"; // 0 windows sisteminde false kimi islendiyinden ele yazmisam;
        }

        // Method of Task 2

        //static void positivNums(int[] nums)
        //{
        //    int[] positivNumbs = new int[nums.Length];
        //    int j = 0;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] > 0)
        //        {
        //            positivNumbs[j] += nums[i];
        //            Console.WriteLine(positivNumbs[j]);
        //            j++;
        //        }
        //    }
        //}

        // Bu taski yazmaq ucun 2saatdan cox vaxt xercledim hec cur return ede bilmedim Kecdiklerimize esasen herseyden istifade etmisem hetta internette bele arasdirdim;
    }
}

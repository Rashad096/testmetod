using System;
using System.Reflection.Metadata.Ecma335;

namespace Methodsto_14._12._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
        }

        //Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        //Verilmiş ədədin kvadratını qaytaran metod

        static int Square(int num)
        {
            return num * num;
        }

        //Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod

        static bool HasA(string word)
        {
            bool hasA = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    return true;
                }
            }
            return hasA;
        }

        //Verilmiş ədədin rəqəmləri cəmini qaytaran metod



        static int Sum_of_Num(int num)
        {
            int sum = 0;
            int lastnum = 0;
            while (num != 0)
            {
                lastnum = num % 10;
                sum = lastnum;
                num = (num - lastnum) / 10;
            }
            return sum;


        }

        //Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod

        static int Ortalama(int a, int b, int c, int d)
        {
            int result = (a * b * c * d) / 4;
            return result;
        }

        //Verilmiş ədədin verilmiş qüvvətini tapan metod 

        static int Void(int num, int power)
        {
            int total = 1;
            for (int i = 0; i < power; i++)
            {
                total = num * num;
            }
            return total;
        }

        //Verilmiş 3 ədəddən ən böyüyünü tapan metod

        

        //Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod

        static int ArraySum(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        //Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan metod

        static int BiggestNumArr(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        //Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index-i qaytaran metod

        static int BiggestIndex(int[] nums)
        {
            int max = 0;
            int maxindex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxindex = i;

                }

            }
            return maxindex;
        }

        //Verilmiş yazılar siyahısındaki (string array) verilmiş yazının yerləşdiyi indexi qaytaran metod.
        //Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın

        static int StrinIndex(string[] words, string word)
        {

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    return i;
                }
            }
            return -1;
        }

        //Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni bir array qaytaran metod.
        //Yəni metodu işə salın {4,-5,3,-2,6} ədədlərindən ibarət array göndərsəm metod geriyə {4,3,6} ədədlərindən ibarət array qaytarmalıdır

        static int[] PositiveNumsArray(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    count++;
                }
            }
            int[] newPositivearr = new int[count];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    newPositivearr[j] = nums[i];
                }
            }
            return newPositivearr;
        }

        //Verilmiş yazıda rəqəm olub olmadığını qaytaran metod

        static bool HasNum(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (IsNum(word[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsNum(char ch) //
        {
            char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return CharIndex(nums, ch) != -1;


        }

        static int CharIndex(char[] nums, char ch)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == ch)
                {
                    return i;
                }
            }
            return -1;
        }

        //Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod

        static int StringGotNum(string[] words)
        {
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (HasNum(words[i]))
                {
                    count++;
                }
            }
            return count;
        }


        //Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod

        static int FirstNonIndexString(string word) //
        {

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    return i;
                }
            }
            return -1;
        }

        //Verilmiş yazıdaki son boşluq olmayan index-i qaytaran metod
        static int LastNonIndexString(string word) //Rashad     |
        {
            for (int i = word.Length - 1; i > 0; i--)
            {
                if (word[i] != ' ')
                {
                    return i;
                }
            }
            return -1;
        }

        //Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
        static string TrimLeft(string word)
        {
            string totalStr = "";
            for (int i = FirstNonIndexString(word); i < word.Length; i++)
            {
                totalStr += word[i];
            }
            return totalStr;
        }

        //Verilmiş yazını sol və sağ tərəflərində boşluq olmayan vəziyyətdə qaytaran metod

        static string TrimRightAndLeft(string word) //(     salam sagol      )
        {
            string trimedfromleft = "";
            string trimedfromright = "";
            string total_Trimed_Str = "";
            for (int i = FirstNonIndexString(word); i < word.Length; i++)
            {
                trimedfromleft += word[i];   //(salam sagol       )
            }
            for (int i = LastNonIndexString(trimedfromleft); i > 0; i--)
            {
                trimedfromright += trimedfromleft[i];

            }
            return total_Trimed_Str;


        }
    }

}     
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21._12Homework1
{
    public static class StaticMethods
    {
        public static object DataTime { get; private set; }

        //task7
        //public static void DateTime()
        //{
        //    DateTime now = DataTime.Now;
        //    Console.WriteLine(now);
        //    now = now.AddDays(-2);
        //    now = now.AddHours(1);
        //    Console.WriteLine(now);
        //    Console.WriteLine(now.ToString("dd-mm-yyyy hh:mm"));
        //}

        //task 5
        private static void ChangeData()
        {
            int value = Convert.ToInt32(Console.ReadLine());
            value += 10;
            Console.WriteLine(value);
        }

        
        public static void stringOutput(string input)
        {

            Console.WriteLine("output" + ":" + input);

        }

        public static void sumArrayNumbers(string numbers)
        {

            string[] arrayValues = numbers.Split(' ');
            int[] myInts = Array.ConvertAll(arrayValues, int.Parse);
            int result = myInts.Sum();

            Console.WriteLine(result);

        }
        //task3
        public static int GetLetterCount(this string letter, string word)
        {
            //int count = 0;
            //foreach (char c in word)
            //{
            //    if (letter == c)
            //        count++;
            //}

            char character = char.Parse(letter);
            int result = word.ToLower().Count(x => x == character);
            return result;
        }

        public static bool Confirm(string title)
        {
            List<string> arrayValues = new List<string>();
            List<DictionaryValues> allResult = new List<DictionaryValues>();
               arrayValues = title.Split(' ').ToList();
            ConsoleKey response;
            do
            {
                if(arrayValues.Count() == 3)
                Console.Write($"{ title } [y/n] ");

                response = Console.ReadKey(false).Key;
                if(response == ConsoleKey.Y)
                {
                    Console.Write(Environment.NewLine);
                    string fromReadLine = Console.ReadLine();
                      List<string> otherValues = fromReadLine.Split(' ').ToList();
                    foreach (var item in otherValues)
                    {
                        arrayValues.Add(item);
                    }
                    //Console.Write($"{ title } [y/n] ");
                    //response = Console.ReadKey(false).Key;
                }
                //else if (response == ConsoleKey.N)
                //{
                    string c = Console.ReadLine();
                    foreach (var word in arrayValues)
                    {
                        int count = GetLetterCount(c, word);

                    DictionaryValues dictionaryValues = new DictionaryValues { 
                    
                    Key = count,
                    Value = word
                    };
                        allResult.Add(dictionaryValues);
         
                    }
             
               // }
                //if (response != ConsoleKey.Enter)
                //    Console.WriteLine();
               
            } while (response != ConsoleKey.Y && response != ConsoleKey.N);

            foreach (var item in allResult)
            {
                Console.WriteLine(item.Key.ToString() +" " + item.Value);
            }
            return (response == ConsoleKey.N);
        }
      

        //task6
         private static void  ChangeData2(int a, int b, int c, int d)
        {
            a += 2;
            b += 4;
            c += 6;
            d += 8;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");

          }
        //task8
        private static void birthday()
        {
            Datatime birthday = new Datatime(1992, 07, 01);
            Console.WriteLine($"Year:{birthday.ToString("yyyy")}");
            Console.WriteLine($"Month:{birthday.ToString("mm")}");
            Console.WriteLine($"Day:{birthday.ToString("dd")}");

            int bDay = Datatime.Now.Year - birthday.Year;
            Console.WriteLine($"{birthday.ToString("dd.mm.yyyy")} =  {bDay} bDay");

        }





    }
}

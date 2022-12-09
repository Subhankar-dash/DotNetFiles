using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallalLoop
{
    public class DigitToWord
    {


        public string Convertion(double number)
        {

            string[] oneDigit = { " ", "one", "two ", "Three", "four", "five", "six", "seven", "eight", "nine" };
            string[] twoDigit = { " ", "ten", "twenty ", "Thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            string[] threeDigit = { " ", "one hundred ", "two hundred", "Three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred" };
            string[] fourDigit = { " ", "one Thousand ", "two Thousand ", "Three Thousand ", "four Thousand ", "five Thousand ", "six Thousand", "seven Thousand", "eight Thousand", "nine Thousand" };
            string[] FiveDigit = { " ", "ten Thousand", "twenty Thousand", "Thirty Thousand", "fourty Thousand", "fifty Thousand", "sixty Thousand", "seventy Thousand", "eighty Thousand", "ninty Thousand" };
            string[] sixDigit = { " ", "one  Lakh", "two Lakh", "Three Lakh", "four Lakh", "five Lakh", "six Lakh", "seven Lakh", "eight Lakh", "nine Lakh" };
            string[] SevenDigit = { " ", "ten Lakh", "twenty Lakh ", "Thirty Lakh ", "fourty Lakh", "fifty Lakh", "sixty Lakh", "seventy Lakh", "eighty Lakh", "ninty Lakh" };
            List<double> data = new List<double>();
            List<string> Contain = new List<string>();
            string Ret = "";

            while (number > 0)
            {
                double c = number % 10;
                // Console.WriteLine(c);
                data.Add(c);

                number /= 10;
            }

            for (int i = 0; i < data.Count; i++)
            {
                if (i == 0)
                {
                    int x = (int)data[i];
                    string y = oneDigit[x];
                    Contain.Add(y);
                }
                if (i == 1)
                {
                    int x = (int)data[i];
                    string y = twoDigit[x];
                    Contain.Add(y);
                }
                if (i == 2)
                {
                    int x = (int)data[i];
                    string y = threeDigit[x];
                    Contain.Add(y);
                }
                if (i == 3)
                {
                    int x = (int)data[i];
                    string y = fourDigit[x];
                    Contain.Add(y);
                }
                if (i == 4)
                {
                    int x = (int)data[i];
                    string y = FiveDigit[x];
                    Contain.Add(y);
                }
                if (i == 5)
                {
                    int x = (int)data[i];
                    string y = sixDigit[x];
                    Contain.Add(y);
                }
                if (i == 6)
                {
                    int x = (int)data[i];
                    string y = SevenDigit[x];
                    Contain.Add(y);
                }



            }

            Contain.Reverse();
           // Console.WriteLine($"{string.Join("",Contain)}");
            var str = string.Join(" ", Contain);
            return str;

        }
    }
}

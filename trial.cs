using System;
using System.Text;
using static System.Console;
namespace csharpFundamentals
{

    //ONE World coders live test
    public class trial
    {
        public static string remoteControl(int width, string title)
        {
            string val = "";
            int count = 0;
            int temp = 0;
            int downCount = 0;
            string groupedStr = appendToWidth(width);
            string[] newStr = groupedStr.Split(",");
            for (int k = 0; k < title.Length; k++)
            {
                char i = title[k];
                for (int j = 0; j < newStr.Length; j++)
                {
                    if (newStr[j].Contains(i))
                    {
                        count++;
                        //get the position of the character
                    }
                    else
                    {
                        val += "D";
                        downCount++;
                        continue;

                    }
                    int pos = newStr[j].IndexOf(i);
                    if (count == 1)
                    {
                        val += new string('R', pos);
                        temp = pos;
                    }
                    else
                    {
                        val += new string('L', Math.Abs(temp - pos));
                    }
                    //WriteLine(pos);
                    break;
                }
                val += "*";
            }
            //WriteLine("downCount:{0}", downCount);
            return val;
        }

        public static string appendToWidth(int width)
        {
            string alpha = "ABCDEFGHIJKLMNOPQRSTYVWXYZ";
            int noOfChar = 26 / width;
            var newStr = new StringBuilder(alpha);
            for (int i = width; i < alpha.Length + noOfChar; i += (width + 1))
            {
                newStr.Insert(i, ',');
            }
            return newStr.ToString();
        }


    }
}
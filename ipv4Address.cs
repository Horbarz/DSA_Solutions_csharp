using System;
namespace csharpFundamentals
{
    public class ipv4Address
    {
        public static bool isIPv4Address(string inputString)
        {
            try
            {

                string[] str = inputString.Split('.');
                bool check = false;
                foreach (string i in str)
                {
                    if (i == "00")
                    {
                        return false;
                    }
                    //convert str to int
                    int val = Int32.Parse(i);
                    Console.WriteLine(i);
                    if (val >= 0 && val <= 255)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                return check;

            }
            catch (FormatException e)
            {
                return false;
            }

        }
    }
}
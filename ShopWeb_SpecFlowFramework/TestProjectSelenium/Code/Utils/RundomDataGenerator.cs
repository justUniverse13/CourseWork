using System;

namespace TestProjectSelenium.Code.Utils
{
    public class RundomDataGenerator
    {
        public static long Numeric(int length)
        {
            Random rand = new Random();
            string result = rand.Next(1, 9).ToString();

            while (result.Length < length)
            {
                result += rand.Next(9).ToString();
            }
            return long.Parse(result);
        }

        public static string Alphanumeric(int length)
        {
            var result = string.Empty;
            while (result.Length < length)
                result += Guid.NewGuid().ToString("N").ToUpper();

            return result.Substring(0, length);
        }

        public static string Email()
        {
            return $"At{Alphanumeric(10)}@{Alphanumeric(5)}.com";
        }
    }
}

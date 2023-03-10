using System.Text;

namespace CurrencyConverter_Server
{
    public class DollerConverter
    {

        /// <summary>
        /// Converts given dollar value to appropiate text
        /// </summary>
        /// <param name="number"></param>
        /// <returns name="string"> return converted dollar in text </returns>
        public string ConvertToDollar(int number)
        {
            if (number < 0 || number > 999999999)
                Console.WriteLine("dollar value more than 9 length is not supported");

            StringBuilder convertToWord = new StringBuilder();
           
            if ((number / 1000000) > 0)
            {
                convertToWord.Append(ConvertToDollar(number / 1000000) + " million ");
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                convertToWord.Append(ConvertToDollar(number / 1000) + " thousand ");
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                convertToWord.Append(ConvertToDollar(number / 100) + " hundred ");
                number %= 100;
            }

            return ConvertToWords(number, convertToWord);
        }

        /// <summary>
        /// Convert given cent value to appropiate text
        /// </summary>
        /// <param name="cent"></param>
        /// <returns name="string"> return converted cent in text  </returns>
        public string ConvertToCent(int cent)
        {
            StringBuilder convertToWord = new StringBuilder();

            if (cent < 0 || cent > 99)
                Console.WriteLine("Cent value more than 2 length is not supported");

            return ConvertToWords(cent, convertToWord);
        }


        /// <summary>
        /// comman function to convert numbers to text 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="strInput"></param>
        /// <returns> return string </returns>
        public string ConvertToWords(int number, StringBuilder strInput)
        {
            var units = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                strInput.Append(units[number]);
            else
            {
                strInput.Append(tens[number / 10]);
                if ((number % 10) > 0)
                    strInput.Append(" " + units[number % 10]);
            }

            return strInput.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_io2
{
    public class StringCalculator
    {
        public static int SumString(string str)
        {
            if(str == string.Empty)
                return 0;

            int sum = 0;

            if (int.TryParse(str, out sum))
            {
                if (sum < 0)
                    throw new ArgumentException();

                if (sum > 1000)
                    return 0;

                return sum;
            }

            char separator = ',';
            if(str.Substring(0, 2) == "//")
            {
                if (str[3] == '\n')
                    separator = str[2];
            }
            var numbers = str.Split(',', '\n', separator);
            foreach(var number in numbers)
            {
                int parsedNum = int.Parse(number);

                if(parsedNum < 0)
                    throw new ArgumentException();

                if (parsedNum > 1000)
                    parsedNum = 0;

                sum += parsedNum;
            }



            return sum;
        }
    }
}

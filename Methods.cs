using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxSugar
{
    public class Methods
    {
        public static string SyntaxSugarCode()
        {
            var answer = 4;

            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";

            return response;
        }
    }
}

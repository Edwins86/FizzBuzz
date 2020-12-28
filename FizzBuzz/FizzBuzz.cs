using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
   public class FizzBuzz 
    {

        private const string _message1 = "FizzBuzz!";
        private const string _message2 = "Fizz!";
        private const string _message3 = "Buzz!";
        private string _result;
        public int UserNumber { get; set; }
        


        public string ShowNumber (int userNumber)
        {
            if (userNumber %3 == 0 && userNumber %5 == 0)
            {
                _result = _message1;
            }
            else if (userNumber %3 == 0)
            {
                _result = _message2;
            }
            else if (userNumber %5 == 0)
            {
                _result = _message3;
            }

            else
            {
                _result = userNumber.ToString();
            }

            return _result;              
        }

    }
}

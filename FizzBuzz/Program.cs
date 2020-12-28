using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
       
                        
        static void Main(string[] args)
        {

            FizzBuzz fizz = new FizzBuzz();

            

            Console.WriteLine("Witaj graczu, wprowadź swoją cyfrę : ");

            try
            {
                fizz.UserNumber  = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Podano niewłaściwą wartość! Spróbuj ponownie");
            }
            
            
            
            string result = fizz.ShowNumber(fizz.UserNumber);

            Console.WriteLine(result);
            Console.ReadLine();


        }

        
    }
}

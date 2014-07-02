using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot("45734");

            Console.ReadKey();
        }

        static int DigitalRoot(string rootThis)
        {
            
            List<int> digits = new List<int>();
            
            string currentNum = rootThis;

            while (currentNum.Length > 1)
            {
                
                int counter = 0;

                
                for (int i = 0; i < currentNum.Length; i++)
                {
                    
                    digits.Add(Convert.ToInt32(currentNum[i].ToString()));
                }
                
                foreach (var item in digits)
                {
                    
                    counter += item;
                }
                
                currentNum = counter.ToString();
                
                digits.Clear();
            }

            int digitalRoot = Convert.ToInt32(currentNum);

            Console.WriteLine("Input: " + rootThis);
            Console.WriteLine("Output: " + digitalRoot);

            return digitalRoot;
        }
    }
}

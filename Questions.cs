using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Questions
    {
        public String getWrongAnswers(int N, String c)
        {
            String newString = " "; 
            foreach (Char newChar in c) { 
                if (newChar == 'a')
                {
                    newString += 'b'; 
                } else if (newChar == 'b')
                {
                    newString += 'a'; 
                }
                else
                {
                    Console.Write("String should only contains a and b");
                    break; 
                }
            }

            return newString; 
        }

        public int GetSum(char a, char b, char c)
        {
            return valueOfLetter(a) + valueOfLetter(b) + valueOfLetter(c); 
        }

        private int valueOfLetter(char letter)
        {
            switch (letter)
            {
                case 'a':
                    return 1;
                case 'b':
                    return 2;
                case 'c':
                    return 3; 
            }

            //should not get here but if we do, return 0
            return 0; 
        }
    }
}

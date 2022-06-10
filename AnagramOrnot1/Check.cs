using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnagramOrnot1
{
    internal class Check
    {
        public void angramorno()
        {
            Console.WriteLine(" Enter First string :");
            string firststr = Console.ReadLine();
            Console.WriteLine(" Enter Second  string");
            string secondstr = Console.ReadLine();
            if (firststr.Length == secondstr.Length)
            {
                char[] ch1 = (firststr.ToLower()).ToCharArray();
                char[] ch2 = (firststr.ToLower()).ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                string str1 = new string(ch1);
                string str2 = new string(ch2);
                if (str1==str2)
                {
                    Console.WriteLine("Anagram given two string");
                }
                else
                {
                    Console.WriteLine(" Not Anagram given string ");
                }





            }


        }
    }
}
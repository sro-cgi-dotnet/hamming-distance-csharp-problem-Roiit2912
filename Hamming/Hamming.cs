using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;
            int i=0;

            //Throwing exception for invalid input

                if(original==null)
                {
                    throw(new ArgumentNullException("original"));
                }
                if (current==null)
                {
                    throw(new ArgumentNullException("current"));
                }
                if(original.Length!=current.Length)
                {
                    throw(new ArgumentException("Hamming Distance can only be calculated over strings of equal length"));
                }
                 
            //converting all the characters of original and current string to upper case for matching both input strings easily

                original.ToUpper();

                current.ToUpper();

                //calculating the hamming distance

                while (i< original.Length)
                {
                    if(original[i]!=current[i])
                    {
                        hammingDistance++;
                    }
                    i++;
                }
            
            
            return hammingDistance;
        }
    }
}

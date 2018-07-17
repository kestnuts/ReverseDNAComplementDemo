using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDNAComplementDemo
{
    class DNA
    {
        
        public static string RandomDNA(int length)
        {
            string chars = "ACTG";
            var data = new byte[length];
            byte[] buffer = null;
            int maxRandom = byte.MaxValue - ((byte.MaxValue + 1) % chars.Length);

            RNGCryptoServiceProvider numgen = new RNGCryptoServiceProvider();

            numgen.GetBytes(data);
            var result = new char[length];
            for (int i = 0; i < length; i++)
            {
                byte v = data[i];
                while (v > maxRandom)
                {
                    if (buffer == null)
                    {
                        buffer = new byte[1];
                    }
                    numgen.GetBytes(buffer);
                    v = buffer[0];
                }
                result[i] = chars[v % chars.Length];
            }
            numgen.Dispose();
            return new string(result);

        }

        
       public static string ReverseString(string s)
        {
            string result = String.Empty;

            int length = s.Length - 1;
            while (length >= 0)
            {
                result = result + s[length];
                length--;
            }
            return result;
        }


       public static string ReverseDNAComplement(string s)
        {
            Hashtable ht = new Hashtable();

            ht.Add('A', 'T');
            ht.Add('T', 'A');
            ht.Add('C', 'G');

            ht.Add('G', 'C');

            string complement = String.Empty;

            foreach (char c in s)
            {
                complement = ht[c] + complement;
            }
            return complement;
        }
    }




    

   
}


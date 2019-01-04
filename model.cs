using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackOpsMasmCipherSolver
{
    static class Model
    {
        public static string RunDecipher(string cipher, string clen, string ccount)
        {
            //split string[] cipher into integer list
            string[] cipherString = cipher.Split(' ');
            List<UInt32> cipherInts = new List<UInt32>();
            foreach (String ss in cipherString)
            {
                cipherInts.Add(UInt32.Parse(ss));
            }
            //split string[] clen into integer list
            string[] clenString = clen.Split(' ');
            List<int> clenInts = new List<int>();
            foreach (String ss in clenString)
            {
                clenInts.Add(int.Parse(ss));
            }
            //convert ccount into an integer value
            int ccountLoop = int.Parse(ccount);

            //static data values used in cipher operations
            UInt32 mult = Convert.ToUInt32("41c64e6d", 16);
            UInt32 add1 = Convert.ToUInt32("3039", 16);
            UInt32 idiv1 = Convert.ToUInt32("8000", 16);
            UInt32 idiv2 = Convert.ToUInt32("1A", 16);
            UInt32 add2 = Convert.ToUInt32("41", 16);

            //string to append letters to
            string output = "";

            for (int i = 0; i < ccountLoop; i++)
            {
                for (int j = 0; j < clenInts[i]; j++)
                {
                    UInt32 firstData = cipherInts[i];
                    UInt32 res1 = firstData * mult;
                    UInt32 res2 = res1 + add1;
                    cipherInts[i] = res2;
                    UInt32 shr = (UInt32)(res2 / Math.Pow(2, 16));
                    UInt32 remainder1 = shr % idiv1;
                    UInt32 remainder2 = remainder1 % idiv2;
                    UInt32 outp = remainder2 + add2;
                    char ascii = (char)outp;
                    output += ascii.ToString();
                }
                output += " ";
            }
            return output;
        }
    }
}

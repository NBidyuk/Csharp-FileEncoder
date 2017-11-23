using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coding
{
    public class MyCoder
    {



        public static string MyEncoder(string text, string key)
        {
            byte[] inStr = Encoding.Unicode.GetBytes(text);
           
            byte[] res = new byte[inStr.Length];

            for (int i = 0; i < inStr.Length; i++)
            {
                res[i] = (byte)(inStr[i] ^ key[i % key.Length]);
            }

            return System.Convert.ToBase64String(res);
        }

        
        public static string MyDecoder(string encoding, string key)
        {
   
                var decoded = System.Convert.FromBase64String(encoding);

                byte[] res = new byte[decoded.Length];


                for (int i = 0; i < decoded.Length; i++)
                {
                    res[i] = (byte)((uint)decoded[i] ^ (uint)key[i % key.Length]);
                }

                return Encoding.Unicode.GetString(res);
           
        }

        public static bool IsBase64Encoded(String str)
        {
            try
            {
                // If no exception is caught, then it is possibly a base64 encoded string
                byte[] data = Convert.FromBase64String(str);
                
                return (str.Replace(" ", "").Length % 4 == 0);
            }
            catch
            {
                // If exception is caught, then it is not a base64 encoded string
                return false;
            }
        }

    }
}

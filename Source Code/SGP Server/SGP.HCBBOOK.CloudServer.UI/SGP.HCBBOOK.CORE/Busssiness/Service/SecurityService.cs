using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.CORE.Busssiness.Service
{
    public static class SecurityService
    {
        public static string Base64Encode(string plainText)
        {
            if(plainText!=null)
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                return System.Convert.ToBase64String(plainTextBytes);
            }

            return null;
        }

        public static string Base64Decode(string base64EncodedData)
        {
            if(base64EncodedData!=null)
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            return null;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Extensions
{
    public static class BytesExtension
    {
        public static string ToEncodedString(this byte[] bytes)
        {
            string hexString = string.Empty;

            foreach (var b in bytes)
            {
                hexString += b.ToString("X2");
            }

           uint.Parse(hexString, System.Globalization.NumberStyles.AllowHexSpecifier);

            return uint.Parse(hexString, System.Globalization.NumberStyles.AllowHexSpecifier).ToString();
        }
    }
}

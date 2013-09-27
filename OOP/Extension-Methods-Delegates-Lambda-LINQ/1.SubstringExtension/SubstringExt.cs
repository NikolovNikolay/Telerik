using System;
using System.Linq;
using System.Text;

namespace SubstringExtension
{
    public static class SubstringExt
    {
        public static StringBuilder Substring(this StringBuilder builder, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();

            string rawData = builder.ToString();

            return result.Append(rawData.Substring(startIndex, length));
        }
    }
}

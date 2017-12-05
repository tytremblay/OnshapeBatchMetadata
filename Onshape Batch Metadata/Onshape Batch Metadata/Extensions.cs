using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onshape.Api
{
    public static class Extensions
    {
        public static StringBuilder AppendQueryParam<T>(this System.Text.StringBuilder stringBuilder, string name, T value)
        {
            if (stringBuilder.Length > 0)
            {
                stringBuilder.Append("&");
            }
            return stringBuilder.Append(String.Format("{0}={1}", name, value));
        }

        public static string GetOptionValue(this Dictionary<string, List<string>> options, string name)
        {
            return options != null && options.ContainsKey(name) ? options[name][0] : null;
        }
    }
}

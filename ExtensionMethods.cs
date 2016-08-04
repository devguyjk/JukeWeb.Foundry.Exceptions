using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JukeWeb.Foundry.Exceptions
{
    public static class ExtensionMethods
    {
        public static string ToFormattedErrorMessage(this IDictionary<string, object> o)
        {
            return ToFormattedErrorMessage(o, "------------------------------------------------------");
        }

        public static string ToFormattedErrorMessage(this IDictionary<string, object> o, string itemSeperator)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string key in o.Keys)
                sb.AppendFormat("{0}:{1}", key, Environment.NewLine).AppendFormat("{0}{1}{2}", o[key], Environment.NewLine, (o.Count > 1) ? itemSeperator : "").AppendLine();

            return sb.ToString();
        }
    }
}

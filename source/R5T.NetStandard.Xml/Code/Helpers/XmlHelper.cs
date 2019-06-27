using System;
using System.Xml;


namespace R5T.NetStandard.Xml
{
    public static class XmlHelper
    {
        public const XmlNode SelectSingleNodeNotFound = null;


        public static bool SelectSingleNodeFound(XmlNode xmlNode)
        {
            var found = xmlNode != XmlHelper.SelectSingleNodeNotFound;
            return found;
        }

        public static string FormatNodeBeginningTag(string nodeName)
        {
            var output = $"<{nodeName}>";
            return output;
        }

        public static string FormatNodeEndingTag(string nodeName)
        {
            var output = $"</{nodeName}>";
            return output;
        }
    }
}

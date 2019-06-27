using System;
using System.Xml.Linq;


namespace R5T.NetStandard.Xml
{
    public static class XElementHelper
    {
        public const XElement NotFound = null;


        public static bool WasFound(XElement xElement)
        {
            var wasFound = xElement != XElementHelper.NotFound;
            return wasFound;
        }
    }
}

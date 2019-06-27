using System;


namespace R5T.NetStandard.Xml.Extensions
{
    public static class StringExtensions
    {
        public static XmlNodeName AsXmlNodeName(this string value)
        {
            var xmlNodeName = new XmlNodeName(value);
            return xmlNodeName;
        }
    }
}

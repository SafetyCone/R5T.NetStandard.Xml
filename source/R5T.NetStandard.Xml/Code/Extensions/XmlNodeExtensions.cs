using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;


namespace R5T.NetStandard.Xml
{
    public static class XmlNodeExtensions
    {
        public static IEnumerable<XmlNode> SelectNodesByXPath(this XmlNode xmlNode, string xPathValue)
        {
            var nodes = xmlNode.SelectNodes(xPathValue).OfType<XmlNode>();
            return nodes;
        }

        public static XmlElement SelectElementByXPath(this XmlNode xmlNode, string xPathValue)
        {
            var xmlElement = xmlNode.SelectSingleNode(xPathValue) as XmlElement;
            return xmlElement;
        }

        public static XElement ToXElement(this XmlNode xmlNode)
        {
            var xElement = XElement.Load(xmlNode.CreateNavigator().ReadSubtree());
            return xElement;
        }
    }
}

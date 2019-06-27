using System;
using System.Xml.Linq;

using R5T.NetStandard;


namespace R5T.NetStandard.Xml
{
    public class XmlNodeName : TypedString
    {
        #region Static

        public static implicit operator XName(XmlNodeName xmlNodeName)
        {
            return xmlNodeName.Value;
        }

        #endregion


        public XmlNodeName(string value)
            : base(value)
        {
        }
    }
}

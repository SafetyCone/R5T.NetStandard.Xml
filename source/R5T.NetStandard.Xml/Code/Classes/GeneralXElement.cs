using System;
using System.Xml.Linq;


namespace R5T.NetStandard.Xml
{
    /// <summary>
    /// A general XElement type for use there is no specific XElement type.
    /// </summary>
    public class GeneralXElement : TypedXElement
    {
        public GeneralXElement(XElement value)
            : base(value)
        {
        }
    }
}

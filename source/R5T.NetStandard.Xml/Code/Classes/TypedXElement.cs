using System;
using System.Xml.Linq;


namespace R5T.NetStandard.Xml
{
    public abstract class TypedXElement : Typed<XElement>
    {
        public TypedXElement(XElement value)
            : base(value)
        {
        }
    }
}

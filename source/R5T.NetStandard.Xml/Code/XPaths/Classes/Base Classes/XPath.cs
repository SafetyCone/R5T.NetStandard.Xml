using System;

using R5T.NetStandard;


namespace R5T.NetStandard.Xml.XPaths
{
    /// <summary>
    /// Abstract base-class for all XPaths.
    /// XPaths need not be absolute; they can be relative, they can be predicated, and they can contain axes.
    /// </summary>
    public abstract class XPath : TypedString
    {
        public XPath(string value) : base(value)
        {
        }
    }
}

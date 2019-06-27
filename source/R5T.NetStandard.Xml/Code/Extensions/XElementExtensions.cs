using System;
using System.Linq;
using System.Xml.Linq;


namespace R5T.NetStandard.Xml
{
    public static class XElementExtensions
    {
        public static GeneralXElement AsGeneralXElement(this XElement xElement)
        {
            var generalElement = new GeneralXElement(xElement);
            return generalElement;
        }

        public static bool HasElement(this XElement xElement, XName name, out XElement element)
        {
            element = xElement.Element(name);

            var hasElement = XElementHelper.WasFound(element);
            return hasElement;
        }

        public static bool HasElement(this XElement xElement, XName name)
        {
            var hasElement = xElement.HasElement(name, out var dummy);
            return hasElement;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the <see cref="XElement"/> does not have an element of the specified name.
        /// </summary>
        public static XElement GetElement(this XElement xElement, XName name)
        {
            var hasElement = xElement.HasElement(name, out var element);
            if (!hasElement)
            {
                throw new ArgumentException($"No element of name '{name}'.", nameof(name));
            }

            return element;
        }

        public static XElement AddElement(this XElement xElement, XName name)
        {
            var element = new XElement(name);
            xElement.Add(element);

            return element;
        }

        public static XElement AddElement(this XElement xElement, XName name, string value)
        {
            var element = xElement.AddElement(name);
            element.Value = value;

            return element;
        }

        public static XElement AddElement(this XElement xElement, XName name, object content)
        {
            var element = new XElement(name, content);
            xElement.Add(element);

            return element;
        }

        /// <summary>
        /// Get the element with the speicified name, if it exists, or adds an element with the specified if it does not exist.
        /// </summary>
        public static XElement AcquireElement(this XElement xElement, XName name)
        {
            var hasElement = xElement.HasElement(name, out var element);
            if(hasElement)
            {
                return element;
            }

            element = new XElement(name);
            return element;
        }
    }
}

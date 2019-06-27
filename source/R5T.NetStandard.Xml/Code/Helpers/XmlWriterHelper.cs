using System;
using System.IO;
using System.Xml;


namespace R5T.NetStandard.Xml
{
    public static class XmlWriterHelper
    {
        /// <summary>
        /// The System XML writer includes an XML declaration by default, however this is often not desired.
        /// An XML writer can be created with settings specifying to omit the XML declaration, but other settings must be set to get the desired default behavior.
        /// This method produces XML writer settings that replicate the default settings, except specifying to omit the declaration.
        /// </summary>
        public static XmlWriterSettings GetNoDeclarationXmlWriterSettings()
        {
            var settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
            };

            return settings;
        }

        /// <summary>
        /// Gets the standard XML writer settings.
        /// </summary>
        /// <returns></returns>
        public static XmlWriterSettings GetSettings()
        {
            var settings = XmlWriterHelper.GetNoDeclarationXmlWriterSettings();

            settings.Indent = true;

            return settings;
        }

        /// <summary>
        /// The System XML writer includes an XML declaration by default, however this is often not desired.
        /// An XML writer can be created with settings specifying to omit the XML declaration, but other settings must be set to get the desired default behavior.
        /// This method produces an XML writer that omits the declaration.
        /// </summary>
        public static XmlWriter NewOmitDeclaration(Stream stream)
        {
            var settings = XmlWriterHelper.GetNoDeclarationXmlWriterSettings();

            var writer = XmlWriter.Create(stream, settings);
            return writer;
        }

        /// <summary>
        /// Gets the standard XML writer.
        /// </summary>
        public static XmlWriter New(Stream stream)
        {
            var settings = XmlWriterHelper.GetSettings();

            var writer = XmlWriter.Create(stream, settings);
            return writer;
        }
    }
}

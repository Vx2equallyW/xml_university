using System.Xml.Serialization;
using System.Xml;

namespace EssentialClasses
{
    public static class XmlDataProvider<T>
        where T : class, new()
    {
        static XmlSerializer xmlSer = new XmlSerializer(typeof(T));
        public static void SaveObject(string uri, T obj)
        {
            XmlWriterSettings xmlWrS = new XmlWriterSettings();
            xmlWrS.Indent = true;
            XmlWriter xmlWrt = XmlWriter.Create(uri, xmlWrS);
            xmlSer.Serialize(xmlWrt, obj);
            xmlWrt.Close();
        }

        public static T LoadObject(string uri)
        {
            XmlReaderSettings xmlRdS = new XmlReaderSettings();
            XmlReader xmlRdr = XmlReader.Create(uri, xmlRdS);
            T obj = xmlSer.Deserialize(xmlRdr) as T;
            xmlRdr.Close();
            return obj;
        }

    }
}

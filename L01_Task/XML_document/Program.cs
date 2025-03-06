using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

namespace XMLdocument
{
    class Program
    {
        public static void DisplayXMLNodeData(XmlReader reader)
        {
            switch (reader.NodeType)
            {
                case XmlNodeType.Element:
                    Console.WriteLine("Element <{0}>:", reader.Name);
                    if (reader.HasAttributes == true)
                    {
                        Console.WriteLine("Attributes of <{0}>:", reader.Name);
                        while (reader.MoveToNextAttribute())
                        {
                            Console.WriteLine("- {0} = {1}", reader.Name, reader.Value);
                        }
                    }
                    break;
                case XmlNodeType.Text:
                    Console.WriteLine("Text: " + reader.Value);
                    break;
                case XmlNodeType.Comment:
                    Console.WriteLine("Comment: " + reader.Value);
                    break;
                case XmlNodeType.CDATA:
                    Console.WriteLine("CDATA section: " + reader.Value);
                    break;

            }
        }

        public static void ReadXML(string uri)
        {
            XmlReaderSettings rdSettings = new XmlReaderSettings();

            rdSettings.IgnoreWhitespace = true;
            rdSettings.IgnoreComments = false;



            XmlReader xmlRdr = XmlReader.Create(uri, rdSettings);

            Console.WriteLine("Reading data from file: {0}", uri);

            try
            {
                while (xmlRdr.Read()) DisplayXMLNodeData(xmlRdr);
            }
            catch(XmlException exc)
            {
                Console.WriteLine("Error in document! Description: {0}", exc.Message);
            }

            xmlRdr.Close();

        }

        public static void WriteXML(string uri)
        {
            XmlWriterSettings wrSettings = new XmlWriterSettings();

            wrSettings.Indent = true;
            wrSettings.Encoding = Encoding.UTF8;

            XmlWriter xmlWrt = XmlWriter.Create(uri, wrSettings);

            xmlWrt.WriteStartDocument();
            xmlWrt.WriteComment("Shedule for group IIb-233");
            xmlWrt.WriteStartElement("shedule");

                xmlWrt.WriteStartElement("week");
                    xmlWrt.WriteAttributeString("week_type", "odd");

                    xmlWrt.WriteStartElement("day");
                        xmlWrt.WriteAttributeString("date", "2025-02-07");

                        xmlWrt.WriteStartElement("class");
                            xmlWrt.WriteAttributeString("class_type", "lecture");
                            xmlWrt.WriteAttributeString("class_number", "2");

                            xmlWrt.WriteStartElement("teacher");
                                xmlWrt.WriteAttributeString("job_title", "lector");

                                xmlWrt.WriteStartElement("full_name");
                                    xmlWrt.WriteString("Назимов Александр Сергеевич");
                                xmlWrt.WriteEndElement();

                            xmlWrt.WriteEndElement();

                            xmlWrt.WriteStartElement("class_name");
                                xmlWrt.WriteString("Теория информационных процессов и систем");
                            xmlWrt.WriteEndElement();

                            xmlWrt.WriteStartElement("class_auditorium");
                                xmlWrt.WriteString("4 лек");
                            xmlWrt.WriteEndElement();

                        xmlWrt.WriteEndElement();

                    xmlWrt.WriteEndElement();

                xmlWrt.WriteEndElement();

            xmlWrt.WriteEndElement();
            xmlWrt.Close();

            Console.WriteLine("XML data is written to: /bin/Debug/net8.0/Shedule_out.xml");

        }

        public static void Main(string[] args)
        {
            string uri_read = "Shedule.xml";
            string uri_write = "Shedule_out.xml";
            ReadXML(uri_read);
            WriteXML(uri_write);
        }

        

    }
}
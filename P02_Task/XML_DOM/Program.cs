using System.Xml;
namespace XML_DOM
{
   class ConsoleUI {
      
   }

   class Program {
      static void Main()
      {
         Console.Title = "Создание и чтение XML-документа с использованием модели DOM";

         // URI, задающий путь к XML-документу
         string uri = @"StudentInfo.xml";

         // Создание начального XML
         XmlDocument XMLDoc = XMLCreate(uri);

         // Загрузка XML из файла
         XMLDoc = XMLLoad(uri);

         // Сохранение XML
         //XMLSave(XMLDoc, uri);

         // Отображение XML
         XMLDisplay(XMLDoc);
         Console.WriteLine("\n");
         XmlNodeList? student = GetStudentData("0", XMLDoc);
         if(student == null) {
            Console.WriteLine("Null");
         } else {
            foreach (XmlNode info in student) {
               Console.WriteLine($"{info.InnerText}");
            }
         }
         
      }

      static XmlDocument XMLCreate(string url)
      {
         XmlDocument XMLDoc = new XmlDocument();

         XMLDoc.AppendChild(XMLDoc.CreateXmlDeclaration("1.0", "utf-8", "yes"));
         XMLDoc.AppendChild(XMLDoc.CreateComment("Данные о студентах"));

         XmlElement rootElement = XMLDoc.CreateElement("students");

         XMLDoc.AppendChild(rootElement);
         rootElement.SetAttribute("xmlns", "https://github.com/Vx2equallyW");

         string vxtNsUri = "https://github.com/Vx2equallyW/xml_university";
         rootElement.SetAttribute("xmlns:vxt", vxtNsUri);


         XmlElement studentElement = XMLDoc.CreateElement("student");
         rootElement.AppendChild(studentElement);
         studentElement.SetAttribute("id", "0");

         XmlElement fullNameElement = XMLDoc.CreateElement("full_name");
         studentElement.AppendChild(fullNameElement);
         fullNameElement.InnerText = "Иванов Иван Иванович";

         XmlElement groupElement = XMLDoc.CreateElement("group");
         studentElement.AppendChild(groupElement);
         groupElement.InnerText = "ИИб-233";
         
         XmlElement sexElement = XMLDoc.CreateElement("sex");
         studentElement.AppendChild(sexElement);
         sexElement.InnerText = "м";

         XmlElement dateOfBirthElement = XMLDoc.CreateElement("date_of_birth");
         studentElement.AppendChild(dateOfBirthElement);
         dateOfBirthElement.InnerText = "07.07.2003";

         XmlElement averageScoreElement = XMLDoc.CreateElement("average_score");
         studentElement.AppendChild(averageScoreElement);
         averageScoreElement.InnerText = "94.6";

         return XMLDoc;
      }

      static XmlDocument XMLLoad(string url)
      {
         XmlDocument XMLDoc = new XmlDocument();
         XMLDoc.Load(url);
         return XMLDoc;
      }

      static void XMLSave(string url, XmlDocument xmlDoc)
      {
         xmlDoc.Save(url);
         Console.WriteLine("XML-документ создан по адресу: " + url);
      }

      static void XMLDisplay(XmlDocument xmlDoc)
      {
         Console.WriteLine("Код XML-документа:\n" + xmlDoc.InnerXml);
      }

      
      //GetStudent and GetStudentData can be united into just GetStudentData
      static XmlNodeList? GetStudentData(string id, XmlDocument xmlDoc)
      {
         XmlNamespaceManager XmlNSMngr = new XmlNamespaceManager(xmlDoc.NameTable);
         XmlNSMngr.AddNamespace("t", "https://github.com/Vx2equallyW");
         XmlNode? student = xmlDoc.SelectSingleNode("//t:student", XmlNSMngr);

         if (student == null)
         {
            return null;
         }
         return student.ChildNodes;
      }

      static void CreateStudent(
            string fullName,
            string group,
            string sex,
            string dateOfBirth,
            string averageScore,
            XmlDocument xmlDoc
            )
      {
         XmlElement rootElement = xmlDoc.DocumentElement;

         XmlNamespaceManager XmlNSMngr = new XmlNamespaceManager(xmlDoc.NameTable);
         XmlNSMngr.AddNamespace("t", "https://github.com/Vx2equallyW");
         XmlNodeList idList = xmlDoc.SelectNodes("//t:student/@id", XmlNSMngr);

         //Problem with id not being unique.
         //Get id list. Monitor it.

         XmlElement studentElement = xmlDoc.CreateElement("student");
         rootElement.AppendChild(studentElement);
         studentElement.SetAttribute("id", "0");

         XmlElement fullNameElement = xmlDoc.CreateElement("full_name");
         studentElement.AppendChild(fullNameElement);
         fullNameElement.InnerText = "Иванов Иван Иванович";

         XmlElement groupElement = xmlDoc.CreateElement("group");
         studentElement.AppendChild(groupElement);
         groupElement.InnerText = "ИИб-233";
         
         XmlElement sexElement = xmlDoc.CreateElement("sex");
         studentElement.AppendChild(sexElement);
         sexElement.InnerText = "м";

         XmlElement dateOfBirthElement = xmlDoc.CreateElement("date_of_birth");
         studentElement.AppendChild(dateOfBirthElement);
         dateOfBirthElement.InnerText = "07.07.2003";

         XmlElement averageScoreElement = xmlDoc.CreateElement("average_score");
         studentElement.AppendChild(averageScoreElement);
         averageScoreElement.InnerText = "94.6";
      }
      
   }
}

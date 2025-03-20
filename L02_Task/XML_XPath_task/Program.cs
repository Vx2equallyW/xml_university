using System.Xml;
using System.Xml.XPath;

namespace XML_XPath
{
   class Program
   {
      static void XPathProcess(XPathNavigator xpnav, string exprs, string title)
      {
         double result = 0.0;
         XmlNamespaceManager nsMgr = new XmlNamespaceManager(xpnav.NameTable);
         nsMgr.AddNamespace("t", "https://github.com/Vx2equallyW");
         nsMgr.AddNamespace("vxt", "https://github.com/Vx2equallyW/xml_example");
         bool isNumber = double.TryParse(xpnav.Evaluate(exprs, nsMgr).ToString(),
               out result);
         if (!isNumber)
         {
            Console.WriteLine(title);
            XPathNodeIterator xpnIter = xpnav.Select(exprs, nsMgr);
            XPathNavigator navCurNode = xpnIter.Current;
            while (xpnIter.MoveNext())
            {
               Console.WriteLine("- {0}", navCurNode.Value);
            }
         }
         else Console.WriteLine(title + " {0}", result);
         Console.WriteLine();
      }

      static void Query1(XPathNavigator xpNav)
      {
         string title = "1. Все учебные дисциплины:";
         string exprs = "//t:class_name";
         XPathProcess(xpNav, exprs, title);
      }

      static void Query2(XPathNavigator xpNav)
      {
         string title = "2. Общее число занятий на четной и нечетной неделях:";
         string exprs = "count(//t:class)";
         XPathProcess(xpNav, exprs, title);
      }

      static void Query3(XPathNavigator xpNav, string dayOfWeek)
      {
         string title = string.Format("3. Все аудитории, в которых проводятся занятия в {0}:", dayOfWeek);
         string exprs = string.Format("//t:day[@week_day='{0}']/t:class/t:class_auditorium", dayOfWeek);
         XPathProcess(xpNav, exprs, title);
      }

      static void Query4(XPathNavigator xpNav, string jobTitle)
      {
         string title = string.Format("4. Число занятий, которые ведут преподаватели с должность {0}", jobTitle);
         string exprs = string.Format("count(//t:class/vxt:teacher[@vxt:job_title='{0}']/ancestor::t:class)", jobTitle);
         XPathProcess(xpNav, exprs, title);
      }

      static void Query5(XPathNavigator xpNav, string auditorium)
      {
         string title = string.Format("5. Дни недели, по которым занятия в ауд. {0} первой парой.", auditorium);
         string exprs = string.Format("//t:class/t:class_auditorium[.='{0}']/ancestor::t:class[@class_number='1']/ancestor::t:day/@week_day", auditorium);
         XPathProcess(xpNav, exprs, title);
      }

      static void Query6(XPathNavigator xpNav)
      {
         string title = "6. Среднее число занятий в один день:";
         string exprs = "count(//t:class) div count(//t:day)";
         XPathProcess(xpNav, exprs, title);
      }

      static void Query7(XPathNavigator xpNav, uint amountOfClasses)
      {
         string title = string.Format("7. Дни недели, по которым проводится более {0} занятий", amountOfClasses);
         string exprs = string.Format("//t:day[count(t:class)>{0}]/@week_day", amountOfClasses);
         XPathProcess(xpNav, exprs, title);
      }

      static void Query8(XPathNavigator xpNav, uint minAmountOfClasses, uint maxAmountOfClasses)
      {
         string title = string.Format("8. Количество дней в которые количество лекций от {0} до {1}:", minAmountOfClasses, maxAmountOfClasses);
         string exprs = string.Format("count(//t:day[count(t:class[@class_type='lecture']) >= {0} and count(t:class[@class_type='lecture']) <= {1}])", minAmountOfClasses, maxAmountOfClasses);
         XPathProcess(xpNav, exprs, title);
      }

      static void Query9(XPathNavigator xpNav, string teacherFullName)
      {
         string title = string.Format("9. Дни недели по которым занятия проводит преподаватель с ФИО {0}:", teacherFullName);
         string exprs = string.Format("//vxt:full_name[.='{0}']/ancestor::t:day/@week_day", teacherFullName);
         XPathProcess(xpNav, exprs, title);
      }

      static void Query10(XPathNavigator xpNav, int classPosition)
      { 
         string title = string.Format("10. Число занятий, следующих в документе за занятием с указаным кодом: {0}:", classPosition);
            string exprs = string.Format("count(//t:class[@id={0}]/following::t:class)", classPosition);
            XPathProcess(xpNav, exprs, title);
      }


      public static void Main()
      {
         Console.Title = "Запросы XPath";

         string uri = @"Shedule.xml";

         XPathDocument xpDoc = new XPathDocument(uri);

         XPathNavigator xpNav = xpDoc.CreateNavigator();


        //XML Файл распологается в bin/Debug/net8.0/
         Query1(xpNav);
         Query2(xpNav);
         Query3(xpNav, "monday");
         Query4(xpNav, "sport_man");
         Query5(xpNav, "4 лек");
         Query6(xpNav);
         Query7(xpNav, 2);
         Query8(xpNav, 2, 3);
         Query9(xpNav, "Алексеева Г. А.");
         Query10(xpNav, 19);
        }
   }
}

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
         string exprs = string.Format("count(//t:class/vxt:teacher[@job_title='{0}'])", jobTitle);
         XPathProcess(xpNav, exprs, title);
      }


      static void Query5(XPathNavigator xpNav, string auditorium)
      {
         string title = string.Format("5. Дни недели, по которым занятия в ауд. {0} первой парой.", auditorium);
         string exprs = string.Format("//t:class[t:class_auditorium='{0}']/t:self", auditorium);
         // //t:day[@week_day]/t:class[t:class_auditorium='{0}']/parent::t:class[@class_number='1']
         XPathProcess(xpNav, exprs, title);
      }

/*
      static void Query6(XPathNavigator xpNav)
      {
         string title = string.Format("", );
         string exprs = string.Format("", );
         XPathProcess(xpNav, exprs, title);
      }

*/

      /*
      static void Query7(XPathNavigator xpNav, string dayOfWeek)
      {
         string title = string.Format("3. Все аудитории, в которых проводятся занятия в {0}:", dayOfWeek);
         string exprs = string.Format("//t:day[@week_day='{0}']/t:class/t:class_auditorium", dayOfWeek);
         XPathProcess(xpNav, exprs, title);
      }

      static void Query8(XPathNavigator xpNav, string dayOfWeek)
      {
         string title = string.Format("3. Все аудитории, в которых проводятся занятия в {0}:", dayOfWeek);
         string exprs = string.Format("//t:day[@week_day='{0}']/t:class/t:class_auditorium", dayOfWeek);
         XPathProcess(xpNav, exprs, title);
      }

      static void Query9(XPathNavigator xpNav, string dayOfWeek)
      {
         string title = string.Format("3. Все аудитории, в которых проводятся занятия в {0}:", dayOfWeek);
         string exprs = string.Format("//t:day[@week_day='{0}']/t:class/t:class_auditorium", dayOfWeek);
         XPathProcess(xpNav, exprs, title);
      }

      static void Query10(XPathNavigator xpNav, string dayOfWeek)
      {
         string title = string.Format("3. Все аудитории, в которых проводятся занятия в {0}:", dayOfWeek);
         string exprs = string.Format("//t:day[@week_day='{0}']/t:class/t:class_auditorium", dayOfWeek);
         XPathProcess(xpNav, exprs, title);
      }

*/

      public static void Main()
      {
         Console.Title = "Запросы XPath";

         string uri = @"Shedule.xml";

         XPathDocument xpDoc = new XPathDocument(uri);

         XPathNavigator xpNav = xpDoc.CreateNavigator();

         Query1(xpNav);
         Query2(xpNav);
         Query3(xpNav, "monday");
         Query4(xpNav, "sport_man");
         Query5(xpNav, "3114");
      }
   }
}

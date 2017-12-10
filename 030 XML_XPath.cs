using System;
using System.Xml;
using System.Xml.XPath;

// Выборка из XML с помощью XPath. (Запросы XPath)

namespace XML
{
    class Program
    {
        static void Main()
        {
            // Создание XPath документа.
            var document = new XPathDocument("029 XMLTextReader.xml");
            XPathNavigator navigator = document.CreateNavigator();

            // Прямой запрос XPath.
            XPathNodeIterator iterator1 = navigator.Select("ListOfBooks/Book/Title");
            while (iterator1.MoveNext())
            {
                Console.WriteLine(iterator1.Current);
            }
            Console.WriteLine(new string('-',20));
            // Скомпилированный запрос XPath
            XPathExpression expr = navigator.Compile("ListOfBooks/Book[2]/Price");
            XPathNodeIterator iterator2 = navigator.Select(expr);

            while (iterator2.MoveNext())
            {
                Console.WriteLine(iterator2.Current);
            }

			// ========================================================================

			// Создание XPath документа.
			document = new XPathDocument("029 XMLTextReader.xml");

			// Единственное назначение XPathDocument - создание навигатора.
			navigator = document.CreateNavigator();

			// При создании навигатора при помощи XPathDocument возможно выполнять только чтение.
			Console.WriteLine("Навигатор создан только для чтения. Свойство CanEdit = {0}.", navigator.CanEdit);

			// Используя XmlDocument навигатор можно использовать и для редактирования.
			var xmldoc = new XmlDocument();
			xmldoc.Load("029 XMLTextReader.xml");

			navigator = xmldoc.CreateNavigator();
			Console.WriteLine("Навигатор получил возможность редактирования. Свойство CanEdit = {0}.", navigator.CanEdit);

			// Теперь можно попробовать что-то записать в XML-документ.
			// Выполняем навигацию к узлу Book.
			navigator.MoveToChild("ListOfBooks", "");
			navigator.MoveToChild("Book", "");

			// Проводим вставку значений.
			navigator.InsertBefore("<InsertBefore>insert_before</InsertBefore>");
			navigator.InsertAfter("<InsertAfter>insert_after</InsertAfter>");
			navigator.AppendChild("<AppendChild>append_child</AppendChild>");

			navigator.MoveToNext("Book", "");

			navigator.InsertBefore("<InsertBefore>1111111111</InsertBefore>");
			navigator.InsertAfter("<InsertAfter>2222222222</InsertAfter>");
			navigator.AppendChild("<AppendChild>3333333333</AppendChild>");

			// Сохраняем изменения.
			xmldoc.Save("030 XML_XPath.xml");

            // Delay.
            Console.ReadKey();
        }
    }
}

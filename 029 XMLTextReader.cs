using System;
using System.IO;
using System.Xml;
using System.Text;

// Загрузка содержимого XML из файла.

namespace XML
{
	class Program
	{
		static void Main()
		{
			FileStream stream = new FileStream("029 XMLTextReader.xml", FileMode.Open);

			XmlTextReader xmlReader = new XmlTextReader(stream);

			while (xmlReader.Read())
			{
				Console.WriteLine("{0,-10} {1,-10} {2,-10}",
					xmlReader.NodeType,
					xmlReader.Name,
					xmlReader.Value);
			}

			xmlReader.Close();
			stream.Close();

			// =========================================================================
			string xmlData = "<?xml version='1.0' encoding='utf-8' ?><Book><Title>CLR via C#</Title></Book>";

		    var stringReader = new StringReader(xmlData);
            var reader = new XmlTextReader(stringReader);
            
			while (reader.Read())
			{
				Console.WriteLine("{0,-15} {1,-10} {2,-10}",
					reader.NodeType.ToString(),
					reader.Name,
					reader.Value);
			}

			reader.Close();

			// =========================================================================
			xmlReader = new XmlTextReader("029 XMLTextReader.xml");

            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                	// Проверка на тип узла необходима, иначе будут найдены не только открывающие элементы (XmlNodeType.Element),
	                // но и закрывающие (XmlNodeType.EndElement).
    	            if (xmlReader.Name.Equals("Title"))   // Закомментировать и выполнить.
        	        {
            	    	Console.WriteLine("Есть атрибут:{0} при Title!!! <{1}>", xmlReader.HasAttributes, xmlReader.GetAttribute("FontSize"));
                	}

                    xmlReader.Read(); // Читаем содержимое узла.
                    Console.WriteLine("{0}:{1}", xmlReader.NodeType, xmlReader.Value);
                }
                else
                {
                    Console.WriteLine("{0}", xmlReader.NodeType);
                }


            }

			// ---------------------------------------------------------------------------------------
            // var xmlWriter = new XmlTextWriter("029 XMLTextWriter.xml", null);
			var xmlWriter = new XmlTextWriter("029 XMLTextWriter.xml", Encoding.GetEncoding(1251))
					{
						Formatting = Formatting.Indented,
						IndentChar = '\t',
						Indentation = 1,
						QuoteChar = '\''
					};

            xmlWriter.WriteStartDocument();                  // Заголовок XML - <?xml version="1.0"?>
            xmlWriter.WriteStartElement("ListOfBooks");      // Корневой элемент - <ListOfBooks>
            xmlWriter.WriteStartElement("Book");             // Книга 1 - <Book
            xmlWriter.WriteStartAttribute("FontSize");       // Атрибут - FontSize
            xmlWriter.WriteString("8");
          //  xmlWriter.WriteString("18");   // ="8"
            xmlWriter.WriteEndAttribute();                   // >
            xmlWriter.WriteString("Title-1");                // Title-1
            xmlWriter.WriteComment("Строка комментария.");
            xmlWriter.WriteEndElement();                     // </Book>
            xmlWriter.WriteEndElement();                     // </ListOfBooks>

            xmlWriter.Close();


			// Delay.
			Console.ReadKey();
		}
	}
}

using System;
using System.Text.RegularExpressions;

// Регулярные выражения.
// \d   Любая цифра
// \D 	Любой символ не-цифра
// \w 	Цифра, буква или подчеркивание
// \W   НЕ-Цифра, буква или подчеркивание
// \s 	Любой непечатный символ, включая пробел. 
// \S 	Любой символ, кроме табуляции, новой строки и Enter
// .    Любой символ кроме Enter

// ^  	c начала строки
// $ 	до конца строки 
// + 	одно и более вхождений
// * 	ни одного и более вхождений 

/*
          Метод Regex.Replace заменяет в первом параметре - строке (myString) 
          подстроку соответствующую шаблону (String) во втором параметре, на подстроку-вставку в третем параметре (Test).
          Regex.Replace("myString","String","Test"); - результат myTest
  
          Шаблонные переменные - обьявляются в текущем шаблоне таким образом:
          (?<somevar>\d+)  - объявление переменной.
          ${somevar}  -  использование шаблонных переменных в новом шаблоне.

            // | - символ для указания вариантов шаблона (ИЛИ). 
            string pattern = "test|str|aaaa";

          Match представляет подстроку соответсвующую шаблону.
          Match.Success - булево значение, которое показывает найдено вхождение или нет.
          Все переменные обьявленные в шаблоне( (?<mylink>) и (?<mylnktext>) ) хранятся в колекции Mathes.Groups.
          В нашем случае нам прийдется использовать m.Groups["mylink"] и m.Groups["mylnktext"],
          для вывода значения каждой переменной. 

          Regex regex = new Regex(@"[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4}");
*/

class Program
{
	static void Main()
    {
		const string pattern = @"^\d+$";
        var regex = new Regex(pattern);
        string s = "Строка 01";

		bool success = regex.IsMatch(s);
        Console.WriteLine("Выражение '{0}' соответствует шаблону '{1}': {2}", s, pattern, success);

		s = "12345";
		success = regex.IsMatch(s);
        Console.WriteLine("Выражение '{0}' соответствует шаблону '{1}': {2}", s, pattern, success);

        Console.WriteLine(Regex.Replace("02/05/1982",                                         	// Исходная строка
                                        @"(?<месяц>\d{1,2})/(?<день>\d{1,2})\/(?<год>\d{2,4})", // Шаблон
                                         "${день}-${месяц}-${год}"));                           // Новый формат


		s = "<a href='http://cbsystematics.com'>Home-page</a>";
        s+= "<a href='http://google.com'>Search</a>";
        s+= "<a href='https://ya.ru'>Yandex</a>";
        s+= "<a href='https://yandex.ru'>Yandex Full</a>";
        s+= "<a href='http://microsoft.com'>Microsoft</a>";

        regex = new Regex(@"href='(?<link>\S+)'>(?<text>\S+)</a>");
        Console.WriteLine(s);
        
		//             foreach (Match m in regex.Matches(input))    
        for (var m = regex.Match(s); m.Success; m = m.NextMatch())
        {
        	Console.WriteLine("ССЫЛКА: {0,-25} на: {1,-4} позиции с именем: {2}", m.Groups["link"],
                                                                                  m.Groups["link"].Index,
                                                                                  m.Groups["text"]);
        }

    }
}

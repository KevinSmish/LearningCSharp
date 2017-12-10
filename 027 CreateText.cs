using System;
using System.IO;
using System.Text;

// Чтение/запись файлов.

namespace InputOutput
{
    class Program
    {
        static void Main()
        {
            // Создаем файл.
			var file = new FileStream("text.txt",FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            var writer = new StreamWriter(file, Encoding.GetEncoding(1251));
            
            writer.WriteLine("Строка 1");
            writer.WriteLine("Строка 2");

            // Вставляем символ начала новой строки.
            writer.Write(writer.NewLine);

            writer.WriteLine("Строка :");           

            for (int i = 0; i < 10; i++)
            {
                writer.Write(i + " ");
            }
            // Вставляем символ начала новой строки.
            writer.Write(writer.NewLine);

            // Метод Close() автоматически очищает все буферы!
            writer.Close();
			file.Close();
            Console.WriteLine("Файл Text.txt создан и в него записан текст.");

            // ---------------------------------------------------------------------------------
			
            // Выводим информацию из файла на консоль при помощи StreamReader. 
            Console.WriteLine("Содержимое файла Text.txt:\n");
            
            // StreamReader reader = File.OpenText("Text.txt");

			var file1 = new FileStream("text.txt",FileMode.Open, FileAccess.Read, FileShare.None);
            var reader = new StreamReader(file1, Encoding.GetEncoding(1251));

            string input;

            // Выводим содержимое файла в консоль.
            while ((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            reader.Close();
			file1.Close();
            // ---------------------------------------------------------------------------------

            // Delay.
            Console.ReadKey();
        }
    }
}

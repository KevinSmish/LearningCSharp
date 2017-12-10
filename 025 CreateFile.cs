using System;
using System.IO;

// Создание/удаление файла.

namespace InputOutput
{
    class Program
    {
        static void Main()
        {
            // Создаем новый файл :
            var file = new FileInfo(@".\test.dat");

            // FileStream stream = file.Create();

			// FileMode.OpenOrCreate - ЕСЛИ: существует ТО: открыть ИНАЧЕ: создать новый
			// FileAccess.Read - только для чтения,
			// FileShare.None - Совместный доступ - Нет.
			FileStream stream = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

            // Создаем файл в текущем каталоге.
            // var stream = new FileStream("Test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // Записываем байты в файл.
            for (int i = 0; i < 256; i++)
            {
                stream.WriteByte((byte)i);
            }
            
            Console.WriteLine(stream.Position);
            // Переставляем внутренний указатель на начало.
            stream.Position = 0;
   
            // Считывам байты из файла.
            for (int i = 0; i < 256; i++)
            {
                Console.Write(" " + stream.ReadByte());
            }
			Console.WriteLine();
			Console.WriteLine(new string('-',50));
   
            // Выводим основную информацию о созданном файле.            
            Console.WriteLine("Full Name   : {0}", file.FullName);
            Console.WriteLine("Attributes  : {0}", file.Attributes.ToString());
            Console.WriteLine("CreationTime: {0}", file.CreationTime);

            Console.WriteLine("Нажмите любую клавишу для удаления файла.");
            Console.ReadKey();

            // Закрываем FileStream.
            stream.Close();

            // Удаляем файл.
            file.Delete();

            Console.WriteLine("Файл успешно удален.");

            // Delay.
            Console.ReadKey();
        }
    }
}

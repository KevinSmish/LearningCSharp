using System;
using System.IO;

// Создание директорий.

namespace InputOutput
{
    class Program
    {
        static void Main()
        {            
            var directory = new DirectoryInfo(@".");
            Console.WriteLine(directory.FullName);
            if (directory.Exists)
            {
                Console.WriteLine(@"Создаем подкаталог SUBDIR");
                directory.CreateSubdirectory("SUBDIR");

                Console.WriteLine(@"Создаем подкаталог MyDir\SubMyDir");
                directory.CreateSubdirectory(@"MyDir\SubMyDir");

                Console.WriteLine("Директории созданы.");

	            Console.WriteLine(directory.FullName + @"\MyDir\SubMyDir");
    	        Console.WriteLine(directory.FullName + @"\SUBDIR");
	            Console.WriteLine("\nНажмите Enter для удаления.\n");

	            // Задержка перед удалением.
    	        Console.ReadKey();
                        
    	        try
	            {
        	        // Удаление каталогов.
            	    Directory.Delete(@".\SUBDIR");

                	// Второй параметр определяет, будут ли удалены также и все вложенные подкаталоги. 
	                Directory.Delete(@".\MyDir", true);

    	            Console.WriteLine("Каталоги успешно удалены.");
        	    }
            	catch (Exception e) { Console.WriteLine(e.Message); }
			}
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}

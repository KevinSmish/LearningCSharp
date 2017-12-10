using System;
using Microsoft.Win32; 

class Program
{
	static void Main()
	{
		RegistryKey[] regKeyArray = new RegistryKey[] { Registry.ClassesRoot,
														Registry.CurrentUser,
														Registry.LocalMachine,
														Registry.Users,
														Registry.CurrentConfig,
														Registry.PerformanceData
													  };
		foreach (RegistryKey regKey in regKeyArray)
			Console.WriteLine("{0}: {1} элементов", regKey.Name, regKey.SubKeyCount);


		// --------------------------------------------------------------------------------
        Console.WriteLine(new string('-', 30));

		RegistryKey myKey = Registry.LocalMachine;
		RegistryKey software = myKey.OpenSubKey("Software");
		RegistryKey microsoft = software.OpenSubKey("Microsoft");

        Console.WriteLine("SubKey {0}: {1} элементов", microsoft.Name, microsoft.SubKeyCount);
        microsoft.Close();
		software.Close();

		// Для удаления используем .DeleteSubKey(KeyName)
		// Для создания используем 	RegistryKey newKey = wKey.CreateSubKey("NewKey");
		// Для новой записи 		newKey.SetValue("TheStringName", "I contain string value.");
		// Для новой записи			newKey.SetValue("TheInt32Name", 1234567890);
		// Тип можно указать явно. 	newKey.SetValue("AnotherName", 1234567890, RegistryValueKind.String);

		Console.ReadKey();
	}
}

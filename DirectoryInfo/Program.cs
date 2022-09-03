using static System.Console;
string path = "C:\Users\Оля\OneDrive\Рабочий стол\C#\Examples\Example001_HelloConsole";
DirectoryInfo di = new DirectoryInfo(path);
WriteLine(di.CreationTime);

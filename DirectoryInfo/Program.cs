using static System.Console;
string path = "C:\Users\Оля\OneDrive\Рабочий стол\C#\Examples\Example001_HelloConsole";
DirectoryInfo di = new DirectoryInfo(path);
WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    WriteLine(fi[i].Name);
}
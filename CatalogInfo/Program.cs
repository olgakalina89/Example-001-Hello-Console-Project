using static System.Console;
Clear();
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        WriteLine($"{indent}{files[i].Name}");
    }
}

string path = @"\Users\Оля\OneDrive\Рабочий стол\VERSIONS CONTROL";
CatalogInfo(path);
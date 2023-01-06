// Как посмотреть содержимое папки?

void CatalogInfo(string path, string indent = "") // Метод, path - путь папки, string indent - отступ, позволяющий видеть структуру папки
{
    DirectoryInfo catalogs = new DirectoryInfo(path); // Получаем инфу о директории, в которую зашли
    foreach (var currentCatalog in catalogs.GetDirectories()) // Получаем массив всех файлов, находящихся в папке и пробегаем по ним
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}"); // Выводим информацию о текущем каталоге
        CatalogInfo(currentCatalog.FullName, indent + " "); // Заныриваем и смотрим все папки, которые находятся в каталоге 
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}
string path = @"/Users/sergejkamaneckij/Projects/HelloCode";
CatalogInfo(path);
using System.Diagnostics;
using System.Formats.Asn1;
using System.IO;
using System.IO.Compression;

namespace Homework5;

public static class Program
{
    public static void Main()
    {
        //1. распаковывает архив в папку рядом с запускаемым файлом программы
        var path = "/Users/elenamazur/Archiv";//исходная папка
        Directory.CreateDirectory(path);

        var path1 = "/Users/elenamazur/Archiv/folder1";
        Directory.CreateDirectory(path1);


        var filePath = Path.Combine(path, "MyFile.txt");
        File.CreateText(filePath);

        var zip = "/Users/elenamazur/Archiv.zip";//сжатый фаил

        var folderPath = "Папка";//папка, куда распаковывается фаил
        

        ZipFile.CreateFromDirectory(path, zip);
        Console.WriteLine($"Папка {path} архивирована в файл {zip}");

        ZipFile.ExtractToDirectory(zip,folderPath);
        Console.WriteLine($"Файл {zip} распакован в папку {folderPath}");

        // 2.считывает названия файлов и папок из указанной папки
        // вот тут не уверена это то или нет

       
        if (Directory.Exists(folderPath))
        {
            Console.WriteLine("Подкаталоги:");
            string[] dirs = Directory.GetDirectories(folderPath);
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("Файлы:");
            string[] files = Directory.GetFiles(folderPath);
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
        }

        //3.записыввает инфомацию о содержимом папки в фаил csv
        // по сути,этот шаг решен полностью неверно,но я не понимаю как вообще сделать
        // запись о типе,названии и дате изменения.
        // Здесь в файле csv папка и файл записываются в виде пути "Папка/folder1" и "Папка/MyFile.txt"


        var fileCsv = "/Users/elenamazur/Info.csv";
        

        if (Directory.Exists(folderPath))
        {
           
            string[] dirs = Directory.GetDirectories(folderPath);
            foreach (var  s in dirs)
            {

                using var fileStream1 = new FileStream(fileCsv, FileMode.OpenOrCreate);
                using var streamWriter1 = new StreamWriter(fileStream1);

                streamWriter1.WriteLine(s);
               
            }
         
            string[] files = Directory.GetFiles(folderPath);
            foreach (var s in files)
            {
                
                using var fileStream2 = new FileStream(fileCsv, FileMode.Append);
                using var streamWriter2 = new StreamWriter(fileStream2);

                streamWriter2.WriteLine(s);
            }
        }

        //4. удаляет папку с распакованым архивом
        Directory.Delete(path);


        //5. сохраняет путь к файлу csv в файле %AppData%/Lesson12Homework.txt
        var appData = Path.GetFullPath(fileCsv);
        var appData1 = Path.Combine(appData, "/Users/elenamazur/%AppData%/Lesson12Homework.txt");
        File.CreateText(appData1);
    }

}


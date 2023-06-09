using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6;
public class Program
{
    /*static void Main(string[] args)
    {
        string zipPath = "Архив.zip";
        string csvPath = "Содержимое.csv";
        string extractPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Распаковка");
        try
        {
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
        catch
        {
            Console.WriteLine("Не удалось распаковать zip");
        }
        string[] entries = Directory.GetFileSystemEntries(extractPath);
        try
        {
            MethodWrite();
            using (StreamWriter sw = new StreamWriter(csvPath))
            {
                sw.WriteLine("Тип   \tИмя   \tДата изменения");
                foreach (string entry in entries)
                {
                    string type = File.GetAttributes(entry).HasFlag(FileAttributes.Directory) ? "Папка" : "Файл";
                    string name = Path.GetFileName(entry);
                    DateTime data = File.GetLastWriteTime(entry);
                    sw.WriteLine(type + "\t" + name + "\t" + data.ToString("dd/MM/yyyy"));
                }
            }
        }
        catch
        {
            Console.WriteLine("Не удалось записать в csv файл");
        }
        Directory.Delete(extractPath, true);
        var text = "Содержимое.txt";
        try
        {
            using var filestream = new FileStream(text, FileMode.OpenOrCreate);
            using var streamWriter = new StreamWriter(filestream);
            streamWriter.WriteLine(csvPath);
        }
        catch
        {
            Console.WriteLine("Не удалось записать в текстовый файл");
        }
        async Task MethodWrite()
        {
            using (StreamWriter sw = new StreamWriter(csvPath))
            {
                await sw.WriteLineAsync("Тип   \tИмя   \tДата изменения");
                foreach (string entry in entries)
                {
                    string type = File.GetAttributes(entry).HasFlag(FileAttributes.Directory) ? "Папка" : "Файл";
                    string name = Path.GetFileName(entry);
                    DateTime data = File.GetLastWriteTime(entry);
                    await sw.WriteLineAsync(type + "\t" + name + "\t" + data.ToString("dd/MM/yyyy"));
                }
            }
        }
    }*/
}

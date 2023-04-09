using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5;
public class Program
{
    static void Main(string[] args)
    {
        string zipPath = "Архив.zip";
        string extractPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Распаковка");
        ZipFile.ExtractToDirectory(zipPath, extractPath);
        string[] entries = Directory.GetFileSystemEntries(extractPath);
        string csvPath = "Содержимое.csv"; 
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
        Directory.Delete(extractPath, true);
        var text = "Содержимое.txt";
        using var filestream = new FileStream (text, FileMode.OpenOrCreate);
        using var streamWriter = new StreamWriter(filestream);
        streamWriter.WriteLine(csvPath);
        streamWriter.Dispose();
        filestream.Dispose();
    }
   // Program2 program = new Program2();
}
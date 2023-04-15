using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Homework_5;
public class Program2
{
    static void Main(string[] args)
    {
        var appDataPath = "Содержимое.txt";
        using var filestream = new FileStream(appDataPath, FileMode.Open);
        using var streamReader = new StreamReader(filestream);
        string csvPath = streamReader.ReadLine();
        Console.WriteLine(csvPath);
        streamReader.Dispose();
        filestream.Dispose();
        if (csvPath != null && File.Exists(csvPath))
        {
            List<string[]> entries = new List<string[]>();
            using (StreamReader sr = new StreamReader(csvPath))
            {
                sr.ReadLine(); // пропускаем заголовок csv файла
                while (!sr.EndOfStream)
                {
                    string[] values = sr.ReadLine().Split('\t');
                    entries.Add(values);
                }
            }
            entries = entries.OrderBy(x => DateTime.ParseExact(x[2], "dd/MM/yyyy", null)).ToList();
            foreach (string[] entry in entries)
            {
                Console.WriteLine(entry[0] + " - " + entry[1] + " - " + entry[2]);
            }
            File.Delete(appDataPath);
        }
        else
        {
            Console.WriteLine("Ошибка: csv не найден.");
        }
    }
}

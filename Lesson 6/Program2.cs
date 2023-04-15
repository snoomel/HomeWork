using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Homework6;
public class Program2
{
    static void Main(string[] args)
    {
        var appDataPath = "Содержимое.txt";
        try
        {
            MethodReader();
            /*using var filestream = new FileStream(appDataPath, FileMode.Open);
            using var streamReader = new StreamReader(filestream);
            string csvPath = streamReader.ReadLine();
            Console.WriteLine(csvPath);
            if (csvPath != null && File.Exists(csvPath))
            {
                List<string[]> entries = new List<string[]>();
                using (StreamReader sr = new StreamReader(csvPath))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string[] values = sr.ReadLine().Split('\t');
                        if (values.Contains("Файл") == true)
                        {
                            entries.Add(values);
                        }          
                    }
                }
                entries = entries.OrderBy(x => DateTime.ParseExact(x[2], "dd/MM/yyyy", null)).ToList();
                foreach (string[] entry in entries)
                {
                    Console.WriteLine(entry[0] + " - " + entry[1] + " - " + entry[2]);
                }
            }
            else
            {
                Console.WriteLine("Ошибка: csv не найден.");
            }*/
        }
        catch
        {
            Console.WriteLine("Не удалось прочитать текстовый файл");
        }
        File.Delete(appDataPath);
        async Task MethodReader()
        {
            using var filestream = new FileStream(appDataPath, FileMode.Open);
            using var streamReader = new StreamReader(filestream);
            string csvPath = await streamReader.ReadLineAsync();
            Console.WriteLine(csvPath);
            if (csvPath != null && File.Exists(csvPath))
            {
                List<string[]> entries = new List<string[]>();
                using (StreamReader sr = new StreamReader(csvPath))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string[] values = sr.ReadLine().Split('\t');
                        if (values.Contains("Файл") == true)
                        {
                            entries.Add(values);
                        }
                    }
                }
                entries = entries.OrderBy(x => DateTime.ParseExact(x[2], "dd/MM/yyyy", null)).ToList();
                foreach (string[] entry in entries)
                {
                    Console.WriteLine(entry[0] + " - " + entry[1] + " - " + entry[2]);
                }
            }
            else
            {
                Console.WriteLine("Ошибка: csv не найден.");
            }
        }
    }
}

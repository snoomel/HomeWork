using static System.Net.Mime.MediaTypeNames;

namespace ControleApp1;
public static class Programm
{
    public static void Main()
    {
        Console.WriteLine("Введите размер массива в виде натурального числа");
        string textone = Console.ReadLine();
        if (int.TryParse(textone, out int sizemassiva) && (string.IsNullOrWhiteSpace(textone) != true))
        {
            if (sizemassiva > 0)
            {
                Console.WriteLine($"Введено число: {sizemassiva}");
                Console.WriteLine("Заполните массив целыми числами");
                int[] number = new int[sizemassiva];
                for (int i = 0; i < number.Length; i++)
                {
                    string texttwo = Console.ReadLine();
                    if (int.TryParse(texttwo, out int znazenie) && (string.IsNullOrWhiteSpace(textone) != true))
                    {
                        number[i] = znazenie;
                        Console.WriteLine($"В массив с порядковым номером {i} введено число: {znazenie}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Вводите целые числа");
                        break;
                    }
                }
                Array.Sort(number);
                for (int i = number.Length - 2; i > 0; i--)
                {
                    if (number[i] != number[i + 1])
                    {
                        Console.WriteLine($"\nВторое наибольшее число в массиве: {number[i]}");
                        break;
                    }
                }
            }
            else 
            {
                Console.WriteLine("Введено некорректное число. Введите размер массива в виде натурального числа");
            }
        }
        else
        {
            Console.WriteLine("Ошибка! Введите размер массива в виде натурального числа");
        }
        
    }
}


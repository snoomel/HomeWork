using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3;
public class Surgeon : Dentists
{
    new public string surname = "Михайлов";
    new public string name = "Глеб";
    new public string patronymic = "Васильевич";
    new public int age = 54;
    new public int experience = 30;
    new public string university = "СибГМУ";
    public Surgeon(string surname)
    {
        this.surname = surname;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"ФИО: {surname} {name} {patronymic} Возраст: {age} Стаж: {experience} Место учебы: {university}");
    }
}
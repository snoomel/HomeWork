using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork3;
public class Ortoped : Dentists
{
    new public string surname = "Риповский";
    new public string name = "Сергей";
    new public string patronymic = "Игоревич";
    new public int age = 29;
    new public int experience = 6;
    new public string university = "НГМУ";
    public Ortoped(string surname)
    {
        this.surname = surname;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"ФИО: {surname} {name} {patronymic} Возраст: {age} Стаж: {experience} Место учебы: {university}");
    }
}


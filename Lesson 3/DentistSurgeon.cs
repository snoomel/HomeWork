using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3;
public class Surgeon : Dentists
{
    string surname = "Михайлов";
    string name = "Глеб";
    string patronymic = "Васильевич";
    int age = 54;
    int experience = 30;
    string university = "СибГМУ";
    public Surgeon(string surname)
    {
        this.surname = surname;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"ФИО: {surname} {name} {patronymic} Возраст: {age} Стаж: {experience} Место учебы: {university}");
    }
}
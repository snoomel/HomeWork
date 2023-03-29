using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3;
public class Terapist : Dentists
{
    new public string surname = "Кищук";
    new public string name = "Татьяна";
    new public string patronymic = "Павловна";
    new public int age = 37;
    new public int experience = 15;
    new public string university = "ОГМУ";
    public Terapist(string surname)
    {
        this.surname = surname;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"ФИО: {surname} {name} {patronymic} Возраст: {age} Стаж: {experience} Место учебы: {university}");
    }
}

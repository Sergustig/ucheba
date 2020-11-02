using System;

/* 
Задача “Класс «Сотрудник»”. Создайте класс «Employee». Для него должна быть реализована возможность 
задать фамилию, имя, отчество, должность, отдел, оклад при инициализации с помощью 
конструктора. Выведите на экран результаты работы не менее 2х экземпляров класса. Реализация возможна в виде консольного
приложения.
 */

class Employee
{
    // Поля класса
    public string Surname, Name, MiddleName, Position, Department;
    public double Salary;

    // Выводим информацию в консоль
    public void writeInConsoleInfo(string Surname, string Name, string Middlename, string Position, string Department, double Salary)
    {
        Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДолжность: {3}\nОтдел: {4}\nОклад: {5} рублей\n", Surname, Name, Middlename, Position, Department, Salary);

    }
}

class Person
{

    static void Main(string[] args)
    {
        // Создаем первый экземпляр класса
        Employee person1 = new Employee();

        person1.Surname = "Волков";
        person1.Name = "Александр";
        person1.MiddleName = "Михайлович";
        person1.Position = "Логист";
        person1.Department = "Отдел логистики";
        person1.Salary = 28500.00;

        // Создаем второй экземпляр класса
        Employee person2 = new Employee();

        person2.Surname = "Корнеева";
        person2.Name = "Елена";
        person2.MiddleName = "Витальевна";
        person2.Position = "Коммерческий директор";
        person2.Department = "Коммерческий отдел";
        person2.Salary = 35500.00;

        // Вывод информации о сотрудниках в консоль
        person1.writeInConsoleInfo(person1.Surname, person1.Name, person1.MiddleName, person1.Position, person1.Department, person1.Salary);
        person2.writeInConsoleInfo(person2.Surname, person2.Name, person2.MiddleName, person2.Position, person2.Department, person2.Salary);

        Console.ReadLine();

    }

}

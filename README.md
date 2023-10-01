# AlgLab2
Лабораторная работа №2
«Наследование, модификаторы доступа, ООП»

#Цели работы:
Научиться синтаксису и основным принципам наследования в C#.

#Задание№1
Создайте класс, представляющий учебный класс ClassRoom.
Создайте класс ученик - Pupil. 
В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика (реализация может быть произвольной, например простой вывод на консоль разных строк).
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать. 

Примечание: при реализации возможности создания экземпляра класса ClassRoom с произвольным количеством учеников воспользуйтесь ключевым словом params.

```
using System;

public class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        if (pupils.Length != 2 && pupils.Length != 3 && pupils.Length != 4)
        {
            throw new ArgumentException("Wrong number of pupils");
        }
        this.pupils = pupils;
    }

    public void PrintClassInfo()
    {
        Console.WriteLine("Classroom composition:");
        for (int i = 0; i < pupils.Length; i++)
        {
            Console.WriteLine($"Pupil {i + 1}: {pupils[i].GetType().Name}");
        }
    }

    public void Study()
    {
        foreach (var pupil in pupils)
        {
            pupil.Study();
        }
    }

    public void Read()
    {
        foreach (var pupil in pupils)
        {
            pupil.Read();
        }
    }

    public void Write()
    {
        foreach (var pupil in pupils)
        {
            pupil.Write();
        }
    }

    public void Relax()
    {
        foreach (var pupil in pupils)
        {
            pupil.Relax();
        }
    }
}

public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Pupil is studying");
    }

    public virtual void Read()
    {
        Console.WriteLine("Pupil is reading");
    }

    public virtual void Write()
    {
        Console.WriteLine("Pupil is writing");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Pupil is relaxing");
    }
}

public class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Excellent pupil is studying");
    }

    public override void Read()
    {
        Console.WriteLine("Excellent pupil is reading");
    }

    public override void Write()
    {
        Console.WriteLine("Excellent pupil is writing");
    }

    public override void Relax()
    {
        Console.WriteLine("Excellent pupil is relaxing");
    }
}

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Good pupil is studying");
    }

    public override void Read()
    {
        Console.WriteLine("Good pupil is reading");
    }

    public override void Write()
    {
        Console.WriteLine("Good pupil is writing");
    }

    public override void Relax()
    {
        Console.WriteLine("Good pupil is relaxing");
    }
}

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Bad pupil is studying");
    }

    public override void Read()
    {
        Console.WriteLine("Bad pupil is reading");
    }

    public override void Write()
    {
        Console.WriteLine("Bad pupil is writing");
    }

    public override void Relax()
    {
        Console.WriteLine("Bad pupil is relaxing");
    }
}

 public class Program
{
    public static void Main(string[] args)
    {
        ClassRoom classRoom = new ClassRoom(new ExcellentPupil(), new GoodPupil(), new BadPupil());
        classRoom.PrintClassInfo();

        Console.WriteLine("\nStudents are:");

        classRoom.Study();
        classRoom.Read();
        classRoom.Write();
        classRoom.Relax();
    }
}

```

#Задание№2
Создайте класс Vehicle.
В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
Создайте 3 производных класса Plane, Саг и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.
Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

Примечание: избегайте дублирования кода, используйте ключевое слово base после объявления конструкторов в классах наследниках для вызова и передачи параметров в конструктор базового класса.

```
using System;

class Vehicle
{
    protected double x, y;
    protected double price, speed;
    protected int year;

    public Vehicle(double x, double y, double price, double speed, int year)
    {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Coordinates: ({0}, {1})", x, y);
        Console.WriteLine("Price: {0}", price);
        Console.WriteLine("Speed: {0}", speed);
        Console.WriteLine("Year: {0}", year);
    }
}

class Plane : Vehicle
{
    private double height;
    private int passengers;

    public Plane(double x, double y, double price, double speed, int year, double height, int passengers)
    : base(x, y, price, speed, year)
    {
        this.height = height;
        this.passengers = passengers;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Height: {0}", height);
        Console.WriteLine("Passengers: {0}", passengers);
    }
}

class Car : Vehicle
{
    public Car(double x, double y, double price, double speed, int year)
    : base(x, y, price, speed, year)
    {
    }
}

class Ship : Vehicle
{
    private int passengers;
    private string port;

    public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
    : base(x, y, price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Passengers: {0}", passengers);
        Console.WriteLine("Port: {0}", port);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Plane plane = new Plane(100, 200, 1000000, 700, 2020, 10000, 200);
        Console.WriteLine("Plane info:");
        plane.DisplayInfo();

        Car car = new Car(300, 400, 50000, 200, 2018);
        Console.WriteLine("\nCar info:");
        car.DisplayInfo();

        Ship ship = new Ship(500, 600, 2000000, 50, 2015, 1000, "New York");
        Console.WriteLine("\nShip info:");
        ship.DisplayInfo();

        Console.ReadLine();
    }
}

```

#Задание №3
Создайте класс DocumentWorker.
В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт", "Редактирование документа доступно в версии Pro", "Сохранение документа доступно в версии Pro".
Создайте производный класс ProDocumentWorker.
Переопределите соответствующие методы, при переопределении методов выводите следующие строки: "Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert".
Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате".
В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.

```
using System;

class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ключ доступа (pro или exp):");
        string key = Console.ReadLine();

        DocumentWorker documentWorker;

        if (key == "pro")
        {
            documentWorker = new ProDocumentWorker();
        }
        else if (key == "exp")
        {
            documentWorker = new ExpertDocumentWorker();
        }
        else
        {
            documentWorker = new DocumentWorker();
        }

        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();

        Console.ReadLine();
    }
}
```

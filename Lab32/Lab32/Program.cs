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

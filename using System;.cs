using System;

public class ArrayMin
{
    public int[] arr;

    public ArrayMin(int size)
    {
        arr = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public int Min()
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
}

public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public abstract double CalculateBonus();
}

public class Developer : Employee
{
    public Developer(int id, string name, string position, double salary)
    {
        Id = id;
        Name = name;
        Position = position;
        Salary = salary;
    }

    public override double CalculateBonus()
    {
        return Math.Max(50000, 0.2 * Salary);
    }
}

public class Manager : Employee
{
    public Manager(int id, string name, string position, double salary)
    {
        Id = id;
        Name = name;
        Position = position;
        Salary = salary;
    }

    public override double CalculateBonus()
    {
        return Math.Max(50000, 0.25 * Salary);
    }
}

public class Admin : Employee
{
    public Admin(int id, string name, string position, double salary)
    {
        Id = id;
        Name = name;
        Position = position;
        Salary = salary;
    }

    public override double CalculateBonus()
    {
        return 50000;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        ArrayMin arrayMin = new ArrayMin(size);
        Console.WriteLine($"The smallest value in the array is: {arrayMin.Min()}");

        Developer developer = new Developer(1, "Enes Çelen", "Developer", 80000);
        Manager manager = new Manager(2, "Kerem Ensar", "Manager", 100000);
        Admin admin = new Admin(3, "Büşre Ceren", "Admin", 70000);

        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine($"ID\tName\tPosition\tSalary\tBonus");
        Console.WriteLine($"{developer.Id}\t{developer.Name}\t{developer.Position}\t{developer.Salary}\t{developer.CalculateBonus()}");
        Console.WriteLine($"{manager.Id}\t{manager.Name}\t{manager.Position}\t{manager.Salary}\t{manager.CalculateBonus()}");
        Console.WriteLine($"{admin.Id}\t{admin.Name}\t{admin.Position}\t{admin.Salary}\t{admin.CalculateBonus()}");
    }
}
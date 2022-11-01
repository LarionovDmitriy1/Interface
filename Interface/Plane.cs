using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface;

public class Plane : IFlyable
{
    public string Name { get; set; }
    public Plane()
    {
        Name = "Истрибитель 228";
    }
    public void Fly()
    {
        Console.WriteLine();
        Console.WriteLine($"Самолёт {Name} летает задом");
        Console.WriteLine();
    }
}

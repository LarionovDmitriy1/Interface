using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface;

public class Bird : Animal, IFlyable
{
    public Bird()
    {
        _name = "Птеца";
    }
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    public void Fly()
    {
        Console.WriteLine();
        Console.WriteLine($"{Name} летает нормально");
        Console.WriteLine();
    }
    public override void GetVoice()
    {
        Console.WriteLine();
        Console.WriteLine($"Птица {Name} мяукоед");
        Console.WriteLine();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface;

public class Dog : Animal
{
    public Dog()
    {
        _name = "Пьес";
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
    public override void GetVoice()
    {
        Console.WriteLine();
        Console.WriteLine($"Собака {Name} гавкоед");
        Console.WriteLine();
    }
}

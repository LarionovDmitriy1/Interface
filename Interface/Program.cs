using Interface;
List<Animal> animals = new List<Animal>();
List<IFlyable> flyable = new List<IFlyable>();
Animal cat = new Cat();
animals.Add(cat);
Animal dog = new Dog();
animals.Add(dog);
Animal lion = new Lion();
animals.Add(lion);
Animal bird = new Bird();
animals.Add(bird);
IFlyable bird1 = new Bird();
flyable.Add(bird1);
IFlyable plane = new Plane();
flyable.Add(plane);
string namePlane = plane.Name;
plane.Name = namePlane;
void Menu()
{
    Console.WriteLine("Меню");
    Console.WriteLine();
    Console.WriteLine("1. Кот,dog, лион, птица");
    Console.WriteLine("2. Летать птица самолёт");
}
void GetMenu()
{
    string a = Console.ReadLine();
    bool parse = int.TryParse(a, out var menu);
    if (parse)
    {
        switch (menu)
        {
            case 1:
                foreach (Animal anim in animals)
                {

                    anim.GetVoice();
                }
                break;
            case 2:
                foreach (IFlyable fly in flyable)
                {
                    fly.Fly();
                }

                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Нет такого");
                Console.WriteLine();
                break;
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Ошибка стоп 000");
        Console.WriteLine();
        return;
    }
}
while (true)
{
    Menu();
    GetMenu();
}

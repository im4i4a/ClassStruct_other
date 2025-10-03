namespace ClassStruct_other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            human.Greetings();
            human = new Human("Arnold");
            human.Greetings();
            Animal animal = new Animal();
            animal.Greetings();

            Pen pen = new Pen();
            pen.Output();
            pen = new Pen("Red",300);
            pen.Output();
        }
    }

    class Human
    {
        // Поля класса
        public string name;
        public int age;

        // Метод класса
        public void Greetings() => Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
        

        // Конструктор 1
        public Human()
        {
            name = "Неизвестно";
            age = 20;
        }
        // Конструктор 2
        public Human(string n)
        {
            name = n;
            age = 20;
        }
        // Конструктор 3
        public Human(string n, int a)
        {
            name = n;
            age = a;
        }
    }

    class Pen
    {
        public string color;
        public int cost;

        public void Output()
        {
            Console.WriteLine($"{color}  {cost}");
        }
        public Pen()
        {
            color = "Черный";
            cost = 100;
        }

        public Pen(string penColor, int penCost)
        {
            color= penColor;
            cost = penCost;
        }
    }
    struct Animal
    {
        public string name;
        public int age;
        public string type;
        public void Greetings()
        {
            Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
        }

        public Animal()
        {

        }
    }
}

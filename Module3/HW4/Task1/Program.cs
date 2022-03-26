using System;

namespace Task1
{
    public abstract class Creature
    {
        public string Name { get; private set; }
        protected string location = "Аваллонэ";
        protected Creature(string s) => Name = s;
        public virtual void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e) { }
    } 

    public class RingIsFoundEventArgs : EventArgs
    {
        public RingIsFoundEventArgs(string s) { Message = s; }
        public String Message { get; set; }
    }
    public class Wizard : Creature
    {
        public new delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);
        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;
        public Wizard(string s) : base(s) { }
        public Wizard() : base("") { }
        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine($"{base.Name} >> Кольцо найдено у старого Бильбо! Призываю вас в Ривендейл! ");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
        }
    }
    public class Hobbit : Creature
    {
        public Hobbit(string s) : base(s) { }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"Я нахожусь в {location}");
            location = e.Message;
            Console.WriteLine($"{Name} >> Покидаю Шир! Иду в " + e.Message);
        }
    }
    public class Human : Creature
    {
        public Human(string s) : base(s) { }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"Я нахожусь в {location}");
            location = e.Message;
            Console.WriteLine($"{Name} >> Волшебник {((Wizard)sender).Name} позвал. Моя цель {e.Message}");
        }
    }
    public class Elf: Creature
    {
        public Elf(string s) : base(s) { }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"Я нахожусь в {location}");
            location = e.Message;
            Console.WriteLine($"{Name} >> Звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают идти в " + e.Message);
        }
    }
    public class Dwarf : Creature
    {
        public Dwarf(string s) : base(s) { }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"Я нахожусь в {location}");
            location = e.Message;
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Выдвигаемся в " + e.Message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Гендальф");
            Hobbit[] hobbits = new Hobbit[4];
            hobbits[0] = new Hobbit("Фродо");
            hobbits[1] = new Hobbit("Сэм");
            hobbits[2] = new Hobbit("Пипин");
            hobbits[3] = new Hobbit("Мэрри");
            foreach(Hobbit hobbit in hobbits)
                wizard.RaiseRingIsFoundEvent += hobbit.RingIsFoundEventHandler;
            Human[] humans = { new Human("Боромир"), new Human("Арагорн") };
            Dwarf dwarf = new Dwarf("Гимли");
            Elf elf = new Elf("Леголас");
            wizard.RaiseRingIsFoundEvent += dwarf.RingIsFoundEventHandler;
            wizard.RaiseRingIsFoundEvent += elf.RingIsFoundEventHandler;
            foreach (Human h in humans)
                wizard.RaiseRingIsFoundEvent += h.RingIsFoundEventHandler;
            wizard.SomeThisIsChangedInTheAir();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota13
{
    class Program
    {
        static void Main(string[] args)
        {
            GoldS auto = new GoldS("Золотое Сердце");
            Zafod auto2 = new Zafod("Зафод");
            Ford_and_Trillian auto3 = new Ford_and_Trillian("Форд и Триллиан");
            Obichai auto4 = new Obichai("Обычаи");

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", auto.name, auto.Deistvie(), auto2.name, auto2.Deistvie2(), auto3.name, auto3.Deistvie3(), auto4.name, auto4.Diestvie4());
            Console.ReadKey();
        }
    }

    public class GoldS
    {
        public string name { get; set; }
        public GoldS(string name)
        {
            this.name = name;
        }

        public string Deistvie()
        {
            return "В эту ночь 'Золотое Сердце' летел, оставляя световые годы между собой и туманностью Конской Головы.";
        }
    }

    public class Zafod
    {
        public string name { get; set; }
        public Zafod(string name)
        {
            this.name = name;
        }

        public string Deistvie2()
        {
            return "Зафод, расположившись под небольшой пальмой на мостике, пытался вправить себе мозги солидными порциями пангалактического бульк-бластера.";
        }
    }

    public class Ford_and_Trillian
    {
        public string name { get; set; }
        public Ford_and_Trillian(string name)
        {
            this.name = name;
        }

        public string Deistvie3()
        {
            return "Форд и Триллиан сидели в уголке, обсуждая жизнь и ее последствия. Артур лежал у себя в каюте и листал фордов экземпляр 'Путеводителя по Галактике для автостопщиков'.";
        }
    }

    public class Obichai
    {
        public string name { get; set; }
        public Obichai(string name)
        {
            this.name = name;
        }

        public string Diestvie4()
        {
            return "Поскольку ему предстояло здесь жить, рассудил он, пора было начинать знакомиться с местными обычаями.";
        }
    }
}

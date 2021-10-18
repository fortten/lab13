using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    /* Задан класс Building, описывающий здание. Содержит элементы: адрес, длина, ширина, высота.
     * В классе реализовать методы: конструктор с 4 параметрами, свойства get/set для доступа к полям, метод Print(), который выводит информацию.
     * Класс MultiBuilding наследует возможности класса Building, добавляя этажность. Реализовать в нем: конструктор с 5 параметрами (вызов конструктора базового класса),
     * свойство get/set для доступа к внутреннему полю, метод Print(), который обращается к методу Print() базового класса.
     * Класс MultiBuilding не может быть унаследован.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Здание родительского класса===");
            Building building = new Building("Красных Фортов 10", 39, 26, 48);
            building.Print();
            Console.WriteLine();
            Console.WriteLine("===Здание дочернего класса===");
            MultiBuilding multiBuilding = new MultiBuilding("Ленинградская 28", 82, 20, 32, 9);
            multiBuilding.Print();
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
    class Building      // родительский класс
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        
        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", Address);
            Console.WriteLine("Длина здания: {0}", Length);
            Console.WriteLine("Ширина здания: {0}", Width);
            Console.WriteLine("Высота здания: {0}", Height);            
        }
    }
    sealed class MultiBuilding : Building       // дочерний класс
    {
        public int Floors { get; set; }
        public MultiBuilding(string address, double length, double width, double height, int floors)
            : base(address, length, width, height)
        {
            Floors = floors;
        }
        public new void Print()     // new подсказала VS, без неё тоже работало, но Print была подчеркнута
        {
            base.Print();
            Console.WriteLine("Количество этажей: {0}", Floors);
        }
    }
}

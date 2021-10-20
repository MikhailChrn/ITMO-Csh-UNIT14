using System;

namespace Задание_01
{
    //Разработать абстрактный класс Animal, который описывает животное.
    //Класс содержит следующие элементы:
    //абстрактное свойство - название животного.

    //В классе Animal нужно определить следующие методы:
    //конструктор, устанавливающий значение по умолчанию для названия;
    //абстрактный метод Say(), который выводит звук, который издает животное;
    //неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук(вызывая метод Say()).
    //Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal.В классах реализовать следующие элементы:

    //свойство – название животного;
    //метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
    //Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.

    class Program
    {
        abstract public class Animal //Объявляем абстрактный класс родоначальник
        {
            public abstract string NameOfAnimal { get; set; } //Объявляем абстрактные свойства доступа к полям
            public abstract string TypeOfAnimal { get; set; }
            public abstract void Say(); //Объявляем абстрактный метод
            public void ShowInfo() //Создаём рабочий метод для использования всеми экземплярами наследуемых классов
            {
                Console.WriteLine("{0} {1}", TypeOfAnimal, NameOfAnimal);
                Say();
            }
        }
        
        public class Cat : Animal //Класс кошка, наследник класса Animal
        {
            //При создании наследуемого класса обязательно требуется переопределение абстрактных свойств доступа !!!
            public override string NameOfAnimal { get; set; }
            public override string TypeOfAnimal { get; set; }

            //Создаём конструктор для наследуемсого класса с одним входящим значением поля
            public Cat(string _name)
            {
                NameOfAnimal = _name;
                TypeOfAnimal = "Кошка";
            }

            //Также обязяательно требуется переопределение абстактного метода, объявленным в клессе родрначальнике
            public override void Say()
            {
                Console.WriteLine("Мяу!");
                Console.WriteLine();
            }
        }

        public class Dog : Animal //Аналагичный класс наследник - собака, воспроизводящий класс родоначальник
        {
            public override string NameOfAnimal { get; set; }
            public override string TypeOfAnimal { get; set; }

            public Dog(string _name)
            {
                NameOfAnimal = _name;
                TypeOfAnimal = "Собака";
            }

            public override void Say()
            {
                Console.WriteLine("Гав!");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //Объявление экземпляров классов            
            Cat cat1 = new Cat("Мурзик");
            Cat cat2 = new Cat("Мурка");
            Dog dog1 = new Dog("Тузик");
            Dog dog2 = new Dog("Барбоскин");

            //Тестирование возможностей созданных классов
            cat1.ShowInfo();
            dog1.ShowInfo();
            cat2.ShowInfo();
            dog2.ShowInfo();

            Console.ReadKey();
        }
    }
}

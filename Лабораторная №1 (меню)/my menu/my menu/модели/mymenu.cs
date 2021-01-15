using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba_1.модели
{
    class mymenu
    {
        public List<Food> Foods = new List<Food>();
        public mymenu(int mode)
        {
            if (mode == 0)
            {
                Food GreenTea = new Drinks(15, 10, 5, 30, "Зеленый чай");
                Food BlackTea = new Drinks(15, 10, 5, 30, "Черный чай");
                Food AppleJuice = new Drinks(17, 12, 7, 32, "Яблочный сок");
                Foods.Add(GreenTea);
                Foods.Add(BlackTea);
                Foods.Add(AppleJuice);
            }
            if (mode == 1)
            {
                Food Chocolatecake = new Desserts(100, 90, 30, 200, "Шоколадный пирог");
                Food Applecake = new Desserts(90, 80, 20, 150, "Яблочный пирог");
                Food Donats = new Desserts(300, 200, 60, 260, "Пончики");
                Foods.Add(Chocolatecake);
                Foods.Add(Applecake);
                Foods.Add(Donats);
            }
            if (mode == 2)
            {
                Food ChocolateIceCream = new IceCream(70, 100, 20, 100, "Шоколадное мороженое");
                Food OrangeIceCream = new IceCream(70, 100, 20, 100, "Апельсиновое мороженое");
                Food StrawberryIceCream = new IceCream(70, 100, 20, 100, "Клубничное мороженое");
                Foods.Add(ChocolateIceCream);
                Foods.Add(OrangeIceCream);
                Foods.Add(StrawberryIceCream);
            }
            if (mode == 3)
            {
                Food Soup = new MainDishes(70, 50, 60, 160, "Суп");
                Food Salat = new MainDishes(150, 100, 40, 110, "Салат");
                Food Pizza = new MainDishes(140, 130, 70, 190, "Пицца");
                Foods.Add(Soup);
                Foods.Add(Salat);
                Foods.Add(Pizza);
            }
            if (mode == 4)
            {
                Food Sushi = new Snacks(140, 130, 70, 190, "Суши");
                Food Ham = new Snacks(170, 150, 10, 170, "Ветчина");
                Food Olives = new Snacks(180, 160, 10, 180, "Оливки");
                Foods.Add(Sushi);
                Foods.Add(Ham);
                Foods.Add(Olives);
            }
            if (mode == 5)
            {
                Food GreenTea = new Drinks(15, 10, 5, 30, "Зеленый чай");
                Food BlackTea = new Drinks(15, 10, 5, 30, "Черный чай");
                Food AppleJuice = new Drinks(17, 12, 7, 32, "Яблочный сок");
                Food Chocolatecake = new Desserts(100, 90, 30, 200, "Шоколадный пирог");
                Food Applecake = new Desserts(90, 80, 20, 150, "Яблочный пирог");
                Food Donats = new Desserts(300, 200, 60, 260, "Пончики");
                Food ChocolateIceCream = new IceCream(70, 100, 20, 100, "Шоколадное мороженое");
                Food OrangeIceCream = new IceCream(70, 100, 20, 100, "Апельсиновое мороженое");
                Food StrawberryIceCream = new IceCream(70, 100, 20, 100, "Клубничное мороженое");
                Food Soup = new MainDishes(70, 50, 60, 160, "Суп");
                Food Salat = new MainDishes(150, 100, 40, 110, "Салат");
                Food Pizza = new MainDishes(140, 130, 70, 190, "Пицца");
                Food Sushi = new Snacks(140, 130, 70, 190, "Суши");
                Food Ham = new Snacks(170, 150, 10, 170, "Ветчина");
                Food Olives = new Snacks(180, 160, 10, 180, "Оливки");
                Foods.Add(GreenTea);
                Foods.Add(BlackTea);
                Foods.Add(AppleJuice);
                Foods.Add(Chocolatecake);
                Foods.Add(Applecake);
                Foods.Add(Donats);
                Foods.Add(ChocolateIceCream);
                Foods.Add(OrangeIceCream);
                Foods.Add(StrawberryIceCream);
                Foods.Add(Soup);
                Foods.Add(Salat);
                Foods.Add(Pizza);
                Foods.Add(Sushi);
                Foods.Add(Ham);
                Foods.Add(Olives);
            }
        }




    }
} 

    
   


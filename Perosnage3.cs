using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Quest
{
    class Perosnage3:MainHero
    {
         public int magicDamage = 30; // добавляем новое поле
       
        //констуркторы
        public Perosnage3(string pname) : base(pname) //унаследованный метод создания экземпляра героя
        {
            this.classID = 3;
            this.name = pname;
            Random rnd = new Random(); //задаем поля героя со случайным коофициентом
            this.health = this.health - rnd.Next(10, 40); // герой наносит меньший урон и у него меньше жизней
            this.damage = this.damage - rnd.Next(5, 15);
            
        }
        public Perosnage3() // создаем с заданными значениями
        {
            this.classID = 3;
            this.name = "Person3";
            this.health = this.health - 20;
            this.damage = this.damage - 10;
        }

        //методы
        // override позволяет нам перегрузить методы 
        public override int SuperAttack()  // у персонажа3 есть свой метод супер атаки
        {
            this.power -= 10;
            Random rnd = new Random();
            int result = rnd.Next(1, 3);
            if (result % 2 == 1)
            {
                return this.magicDamage + rnd.Next(1, 10); ;
            }
            else
            {
                return 0;
            }
        }
    }
}

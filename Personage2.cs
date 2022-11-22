using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Quest
{
    class Personage2:MainHero
    {
         //констуркторы
        public Personage2(string pname) : base(pname)//унаследованный конструктор    
        {
            this.classID = 2;
            this.name = pname;
            Random rnd = new Random(); //задаем поля героя со случайным коофициентом
            this.health = this.health - rnd.Next(0, 30); // волшебник наносит меньший урон и у него меньше жизней
            this.damage = this.damage - rnd.Next(0, 10);
        }
        public Personage2(): base() 
        {
            this.classID = 2;
            this.name = "Person2";
            this.health = 100;
            this.damage = 15;
        }
    }
}

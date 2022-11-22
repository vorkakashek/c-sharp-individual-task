using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Quest
{
    class Personage1:MainHero
    {
        public Personage1(string pname):base(pname)
        {
            this.name = pname;
            Random rnd = new Random(); //задаем поля персонажа1 со случайным коофициентом, 
            //чтобы он был слабее героя
            this.health = 50 + rnd.Next(0, 30);
            this.damage = 5 + rnd.Next(0, 5); 
        }
    }
}

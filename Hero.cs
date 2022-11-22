using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Quest
{
    internal interface Hero
    {
        // методы
        int Attack();        // атака
        int getID();        // возвращает id класса 
        string getName();    //  имя персонажа
        int getHealth();     //  текущее здоровье персонажа
        int getDamage();     //   текущий урон персонажа
        void setHealth(int newHealtch);  //установить уровень очков здоровья
        void setDamage(int newDamage);   //установить уровень очков урона
        int addHealth(int addHealth);    //добавить очков здоровья
        int addDamage(int addDamage);    //добавить очков урона
        int SuperAttack();                 //метод суператаки героя
    }
}

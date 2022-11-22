using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Quest
{
    class MainHero:Hero
    {
        //поля персонажа
        public int classID = 1;         // ID, по которому будем проверять класс героя в течении игры 
        public string name = "Hero";   // имя героя
        public int health = 100;        // количество очков здоровья
        public int damage = 20;         // количество очков урона
        public int power = 50;         // количество очков урона
//констуркторы
        public MainHero()
        {
        } //создание героя с полями по умолчанию
        public MainHero(string hero_name)   //конструктор с именем
        {
            this.name = hero_name;
            Random rnd = new Random(); //задаем поля героя со случайным коофициентом
            this.health = 100 + rnd.Next(-10, 30);      
            this.damage = 20 + rnd.Next(-5, 5); 
        }

        
 

   
        //методы
        public int Attack()         // метод атаки: попал или нет
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 3);
            if (result % 2 == 1)
            {
                return this.damage;
            }
            else
            {
                return 0;
            }
        }
    
        public int getID() {
          return this.classID;    // вернуть id класса героя
        }
        public string getName() 
        {
            return this.name;    // вернуть имя героя
        }
        public int getHealth() 
        {
            return this.health; 
        }// вернуть количество очков здоровья героя
        public int getDamage(){
            return this.damage; 
        }// вернуть занчение атаки героя
         public void setHealth(int newHealtch){
             this.health = newHealtch;  // задать здоровье героя
         }
         public void setDamage(int newDamage)
         {
             this.damage = newDamage;    // задать атаку героя
         }
        public int addHealth(int addHealth) //добавить здоровья герою
        {
            this.health += addHealth;
            return this.health;
        }
        public int addDamage(int addDamage)  //доабвить атаки герою
        {
            this.damage += addDamage;
            return this.damage;
        }
        public virtual int SuperAttack() // доабвить суператаки герою
        {
            return 0;
        }
    
    }
 }
     


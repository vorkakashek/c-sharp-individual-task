using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Quest
{
    public partial class Game : Form
    {
        Hero hero;                      // объект интерфейса с методами
        private int currentStep = 0;        
        private bool battle = false;       
        MainHero curMonster;             //глобальный объект с текущим монстром, если сражаемся

        public Game()
        {
            InitializeComponent(); 
     
        }
        public Game(int heroClass, string heroName) //перегруженный конструктор формы
        {
            InitializeComponent();
            if (heroClass == 0) // в зависимости от переданного значения определяем класс игрока
                hero = new Personage1(heroName);
            else if (heroClass == 1)
                hero = new Personage2(heroName);
            else if (heroClass == 2)
                hero = new Perosnage3(heroName);
            //выводим данные о персонаже
           
            qStatus.Text = hero.getName();
            updateStatus(); // отдельный метод обновления данных о герое. 
            //т.к. они меняются в ходе игры
            start(); //запускаем игру

        }
        private void start()
        {
            //вместо этих функций можно создать класс игры, в котором будут списки с текстами ходов
            //и действий
            //а так же возможность загружать всю историю из файла
            if (currentStep == 0)
            {
                printStep("Пройдя долгий путь, вы оказались перед воротами ужасного замка\n" +
                "вашего заклятого врага: Скелетрона.\n" +
                "Вы можете войти в ворота замка или трусливо сбежать",
                 "Войти в дверь", "Сбежать");
            }
            else if (currentStep == 1)
            {
                printStep("Дверь перед вами открывается, вы видите динный коридок, увешанный чадящими факелами",
                            "Идти по коридору", "Убежать из замка");
            }
            else if (currentStep == 2)
            {
                printStep("Вы идете по коридору, внимательно вглядываясь вперед." +
                    "Вдруг одна из статуй горгулий начинает медленного двигаться, и, разбрасывая каменную крошку, идет к вам",
                            "Атаковать", "Убежать из замка", "игнорировать бой");
            }
            else if (currentStep == 3)
            {
                if (hero.getID() == 1) printStep("Завязывается бой", "Атака");
                else if (hero.getID() == 2) printStep("Завязывается бой", "Атака");
                else if (hero.getID() == 3) printStep("Завязывается бой", "Атака", "Супер-атака");
                curMonster = new Perosnage3();
                battle = true; // включаем режим сражения
            }
            else if (currentStep == 4)
            {
                printStep("Вы продолжаете идти по коридору. " +
                    "Коридор оканчивается высокими и массивными воротами." +
                    "Налево из коридора идет проход, в нем виднеется винтовая лестница наверх." +
                    "Направо - проход с уходящими вниз ступенями." +
                    "Куда вы направитесь?",
                    "Налево",
                    "Попробовать открыть ворота",
                    "Направо и вниз");
            }
            else if (currentStep == 5)
            {
                printStep("Вы явно видите винтовую лестницу, которая находится за аркой в стене." +
                    "Однако вы не можете ее достичь: когда вы идете к ней, вы остаетесь на месте." +
                    "Может стоит попробовать пойти в другом направлении?",
                    "Попробовать открыть ворота",
                    "Напрво и вниз");
            }
            else if (currentStep == 6)
            {
                printStep("Ворота выглядят как две огромные деревянные створки, на них не видно нн петель," +
                    "ни ручек. вы толкаете их, но они остаются на месте." +
                    "Возможно, они открываются как-то иначе, стоит поискать",
                    "Пойти налево",
                    "Направо и вниз");
            }
            else if (currentStep == 7)
            {
                printStep("Вы идете направо и спускаетесь вниз по лестнице, прихватив со стены факел." +
                    "Лестница выходит в коридор, уходящий налево и направо. " +
                    "Здесь темно, в стенах виднеются решетки, за которыми ничего не видно.",
                    "Пойти налево",
                    "Пойти направо",
                    "Вернуться наверх");
            }
            else if (currentStep == 8)
            {
                printStep("Вы идете по коридору. C обоих сторон коридора на вас слепо взирают проемы с решетками" +
                    "с тьмой за ними. Вдруг на полу что-то виднеется. Это груда костей вперемешку с обрывками одежды " +
                    "и кусками ржавого метала, по-видимому, ранее бывшими кольчугой, шлемом, щитом и мечом.",
                    "Осмотреть груду костей",
                    "пройти дальше мимо",
                    "Вернуться назад");
            }
            else if (currentStep == 9)
                printStep("При вашем приближении груда костей застучала, зашевилась, кости задвигались. " +
                    "И это не копошащиеся крысы: кости примыкают к друг другу, формируя скелет, который встает перед вами. " +
                    "В руках он держит ржавые меч и щит. Он начинает двигаться к вам, принимая боевую стойку",
                    "Атаковать",
                    "Сбежать");
            else if (currentStep == 10)
            {
                if (hero.getID() == 1) printStep("Вы тоже принимаете боевую стойку. Завязывается бой", "Атака");
                else if (hero.getID() == 2) printStep("Вы тоже принимаете боевую стойку. Завязывается бой", "Атака");
                else if (hero.getID() == 3) printStep("Вы тоже принимаете боевую стойку. Завязывается бой", "Атака", "Супер-атака");
                curMonster = new Personage1("Дракон"); // назначаем текущего монстра 
                battle = true;
            }
            else if (currentStep == 11)
            {
                printStep("Конец бета-версии. Вы можете закрыть программу, написав команду \"Выход\"");
            }
        }

        public void printStep(string txt, string action1 = "", string action2 = "", string action3 = "")
        {   //метод, который отображает игровой текст, разделяя его с доступными действиями.
            string str = txt; str += "\n\n";
            str += "Доступные действия:\n";
            str += action1; str += "\n";
            str += action2; str += "\n";
            str += action3;
            qMainField.Text = str;
        }


        public int checkAction(string txtAction, string action1 = "", string action2 = "", string action3 = "")
        {   //метод, который проверяет ввод игрока и сравнивает его с предусмотренными действиями
            if (txtAction == action1) return 1;
            else if (txtAction == action2) return 2;
            else if (txtAction == action3) return 3;
            else return 0;
        }

        private void updateStatus() //обновление характеристик героя, которые могут меняться в течении игры
        {
            qHealth.Text = hero.getHealth().ToString();
            qDamage.Text = hero.getDamage().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (qAction.Text == "Продолжить") //Если битва окончена
            {
                currentStep++; //переходим на следующий шаг
                battle = false; //отключаем режим битвы
                start();    //идем к следующему этапу 
                return;         //прерываем выполнение функции, иначе у нас будут последющие проверки
            }
            if (battle)
            {   
                
                if (hero.getID() == 1) result = checkAction(qAction.Text, "Атака", "Сбежать");
                else if (hero.getID() == 2) result = checkAction(qAction.Text, "Атака", "Сбежать");
                else if (hero.getID() == 3) result = checkAction(qAction.Text, "Атака", "Супер-атака", "Сбежать");
                if (result == 0)
                {
                    if (hero.getID() == 1) printStep("Нет такого действия.", "Атака", "Сбежать");
                    else if (hero.getID() == 2) printStep("Нет такого действия.", "Атака", "Сбежать");
                    else if (hero.getID() == 3) printStep("Нет такого действия.", "Атака", "Супер-атака", "Сбежать");
                }
                if (result == 1) //Атака
                {
                    int damage = hero.Attack();
                    int enemyDamage = curMonster.Attack();
                    string txtDamage = (damage == 0)?"вы промахнулись": "нанесли " +damage+ " урона";
                    string txtEnemyDamage = (enemyDamage == 0) ? "он промахнулся" : "нанес вам "+ enemyDamage+" урона";

                    string txt = "Вы атаковали монстра "+curMonster.getName()+" и ";
                    txt+= txtDamage;
                    txt +=" "+ curMonster.getName()+ "тоже атаковал вас и ";
                    txt += txtEnemyDamage;
                    txt += "\n";

                    hero.addHealth(-enemyDamage);
                    curMonster.addHealth(-damage);
                    updateStatus();

                    txt += " У вас осталось "+hero.getHealth()+" очков здоровья, у "+curMonster.getName()+ curMonster.getHealth()+" очков здоровья";

                    if (hero.getHealth() <= 0) 
                    {
                        txt += "\nВы погибли. Враг уничтожил ваше королевство. Игра окончена";
                        printStep(txt);
                        return;
                    }
                    if (curMonster.getHealth() <= 0) 
                    {
                        txt += "\n"+curMonster.getName()+" побежден";
                        Random rnd = new Random();
                        int bonus = rnd.Next(1, 10);
                        txt += "Вы стали опытнее, и теперь можете наносить на "+bonus+" больше урона.";
                        hero.addDamage(bonus);
                        updateStatus();
                        printStep(txt, "Продолжить");
                        return;
                    }                    

                    if (hero.getID() == 1) printStep(txt, "Атака", "Сбежать");
                    else if (hero.getID() == 2) printStep(txt, "Атака", "Сбежать");
                    else if (hero.getID() == 3) printStep(txt, "Атака", "Супер-атака", "Сбежать");
                }
                else if ((hero.getID() == 1 && result == 2) || ((hero.getID() == 2 || hero.getID() == 3) && result == 3)) //сбежать
                { 
                        printStep("Конец игры. Враг унижтожил ваше королевство, а затем и другие.");
                }
                else if (result == 2) //магическая или скрытая атака 
                {     
                    if (hero.getID() == 2)      //волшебник
                    {
                       
                        { 
                            int damage = hero.SuperAttack();
                            int enemyDamage = curMonster.Attack();
                            string txtDamage = (damage == 0) ? "вы промахнулись" : "нанесли" + damage +" урона";
                            string txtEnemyDamage = (enemyDamage == 0) ? "он промахнулся" : "нанес вам" +enemyDamage+" урона";

                            string txt = " Вы атаковали монстра " +curMonster.getName()+" и ";
                            txt += txtDamage;
                            txt += curMonster.getName()+" тоже атаковал вас и ";
                            txt += txtEnemyDamage;
                          

                            hero.addHealth(-enemyDamage);
                            curMonster.addHealth(-damage);
                            updateStatus();

                            txt += " У вас осталось "+ hero.getHealth()+" очков здоровья, у "+curMonster.getName()+ curMonster.getHealth()+ "очков здоровья";
                            printStep(txt, "Атака",  "Сбежать");
                        }
                    }
                    else if (hero.getID() == 3)//плут
                    {
                        int damage = 0;
                        int enemyDamage = curMonster.Attack();
                        string txtDamage = (damage == 0) ? "вы промахнулись. Скрытой атакой получается нанести урон реже, чем обычной" : "нанесли"+ damage+ " урона";
                        string txtEnemyDamage = (enemyDamage == 0) ? "он промахнулся" : "нанес вам"+ enemyDamage+ "  урона";


                        string txt = " Вы атаковали монстра" +curMonster.getName()+ " и ";
                        txt += txtDamage;
                        txt +=" "+curMonster.getName()+ " тоже атаковал вас и ";
                        txt += txtEnemyDamage;
                        

                        hero.addHealth(-enemyDamage);
                        curMonster.addHealth(-damage);
                        updateStatus();

                        txt += " У вас осталось"+ hero.getHealth()+" очков здоровья, у "+curMonster.getName()+ curMonster.getHealth()+ "очков здоровья";
                        printStep(txt, "Атака", "Сбежать");
                    }
            }    


            }
            else  //если мы в режиме истории, проверяем, что ввел игрок 
            { 
                if (currentStep == 0)
                {
                    result = checkAction(qAction.Text,"Войти в дверь", "Сбежать");
                    if (result == 0) printStep("Нет такого действия.", "Войти в дверь", "Сбежать");
                    if (result == 1)
                    {
                        currentStep++;
                        start();
                    }
                    else if (result == 2)
                        printStep("Игра окончена.");
                
                }
                else if (currentStep == 1)
                {
                    result = checkAction(qAction.Text, "Идти по коридору", "Убежать из замка");
                    if (result == 0) printStep("Нет такого действия.","Идти по коридору","Убежать из замка");
                    if (result == 1)
                    {
                        currentStep++;
                        start();
                    }
                    else if (result == 2)
                        printStep("Конец игры. Скелетрон унижтожил ваше королевство, а затем и другие.");                
                }
                else if (currentStep == 2)
                {
                    result = checkAction(qAction.Text, "Атаковать", "Убежать из замка", "попробовать обойти горгулью");
                    if (result == 0) printStep("Нет такого действия. Вы можете ", "Атаковать", "Убежать из замка","попробовать обойти горгулью");
                    if (result == 1)
                    {
                        currentStep++;
                        start();
                    }
                    else if (result == 2)
                        printStep("Конец игры. Скелетрон унижтожил ваше королевство, а затем и другие.");
                    else if (result == 3)
                    {
                        currentStep=4;
                        start();
                    }               

                }
                else if (currentStep == 4)
                {
                    result = checkAction(qAction.Text, "Налево", "Попробовать открыть ворота", "Направо и вниз");
                    if (result == 0) printStep("Нет такого действия.  ", "Налево", "Попробовать открыть ворота", "Направо и вниз");
                    if (result == 1)
                    {
                        currentStep=5;
                        start();
                    }
                    else if (result == 2)
                    {
                        currentStep=6;
                        start();
                    }

                    else if (result == 3)
                    {
                        currentStep = 7;
                        start();
                    }
                }
                else if (currentStep == 5)
                {
                    result = checkAction(qAction.Text, "Попробовать открыть ворота", "Направо и вниз");
                    if (result == 0) printStep("Нет такого действия.  ", "Попробовать открыть ворота", "Направо и вниз");
                    if (result == 1)
                    {
                        currentStep = 6;
                        start();
                    }
                    else if (result == 2)
                    {
                        currentStep = 7;
                        start();
                    }             
                }
                else if (currentStep == 6)
                {
                    result = checkAction(qAction.Text, "Пойти налево", "Направо и вниз");
                    if (result == 0) printStep("Нет такого действия.  ", "Пойти налево", "Направо и вниз");
                    if (result == 1)
                    {
                        currentStep = 5;
                        start();
                    }
                    else if (result == 2)
                    {
                        currentStep = 7;
                        start();
                    }
                }
                else if (currentStep == 7)//налево и направо будет скелет... иллюзия выбора
                {
                    result = checkAction(qAction.Text, "Пойти налево", "Пойти направо", "Вернуться наверх");
                    if (result == 0) printStep("Нет такого действия.  ", "Пойти налево", "Пойти направо","Вернуться наверх");
                    if (result == 1)
                    {
                        currentStep = 8;
                        start();
                    }
                    else if (result == 2)
                    {
                        currentStep = 8;
                        start();
                    }
                    else if (result == 3)
                    {
                        currentStep = 4;
                        start();
                    }
                }
                else if (currentStep == 8)//со скелетом вы все равно будете сражаться...
                {
                    result = checkAction(qAction.Text, "Осмотреть груду костей", "пройти дальше мимо", "Вернуться назад");
                    if (result == 0) printStep("Нет такого действия.  ", "Осмотреть груду костей", "пройти дальше мимо", "Вернуться назад");
                    if (result == 1)
                    {
                        currentStep = 9;
                        start();
                    }
                    else if (result == 2)
                    {
                        currentStep = 9;
                        start();
                    }
                    else if (result == 3)
                    {
                        currentStep = 8;
                        start();
                    }
                }
                else if (currentStep == 9)//со скелетом вы все равно будете сражаться...
                {
                    result = checkAction(qAction.Text, "Атаковать", "Сбежать");
                    if (result == 0) printStep("Нет такого действия.  ", "Атаковать", "Сбежать");
                    if (result == 1)
                    {
                        currentStep = 10;
                        start();
                    }
                    else if (result == 2)
                    {
                        currentStep = 8;
                        start();
                    }                
                }
                else if (currentStep == 11)
                {
                    result = checkAction(qAction.Text, "Выход");
                        if (result == 0) printStep("Нет такого действия", "Выход");
                        else if (result == 1) Application.Exit();
                }    
            }
        }

    }
}

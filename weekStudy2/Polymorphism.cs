using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{
    class Polymorphism
    {
    }

    public class Goblin
    {
        Entity01 entity01 = new Entity01();
        public void TakeDamage(int damage)
        {
            Console.WriteLine($"고블린 : {damage}만큼 체력 감소");
        }
    }

    public class Slime
    {
        
        public void TakeDamage(int damage)
        {
            Console.WriteLine($"슬라임 : {damage}만큼 체력 감소");
        }
    }

    public class Dragon
    {
        
        public void TakeDamage(int damage)
        {
            Console.WriteLine($"드래곤 : {damage}만큼 체력 감소");
        }
    }

    public class Player03
    {
        private int damage = 10;
        public void Hit(Goblin goblin)
        {
            goblin.TakeDamage(damage);
        }

        public void Hit(Slime slime)
        {
            slime.TakeDamage(damage);
        }

        public void Hit(Dragon dragon)
        {
            dragon.TakeDamage(damage);
        }
    }

    public class GameController02
    {
        private void Awake()
        {
            Player03 player03 = new Player03();

            Goblin goblin = new Goblin();
            Slime slime = new Slime();
            Dragon dragon = new Dragon();

            player03.Hit(goblin);
            player03.Hit(slime);
            player03.Hit(dragon);
        }
    }
}

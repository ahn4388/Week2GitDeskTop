using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{
    public class Player
    {
        private string ID = "고초아";
        private int currentHP = 1000;
        private int currentMP = 1000;

        ~Player()
        {
            //삭제됨
        }

        public void TakeDamage(int damage)
        {
            if (currentHP > damage)
            {
                currentHP -= damage;
            }
        }

        public void SetID(string ID)
        {
            Console.WriteLine($"ID ; {ID}");
            Console.WriteLine($"ID ; {this.ID}");
        }

        public Player()
        {
            ID = "고박사";
        }
        public Player(int hp) : this()
        {
            currentHP = hp;
        }
        public Player(int hp, int mp) : this(hp)
        {
            currentMP = mp;
        }
    }

    public class Enemy
    {
        private Player player;

        public void AttackToTarget(Player target)
        {
            target.TakeDamage(100);
        }
    }

    public class GameController
    {
        public Player player;
        public Player player01;
        public Player player02;

        private void Awake()
        {
            player01 = new Player();
            player01.TakeDamage(100);
            player02.TakeDamage(200); //null Ecception
            player.SetID("유니티");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{

    class EncapsulationEX
    {
    }

    public class Player01
    {
        private int currentHP;
        public void SetCurrentHP(int hp)
        {
            currentHP = hp;
        }

        public int GetCurrentHP()
        {
            return currentHP;
        }
    }

    public class GameController01
    {
        private void Awake()
        {
            Player01 player01 = new Player01();

            // player01.SetCurrentHP = 100; 오류

            //currentHP의 Set, Get 메서드에 접근함.
            player01.SetCurrentHP(100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{
    class Inheritance
    {
    }
    
    public class Entity
    {
        public string ID;
        protected int currentHP;

        private void Initalize()
        {
            ID = "Noname";
        }

        public void RecoveryHP(int hp)
        {
            currentHP += hp;
        }
    }
                // 파생(자식)   /   기반(부모)
    public class Player02 : Entity
    {
        private string ID;
        public Player02(string id, int hp)
        {
            base.ID = "Noname";
            ID = id;
            currentHP = hp;

            RecoveryHP(1000);

            //Initalize();  private는 사용 불가
        }
    }
}

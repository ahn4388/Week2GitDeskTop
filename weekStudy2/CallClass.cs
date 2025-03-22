using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{
    class player
    {
        public string ID;
        private int currentHP;

        void RecoveryHP(int hp) // 외부에서 호출 불가
        {
            currentHP += hp;
        }

        public void TakeDamage(int damage) // 호출 가능
        {
            if (currentHP > damage)
            {
                currentHP -= damage;
            }
        }
    }

    
}

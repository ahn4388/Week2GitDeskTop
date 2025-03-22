using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{
    class overrideEx
    {
    }

    public class Entity01
    {
        public virtual void Attack()
        {
            Console.WriteLine("적 공격1");
        }
    }

    public class Slime01 : Entity01
    {
        public override void Attack()
        {
            Console.WriteLine("적 공격 2");
        }
    }

    public class Gobline01 : Entity01
    {
        public override void Attack()
        {
            Console.WriteLine("적 공격 2");
        }
    }

    public class GameController03
    {
        private Slime01 slime01;
        private Gobline01 gobline01;

        private void Awake()
        {
            slime01.Attack();
            gobline01.Attack();
        }
    }
}

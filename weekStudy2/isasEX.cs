 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{
    class isasEX
    {
    }

    public class Entity02
    {
        public void Attack()
        {
            Console.WriteLine("적을 공격한다.");
        }
    }

    public class Slime02 : Entity02
    {

    }

    public class Gobline02 : Entity02
    {

    }

    public class GameController04
    {
        private void Awake()
        {
            Entity02 entity02 = new Slime02();
            if (entity02 is Slime02)
            {
                Console.WriteLine("Entity02 type is Slime");
            }

            Gobline02 gobline02 = entity02 as Gobline02;
            if (gobline02 == null)
            {
                Console.WriteLine("gobline is null");
            }
        }
    }
}

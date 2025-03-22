using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{
    class AbstractionEX
    {
    }

    /*
     추상 클래스 형식 :

    public abstract class 클래스 이름
    {
        추상 메소드 형식
        한정자 abstract 반환형식 메소드 이름(매개변수목록);
        멤버 변수, 멤버 함수는 일반 클래스와 동일하게 구현함
    }
     */

    public abstract class Entity03
    {
        protected int damage;
        protected int currentHP;

        public abstract void Attack(Entity03 target);

        public void TakeDamage(int damage)
        {
            if (currentHP > damage)
            {
                currentHP -= damage;
                Console.WriteLine($"체력이 {damage}감소");
            }
            else
            {
                Console.WriteLine($"die");
            }
        }
    }
}

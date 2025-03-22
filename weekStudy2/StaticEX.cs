using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{
    class StaticEX
    {
    }

    /*
     public class Enemy
    {
        static 메소드 정의
        메소드의 반환형식 앞에 static 키워드 사용
        한정자 static 반환형식 메소드 이름(매개변수목록)
        {
         
        }
    }

    public class GameController
    {
        private void Awake()
        {
            호출시,
            Enemy.메소드이름()
        }
    }
     
     */


    public class Enemy01
    {
        public int InstanceRun() { return 1; }

        public static int StaticRun()
        {
            //InstanceRun(); 호출 불가능
            return 1;
        }
    }

    public class GameController06
    {
        private void Awake()
        {
            int j = Enemy01.StaticRun();
            Enemy01 enemy01 = new Enemy01();
            int i = enemy01.InstanceRun();

            //enrmy01.StaticRun(); 호출불가능
        }
    }
}

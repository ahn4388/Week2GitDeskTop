using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{
    class Property
    {
    }

    /*
     public class Player
    {
        데이터형식 멤버변수이름
        접근지정자 데이터형식프로퍼티 이름
        {
            get
            {
                return 멤버변수이름;
            }

            set
            {
                멤버변수이름 = value;
            }

            또는,

            get => 멤버변수이름;
            set => 멤버변수이름 = value;
        }
    }
     */

    public class Player04
    {
        private int currentHP;
        public int CurrentHP
        {
            get => currentHP;
            set => currentHP = value;
        }
    }
    // 이하 클래스와 동일

    /*
     public class Player04
    {
        public int CurrentHP
        {
            get;set;
        }
    }
     
     
     */
}

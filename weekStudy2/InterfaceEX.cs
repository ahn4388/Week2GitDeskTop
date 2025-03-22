using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace weekStudy2
{
    class InterfaceEX
    {
    }

    /*
     인터페이스 형식
    interface 인터페이스 이름
    {
        메소드, 프로퍼티, 인덱서, 이벤트를 구현없이 선언만 가능함
        반환형식 메소드 이름(매개변수목록);
    }
     */

    interface IMovingEntity
    {
        void MoveTo(Vector3 destination);
    }

    public class Gobline : IMovingEntity
    {
        public void MoveTo(Vector3 destination)
        {
            Console.WriteLine($"{destination}까지 이동");
        }
    }

    public class GameController05
    {
        private IMovingEntity gobline;

        private void Awake()
        {
            gobline = Method();
        }

        public IMovingEntity Method()
        {
            Gobline gobline = new Gobline();

            return gobline;
        }
    }


}

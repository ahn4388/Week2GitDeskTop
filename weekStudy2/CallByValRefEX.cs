using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{
    class CallByValRefEX
    {
        //값에 의한 전달 예
        private void Awake()
        {
            int a = 3, b = 4;
            Console.WriteLine($"{a}, {b}");
            Swap(a, b);
            Console.WriteLine($"{a}, {b}"); //값 안바뀜
        }

        public void Swap(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

    }

    class CallByRef
    {
        //참조에 의한 전달
        private void Awake()
        {
            int a = 3, b = 4;
            Console.WriteLine($"{a}, {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"{a}, {b}"); //값 바뀜
        }

        public void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}

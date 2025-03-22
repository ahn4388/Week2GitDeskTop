using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{
    class ReturnEX
    {
        private void Awake()
        {
            int a = Max(10, 20);

        }

        public int Max(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;//void시, return;만
        }
    }
}

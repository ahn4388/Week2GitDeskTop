using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekStudy2
{
    public struct Stats
    {
        public string ID;
        public int currentHP;
        public int damage;
    }

    public class StructureEX
    {
        Stats player01 = new Stats();
        Stats player02;

        //player02.ID = "고박사";
        //player02.currentHP = 1000;  에러
        //player02.damage = 99;
    }


}

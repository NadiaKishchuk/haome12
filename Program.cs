using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home11
{
    class Program
    {
        static void Main(string[] args)
        {
            SaintNicolas nicolas = SaintNicolas.GetInstance();
            nicolas.addChild(new Child("Jane", true, 10, 5));
            nicolas.addChild(new Child("Jym", false, 2, 5));
            nicolas.addChild(new Child("Cody", false, 5, 5));
            nicolas.addChild(new Child("Bob", false, 2, 5));
            nicolas.addChild(new Child("Alex", false, 3, 5));
            nicolas.addChild(new Child("Kate",true,2,10));
            nicolas.addChild(new Child("Kate", true, 12, 10));
            var a=nicolas.giveGift();
            foreach(var s in a)
            {
                Console.WriteLine(s);
            }


        }
    }
}

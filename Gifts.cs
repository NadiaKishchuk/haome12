using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home11
{
    abstract class Gift
    {
        protected Wishes wishes;
        public override string ToString()
        {
            return wishes.ToString();
        }
        public Gift(in Wishes wish)
        {
            wishes = wish;
        }
    }
    class BadBehaviorGift : Gift
    {
        Birch birch;
        public BadBehaviorGift(in Wishes wish) : base(wish) {
            birch = new Birch();
        }
        public override string ToString()
        {
            return wishes.ToString()+birch;
        }
    }
    class GoodBehaviorGift : Gift
    {
        Toy toy;
        Sweets sweets;

        public GoodBehaviorGift(in Wishes wish, in Toy toy,
            in Sweets sweets) : base(wish)
        {
            this.toy = toy;
            this.sweets = sweets;
        }
        public override string ToString()
        {
            return wishes.ToString()+"  " + toy +"  "+ sweets;
        }
    }
    class Sweets
    {
        double weight;
        public Sweets(double weight=1)
        {
            this.weight = weight;
        }
        public override string ToString()
        {
            return "you get " + weight + "kg of sweets. ";
        }
    }
    class Wishes
    {
        string text, name;
        public Wishes(string text, string name)
        {
            this.text = text; this.name = name;
        }
        public override string ToString()
        {
            return name + "\n" + text;
        }

    }
    class Birch
    {
        public Birch() { }
        public override string ToString()
        {
            return "You get a birch";
        }
    }
}

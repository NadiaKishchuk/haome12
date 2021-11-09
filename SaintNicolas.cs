using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home11
{
    class SaintNicolas
    {
        private static readonly Lazy<SaintNicolas> Nicolas =
            new Lazy<SaintNicolas>(() => new SaintNicolas());
        List<Child> childs;
        GiftCreator creator;
        private SaintNicolas()
        {
            childs = new List<Child>();
            creator = new GiftCreator();
        }
        public static SaintNicolas GetInstance()
        {
            return Nicolas.Value;
        }
        public void addChild(in Child child)
        {

            childs.Add(child);
        }
        void createGift()
        {

        }
        public LinkedList<Gift> giveGift()
        {
            LinkedList<Gift> gifts = new LinkedList<Gift>();
            
            Random rand = new Random();

            foreach (var a in childs)
            {
                gifts.AddFirst(creator.GetGift(a, (rand.Next(0, 2) == 0) ? false : true));
            }
            return gifts;
        }
    }
    class Child
    {
        public string name { get; private set; }
        public bool isWomen { get; private set; }
        public int goodBehavior { get; private set; }
        public int badBehavior{ get; private set; }

    public Child(string name,bool isWomen,int goodBehavior,int badBehavior)
        {
            this.name = name;
            this.isWomen = isWomen;
            this.goodBehavior = goodBehavior;
            this.badBehavior = badBehavior;
        }
    }
}

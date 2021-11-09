using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home11
{
    class GiftCreator
    {
       
        public GiftCreator()
        {}
        public Gift GetGift(in Child child, bool considerBehavior=true)
        {
            Gift gift;

            
                if (child.goodBehavior < child.badBehavior&&considerBehavior)
                {
                    gift = new BadBehaviorGift(new Wishes(
                        "Be better and polite child and you will get ", child.name));
                }
            
            else
            {
                if (child.isWomen)
                {
                    gift = new GoodBehaviorGift(new Wishes("Be the same", child.name),
                        new GirlsGiftCreator().getGift(considerBehavior), new Sweets());
                }
                else
                {
                    gift = new GoodBehaviorGift(new Wishes("Be the same", child.name),
                           new BoyGiftCreator().getGift(considerBehavior), new Sweets());

                }
            }
            return gift;
        }
       
    }
    class GirlsGiftCreator
    {
        
        static int count = 0;
        public GirlsGiftCreator() {
           
        }
         Doll createDoll(string name="Barbie", int count = 1)
        {
            return new Doll(name, count);
        }
         Cosmetic createCosmetic()
        {
            return new Cosmetic();
        }
         Cosmetic createCosmetic(string name,string type)
        {
            return new Cosmetic(name,type);
        }
        public GirlsToy getGift(bool considerBehavior=true)
        {
            int number;
            if (considerBehavior)
            {
                Random random = new Random();
                number = random.Next(0, 2);
                
            }
            else
            {
                if (count == 2)
                {
                    count = 0;
                }
                number = count;
                ++count;
            }
            if (number == 0)
            {
                return createDoll();
            }
            else
            {
                return createCosmetic();
            }

        }
    }

    class BoyGiftCreator
    {
        public BoyGiftCreator() { }
        static int count = 0;

        ToyCar createToyCar(string color = "red") {
            return new ToyCar(color);
        }
        Tools createTools(string name= "screwdriver")
        {
            return new Tools(name);
        }
        Weight createWeight(double weight=2)
        {
            return new Weight(weight);
        }
        public BoysToy getGift(bool considerBehavior = true)
        {
            int number;
            if (considerBehavior)
            {
                Random random = new Random();
                number = random.Next(0, 2);
            }
            else
            {

                if (count == 3)
                {
                    count = 0;
                }
                number = count;
                ++count;
            }
            BoysToy boysToy;
            switch (number)
            {
                case 0:
                    boysToy= createToyCar();
                    break;
                case 1:
                    boysToy = createTools();
                    break;
                default:
                    boysToy = createWeight();
                    break;
            }
            return boysToy;

        }
    }

}

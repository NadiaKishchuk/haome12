using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home11
{
    abstract class Toy
    {
        protected string name;
        public Toy() { }
        public Toy(string name) { this.name = name; }
        public override string ToString()
        {
            return name;
        }
    }
    abstract class GirlsToy: Toy
    {
        public GirlsToy(string name) : base(name) { }
    }
    abstract class BoysToy : Toy
    {
        public BoysToy(string name) : base(name) { }
    }
    class Cosmetic: GirlsToy
    {
        string type;
        public Cosmetic(string name="cream",string type="care") : base(name) {
            this.type = type;
        }
        public override string ToString()
        {
            return name+ " type= "+ type ;
        }
    }
    class Doll : GirlsToy
    {
        int countDolls;
        public Doll(string name,int count=1) : base(name)
        {
            countDolls = count;
        }
        public override string ToString()
        {
            return countDolls+ "dolls "+ name ;
        }
    }

    class ToyCar : BoysToy
    {
        string color;
        public ToyCar(string color) : base("car") {
            this.color = color;

        }
        
    }
    class Tools : BoysToy
    {
        public Tools(string name) : base(name) { }
    }
    class Weight : BoysToy
    {
        double weight;
        public Weight(double weight=2) : base("gir") {
            this.weight = weight;
        }
        public override string ToString()
        {
            return name + "weight= " + weight;
        }
    }

}

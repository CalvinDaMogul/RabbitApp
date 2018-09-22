using System;

namespace rabbitApp {
    public class Pig: LifeForm, Grazing {

        public Carnivore carny= new Carnivore();
        public Pig(string rname, string rgender, string rcolor, string ractive):  base(rname,rgender,rcolor,ractive) {
        
        }

        public void graze()
        {
            Console.WriteLine("I am eating corn");
        }
        public void eatMeat() {
            carny.eatMeat();
        }
        public override void makeNoise() {
            Console.WriteLine("Oink!");
        
    }

        public void MakePrimalNoise() {
            base.makeNoise();
        }
    }
}
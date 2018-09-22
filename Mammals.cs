using System;

namespace rabbitApp {
    public class Mammals {
        public string name;
        public string color;
        string speed;
        string gender;
        public int eyes;
        public int legs;


        public Mammals(string mname, string mcolor, string mspeed, string mgender) {
            this.name= mname;
            this.color= mcolor;
            this.speed= mspeed;
            this.gender= mgender;
            this.eyes=0;
            this.legs=0;

        }

        public Mammals() {

        }
        public void SeeAll() {
            Console.WriteLine(this.name+" "+this.color+" "+this.speed+" "+this.gender+" "+this.eyes+" "+this.legs);
        }

        public void MakeSound() {
            Console.WriteLine("HOWL!!!");

     
        }
    }
}
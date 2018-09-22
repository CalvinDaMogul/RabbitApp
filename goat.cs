using System;

namespace rabbitApp {

    public class Goat: LifeForm, Grazing {
public Goat(string rname, string rgender, string rcolor, string ractive) {
            this.name= rname;
            this.gender= rgender;
            this.color=rcolor;
            this.active=ractive;
            this.fatherId=0;
            this.ssn=LifeForm.nextssn+1;
            LifeForm.nextssn++;
            this.motherId=0;
        }
        new public void makeNoise() {
            Console.WriteLine("Baa");
     
        }

        public void MakePrimalNoise() {
            base.makeNoise();
        }

        public void graze() {
            Console.WriteLine("I am eating grass");
        }

        public void divide(decimal a, decimal b) {
            try {
                Console.WriteLine($"{a} divided by {b} equals {a/b}");
            // Console.WriteLine(a+" divided by "+b+" equals "+ (a/b));
            } 
            catch {
                Console.WriteLine("Oops!!! An error has occured...");
            }


        }


    }
}
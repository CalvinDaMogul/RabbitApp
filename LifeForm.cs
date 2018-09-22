using System;

namespace rabbitApp{
    public class LifeForm{
        public string name;
        public string gender;
        public string color;
        public string active;
        public int ssn;
        public int fatherId;
        public int motherId;
        public static int nextssn=0;

        public LifeForm(string rname, string rgender, string rcolor, string ractive) {
            this.name= rname;
            this.gender= rgender;
            this.color=rcolor;
            this.active=ractive;
            this.fatherId=0;
            this.ssn=LifeForm.nextssn+1;
            LifeForm.nextssn++;
            this.motherId=0;
        }

        public LifeForm() {

        }

        public void DisplayAll() {
            Console.WriteLine(this.name +" "+ this.gender +" "+ this.color +" "+ this.fatherId +" "+ this.active +" "+ this.ssn +" "+ this.motherId);
        }
    
        public LifeForm mate(LifeForm Spouse)  {
            LifeForm babyLifeForm;
            string bbName= this.name + " Jr." ;
            string bbgender;
            if((this.ssn+Spouse.ssn)%2==0) bbgender="male";
            else {
                bbgender="female";
            }
            
            string bbcolor;
            if( this.color==Spouse.color) bbcolor= this.color; 
            else
            {
                bbcolor="gray";
            }
            string bbactive=this.active;
            babyLifeForm=new LifeForm(bbName,bbgender,bbcolor,bbactive);
            babyLifeForm.fatherId=this.ssn;
            babyLifeForm.motherId=Spouse.ssn;
            return babyLifeForm;
        }
    
        public virtual void makeNoise() {

             Console.WriteLine("randomNoise");

         }

    }
                
}

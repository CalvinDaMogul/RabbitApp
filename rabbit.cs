using System;

namespace rabbitApp{
    class Rabbit{
        public string name;
        public string gender;
        public string color;
        public string active;
        public int ssn;
        public int fatherId;
        public int motherId;
        public static int nextssn=0;

        public Rabbit(string rname, string rgender, string rcolor, string ractive) {
            this.name= rname;
            this.gender= rgender;
            this.color=rcolor;
            this.active=ractive;
            this.fatherId=0;
            this.ssn=Rabbit.nextssn+1;
            Rabbit.nextssn++;
            this.motherId=0;
        }

        public void DisplayAll() {
            Console.WriteLine(this.name +" "+ this.gender +" "+ this.color +" "+ this.fatherId +" "+ this.active +" "+ this.ssn +" "+ this.motherId);
        }
    
        public Rabbit mate(Rabbit Spouse)  {
            Rabbit babyRabbit;
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
            babyRabbit=new Rabbit(bbName,bbgender,bbcolor,bbactive);
            babyRabbit.fatherId=this.ssn;
            babyRabbit.motherId=Spouse.ssn;
            return babyRabbit;
        }
    }

}
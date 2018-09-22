using System;

namespace rabbitApp{
    class Elephant{
        public string name;
        public string gender;
        public string color;
        public string active;
        public int ssn;
        public int fatherId;
        public int motherId;
        public static int nextssn=0;

        public Elephant(string ename,string egender,string ecolor,string eactive) {
            this.name=ename;
            this.gender=egender;
            this.color=ecolor;
            this.active=eactive;
            this.ssn=Elephant.nextssn+1;
            Elephant.nextssn++;
            this.motherId=0;


        }

        public void ViewAll() {
            Console.WriteLine(this.name+" "+this.gender+" "+this.color+" "+this.active+" "+this.ssn+" "+this.motherId);
        }

        public Elephant mateC(Elephant Spouse) {
            Elephant babyElephant;
            string eename= this.name + "peanut";
            string eegender;
            if((this.ssn+Spouse.ssn)%2==0) eegender="male";
            else
            {
               eegender="female";
            }
            
            string eecolor;
            if(this.color==Spouse.color) eecolor=this.color;
            else
            {
                 eecolor="red";  
            }

            string eeactive=this.active;
            babyElephant=new Elephant(eename, eegender, eecolor,eeactive);
            babyElephant.fatherId=this.ssn;
            babyElephant.motherId=Spouse.ssn;
            return babyElephant;

        }
    }
}
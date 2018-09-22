using System;

namespace rabbitApp{
    class Duck: Grazing {
        public string name;
        public string gender;
        public string color;
        public string active;
        public int ssn;
        public int fatherId;
        public int motherId;
        public static int nextssn=0;

        // public Duck() {

        // }

        public Duck(string dname, string dgender, string dcolor, string dactive) {
            this.name=dname;
            this.gender=dgender;
            this.color=dcolor;
            this.active=dactive;
            this.fatherId=0;
            this.ssn=Duck.nextssn+1;
            Duck.nextssn++;
            this.motherId=0;
        }

        public void ShowAll() {
                Console.WriteLine(this.name+" "+this.gender+" "+this.color+" "+this.active+" "+this.ssn+" "+this.motherId);
            }

        public Duck mateB(Duck Spouse) {
            Duck babyDuck;
            string ddname= this.name + "Dr" ;
            string ddgender;
            if((this.ssn+Spouse.ssn)%2==0) ddgender="male";
            else
            {
               ddgender="female";
            }
            
            string ddcolor;
            if(this.color==Spouse.color) ddcolor=this.color;
            else
            {
                 ddcolor="red";  
            }

            string ddactive=this.active;
            babyDuck=new Duck(ddname, ddgender, ddcolor,ddactive);
            babyDuck.fatherId=this.ssn;
            babyDuck.motherId=Spouse.ssn;
            return babyDuck;

        }

            public void graze() {
                Console.WriteLine("I am eating sunflowers");
            }



}

}
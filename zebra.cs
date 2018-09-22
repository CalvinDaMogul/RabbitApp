using System;

namespace rabbitApp {
    public class Zebra: Mammals {

        public Zebra(string mname, string mcolor, string mspeed, string mgender): base(mname,mcolor,mspeed,mgender) {
            
            

        }
        
    public Zebra(string attribute, string value, string value2) {
        if(attribute=="color") this.color=value;
        if(attribute=="name") this.name=value;
        if(attribute=="name color") {
            this.name=value;
            this.color=value2;
        }


    }
    }
}
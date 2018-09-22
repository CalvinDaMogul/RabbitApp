using System;

namespace rabbitApp {
    public class giraffe: Mammals {
        public giraffe(string mgender, string mcolor, string mspeed, string mname): base(mgender,mcolor,mspeed,mname) {

        }

        public giraffe(string attribute, string value, string value2) {
            if(attribute=="color") this.color=value;
            if(attribute=="name") this.name=value;
            if(attribute=="name color") {
               this.name=value;
               this.color=value2;

            }
        }
    }
    
}

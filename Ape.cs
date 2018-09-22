namespace rabbitApp {
   public class Ape: Mammals {
       
    public Ape(string mname, string mcolor, string mspeed, string mgender): base(mname,mcolor,mspeed,mgender) {
        legs=2;
        eyes=2;
    }

     public void MakeSound(int howManyTimes) {
        for (int i = 0; i < howManyTimes; i++) {
            MakeSound();
        }
     }   
    }
}
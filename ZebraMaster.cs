using System;
using System.Collections.Generic;

namespace rabbitApp {
    public class ZebraMaster {
        public List<Zebra> ZebraList{get;set;}

        public ZebraMaster() {
            ZebraList=new List<Zebra>();
        }

        public void askForZebra() {
            string input1;
            string input2;
            string input3;
            string input4;
            do {
                Console.Write("Enter zebra color: ");
                input1= Console.ReadLine();
                    if(input1=="")break;
                    Zebra FirstZebra=new Zebra("color",input1,"");
                   Add(FirstZebra);
            }while(input1 !="");
                  
            do {
                Console.Write("Enter zebra name: ");
                input2= Console.ReadLine();
                    if(input2=="")break;
                    Zebra SecondZebra=new Zebra("name",input2,"");
                    Add(SecondZebra);
            }while(input2 !="");
            
            do {
                Console.Write("Now Enter zebra name: ");
                input3= Console.ReadLine();
                
                Console.Write("Now Enter zebra color: ");
                input4= Console.ReadLine();

                if(input3=="")break;
              
                Zebra ThirdZebra=new Zebra("name color",input3,input4);
                Add(ThirdZebra);
            }while(input3 !="");
        
        } 
        public void Add(Zebra newZebra) {
            if (ZebraList.Count==1) {

            }
            if (newZebra.name== null) {
                newZebra.name="Ziggy"+(ZebraList.Count+1);
            }
            ZebraList.Add(newZebra);
        }
    }
}
using System;
using System.Collections.Generic;

namespace rabbitApp {
    public class GiraffeMaster {
        public List<giraffe> GiraffeList {get;set;}

        public GiraffeMaster() {
            GiraffeList=new List<giraffe>();
        }

        public void askforGiraffe() {
            string input1;
            string input2;
            string input3;
            string input4;
            do{
                Console.Write("Enter Giraffe color: ");
                input1= Console.ReadLine();
                    if(input1=="")break;
                    giraffe FirstGiraffe=new giraffe("color",input1,"");
                   Add(FirstGiraffe);
            }while(input1 !="");
            do {
                Console.Write("Enter giraffe name: ");
                input2= Console.ReadLine();
                    if(input2=="")break;
                    giraffe SecondGiraffe=new giraffe("name",input2,"");
                    Add(SecondGiraffe);
            }while(input2 !="");
            
            do {
                Console.Write("Now Enter giraffe name: ");
                input3= Console.ReadLine();
                
                Console.Write("Now Enter giraffe color: ");
                input4= Console.ReadLine();

                if(input3=="")break;
              
                giraffe ThirdGiraffe=new giraffe("name color",input3,input4);
                Add(ThirdGiraffe);
            }while(input3 !="");
        
        } 
        public void Add(giraffe newGiraffe) {
            if (GiraffeList.Count==1) {

            }
            if (newGiraffe.name== null) {
                newGiraffe.name="Ziggy"+(GiraffeList.Count+1);
            }
            GiraffeList.Add(newGiraffe);
            }


        }


}


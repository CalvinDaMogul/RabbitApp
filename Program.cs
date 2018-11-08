using System.Collections.Generic;
using System;

namespace rabbitApp
{
    class Program
    {
        static void Main(string[] args)
        {
          DateTime dateTime = DateTime.Now;
            Console.WriteLine("Today is {0} {1}.", dateTime.DayOfWeek, dateTime.Day);
            Console.WriteLine("It is month number {0} of the year {1}.", dateTime.Month, dateTime.Year);
            Console.WriteLine("{0} hours, {1} minutes and {2} seconds.", dateTime.Hour, dateTime.Minute, dateTime.Second);
            Console.ReadKey();   
            Console.WriteLine("Hello World! It's Calvin J");

            //Rabbit Creation

            // Rabbit adam=new Rabbit("Adam","male","white","fast");
            // Rabbit eve=new Rabbit("Eve","female","white","slow");
            // Rabbit junior=adam.mate(eve);
            // Rabbit Evelyn=new Rabbit("Evelyn", "female","black","slow");
            // Rabbit junior2= junior.mate(Evelyn);

            // adam.DisplayAll();
            // eve.DisplayAll();
            // junior.DisplayAll();
            // Evelyn.DisplayAll();
            // junior2.DisplayAll();


            List<Duck>duckList=new List<Duck>();
            //Duck Creation
            int magicDuck=2;
             Duck []duckArray=new Duck [4]; 
            duckArray[0]=new Duck("David","male","green","fast");
            duckArray[1]=new Duck("Daisy","female","blue","slow");
            duckArray[2]=duckArray[0].mateB(duckArray[1]);
            duckArray[3]=new Duck("Dana","female","green","fast");

            duckArray[magicDuck].ShowAll();
            for (int i = 0; i < 4; i++)
            {
                // duckArray[i].ShowAll();
                duckList.Add(duckArray[i]);
            }
            
            duckMaster DuckBoss=new duckMaster(duckList);

            DuckBoss.displayDuck();
            duckArray[0].graze();

           
            duckArray[2].graze();
       

            // Elephant Creation
            Elephant Tom=new Elephant("Tom","male","gray","slow");
            Elephant Tina=new Elephant("Tina","female","dark gray","swift");
            Elephant Timmy=Tom.mateC(Tina);

            Tom.ViewAll();
            Tina.ViewAll();
            Timmy.ViewAll();


            Goat Billy=new Goat("Billy","male","white","fast");

            Billy.DisplayAll();
            Billy.graze();
            Billy.makeNoise();
            Billy.MakePrimalNoise();
            Billy.divide((decimal)20,0);
        
           

            Pig Charlotte=new Pig("Charlotte","male","pink","slow");
            Pig Charlie= new Pig("Charlie","male","green","fast");
            Pig Shirley= new Pig("Shirley", "female","orange","moderate");

            Charlotte.DisplayAll();
            Charlotte.graze();
            Charlotte.makeNoise();
            Charlotte.MakePrimalNoise();
            Charlotte.eatMeat();
            Charlie.eatMeat();
            Charlie.graze();
            Charlie.makeNoise();
            Charlie.DisplayAll();
            Shirley.DisplayAll();
            Shirley.graze();
            Shirley.eatMeat();
            Shirley.MakePrimalNoise();


            LifeForm Angel= Billy.mate((LifeForm)Charlotte);

            Angel.DisplayAll();
            Angel.makeNoise();
    


            Zebra Kyle=new Zebra("Kyle","striped","fast","male");
            ZebraMaster Carl=new ZebraMaster();
            
            
            Kyle.SeeAll();
            Carl.askForZebra();
            foreach(Zebra IndyZebra in Carl.ZebraList) {
                IndyZebra.SeeAll();
            }

            Ape Magilla=new Ape("Magilla","black","slow","female");
            Magilla.legs=2;
            Magilla.SeeAll();
            Magilla.MakeSound(3);
            Ape George= new Ape("George", "blue", "fast", "male");
            George.legs=2;
            George.SeeAll();
            George.MakeSound();

            giraffe Gordon=new giraffe("Gordon","yellow","moderate","male");
            GiraffeMaster Gerald=new GiraffeMaster();
            Gerald.askforGiraffe();
        

        
        }

    }
}

using System.Collections.Generic;

namespace rabbitApp{
    class duckMaster{

        public List<Duck> duckList;


        public duckMaster(List<Duck> listDuck) {

            this.duckList=listDuck;
        }

        public void displayDuck() {

            foreach (Duck DDuck in duckList) {

                DDuck.ShowAll();

            }

        }   
    }
}
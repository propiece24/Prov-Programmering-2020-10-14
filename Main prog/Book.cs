using System;
using System.Collections.Generic;

namespace Main_prog
{
    public class Book
    {
        
        public int price = 200;
        private string name = "";
        private int rarity = 1;
        private string category = "";
        private int actualValue = 0;
        private bool cursed = false;
        private static Random generator = new Random();

        public Book()
        {
         
         int actualValue = generator.Next(10);
          


        }

        public void Printinfo()
        {



        }

        public int Evaluate(int price)
        {

          return price;


        }

        public string GetCategory(string category)
        {
        return category;
        }

        public string GetName(string name)
        {
         return name;  
        }

        public bool IsCursed()
        {

         int risk = generator.Next(10);

         if( risk <= 8)
         {
             cursed = false;
         }
         else
         {
             cursed = true;
         }

         if(cursed == false)
         {
             return false;
         }
         else
         {
             return true;
         }


        }

          //Jag vet att jag skulle kunna göra detta men jag är alldeles för långsam för att hinna med allt.



    }
}

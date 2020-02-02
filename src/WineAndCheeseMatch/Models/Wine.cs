using System;
using System.Collections.Generic;
using System.Text;

namespace WineAndCheeseMatch.Models
{
    public class Wine
    { 
        //might add later
        //public string WineryName { get; private set; }
        //public int WineYear { get; private set; }
        //public FlavorProfile Flavors { get; set; }

        public string WineVarietyName { get;  }
        
        public string Color { get; }

        public string WineDescription { get; private set; }


        public Wine(string wineVarietyName, string color, string wineDescription)
        {
            this.WineVarietyName = wineVarietyName;
            this.Color = color;
            this.WineDescription = wineDescription;
        }


        public List<WineAndCheese> getWineCheesePairList()
        {
            List<WineAndCheese> wineCheesePairList = new List<WineAndCheese>();
            foreach (WineAndCheese wineCheese in WineCellar.WineAndCheeseList)
            {
                if (this.WineVarietyName.Equals(wineCheese.WinePair.WineVarietyName))
                {
                    wineCheesePairList.Add(wineCheese);   
                }
            }

            wineCheesePairList.Sort((x, y) => x.Rating.CompareTo(y.Rating));

            return wineCheesePairList;
        }






    }
}

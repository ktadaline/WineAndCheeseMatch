using System;
using System.Collections.Generic;
using System.Text;

namespace WineAndCheeseMatch.Models
{
    public class Cheese
    {
        public string CheeseVarietyName{ get; }

        public string CheeseType { get; }

        public string CheeseDescription { get; private set; }


        public Cheese(string cheeseVarietyName, string cheeseType, string cheeseDescription)
        {
            this.CheeseVarietyName = cheeseVarietyName;
            this.CheeseType = cheeseType;
            this.CheeseDescription = cheeseDescription;
        }

        public List<WineAndCheese> getWineCheesePairList()
        {
            List<WineAndCheese> wineCheesePairList = new List<WineAndCheese>();
            foreach (WineAndCheese wineCheese in WineCellar.WineAndCheeseList)
            {
                if (this.CheeseVarietyName.Equals(wineCheese.CheesePair.CheeseVarietyName))
                {
                    wineCheesePairList.Add(wineCheese);
                }
            }
            wineCheesePairList.Sort((x, y) => x.Rating.CompareTo(y.Rating));

            return wineCheesePairList;
        }


    }
}

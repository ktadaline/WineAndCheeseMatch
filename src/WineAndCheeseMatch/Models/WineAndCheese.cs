using System;
using System.Collections.Generic;
using System.Text;

namespace WineAndCheeseMatch.Models
{
    public class WineAndCheese
    {

        public string WineAndCheeseDescription { get; }
        public int Rating { get; set; }

        public Cheese CheesePair { get; }

        public Wine WinePair { get; }

        public WineAndCheese(Wine wine, Cheese cheese, int rating, string wineCheeseDescription)
        {
            this.CheesePair = cheese;
            this.WinePair = wine;
            this.Rating = rating;
            this.WineAndCheeseDescription = wineCheeseDescription;
        }

    }
}

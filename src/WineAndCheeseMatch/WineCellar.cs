using System;
using System.Collections.Generic;
using System.Text;
using WineAndCheeseMatch.Models;

namespace WineAndCheeseMatch
{
    public class WineCellar
    {
        //wines
        //Cabernet Sauvignon
        public static Wine CabernetSauvignon { get;  } = new Wine("Cabernet Sauvignon", "Red", "CabSauv is dry.");
        static Wine Malbec { get; } = new Wine("Malbec", "Red", "Malbec is peppery.");

        //cheeses
        public static Cheese SharpCheddar { get; } = new Cheese("Extra Sharp Cheddar", "Firm", "Sharp Cheddary taste");
        public static Cheese VintageReserveCheddar { get; } = new Cheese("VintageReserveCheddar", "Firm", "Robust Flavor");

        //WineAndCheese
        public static WineAndCheese CabernetSauvignonAndSharpCheddar { get; set; } = new WineAndCheese(CabernetSauvignon, SharpCheddar, 5, "A full-bodied and dry red Cabernet Sauvignon has hints of herbs and dark fruits. When paired with the extra sharp cheddar, the red wine draws out the bold cheddar flavors of this strong cheese. Cabernet Sauvignon also works well with other intense cheeses, particularly ones that are firm and salty.");


        //WineandCheeseList
        public static List<WineAndCheese> WineAndCheeseList { get; } = new List<WineAndCheese>()
        {
            CabernetSauvignonAndSharpCheddar
        };



        //wine list
        //public List<Wine> wineList = new List<Wine>()
        //{
        //    new Wine("Cabernet Sauvignon", "Red", "CabSauv is dry.", )
        //};

        ////cheese list
        //(string cheeseVarietyName, string cheeseType, string cheeseDescription, List<WineAndCheese> topWineAndCheeses)









        //public Wine(string wineVarietyName, string color, string wineDescription, List<WineAndCheese> topWineAndCheeses)

    }
}

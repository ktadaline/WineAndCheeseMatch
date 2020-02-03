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

        public static Cheese MontereyJack { get; } = new Cheese("Monterey Jack", "Semi-Firm", "Monterey Jack earns the rightful position as a true “American” cheese since it originated in the Mexican Franciscan friars of Monterey, California. Around the 1700s, these monasteries around the Monterey region were making a semi-firm, creamy, mild flavoured cheese from cow's milk which they aged for a little period. It is noted for its mild flavor and slight sweetness.");

        //WineAndCheese
        public static WineAndCheese CabernetSauvignonAndSharpCheddar { get; private set; } = new WineAndCheese(CabernetSauvignon, SharpCheddar, 5, "A full-bodied and dry red Cabernet Sauvignon has hints of herbs and dark fruits. When paired with the extra sharp cheddar, the red wine draws out the bold cheddar flavors of this strong cheese. Cabernet Sauvignon also works well with other intense cheeses, particularly ones that are firm and salty.");

        public static WineAndCheese MalbecAndVintageReserveCheddar { get; private set; } = new WineAndCheese(Malbec, VintageReserveCheddar, 5, "Reserve or vintage cheese has robust flavors, which need a red wine that can hold up against it. Malbecs are medium to full-bodied red wines that have black fruit, anise, and herb notes. The strong flavor of the Malbec complements the vintage or reserve cheese.");

        public static WineAndCheese MalbecAndMontereyJack { get; private set; } = new WineAndCheese(Malbec, MontereyJack, 4, "The key when pairing Malbec with cheese is recognize that the finish isn’t extremely long, so a cheese also without a super long, lingering taste is generally a good match.");

        //WineandCheeseList
        public static List<WineAndCheese> WineAndCheeseList { get; } = new List<WineAndCheese>()
        {
            CabernetSauvignonAndSharpCheddar, MalbecAndVintageReserveCheddar, MalbecAndMontereyJack
        };

        //wine list
        public List<Wine> wineList = new List<Wine>()
        {
            CabernetSauvignon, Malbec
        };

        //cheese list
        public List<Cheese> cheeseList = new List<Cheese>()
        {
            SharpCheddar, VintageReserveCheddar, MontereyJack
        };
    }
}

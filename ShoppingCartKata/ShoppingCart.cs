using NUnit.Framework;
using System;

namespace ShoppingCartKata
{
    public class ShoppingCart
    {
        private int appleDiscount;
        private int bananasDiscount;
        private int turnipsDiscount;
        double applesTotal = 0;
        double bananasTotal = 0;
        double carrotsTotal = 0;
        double turnipsTotal = 0;
        public double Basket()
        {
            double total = applesTotal+bananasTotal+carrotsTotal+turnipsTotal;
            return total;
        }
        public void Scan(string code)
        {
            if (code == "1111")
            {
                appleDiscount++;
                applesTotal = applesTotal + 50;
                if (appleDiscount == 3)
                {
                    applesTotal = applesTotal - 30;
                    appleDiscount=0;
                }
            }
            if (code == "2222")
            {
                bananasDiscount++;
                bananasTotal = bananasTotal + 20;
                if(bananasDiscount == 5)
                {
                    bananasTotal = bananasTotal - 20;
                    bananasDiscount = 0;
                }
            }
            if (code == "3333")
            {
                carrotsTotal = carrotsTotal + 15;
            }
            if (code == "4444")
            {
                turnipsDiscount++;
                turnipsTotal = turnipsTotal + 75;
                if (turnipsDiscount == 2)
                {
                    turnipsTotal = turnipsTotal -75;
                    turnipsDiscount = 0;
                }
            }
        }
    }
}
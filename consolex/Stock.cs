using System;

namespace consolex
{
    
    public class Stock : Asset
    {
        private string symbol;

        public string Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }

        private double pricepershare;
        public double PricePerShare
        {
            get { return this.pricepershare; }
            set { this.pricepershare = value; }
        }
       

        public Stock()
        {

        }
        public Stock(string sym, double pps, int num )
        {
            Symbol = sym;
            PricePerShare = pps;
            NumShares = num;
        }

        private int numshares;
        public int NumShares
        {
            get { return this.numshares; }
            set { this.numshares = value; }
        }

        
        public double GetValue()
        {
            return PricePerShare * NumShares;
        }

        
        public static double TotalValue(Asset[] any)
        {
            double result = 0.0;
            
            foreach(Asset anasset in any)
            {
                result += anasset.GetValue();
            }
            return result;
        }

        public override string ToString()
        {
            return "Stock[symbol="+ Symbol + ",pricePerShare=" + PricePerShare + ",numShares=" + NumShares + "]";
        }

        public override bool Equals(object someobject)
        {
            Stock somestock = (Stock)someobject;
            if((somestock.NumShares == this.NumShares) && (somestock.PricePerShare == this.PricePerShare)
                && (somestock.Symbol == this.Symbol))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
} 
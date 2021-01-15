using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba_1.модели
{
    class Snacks : Food
       
    {
        public string _Name;
        public double _Price;
        public double _CostPrice;
        public int _Time;
        public int _Weight;
        

        public  Snacks(double Price, double Costprice, int Time, int Weight, string Name)
        {
         _Name =Name;
         _Price=Price;
         _CostPrice=Costprice;
         _Time=Time;
         _Weight=Weight;
            
        }
        public double price { get =>  _Price; set => _Price=value; }
        public double costprice { get => _CostPrice; set => _CostPrice = value; }
        public int time { get => _Time; set => _Time=value; }
        public int weight { get => _Weight; set => _Weight=value; }
        public string name { get =>_Name; set => _Name=value; }
        
    }
}

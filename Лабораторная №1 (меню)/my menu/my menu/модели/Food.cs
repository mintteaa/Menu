using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba_1.модели
{
    interface Food
    {
        double price { get; set; }
        double costprice { get; set; }
        int time { get; set; }
        int weight { get; set; }
        string name { get; set; }
        
    }
}

using laba_1.модели;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba_1.контроллер
{
    class заказ
    {

        public заказ(int mode) { mymenu Eda = new mymenu(mode);  Orderr=Eda.Foods ;  }

        List<Food> Orderr;

        List<dishes> mymenu;

        OrderInformation info;

        List<Food> ShowMenu(List<Food> F) { return F; }
        bool ChooseItem(List<dishes> W, Food S, int D)
        {
            bool K=false;
            dishes N;
            N.amount=D;
            N.T=S;
            W.Add(N);
            return K;
        }
       void FinishOrder(bool Cheque=false)
            
        {
            OrderInformation R = new OrderInformation();
            foreach (dishes lemon in mymenu)
            {
                R.price = R.price + lemon.T.price*lemon.amount;
                Console.WriteLine("Стоимость: " +R.price );
                R.weight = R.weight * lemon.T.price;
                Console.WriteLine("Вес:"+R.weight);
            }
        }  
     
    }
    struct OrderInformation { public double price; public double time; public double weight; public int id; }
    struct dishes {public int amount; public Food T; }

}


    

using laba_1.модели;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections;
using Microsoft.Win32;

namespace my_menu
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Mode;
        mymenu DailyMenu;
        Orders DailyOrders;
        int totalP = 0;
        public MainWindow()
        {
            Mode = 0;
            DailyMenu = new mymenu(Mode);
            DailyOrders = new Orders();
            DailyOrders.FinalOrders = new List<Order>();
            InitializeComponent();
            this.DataContext = DailyMenu;
            DMenu.ItemsSource = DailyMenu.Foods;
            DOrderView.ItemsSource = DailyMenu.Foods;
        }

        public struct Order
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Time { get; set; }
            public int Amount { get; set; }
        }
        public struct Orders
        {
            public List<Order> FinalOrders;
            public int FinalPrice;
            public int FinalTime;
        }
        private void AddtoOrderClick(object sender, RoutedEventArgs e) //заказы обычные
        {

            Order temporaryOrder = new Order();
            try
            {
                DOrderView.ItemsSource = default;
                temporaryOrder.Name = Dname.Text;

                temporaryOrder.Price = Convert.ToInt32(Dprice.Text);

                temporaryOrder.Time = Convert.ToInt32(Dtime.Text);

                temporaryOrder.Amount = Convert.ToInt32(DAmount.Text);

                DailyOrders.FinalOrders.Add(temporaryOrder);

                TemporaryOr.Add(temporaryOrder.Name + " " + "х" + Convert.ToString(temporaryOrder.Amount) + " " + Convert.ToString(temporaryOrder.Price) + "р");
                DOrderView.Items.Refresh();

                totalP += Convert.ToInt32(temporaryOrder.Price) * temporaryOrder.Amount;
                TotalP.Text = Convert.ToString(totalP) + "p";
                if (temporaryOrder.Time > totalTime) totalTime = temporaryOrder.Time;
                DOrderView.Items.Add(temporaryOrder.Name + " " + "х" + Convert.ToString(temporaryOrder.Amount) + " " + Convert.ToString(temporaryOrder.Price) + "р");
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректно количество");
                DAmount.Text = "1";
            }

        }
        private void DOrderView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        int totalT = 0, totalTime = 0,  i = 1;
        List<List<string>> AllOrd = new List<List<string>>(); //Все сделанные заказы
        List<string> TemporaryOr = new List<string>();
        private void AllOrderrs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TemporaryOr.Clear();
            DailyOrders.FinalOrders.Clear();
            DOrderView.ItemsSource = AllOrd[AllOrders.SelectedIndex];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DailyOrders.FinalOrders.Clear();
            DOrderView.ItemsSource = null;
            AllOrders.ItemsSource = null;
            totalP = 0;
            TotalP.Text = Dname.Text = Dtime.Text = Dprice.Text = DAmount.Text = "";
        }

        private void ChangeMenuClick(object sender, RoutedEventArgs e) //переключение меню
        {
            DMenu.ItemsSource = DailyMenu.Foods;
            switch (Mode)
            {
                case 0:
                    {
                        Mode = 1;
                        DailyMenu = new mymenu(Mode);
                        DMenu.ItemsSource = DailyMenu.Foods;
                        break;
                    }
                case 1:
                    {
                        Mode = 2;
                        DailyMenu = new mymenu(Mode);
                        DMenu.ItemsSource = DailyMenu.Foods;
                        break;
                    }
                case 2:
                    {
                        Mode = 3;
                        DailyMenu = new mymenu(Mode);
                        DMenu.ItemsSource = DailyMenu.Foods;
                        break;
                    }
                case 3:
                    {
                        Mode = 4;
                        DailyMenu = new mymenu(Mode);
                        DMenu.ItemsSource = DailyMenu.Foods;
                        break;
                    }
                case 4:
                    {
                        Mode = 5;
                        DailyMenu = new mymenu(Mode);
                        DMenu.ItemsSource = DailyMenu.Foods;
                        break;
                    }
                case 5:
                    {
                        Mode = 0;
                        DailyMenu = new mymenu(Mode);
                        DMenu.ItemsSource = DailyMenu.Foods;
                        break;
                    }
            }
        }

        private void FinishOrderClick(object sender, RoutedEventArgs e) //Завершение оформления заказов, вывод всех сделанных заказов в третий листвью
        {
            if (DailyOrders.FinalOrders.Count == 0) { }
            else
            {
                List<string> AllO = new List<string>();
                foreach (Order Заказ in DailyOrders.FinalOrders)
                {
                    AllO.Add(Заказ.Name + "  " + "x" + Заказ.Amount + " " + Заказ.Price + "p");
                }
                AllO.Add("Итого: " + Convert.ToString(totalP) + "p");
                AllOrders.Items.Add("Заказ" + Convert.ToString(i));
                AllO.Add("Ориентировочное время приготовления заказа: "+ Convert.ToString(totalTime) + "минут");
                i++;
                AllOrd.Add(AllO);
                TemporaryOr.Clear();
                MessageBox.Show("Спасибо за заказ! :) ");
                DailyOrders.FinalOrders.Clear();
                DOrderView.Items.Clear();
                totalP = totalT  = 0;
                TotalP.Text = Dname.Text = Dtime.Text = Dprice.Text = "";
            }
        }
    } 
}

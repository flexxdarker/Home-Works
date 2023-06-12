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

namespace HomeWork_07._06._2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int countPeople = 0;
        string typeofaparts = string.Empty;
        double price;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            if (countPeople < 12)
            {
                countPeople += 1;
                CountPeople.Content = countPeople;
            }
            else
            {
                countPeople = 0;
                countPeople += 1;
                CountPeople.Content = countPeople;
            }
        }

        private void CountBTN_Click(object sender, RoutedEventArgs e)
        {
            CountPrice();
            MessageBox.Show($"Name: {NameTB.Text}\nSurname: {SurnameTB.Text}\nPhone number: {PhoneTB.Text}\nCount of People: {countPeople}\nSelected Apartments: {typeofaparts}\nDate From: {Calendar.SelectedDates.First()}\nDate To: {Calendar.SelectedDates.Last()}\nPrice: {price}");
        }
        
        private void CountPrice()
        {
            int time = Convert.ToInt32(Calendar.SelectedDates.Count);
            if(typeofaparts == "Standart")
            {
                price = 20 * countPeople * time * 1.1;
            }
            else if(typeofaparts == "Econom")
            {
                price = 20 * countPeople * time * 0.8;
            }
            else if(typeofaparts == "Luxe")
            {
                price = 20 * countPeople * time * 2.3;
            }
        }
        private void ClearBTN_Click(object sender, RoutedEventArgs e)
        {
            NameTB.Text = string.Empty;
            SurnameTB.Text = string.Empty;
            PhoneTB.Text = string.Empty;
            countPeople = 0;
            CountPeople.Content = countPeople;
            Luxe.IsChecked = false;
            Standart.IsChecked = false;
            Econom.IsChecked = false;
            typeofaparts = string.Empty;
            Calendar.SelectedDate = DateTime.Now;
        }

        private void Luxe_Click(object sender, RoutedEventArgs e)
        {
            typeofaparts = "Luxe";
        }

        private void Standart_Click(object sender, RoutedEventArgs e)
        {
            typeofaparts = "Standart";
        }

        private void Econom_Click(object sender, RoutedEventArgs e)
        {
            typeofaparts = "Econom";
        }
    }
}

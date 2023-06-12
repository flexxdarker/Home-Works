using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HomeWork_09._06._2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewmodel = new();

        ObservableCollection<string> colors;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewmodel;
            colors = new ObservableCollection<string>();
            ColorListView.ItemsSource = colors;
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            colors.Add(viewmodel.ToString());
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            colors.RemoveAt(ColorListView.SelectedIndex);
        }
    }
    [PropertyChanged.AddINotifyPropertyChangedInterface()]
    public class ViewModel
    {
        public Color color => Color.FromArgb(alpha, red, green, blue);
        public byte alpha { get; set; }
        public byte red { get; set; }
        public byte green { get; set; }
        public byte blue { get; set; }
        public ViewModel()
        {

        }
        public override string ToString()
        {
            return color.ToString();
        }
    }
}

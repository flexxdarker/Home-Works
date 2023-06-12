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

namespace HomeWork_09._06._2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewmodel = new();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewmodel;
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
    }
}

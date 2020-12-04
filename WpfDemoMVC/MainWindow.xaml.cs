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
using WpfCounterController;
using ViewInterface;

namespace WpfDemoMVC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ICounterView
    {
        private Controller controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void increase_Click(object sender, RoutedEventArgs e)
        {
            controller.Increase(this);
        }

        private void decrease_Click(object sender, RoutedEventArgs e)
        {
            controller.Decrease(this);
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            controller.Reset(this);
        }

        private void resetToMax_Click(object sender, RoutedEventArgs e)
        {
            controller.ResetToMax(this);
        }
        public void SetNumber(string value)
        {
            number.Text = value;
        }
    }
}

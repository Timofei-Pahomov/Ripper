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

namespace Ripper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void open_otrasl(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new otrasl());
        }

        private void open_robo(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new robo());
        }

        private void open_inst(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ints());
        }
    }
}

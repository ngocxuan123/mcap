using Mcap.ViewModels;
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

namespace Mcap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Menu_Cick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            switch (button.Content)
            {
                case "Worklist":
                    DataContext = new WorkListViewModel();
                    break;
                case "Home":
                    DataContext = new HomeViewModel();
                    break;
                default:
                    DataContext = new HomeViewModel();
                    break;
            }
        }
    }
}

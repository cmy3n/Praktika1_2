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

namespace Praktika1_2
{
    public partial class Page2 : Page
    {
        private PunktVidachiZakazovEntities orders = new PunktVidachiZakazovEntities();

        public Page2()
        {
            InitializeComponent();

            DataGrid2.ItemsSource = orders.Orders.ToList();
        }

        private void ButtonPage2_Right_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
        }

        private void ButtonPage2_Left_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
    }
}

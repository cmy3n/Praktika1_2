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
    public partial class Page3 : Page
    {
        private PunktVidachiZakazovEntities OrdersClients = new PunktVidachiZakazovEntities();

        public Page3()
        {
            InitializeComponent();

            DataGrid3.ItemsSource = OrdersClients.OrdersClients.ToList();
        }

        private void ButtonPage3_Left_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }
    }
}

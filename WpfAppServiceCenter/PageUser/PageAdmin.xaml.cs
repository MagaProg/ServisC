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
using WpfAppServiceCenter.Org;

namespace WpfAppServiceCenter.PageUser
{
    /// <summary>
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page
    {
        public PageAdmin()
        {
            InitializeComponent();
        }

        private void SozZakaz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageOrders());
        }

        private void SelectOrders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageOrdersCelect2());
        }
    }
}

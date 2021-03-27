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
    /// Логика взаимодействия для PageMaster.xaml
    /// </summary>
    public partial class PageMaster : Page
    {
        public PageMaster()
        {
            InitializeComponent();
        }

        private void miOrders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMasterOrders());

        }

        private void POrders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageOrdersSelect());
        }
    }
}

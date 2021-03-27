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
using WpfAppServiceCenter.Model;

namespace WpfAppServiceCenter.Org
{
    /// <summary>
    /// Логика взаимодействия для PageMasterOrders.xaml
    /// </summary>
    public partial class PageMasterOrders : Page
    {
        public PageMasterOrders()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dtagrid.ItemsSource = ODBconext.DB.MasterOrdersMaster.ToList();
        }

        private void ZavvvvRem_Click(object sender, RoutedEventArgs e)
        {
            var c = dtagrid.SelectedItem as MasterOrdersMaster;

            
        }
    }
}

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
using WpfAppServiceCenter.WinForm;

namespace WpfAppServiceCenter.Org
{
    /// <summary>
    /// Логика взаимодействия для PageOrdersSelect.xaml
    /// </summary>
    public partial class PageOrdersSelect : Page
    {
        public PageOrdersSelect()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridOrders.ItemsSource = ODBconext.DB.Cluent.ToList();

        }

        private void OrdersNaRem_Click(object sender, RoutedEventArgs e)
        {
            var s = dataGridOrders.SelectedItem as Cluent;

            WindowOrders windowOrders = new WindowOrders(s);

            windowOrders.ShowDialog();


        }

        private void dataGridOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var c = dataGridOrders.SelectedItem as Cluent;


        }

       

        private void DALETE_Click(object sender, RoutedEventArgs e)
        {
           


        }
    }
}

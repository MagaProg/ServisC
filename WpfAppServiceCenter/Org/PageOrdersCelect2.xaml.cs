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
    /// Логика взаимодействия для PageOrdersCelect2.xaml
    /// </summary>
    public partial class PageOrdersCelect2 : Page
    {
        public PageOrdersCelect2()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridddd.ItemsSource = ODBconext.DB.Cluent.ToList();
        }

        private void DelOrders_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

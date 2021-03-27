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
    /// Логика взаимодействия для PageOrders.xaml
    /// </summary>
    public partial class PageOrders : Page
    {
        public PageOrders()
        {
            InitializeComponent();
        }

        private void OfOrders_Click(object sender, RoutedEventArgs e)
        {
            if (NAzvTech.Text == "" ||  Opis.Text == "" || DataRegis.Text == "" || FIO.Text == "" || Teleh.Text == "" || Adres.Text == "" )
            {
                MessageBox.Show("Все поля должны быть заполнены", "Уведомление",  MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else
            {
            Orders orders = new Orders() {
                NameTechnic = NAzvTech.Text,

                Malfunctions= Opis.Text,

                DateOrders= DataRegis.Text
            };

            Cluent cluent = new Cluent() {
            FullName= FIO.Text,

            Telephone= Teleh.Text,

            Address= Adres.Text,

            idOrders= orders.id
            };

            ODBconext.DB.Orders.Add(orders);
            ODBconext.DB.Cluent.Add(cluent);

            ODBconext.DB.SaveChanges();
                MessageBox.Show("Заказ создан", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

                NAzvTech.Text = "";
                Opis.Text = "";
                DataRegis.Text = "";
                FIO.Text = "";
                Teleh.Text = "";
                Adres.Text = "";
            }

        }

        private void Teleh_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }
    }
}

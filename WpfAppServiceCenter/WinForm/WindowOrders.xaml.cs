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
using System.Windows.Shapes;
using WpfAppServiceCenter.Model;

namespace WpfAppServiceCenter.WinForm
{
    /// <summary>
    /// Логика взаимодействия для WindowOrders.xaml
    /// </summary>
    public partial class WindowOrders : Window
    {
       public Cluent cluent;
        public WindowOrders(Cluent s)
        {
            InitializeComponent();
            this.cluent = s;
            Fiotex.Text = s.FullName;
            TelTex.Text = s.Telephone;
            AresTex.Text = s.Address;
            NameTex.Text = s.Orders.NameTechnic;
            OpisTex.Text = s.Orders.Malfunctions;
            DataTex.Text = s.Orders.DateOrders;

        }

        private void OfOrders_Click(object sender, RoutedEventArgs e)
        {
            MasterOrdersMaster orders2 = new MasterOrdersMaster()
            {
                Vremonta = NAzvTech.Text,

                Stoimremon = Opis.Text,

                opisrem = DataRegis.Text,



                zatrelement = FIO.Text,

                detalnaxamen = Teleh.Text,

                stoimDiagnos = Adres.Text,
                idCluent = cluent.id,

                idOrders = cluent.Orders.id
                
            };


            ODBconext.DB.MasterOrdersMaster.Add(orders2);

          
            ODBconext.DB.SaveChanges();

            this.Close();
        }
    }
}

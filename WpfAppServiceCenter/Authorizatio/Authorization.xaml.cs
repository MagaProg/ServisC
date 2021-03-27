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
using WpfAppServiceCenter.PageUser;

namespace WpfAppServiceCenter.Authorizatio
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void btnAuto_Click(object sender, RoutedEventArgs e)
        {
            var auto = ODBconext.DB.User.FirstOrDefault(x => x.Login == Vlogin.Text && x.Password == Vpassword.Password);

            if (auto != null)
            {
                switch (auto.idRolle)
                {
                    case 1:

                        NavigationService.Navigate(new PageAdmin());
                        break;

                    case 2:

                        NavigationService.Navigate(new PageMaster());

                        break;
                }

                    
            }

            else
            {
                MessageBox.Show("Токого пользователя нет!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ClikRegist_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageRegistration());
        }

        private void ClikRegist_MouseEnter(object sender, MouseEventArgs e)
        {
            ClikRegist.Foreground = Brushes.Black;

        }

        private void Page_MouseLeave(object sender, MouseEventArgs e)
        {
            ClikRegist.Foreground = Brushes.Red;
        }
    }
}

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
using System.Windows.Threading;
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
        int Shet = 0;
        int Shet2 = 0;

        DispatcherTimer time = new DispatcherTimer();
        void tim()
        {
            time = new DispatcherTimer();

            time.Interval = new TimeSpan(0, 0, 0, 0,1000);
            time.Tick += Time_Tick;

            time.Start();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (Shet2== 1)
            {
                time.Stop();

                btnAuto.IsEnabled = true;
                Vlogin.IsEnabled = true;
                Vpassword.IsEnabled = true;
                Shet2 = 0;

                timER.Text = "";
                return;
            }
            Shet2--;

            timER.Text = Shet2.ToString();

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
                Shet++;
                if (Shet == 4)
                {
                    MessageBox.Show("Подождите 30 сек!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    Shet = 0;
                    btnAuto.IsEnabled = false;
                    Vlogin.IsEnabled = false;
                    Vpassword.IsEnabled = false;
                   Shet2 = 30;
                    tim();
                }

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

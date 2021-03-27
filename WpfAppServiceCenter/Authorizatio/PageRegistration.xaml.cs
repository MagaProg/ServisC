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

namespace WpfAppServiceCenter.Authorizatio
{
    /// <summary>
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
            CMDRolli.ItemsSource = ODBconext.DB.Rolle.ToList();
        }

        

        private void btnAuto2_Click(object sender, RoutedEventArgs e)
        {
           


            if (Vlogin.Text != ""  && CMDRolli.Text!= "" ) 
            { 

             if (ODBconext.DB.User.Count(X => X.Login==Vlogin.Text)>0)
               {
                  MessageBox.Show("Такой пользователь уже есть", "Уведомление" , MessageBoxButton.OK, MessageBoxImage.Information);
               }  
                else
               {
                   User user = new User()
                   {

                    Login = Vlogin.Text,

                    Password = Vpassword.Password,

                    Rolle = CMDRolli.SelectedItem as Rolle
                   };
                          ODBconext.DB.User.Add(user);

                          ODBconext.DB.SaveChanges();

                    MessageBox.Show("Пользователь создан", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }

            else
            {
                MessageBox.Show("Все поля должны быть заполнены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
         
        private void Vpassword2_PasswordChanged(object sender, RoutedEventArgs e)
        {
            
            if (Vpassword.Password == Vpassword2.Password)
            {
                btnAuto2.IsEnabled = true;
                Vpassword2.Background = Brushes.LightGreen;
            }
            else
            {
                btnAuto2.IsEnabled = false;
                Vpassword2.Background = Brushes.Red;
            }
        }
    }
}

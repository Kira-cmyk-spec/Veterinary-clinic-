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
using Veterinary_clinic.AppClass;

namespace Veterinary_clinic.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageAutho.xaml
    /// </summary>
    public partial class PageAutho : Page
    {
        public PageAutho()
        {
            InitializeComponent();
        }

        private void Voidbd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (loginbd.Text != "" )
                {
                    var _user = App.Connection.Doct.Where(z =>  z.Name == loginbd.Text).FirstOrDefault();
                    if (_user != null)
                    {

                        Class_User.CorrUsers = _user;
                        NavigationService.Navigate(new PageMainMenu());



                    }
                    else
                    {
                        MessageBox.Show("Таких пользователей не существует", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Поля логина или пароля введены неправильно", "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch { }
        }
    }
}

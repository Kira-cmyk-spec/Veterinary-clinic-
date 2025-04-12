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
using Veterinary_clinic.AddBd;
using Veterinary_clinic.AppClass;

namespace Veterinary_clinic.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageEdit.xaml
    /// </summary>
    public partial class PageEdit : Page
    {
        public PageEdit()
        {
            InitializeComponent();
            this.DataContext = App.Connection.Reception.Where(z => z.id == Class_User.CorrUsers.id).FirstOrDefault();
           
        }

        private void CliventSave(object sender, RoutedEventArgs e)
        {
            App.Connection.SaveChanges();
            MessageBox.Show("Изменение произошло успешно ");
            NavigationService.Navigate(new PageApp.PageMainMenu());

        }
    }
}

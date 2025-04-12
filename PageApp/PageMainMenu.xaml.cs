using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.IO;
using System.Collections;
using System.Data.Common;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Veterinary_clinic.AppClass;


namespace Veterinary_clinic.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageMainMenu.xaml
    /// </summary>
    public partial class PageMainMenu : Page
    {   
        public static List<Reception> receptions { get; set; }
        public ObservableCollection<Reception> receptions1 { get; set; }
        public ICollectionView animalView { get; set; }
        public PageMainMenu()
        {
            InitializeComponent();
            Listanimals.ItemsSource = App.Connection.Animals.ToList();
            receptions = new List<Reception>(asd.veterinary_ClinicEntities.Reception.Where(i => i.lsDelete == true).ToList());
            this.DataContext = this;
        }
    


        

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageApp.PageEdit());
        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var ser = (sender as Button).DataContext as Reception;
            MessageBox.Show("Точно хотите удалить?");
            ser.lsDelete = false;
            asd.veterinary_ClinicEntities.SaveChanges();
            Listanimals.ItemsSource = new List<Reception>(asd.veterinary_ClinicEntities.Reception.Where(i => i.lsDelete == true).ToList());

        }



        private void Group_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filterText = Group_TextBox.Text.ToLower();
            var filteredProducts = receptions.Where(p => p.id_animals.ToString().Contains(filterText)).ToList();
            Listanimals.ItemsSource = new ObservableCollection<Reception>(filteredProducts);
        }

     
    }
}

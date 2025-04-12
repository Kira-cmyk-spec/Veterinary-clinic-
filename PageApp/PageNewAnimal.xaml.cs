using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для PageNewAnimal.xaml
    /// </summary>
    public partial class PageNewAnimal : Page
    {
        public static List<Reception> receptions { get; set; }
        public ObservableCollection<Reception> receptions1 { get; set; }
        public static List<Animals> animals { get; set; }
        public static List<Doct> animals1 { get; set; }
        public PageNewAnimal()
        {
            InitializeComponent();
            this.DataContext = App.Connection.Reception.Where(z => z.id == Class_User.CorrUsers.id).FirstOrDefault();
            animals1 = new List<Doct>((App.Connection.Doct.ToList()));
            animals = new List<Animals>((App.Connection.Animals.ToList()));
        }

        private void CLEventAddNewProd(object sender, RoutedEventArgs e)
        {

            try
            {


                Animals items = new Animals()
                {
                    Name = nameanim.Text,
                    id_Gender = Convert.ToInt32(pol.Text),
                    Height = heig.Text,
                    Weight = heig.Text,


                };
                Reception data = new Reception()
                {
                   
                    Date = DateTime.Now,
                    Dicription = disk.Text,
                    lsDelete = true,
                };

                App.Connection.Animals.Add(items);
                App.Connection.Reception.Add(data);


                App.Connection.SaveChanges();
                MessageBox.Show("Добавление произошло  успешно ");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }
    }
}

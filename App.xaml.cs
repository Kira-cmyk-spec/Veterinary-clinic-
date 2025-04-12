using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Veterinary_clinic.AddBd;

namespace Veterinary_clinic
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static  Veterinary_clinicEntities Connection = new Veterinary_clinicEntities();

    }
}

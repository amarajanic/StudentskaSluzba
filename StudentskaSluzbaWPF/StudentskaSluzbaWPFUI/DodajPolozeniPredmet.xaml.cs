using StudentskaSluzbaWPFLibrary;
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

namespace StudentskaSluzbaWPFUI
{
    /// <summary>
    /// Interaction logic for DodajPolozeniPredmet.xaml
    /// </summary>
    public partial class DodajPolozeniPredmet : Window
    {
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        StudentiPredmeti std = new StudentiPredmeti();
        public DodajPolozeniPredmet(Student student)
        {
            InitializeComponent();
            std.StudentId = student.StudentId;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool ocjena;
            std.NazivPredmeta = t1.Text;
            ocjena = int.TryParse(t2.Text,out int rezultat);
            if (ocjena)
                std.Ocjena = rezultat;
            std.Datum = t3.Text;

            if(!string.IsNullOrEmpty(std.NazivPredmeta) && !string.IsNullOrEmpty(std.Datum))
            {
                db.DodajPolozeniPredmet(std);
                MessageBox.Show("Uspjesno ste dodali predmet !");
                Close();
            }
            else
            {
                MessageBox.Show("Neki od parametara nisu tacni!");
            }
           
        }
    }
}

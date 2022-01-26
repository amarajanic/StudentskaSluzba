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
    /// Interaction logic for PredmetiWindow.xaml
    /// </summary>
    public partial class PredmetiWindow : Window
    {
        Student currentStudent = new Student();
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        public PredmetiWindow(Student std)
        {
            InitializeComponent();

            currentStudent = std;

            DG.ItemsSource = db.UcitajPolozenePredmete(currentStudent);

            t1.Text = currentStudent.FullName;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DodajPolozeniPredmet pred = new DodajPolozeniPredmet(currentStudent);

            pred.Show();
        }

        private void TextBlock_Initialized(object sender, EventArgs e)
        {
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = null;
            DG.ItemsSource = db.UcitajPolozenePredmete(currentStudent);
        }
    }
}

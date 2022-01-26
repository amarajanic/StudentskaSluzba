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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentskaSluzbaWPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        TabItem _tabUserPage;
        public List<Student> StudentiLista = new List<Student>();
       
        public MainWindow()
        {
            InitializeComponent();
            StudentiLista = db.UcitajSveStudente();

            DG.ItemsSource = db.UcitajSveStudente();
        }

        List<Student> PopuniListu()
        {
            List<Student> temp = new List<Student>();

            temp.Add(new Student { StudentId = 1, Ime = "Amar", Prezime = "Ajanic", UserName = "amar", PassWord = "amar123", PolozeniPredmeti = PopuniPolozene() }) ;
            temp.Add(new Student { StudentId = 2, Ime = "Tim", Prezime = "Corey", UserName = "tim", PassWord = "tim123", PolozeniPredmeti = PopuniPolozene() });
            temp.Add(new Student { StudentId = 3, Ime = "Johhny", Prezime = "Sins", UserName = "johhny", PassWord = "js123", PolozeniPredmeti = PopuniPolozene() });


            return temp;
        }

        List <StudentiPredmeti> PopuniPolozene()
        {
            List<StudentiPredmeti> temp = new List<StudentiPredmeti>();

            temp.Add(new StudentiPredmeti { Id = 1, Ocjena = 7, Datum = "25.7.2015", StudentId = 1 });
            temp.Add(new StudentiPredmeti { Id = 1, Ocjena = 7, Datum = "25.7.2015", StudentId = 1 });
            temp.Add(new StudentiPredmeti { Id = 1, Ocjena = 7, Datum = "25.7.2015", StudentId = 1 });
            temp.Add(new StudentiPredmeti { Id = 1, Ocjena = 7, Datum = "25.7.2015", StudentId = 1 });

            return temp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear();
            var userControls = new Studenti();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage);
            MainTab.Items.Refresh();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear();
            var userControls = new Studenti();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage);
            MainTab.Items.Refresh();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PredmetiWindow wdw = new PredmetiWindow(DG.CurrentItem as Student);

            wdw.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DodajStudenta frm = new DodajStudenta();
            frm.ShowDialog();

            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = null;
            DG.ItemsSource = db.UcitajSveStudente();

        }
    }
}

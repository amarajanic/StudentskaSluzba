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
    /// Interaction logic for DodajStudenta.xaml
    /// </summary>
    public partial class DodajStudenta : Window
    {
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        public DodajStudenta()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student temp = new Student();

            temp.Ime = t1.Text;
            temp.Prezime = t2.Text;
            temp.UserName = t3.Text;
            temp.PassWord = t4.Text;

            if(!string.IsNullOrEmpty(temp.Ime) && !string.IsNullOrEmpty(temp.Prezime) && !string.IsNullOrEmpty(temp.UserName) && !string.IsNullOrEmpty(temp.PassWord) )
            {
                db.DodajStudenta(temp);
                MessageBox.Show("Uspjesno ste dodali novog studenta!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Podaci nisu u ispravnom formatu!");
            }
           
        }
    }
}

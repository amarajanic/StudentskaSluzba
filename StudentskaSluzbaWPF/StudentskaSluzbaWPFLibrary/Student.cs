using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzbaWPFLibrary
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }


        public List<StudentiPredmeti> PolozeniPredmeti { get; set; }

        public string FullName { get { return Ime + " " + Prezime; } set { } }


    }
}

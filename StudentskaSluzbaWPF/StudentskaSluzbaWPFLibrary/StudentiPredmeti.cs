using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzbaWPFLibrary
{
    public class StudentiPredmeti
    {

        public int Id { get; set; }
        public int StudentId { get; set; }
        public string NazivPredmeta { get; set; }
        public int Ocjena { get; set; }
        public string Datum { get; set; }
    }
}

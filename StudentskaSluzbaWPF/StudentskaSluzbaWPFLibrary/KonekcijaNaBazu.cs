using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzbaWPFLibrary
{
   public class KonekcijaNaBazu
    {
        public string GetConnectionString(string cnn="WPFConnection")
        {
            return ConfigurationManager.ConnectionStrings[cnn].ConnectionString;
        }

        public void DodajStudenta(Student student)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GetConnectionString("WPFConnection")))
            {
               connection.Execute("insert into Student (Ime, Prezime, UserName, PassWord) values (@Ime, @Prezime, @UserName, @PassWord) ", student);
            }
        }

        public List<Student> UcitajSveStudente()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GetConnectionString("WPFConnection")))
            {
                var output = connection.Query<Student>("select * from Student", new DynamicParameters()).ToList();

                return output;
            }
        }

        public void DodajPolozeniPredmet(StudentiPredmeti studentiPredmeti)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GetConnectionString("WPFConnection")))
            {
                connection.Execute("insert into StudentiPredmeti (StudentId, NazivPredmeta, Ocjena, Datum) values (@StudentId, @NazivPredmeta, @Ocjena, @Datum)",studentiPredmeti);
                
            }
        }

        public List<StudentiPredmeti> UcitajPolozenePredmete(Student student)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GetConnectionString("WPFConnection")))
            {
                var output = connection.Query<StudentiPredmeti>("select * from StudentiPredmeti where StudentId="+student.StudentId, new DynamicParameters()).ToList();
                return output;
            }
        }
    }
}

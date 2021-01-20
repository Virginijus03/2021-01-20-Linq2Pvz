using _2021_01_20_Linq2Pvz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_20_Linq2Pvz.Data
{
    public class PersonInincialData
    {
        public List<Person> DataSeed => new List<Person>
        {
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(1996, 01, 20) },
            new Person { FirstName = "Rimas", LastName = "Rimaitis", BirthDate = new DateTime(1995, 02, 21) },
            new Person { FirstName = "Tadas", LastName = "Tadaitis", BirthDate = new DateTime(1994, 03, 22) },
            new Person { FirstName = "Mikas", LastName = "Mikaitis", BirthDate = new DateTime(1993, 04, 23) },
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(1992 ,04, 20) },
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(2000, 01, 02) },
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(1999, 12, 15) },
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(2002, 07, 09) },
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(1989, 11, 17) },
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(1988, 09, 20) },
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(1999, 03, 11) },
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(1995, 06, 25) },
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(1997, 09, 27) },
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(1987, 05, 05) },
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(1999, 12, 20) },


        };
    }
}

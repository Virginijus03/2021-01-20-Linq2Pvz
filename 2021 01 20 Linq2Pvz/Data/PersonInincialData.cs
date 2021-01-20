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
            new Person { FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DataTime(1996.01.20)};

        }
    }
}

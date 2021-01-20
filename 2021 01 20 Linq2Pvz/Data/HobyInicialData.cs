using _2021_01_20_Linq2Pvz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_20_Linq2Pvz.Data
{
    public class HobyInicialData
    {
        public List<Hoby> DataSeed => new List<Hoby>
        {
            new Hoby {"Read book" },
            new Hoby {""}
        }
    }
}

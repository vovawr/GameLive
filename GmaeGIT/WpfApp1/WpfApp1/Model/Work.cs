using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Work
    {
        public string Name { get; set; }
        public double salary { get; set; }
        public double minqualifications { get; set; }

        public override string ToString()
        {
            return $"{Name } - оклад {salary} - мин опыт {minqualifications}";
        }
    }
}
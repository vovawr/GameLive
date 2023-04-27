using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Gamer
    {
      public Gamer() 
      {
            int Experience = 1;
            string Work = "Безработный";
            int Money = 100;
            string qualifications = "Без категории";
      }
        public string Name { get; set; }        
        public string Gender{ get; set; }
        public int Age { get; set; } 
        public string Subject { get; set; } 
        public DateTime DateCreate { get; set; }    
        public double Experience { get; set; }  
        public double Money { get; set; }
        public string Work { get; set; }    
        public string qualifications { get; set; }  
    }
}

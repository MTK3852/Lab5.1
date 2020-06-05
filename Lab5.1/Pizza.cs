using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    public class Pizza
    {
        private string name;
        private string address;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { name = value; }
        }

        public Pizza()
        {
            this.name = "Rolex";
            this.address = "вул.Шевченка, 40";
        }
    }
}

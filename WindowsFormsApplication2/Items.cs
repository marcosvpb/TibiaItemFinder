using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Items
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public Items(string Name, string ID)
        {
            this.Name = Name;
            this.ID = ID;
        }
    }
}

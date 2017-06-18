using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication2
{
    class Items
    {
        public string Name { get; set; }
        public string ID { get; set; }
        const string FilePath = @"\txt\ids.txt";

        public Items(string Name, string ID)
        {
            this.Name = Name;
            this.ID = ID;
        }

        public List<Items> LoadItems()
        {
            List<Items> _Items = new List<Items>();
            foreach (var myString in File.ReadAllLines(FilePath))
            {
                var Splitted = myString.Split(';');
                _Items.Add(new Items(Splitted[0].ToLower(), Splitted[1]));
            }
            return _Items;
        }
    }
}

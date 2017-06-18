using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        List<Items> _Items = new List<Items>();
        List<Items> _ItemsF = new List<Items>();
        Items Item = new Items(null,null);
          
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _Items = Item.LoadItems(); 
        }

        public void SearchItem(string Item)
        {
            listBox1.Items.Clear();
            _ItemsF.Clear();
            _Items.ForEach(x =>
            {
                if (x.Name.Contains(Item))
                {
                    _ItemsF.Add(x);
                    //Console.WriteLine("Found!");

                }
            });

            _ItemsF.ForEach(x => this.listBox1.Items.Add(String.Format("{0} = {1}", x.Name, x.ID)));
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            SearchItem(textBox1.Text);
        }
    }
}

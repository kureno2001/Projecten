using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magicNumberDmul4_11
{   
    public partial class Form1 : Form
    {   private Random R1 = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }


        public void magicNumberRefresh(int One, int Two)
        {
           R1.Next(One, Two);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            magicNumberRefresh(1,2);


        }
    }
}

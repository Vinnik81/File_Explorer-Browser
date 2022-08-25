using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_Сalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (Size.Width == 540) buttonHistory.Visible = true;
            else if (Size.Width != 540) buttonHistory.Visible = false;
        }



        
    }

}

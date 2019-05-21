using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Plan_and_Program {
	public partial class Form1: Form {
        //create multidimensional array for order.
        //data is menu item and quantity so 2 values. 9 different menu items so array is 9, 2
        string[,] order = new string[9, 2];
		public Form1() {
			InitializeComponent();
         
			}
        private void PizzaButton_Click(object sender, EventArgs e)
        {
            //attempt as assiging value
            //order[0, 0] = pizzaChoice.Text;

            //array very hard to iterate over
            for(int i =0; i < 9; i++)
            {
                //hard to check value
                if (order[i, 0] == pizzaChoice.Text)
                {
                    //have to convert value to string cbecause array can only have one value
                    order[i, 1] = pizzaCombo.Value.ToString;
                }
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {

        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
        }
    }
	}

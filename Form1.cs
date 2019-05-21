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
        //create dictionary for order. string is name of item, decimal is quantity
        Dictionary<string, decimal> order = new Dictionary<string, decimal>();
        //array to store customer details. only 4 values so array used instead of dict
        string[] details = new string[4];
		public Form1() {
			InitializeComponent();
            
			}
        private void PizzaButton_Click(object sender, EventArgs e)
        {
            decimal tmp = 0;
            if(order.TryGetValue(pizzaChoice.Text, out tmp)) {
                order[pizzaChoice.Text] = pizzaCombo.Value;
            }
            else
            {
                order.Add(pizzaChoice.Text, pizzaCombo.Value);
            }
            pizzaBox.Clear();
            foreach (KeyValuePair<string, decimal> entry in order)
            {
                if(entry.Value != 0) {
                    pizzaBox.Text += (entry.Key + ": x" + entry.Value.ToString() + "\r\n");
                }
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {

        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            details[0] = nameBox.Text;
            details[1] = phoneBox.Text;
            details[2] = addressBox.Text;
            details[3] = deliveryBox.Checked.ToString();
            detailsBox.Lines = details;
        }
    }
	}

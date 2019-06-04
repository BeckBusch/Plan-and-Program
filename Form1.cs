﻿using System;
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
        //path variable to point to save file
        string path = @"C:\Users\beckb\source\repos\Plan and Program\";
        //integer for saving total cost of order
        decimal price = 0;
        //dictionary to hold all costs
        Dictionary<string, decimal> prices = new Dictionary<string, decimal>() {
            {"Cheese", 2.5m},
            {"Double Cheese", 2.5m},
            {"Hawaiian", 2.5m},
            {"Meatlovers", 2.5m},
            {"Pepperoni", 2.5m},
            {"Chicken", 2.5m},
            {"Garlic Bread", 2.5m},
            {"Fries", 2.5m},
            {"Large Drink", 2.5m}
        };
        private void PizzaUpdate()
        {
            pizzaBox.Clear();
            price = 0;
            File.WriteAllText(path + "PizzaOrder.txt", "Last Order:\r\n");
            foreach (KeyValuePair<string, decimal> entry in order)
            {
                if (entry.Value != 0)
                {
                    string tempStr = entry.Key + ": x" + entry.Value.ToString() + " $" + (prices[entry.Key] * entry.Value).ToString() + "\r\n";
                    pizzaBox.Text += tempStr;
                    File.AppendAllText(path + "PizzaOrder.txt", tempStr);
                    price += prices[entry.Key] * entry.Value;
                }
            }
            if (details[3] == "True")
            {
                pizzaBox.Text += "--------\r\nDelivery Cost: $4.50\r\n";
                price += 4.50m;
            }
            pizzaBox.Text += "Total Cost: $" + price.ToString();

        }

        public Form1() {
			InitializeComponent();
          
            //Fills out text boxes with data from files
            detailsBox.Text = File.ReadAllText(path + "Details.txt");
            pizzaBox.Text = File.ReadAllText(path + "PizzaOrder.txt");
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
            File.WriteAllText(path + "PizzaOrder.txt", "Last Order:\r\n");
            foreach (KeyValuePair<string, decimal> entry in order)
            {
                if(entry.Value != 0) {
                    pizzaBox.Text += (entry.Key + ": x" + entry.Value.ToString() + "\r\n");
                    File.AppendAllText(path + "PizzaOrder.txt", (entry.Key + ": x" + entry.Value.ToString() + "\r\n"));
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
            File.WriteAllLines(path + "Details.txt", details);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            decimal tmp = 0;
            if (order.TryGetValue(pizzaChoice.Text, out tmp))
            {
                order[pizzaChoice.Text] = 0;
            }
            PizzaUpdate();
        }
       
    }
	}
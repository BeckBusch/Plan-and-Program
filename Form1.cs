// 03DTP Plan&Program Assesment
// Beck Busch

//no space after slashes is commented-out code
// Space after slashes is comment on the program

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Windows Forms is used to create the GUI
using System.Windows.Forms;
// IO is used to read and edit files to save data
using System.IO;
// Regular Expressions is used to validate user input
using System.Text.RegularExpressions;

namespace Plan_and_Program
{
	public partial class Form1 : Form
	{
		// Create dictionary for order. string is name of item, decimal is quantity
		Dictionary<string, decimal> order = new Dictionary<string, decimal>();

		// Array to store customer details. only 4 values so array used instead of dict
		public static string[] details = new string[4];

		// Path variable to point to save file
		public static string path = @"C:\Users\beckb\source\repos\Plan and Program\";

		// Integer for saving total cost of order
		public static decimal price = 0;

		// Dictionary to hold all costs
		public static Dictionary<string, decimal> prices = new Dictionary<string, decimal>() {
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

		// Method to check the user input
		private string InputCheck(object Input, string Case)
		{
			// I am very happy with the flow in this method.
			// First, the form control passed as an argument is loaded as a control.
			Control obj = Input as Control;

			// Next, the background color of that control is set to green.
			// By automatically setting the background to the sucess state, I remove the need to do it in each case.
			obj.BackColor = Color.LimeGreen;

			// A Switch/Case statment is used as a neat alternative to several if statments to run the right code.
			switch (Case)
			{
				case "name":
					// input field is checked against a regex expression that checks the content of that field. 
					string regex = @"^( |\D)+$";
					var match = Regex.Match(obj.Text, regex, RegexOptions.IgnoreCase);

					// If that regex match succeded, then return a string.
					if (match.Success)
					{
						return "Name: " + obj.Text;
					}
					// The clever part is that the return statment will immeaditly close the entire method, so any remaning code will go unexecuted.
					// This allows me to vastly simplify the code needed to handle  an unsuxcessful match.
					// A break statment breaks the Switch/Case statment and continues running the rest of the method.
					break;

				case "phone":
					regex = @"^\d{7,}$";
					match = Regex.Match(obj.Text, regex, RegexOptions.IgnoreCase);
					if (match.Success)
					{
						return "Phone Number: " + obj.Text;
					}
					break;

				case "address":
					// Address can be anything so there is no use validating it
					//regex = @"^\d{7,}$";
					//match = Regex.Match(obj.Text, regex, RegexOptions.IgnoreCase);
					if (true)
					{
						return "Address: " + obj.Text;
					}
					//break;
			}
			// Due to the return statments, this code is only run if the regex match was unsucessful.
			// It sets the background color of the field to red to indicate an error, and returns an empty string.
			obj.BackColor = Color.Red;
			return "";
		}

		// Method to update the list of pizzas displayed to the user
		private void PizzaUpdate()
		{
			// First, everything is set to 0.
			// This includes the content of the display, the total price, and the content of the text file.
			pizzaBox.Clear();
			price = 0;
			File.WriteAllText(path + "PizzaOrder.txt", "Last Order:\r\n");

			// A foreach statment iterates over the dictionary, returning the current Key-Value pair as 'entry'
			foreach (KeyValuePair<string, decimal> entry in order)
			{
				// The Keys in the dictionary are the menu items, and the Values are the quantity being ordered.
				// If the quantity for an item is 0, we ignore it.
				// Because we cleared everything at the start it will be removed from the summary and file.
				if (entry.Value != 0)
				{
					// Make code neater by building the string once and using that variable mulitple times.
					// Example of string    Hawaiian: x3 $7.50
					string tempStr = entry.Key + ": x" + entry.Value.ToString() + " $" + (prices[entry.Key] * entry.Value).ToString() + "\r\n";

					// Append this string to the summary and the file
					pizzaBox.Text += tempStr;
					File.AppendAllText(path + "PizzaOrder.txt", tempStr);

					// Multiply the price of the pizza by the quantity, and add this value to the total price.
					price += prices[entry.Key] * entry.Value;
				}
			}

			// If the user has asked for delivery, add $4.50 to the price total and add a line to the summary mentioning the delivery.
			if (details[3] == "Delivery: True")
			{
				pizzaBox.Text += "Delivery Cost: $4.50\r\n";
				price += 4.50m;
			}
		}

		// Main method to initialise and start the form
		public Form1()
		{
			InitializeComponent();

			//Fills out text boxes with data from files
			detailsBox.Text = File.ReadAllText(path + "Details.txt");
			pizzaBox.Text = File.ReadAllText(path + "PizzaOrder.txt");
		}

		// Event Handler for the button that adds the selected menu item to the order
		private void PizzaButton_Click(object sender, EventArgs e)
		{
			// Checks if the contents of the Pizza Choice control have allready been saved to the dictionary 'order'
			if (order.TryGetValue(pizzaChoice.Text, out decimal tmp))
			{
				// If they have, then update the value.
				order[pizzaChoice.Text] = pizzaCombo.Value;
			}
			else
			{
				// If they haven't, add a new key to 'order'
				order.Add(pizzaChoice.Text, pizzaCombo.Value);
			}
			// Run the update method
			PizzaUpdate();
		}

		private void OrderButton_Click(object sender, EventArgs e)
		{
		
		}

		private void DetailsButton_Click(object sender, EventArgs e)
		{
			details[0] = InputCheck(nameBox, "name");
			details[1] = InputCheck(phoneBox, "phone");

			details[2] = InputCheck(addressBox, "address");
			details[3] = "Delivery: " + deliveryBox.Checked.ToString();

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
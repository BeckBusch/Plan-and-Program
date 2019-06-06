using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_and_Program
{
    public partial class Summary : Form
    {
		string test = Form1.path;
        public Summary()
        {
            InitializeComponent();

			// Add a line summarising the total cost to the summary box.
			//Form1.pizzaBox.Text += "Total Cost: $" + price.ToString();
		}
    }
}

namespace Plan_and_Program {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.deliveryBox = new System.Windows.Forms.CheckBox();
            this.detailsBox = new System.Windows.Forms.TextBox();
            this.pizzaChoice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pizzaCombo = new System.Windows.Forms.NumericUpDown();
            this.Order = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.pizzaButton = new System.Windows.Forms.Button();
            this.pizzaBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaCombo)).BeginInit();
            this.Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameBox.Location = new System.Drawing.Point(93, 13);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(93, 39);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 20);
            this.phoneBox.TabIndex = 2;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(93, 65);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(100, 45);
            this.addressBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.detailsButton);
            this.groupBox1.Controls.Add(this.deliveryBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addressBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.phoneBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(93, 116);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(100, 25);
            this.detailsButton.TabIndex = 7;
            this.detailsButton.Text = "Submit Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // deliveryBox
            // 
            this.deliveryBox.AutoSize = true;
            this.deliveryBox.Location = new System.Drawing.Point(9, 93);
            this.deliveryBox.Name = "deliveryBox";
            this.deliveryBox.Size = new System.Drawing.Size(70, 17);
            this.deliveryBox.TabIndex = 6;
            this.deliveryBox.Text = "Delivery?";
            this.deliveryBox.UseVisualStyleBackColor = true;
            // 
            // detailsBox
            // 
            this.detailsBox.BackColor = System.Drawing.Color.White;
            this.detailsBox.Enabled = false;
            this.detailsBox.Location = new System.Drawing.Point(12, 165);
            this.detailsBox.Multiline = true;
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(200, 149);
            this.detailsBox.TabIndex = 5;
            // 
            // pizzaChoice
            // 
            this.pizzaChoice.FormattingEnabled = true;
            this.pizzaChoice.Items.AddRange(new object[] {
            "Cheese",
            "Double Cheese",
            "Hawaiian",
            "Meatlovers",
            "Pepperoni",
            "Chicken",
            "Garlic Bread",
            "Fries",
            "Large Drink"});
            this.pizzaChoice.Location = new System.Drawing.Point(59, 13);
            this.pizzaChoice.Name = "pizzaChoice";
            this.pizzaChoice.Size = new System.Drawing.Size(89, 21);
            this.pizzaChoice.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pizza:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Number:";
            // 
            // pizzaCombo
            // 
            this.pizzaCombo.Location = new System.Drawing.Point(59, 40);
            this.pizzaCombo.Name = "pizzaCombo";
            this.pizzaCombo.Size = new System.Drawing.Size(89, 20);
            this.pizzaCombo.TabIndex = 9;
            // 
            // Order
            // 
            this.Order.Controls.Add(this.button1);
            this.Order.Controls.Add(this.orderButton);
            this.Order.Controls.Add(this.pizzaButton);
            this.Order.Controls.Add(this.label5);
            this.Order.Controls.Add(this.pizzaCombo);
            this.Order.Controls.Add(this.pizzaChoice);
            this.Order.Controls.Add(this.label6);
            this.Order.Location = new System.Drawing.Point(218, 12);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(200, 127);
            this.Order.TabIndex = 10;
            this.Order.TabStop = false;
            this.Order.Text = "Order";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(101, 96);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(89, 25);
            this.orderButton.TabIndex = 10;
            this.orderButton.Text = "Submit Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // pizzaButton
            // 
            this.pizzaButton.Location = new System.Drawing.Point(6, 66);
            this.pizzaButton.Name = "pizzaButton";
            this.pizzaButton.Size = new System.Drawing.Size(89, 25);
            this.pizzaButton.TabIndex = 8;
            this.pizzaButton.Text = "Add Item";
            this.pizzaButton.UseVisualStyleBackColor = true;
            this.pizzaButton.Click += new System.EventHandler(this.PizzaButton_Click);
            // 
            // pizzaBox
            // 
            this.pizzaBox.BackColor = System.Drawing.Color.White;
            this.pizzaBox.Enabled = false;
            this.pizzaBox.Location = new System.Drawing.Point(218, 145);
            this.pizzaBox.Multiline = true;
            this.pizzaBox.Name = "pizzaBox";
            this.pizzaBox.Size = new System.Drawing.Size(200, 169);
            this.pizzaBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 323);
            this.Controls.Add(this.pizzaBox);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaCombo)).EndInit();
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

			}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox deliveryBox;
        private System.Windows.Forms.TextBox detailsBox;
        private System.Windows.Forms.ComboBox pizzaChoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown pizzaCombo;
        private System.Windows.Forms.GroupBox Order;
        private System.Windows.Forms.TextBox pizzaBox;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button pizzaButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button1;
    }
	}


namespace DemoCalculatorLib
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPizza = new System.Windows.Forms.Label();
            this.lblSalad = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.lblLatte = new System.Windows.Forms.Label();
            this.lblSandwich = new System.Windows.Forms.Label();
            this.lblPasta = new System.Windows.Forms.Label();
            this.lblSauce = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnSalad = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnLatte = new System.Windows.Forms.Button();
            this.btnSandwich = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.btnSauce = new System.Windows.Forms.Button();
            this.btnWater = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnTotalTax = new System.Windows.Forms.Button();
            this.receiptItems = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.lblTotalTax = new System.Windows.Forms.TextBox();
            this.lblCompleteTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Location = new System.Drawing.Point(29, 35);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(32, 13);
            this.lblPizza.TabIndex = 0;
            this.lblPizza.Text = "Pizza";
            // 
            // lblSalad
            // 
            this.lblSalad.AutoSize = true;
            this.lblSalad.Location = new System.Drawing.Point(153, 35);
            this.lblSalad.Name = "lblSalad";
            this.lblSalad.Size = new System.Drawing.Size(34, 13);
            this.lblSalad.TabIndex = 1;
            this.lblSalad.Text = "Salad";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(32, 102);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(38, 13);
            this.lblCoffee.TabIndex = 2;
            this.lblCoffee.Text = "Coffee";
            // 
            // lblLatte
            // 
            this.lblLatte.AutoSize = true;
            this.lblLatte.Location = new System.Drawing.Point(156, 102);
            this.lblLatte.Name = "lblLatte";
            this.lblLatte.Size = new System.Drawing.Size(31, 13);
            this.lblLatte.TabIndex = 3;
            this.lblLatte.Text = "Latte";
            // 
            // lblSandwich
            // 
            this.lblSandwich.AutoSize = true;
            this.lblSandwich.Location = new System.Drawing.Point(32, 172);
            this.lblSandwich.Name = "lblSandwich";
            this.lblSandwich.Size = new System.Drawing.Size(54, 13);
            this.lblSandwich.TabIndex = 4;
            this.lblSandwich.Text = "Sandwich";
            // 
            // lblPasta
            // 
            this.lblPasta.AutoSize = true;
            this.lblPasta.Location = new System.Drawing.Point(156, 171);
            this.lblPasta.Name = "lblPasta";
            this.lblPasta.Size = new System.Drawing.Size(34, 13);
            this.lblPasta.TabIndex = 5;
            this.lblPasta.Text = "Pasta";
            // 
            // lblSauce
            // 
            this.lblSauce.AutoSize = true;
            this.lblSauce.Location = new System.Drawing.Point(32, 237);
            this.lblSauce.Name = "lblSauce";
            this.lblSauce.Size = new System.Drawing.Size(38, 13);
            this.lblSauce.TabIndex = 6;
            this.lblSauce.Text = "Sauce";
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Location = new System.Drawing.Point(156, 236);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(36, 13);
            this.lblWater.TabIndex = 7;
            this.lblWater.Text = "Water";
            // 
            // btnPizza
            // 
            this.btnPizza.BackColor = System.Drawing.SystemColors.Control;
            this.btnPizza.Location = new System.Drawing.Point(32, 52);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(75, 23);
            this.btnPizza.TabIndex = 8;
            this.btnPizza.Text = "$1.99";
            this.btnPizza.UseVisualStyleBackColor = false;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnSalad
            // 
            this.btnSalad.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalad.Location = new System.Drawing.Point(156, 52);
            this.btnSalad.Name = "btnSalad";
            this.btnSalad.Size = new System.Drawing.Size(75, 23);
            this.btnSalad.TabIndex = 9;
            this.btnSalad.Text = "$2.99";
            this.btnSalad.UseVisualStyleBackColor = false;
            this.btnSalad.Click += new System.EventHandler(this.btnSalad_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackColor = System.Drawing.SystemColors.Control;
            this.btnCoffee.Location = new System.Drawing.Point(35, 119);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(75, 23);
            this.btnCoffee.TabIndex = 10;
            this.btnCoffee.Text = "$1.99";
            this.btnCoffee.UseVisualStyleBackColor = false;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnLatte
            // 
            this.btnLatte.BackColor = System.Drawing.SystemColors.Control;
            this.btnLatte.Location = new System.Drawing.Point(156, 118);
            this.btnLatte.Name = "btnLatte";
            this.btnLatte.Size = new System.Drawing.Size(75, 23);
            this.btnLatte.TabIndex = 11;
            this.btnLatte.Text = "$5.99";
            this.btnLatte.UseVisualStyleBackColor = false;
            this.btnLatte.Click += new System.EventHandler(this.btnLatte_Click);
            // 
            // btnSandwich
            // 
            this.btnSandwich.BackColor = System.Drawing.SystemColors.Control;
            this.btnSandwich.Location = new System.Drawing.Point(32, 189);
            this.btnSandwich.Name = "btnSandwich";
            this.btnSandwich.Size = new System.Drawing.Size(75, 23);
            this.btnSandwich.TabIndex = 12;
            this.btnSandwich.Text = "$10.00";
            this.btnSandwich.UseVisualStyleBackColor = false;
            this.btnSandwich.Click += new System.EventHandler(this.btnSandwich_Click);
            // 
            // btnPasta
            // 
            this.btnPasta.BackColor = System.Drawing.SystemColors.Control;
            this.btnPasta.Location = new System.Drawing.Point(156, 189);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(75, 23);
            this.btnPasta.TabIndex = 13;
            this.btnPasta.Text = "$5.49";
            this.btnPasta.UseVisualStyleBackColor = false;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // btnSauce
            // 
            this.btnSauce.BackColor = System.Drawing.SystemColors.Control;
            this.btnSauce.Location = new System.Drawing.Point(32, 254);
            this.btnSauce.Name = "btnSauce";
            this.btnSauce.Size = new System.Drawing.Size(75, 23);
            this.btnSauce.TabIndex = 14;
            this.btnSauce.Text = "$0.50";
            this.btnSauce.UseVisualStyleBackColor = false;
            this.btnSauce.Click += new System.EventHandler(this.btnSauce_Click);
            // 
            // btnWater
            // 
            this.btnWater.BackColor = System.Drawing.SystemColors.Control;
            this.btnWater.Location = new System.Drawing.Point(156, 254);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(75, 23);
            this.btnWater.TabIndex = 15;
            this.btnWater.Text = "$1.10";
            this.btnWater.UseVisualStyleBackColor = false;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.SystemColors.Control;
            this.btnTotal.Location = new System.Drawing.Point(298, 347);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(197, 23);
            this.btnTotal.TabIndex = 16;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnTotalTax
            // 
            this.btnTotalTax.BackColor = System.Drawing.SystemColors.Control;
            this.btnTotalTax.Location = new System.Drawing.Point(298, 377);
            this.btnTotalTax.Name = "btnTotalTax";
            this.btnTotalTax.Size = new System.Drawing.Size(197, 23);
            this.btnTotalTax.TabIndex = 17;
            this.btnTotalTax.Text = "Total Tax";
            this.btnTotalTax.UseVisualStyleBackColor = false;
            this.btnTotalTax.Click += new System.EventHandler(this.btnTotalTax_Click);
            // 
            // receiptItems
            // 
            this.receiptItems.Location = new System.Drawing.Point(298, 35);
            this.receiptItems.Multiline = true;
            this.receiptItems.Name = "receiptItems";
            this.receiptItems.Size = new System.Drawing.Size(442, 294);
            this.receiptItems.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTotal.Location = new System.Drawing.Point(511, 349);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 13);
            this.lblTotal.TabIndex = 19;
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTotalTax.Location = new System.Drawing.Point(511, 379);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(100, 13);
            this.lblTotalTax.TabIndex = 20;
            // 
            // lblCompleteTotal
            // 
            this.lblCompleteTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCompleteTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCompleteTotal.Location = new System.Drawing.Point(511, 407);
            this.lblCompleteTotal.Name = "lblCompleteTotal";
            this.lblCompleteTotal.Size = new System.Drawing.Size(100, 13);
            this.lblCompleteTotal.TabIndex = 21;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblCompleteTotal);
            this.Controls.Add(this.lblTotalTax);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.receiptItems);
            this.Controls.Add(this.btnTotalTax);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.btnSauce);
            this.Controls.Add(this.btnPasta);
            this.Controls.Add(this.btnSandwich);
            this.Controls.Add(this.btnLatte);
            this.Controls.Add(this.btnCoffee);
            this.Controls.Add(this.btnSalad);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.lblSauce);
            this.Controls.Add(this.lblPasta);
            this.Controls.Add(this.lblSandwich);
            this.Controls.Add(this.lblLatte);
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.lblSalad);
            this.Controls.Add(this.lblPizza);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.Label lblSalad;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label lblLatte;
        private System.Windows.Forms.Label lblSandwich;
        private System.Windows.Forms.Label lblPasta;
        private System.Windows.Forms.Label lblSauce;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnSalad;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnLatte;
        private System.Windows.Forms.Button btnSandwich;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.Button btnSauce;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnTotalTax;
        private System.Windows.Forms.TextBox receiptItems;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.TextBox lblTotalTax;
        private System.Windows.Forms.TextBox lblCompleteTotal;
    }
}

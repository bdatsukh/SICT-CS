namespace WindowsFormsApp2
{
    partial class JuiceBarForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.twentyOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.sixteenOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.twelveOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ladiesCheckBox = new System.Windows.Forms.CheckBox();
            this.energyBoosterCheckBox = new System.Windows.Forms.CheckBox();
            this.vitaminPackCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.veggleRadioButton = new System.Windows.Forms.RadioButton();
            this.fruitJuiceRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.orderCompleteButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noSizeRadioButton);
            this.groupBox1.Controls.Add(this.twentyOunceRadioButton);
            this.groupBox1.Controls.Add(this.sixteenOunceRadioButton);
            this.groupBox1.Controls.Add(this.twelveOunceRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(39, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // noSizeRadioButton
            // 
            this.noSizeRadioButton.AutoSize = true;
            this.noSizeRadioButton.Location = new System.Drawing.Point(146, 89);
            this.noSizeRadioButton.Name = "noSizeRadioButton";
            this.noSizeRadioButton.Size = new System.Drawing.Size(79, 21);
            this.noSizeRadioButton.TabIndex = 19;
            this.noSizeRadioButton.TabStop = true;
            this.noSizeRadioButton.Text = "invisible";
            this.noSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // twentyOunceRadioButton
            // 
            this.twentyOunceRadioButton.AutoSize = true;
            this.twentyOunceRadioButton.Location = new System.Drawing.Point(8, 75);
            this.twentyOunceRadioButton.Name = "twentyOunceRadioButton";
            this.twentyOunceRadioButton.Size = new System.Drawing.Size(123, 21);
            this.twentyOunceRadioButton.TabIndex = 2;
            this.twentyOunceRadioButton.TabStop = true;
            this.twentyOunceRadioButton.Text = "20 Ounce 4.00";
            this.twentyOunceRadioButton.UseVisualStyleBackColor = true;
            // 
            // sixteenOunceRadioButton
            // 
            this.sixteenOunceRadioButton.AutoSize = true;
            this.sixteenOunceRadioButton.Location = new System.Drawing.Point(7, 48);
            this.sixteenOunceRadioButton.Name = "sixteenOunceRadioButton";
            this.sixteenOunceRadioButton.Size = new System.Drawing.Size(123, 21);
            this.sixteenOunceRadioButton.TabIndex = 1;
            this.sixteenOunceRadioButton.TabStop = true;
            this.sixteenOunceRadioButton.Text = "16 Ounce 3.50";
            this.sixteenOunceRadioButton.UseVisualStyleBackColor = true;
            // 
            // twelveOunceRadioButton
            // 
            this.twelveOunceRadioButton.AutoSize = true;
            this.twelveOunceRadioButton.Location = new System.Drawing.Point(7, 21);
            this.twelveOunceRadioButton.Name = "twelveOunceRadioButton";
            this.twelveOunceRadioButton.Size = new System.Drawing.Size(123, 21);
            this.twelveOunceRadioButton.TabIndex = 0;
            this.twelveOunceRadioButton.TabStop = true;
            this.twelveOunceRadioButton.Text = "12 Ounce 3.00";
            this.twelveOunceRadioButton.UseVisualStyleBackColor = true;
            this.twelveOunceRadioButton.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ladiesCheckBox);
            this.groupBox2.Controls.Add(this.energyBoosterCheckBox);
            this.groupBox2.Controls.Add(this.vitaminPackCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(39, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras - $0.50 each";
            // 
            // ladiesCheckBox
            // 
            this.ladiesCheckBox.AutoSize = true;
            this.ladiesCheckBox.Location = new System.Drawing.Point(6, 75);
            this.ladiesCheckBox.Name = "ladiesCheckBox";
            this.ladiesCheckBox.Size = new System.Drawing.Size(121, 21);
            this.ladiesCheckBox.TabIndex = 2;
            this.ladiesCheckBox.Text = "For the Ladies";
            this.ladiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // energyBoosterCheckBox
            // 
            this.energyBoosterCheckBox.AutoSize = true;
            this.energyBoosterCheckBox.Location = new System.Drawing.Point(6, 48);
            this.energyBoosterCheckBox.Name = "energyBoosterCheckBox";
            this.energyBoosterCheckBox.Size = new System.Drawing.Size(128, 21);
            this.energyBoosterCheckBox.TabIndex = 1;
            this.energyBoosterCheckBox.Text = "Energy Booster";
            this.energyBoosterCheckBox.UseVisualStyleBackColor = true;
            // 
            // vitaminPackCheckBox
            // 
            this.vitaminPackCheckBox.AutoSize = true;
            this.vitaminPackCheckBox.Location = new System.Drawing.Point(7, 21);
            this.vitaminPackCheckBox.Name = "vitaminPackCheckBox";
            this.vitaminPackCheckBox.Size = new System.Drawing.Size(111, 21);
            this.vitaminPackCheckBox.TabIndex = 0;
            this.vitaminPackCheckBox.Text = "Vitamin Pack";
            this.vitaminPackCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.veggleRadioButton);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.fruitJuiceRadioButton);
            this.groupBox3.Controls.Add(this.radioButton8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(340, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 248);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select the drink type";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // veggleRadioButton
            // 
            this.veggleRadioButton.AutoSize = true;
            this.veggleRadioButton.Location = new System.Drawing.Point(43, 74);
            this.veggleRadioButton.Name = "veggleRadioButton";
            this.veggleRadioButton.Size = new System.Drawing.Size(73, 21);
            this.veggleRadioButton.TabIndex = 14;
            this.veggleRadioButton.TabStop = true;
            this.veggleRadioButton.Text = "Veggle";
            this.veggleRadioButton.UseVisualStyleBackColor = true;
            // 
            // fruitJuiceRadioButton
            // 
            this.fruitJuiceRadioButton.AutoSize = true;
            this.fruitJuiceRadioButton.Location = new System.Drawing.Point(42, 46);
            this.fruitJuiceRadioButton.Name = "fruitJuiceRadioButton";
            this.fruitJuiceRadioButton.Size = new System.Drawing.Size(57, 21);
            this.fruitJuiceRadioButton.TabIndex = 13;
            this.fruitJuiceRadioButton.TabStop = true;
            this.fruitJuiceRadioButton.Text = "Fruit";
            this.fruitJuiceRadioButton.UseVisualStyleBackColor = true;
            this.fruitJuiceRadioButton.CheckedChanged += new System.EventHandler(this.Fruit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Juices";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(43, 172);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(104, 21);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "WheatBerry";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(43, 149);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(150, 21);
            this.radioButton7.TabIndex = 16;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Strawberry Banana";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(43, 122);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(114, 21);
            this.radioButton8.TabIndex = 15;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Pomegranate";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Smoothles";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(139, 310);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(48, 22);
            this.quantityTextBox.TabIndex = 3;
            this.quantityTextBox.Click += new System.EventHandler(this.quantityTextbox_Click);
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(139, 339);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.itemPriceTextBox.TabIndex = 4;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(488, 300);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(133, 27);
            this.addToOrderButton.TabIndex = 5;
            this.addToOrderButton.Text = "Add to Order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // orderCompleteButton
            // 
            this.orderCompleteButton.Location = new System.Drawing.Point(488, 333);
            this.orderCompleteButton.Name = "orderCompleteButton";
            this.orderCompleteButton.Size = new System.Drawing.Size(133, 27);
            this.orderCompleteButton.TabIndex = 6;
            this.orderCompleteButton.Text = "Order Complete";
            this.orderCompleteButton.UseVisualStyleBackColor = true;
            this.orderCompleteButton.Click += new System.EventHandler(this.orderCompleteButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 27);
            this.button3.TabIndex = 8;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(488, 366);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(133, 27);
            this.summaryButton.TabIndex = 7;
            this.summaryButton.Text = "Summary Report";
            this.summaryButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item Price";
            // 
            // JuiceBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.orderCompleteButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "JuiceBarForm";
            this.Text = "JuiceBarForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton twentyOunceRadioButton;
        private System.Windows.Forms.RadioButton sixteenOunceRadioButton;
        private System.Windows.Forms.RadioButton twelveOunceRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ladiesCheckBox;
        private System.Windows.Forms.CheckBox energyBoosterCheckBox;
        private System.Windows.Forms.CheckBox vitaminPackCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton veggleRadioButton;
        private System.Windows.Forms.RadioButton fruitJuiceRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button orderCompleteButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton noSizeRadioButton;
    }
}


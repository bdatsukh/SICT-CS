namespace WindowsFormsApp2
{
    partial class FoodForm
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
            this.button = new System.Windows.Forms.Button();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxBituu = new System.Windows.Forms.ComboBox();
            this.comboBoxHar = new System.Windows.Forms.ComboBox();
            this.comboBoxGul = new System.Windows.Forms.ComboBox();
            this.comboBoxTeptel = new System.Windows.Forms.ComboBox();
            this.comboBoxTsuivan = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelHar = new System.Windows.Forms.Label();
            this.textBoxBituu = new System.Windows.Forms.TextBox();
            this.labelBituu = new System.Windows.Forms.Label();
            this.textBoxHar = new System.Windows.Forms.TextBox();
            this.checkBoxBituu = new System.Windows.Forms.CheckBox();
            this.checkBoxHar = new System.Windows.Forms.CheckBox();
            this.labelTsuivan = new System.Windows.Forms.Label();
            this.labelGul = new System.Windows.Forms.Label();
            this.textBoxGul = new System.Windows.Forms.TextBox();
            this.textBoxTeptel = new System.Windows.Forms.TextBox();
            this.labelTeptel = new System.Windows.Forms.Label();
            this.textBoxTsuivan = new System.Windows.Forms.TextBox();
            this.checkBoxGul = new System.Windows.Forms.CheckBox();
            this.checkBoxTeptel = new System.Windows.Forms.CheckBox();
            this.checkBoxTsuivan = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelNiislel = new System.Windows.Forms.Label();
            this.labelBaitsaa = new System.Windows.Forms.Label();
            this.textBoxBaitsaa = new System.Windows.Forms.TextBox();
            this.textBoxLuuvan = new System.Windows.Forms.TextBox();
            this.labelLuuvan = new System.Windows.Forms.Label();
            this.textBoxNiislel = new System.Windows.Forms.TextBox();
            this.checkBoxBaitsaa = new System.Windows.Forms.CheckBox();
            this.checkBoxLuuvan = new System.Windows.Forms.CheckBox();
            this.checkBoxNiislel = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHarHagas = new System.Windows.Forms.Label();
            this.labelBituuHagas = new System.Windows.Forms.Label();
            this.labelTsuivanHagas = new System.Windows.Forms.Label();
            this.labelGulHagas = new System.Windows.Forms.Label();
            this.labelTeptelHagas = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(442, 272);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(92, 27);
            this.button.TabIndex = 17;
            this.button.Text = "Мэдээлэл";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(442, 305);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(92, 27);
            this.addToOrderButton.TabIndex = 16;
            this.addToOrderButton.Text = "Захиалах";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelHarHagas);
            this.groupBox3.Controls.Add(this.labelBituuHagas);
            this.groupBox3.Controls.Add(this.labelTsuivanHagas);
            this.groupBox3.Controls.Add(this.labelGulHagas);
            this.groupBox3.Controls.Add(this.labelTeptelHagas);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBoxBituu);
            this.groupBox3.Controls.Add(this.comboBoxHar);
            this.groupBox3.Controls.Add(this.comboBoxGul);
            this.groupBox3.Controls.Add(this.comboBoxTeptel);
            this.groupBox3.Controls.Add(this.comboBoxTsuivan);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.labelHar);
            this.groupBox3.Controls.Add(this.textBoxBituu);
            this.groupBox3.Controls.Add(this.labelBituu);
            this.groupBox3.Controls.Add(this.textBoxHar);
            this.groupBox3.Controls.Add(this.checkBoxBituu);
            this.groupBox3.Controls.Add(this.checkBoxHar);
            this.groupBox3.Controls.Add(this.labelTsuivan);
            this.groupBox3.Controls.Add(this.labelGul);
            this.groupBox3.Controls.Add(this.textBoxGul);
            this.groupBox3.Controls.Add(this.textBoxTeptel);
            this.groupBox3.Controls.Add(this.labelTeptel);
            this.groupBox3.Controls.Add(this.textBoxTsuivan);
            this.groupBox3.Controls.Add(this.checkBoxGul);
            this.groupBox3.Controls.Add(this.checkBoxTeptel);
            this.groupBox3.Controls.Add(this.checkBoxTsuivan);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 196);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Хоол";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // comboBoxBituu
            // 
            this.comboBoxBituu.FormattingEnabled = true;
            this.comboBoxBituu.Items.AddRange(new object[] {
            "Бүтэн",
            "Хагас"});
            this.comboBoxBituu.Location = new System.Drawing.Point(383, 146);
            this.comboBoxBituu.MaxDropDownItems = 2;
            this.comboBoxBituu.Name = "comboBoxBituu";
            this.comboBoxBituu.Size = new System.Drawing.Size(89, 24);
            this.comboBoxBituu.TabIndex = 48;
            // 
            // comboBoxHar
            // 
            this.comboBoxHar.FormattingEnabled = true;
            this.comboBoxHar.Items.AddRange(new object[] {
            "Бүтэн",
            "Хагас"});
            this.comboBoxHar.Location = new System.Drawing.Point(383, 120);
            this.comboBoxHar.MaxDropDownItems = 2;
            this.comboBoxHar.Name = "comboBoxHar";
            this.comboBoxHar.Size = new System.Drawing.Size(89, 24);
            this.comboBoxHar.TabIndex = 47;
            this.comboBoxHar.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBoxGul
            // 
            this.comboBoxGul.FormattingEnabled = true;
            this.comboBoxGul.Items.AddRange(new object[] {
            "Бүтэн",
            "Хагас"});
            this.comboBoxGul.Location = new System.Drawing.Point(383, 93);
            this.comboBoxGul.MaxDropDownItems = 2;
            this.comboBoxGul.Name = "comboBoxGul";
            this.comboBoxGul.Size = new System.Drawing.Size(89, 24);
            this.comboBoxGul.TabIndex = 46;
            // 
            // comboBoxTeptel
            // 
            this.comboBoxTeptel.FormattingEnabled = true;
            this.comboBoxTeptel.Items.AddRange(new object[] {
            "Бүтэн",
            "Хагас"});
            this.comboBoxTeptel.Location = new System.Drawing.Point(383, 66);
            this.comboBoxTeptel.MaxDropDownItems = 2;
            this.comboBoxTeptel.Name = "comboBoxTeptel";
            this.comboBoxTeptel.Size = new System.Drawing.Size(89, 24);
            this.comboBoxTeptel.TabIndex = 45;
            // 
            // comboBoxTsuivan
            // 
            this.comboBoxTsuivan.FormattingEnabled = true;
            this.comboBoxTsuivan.Items.AddRange(new object[] {
            "Бүтэн",
            "Хагас"});
            this.comboBoxTsuivan.Location = new System.Drawing.Point(383, 40);
            this.comboBoxTsuivan.MaxDropDownItems = 2;
            this.comboBoxTsuivan.Name = "comboBoxTsuivan";
            this.comboBoxTsuivan.Size = new System.Drawing.Size(89, 24);
            this.comboBoxTsuivan.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "Тоо ширхэг";
            // 
            // labelHar
            // 
            this.labelHar.AutoSize = true;
            this.labelHar.Location = new System.Drawing.Point(159, 123);
            this.labelHar.Name = "labelHar";
            this.labelHar.Size = new System.Drawing.Size(40, 17);
            this.labelHar.TabIndex = 42;
            this.labelHar.Text = "6000";
            // 
            // textBoxBituu
            // 
            this.textBoxBituu.Location = new System.Drawing.Point(311, 146);
            this.textBoxBituu.Name = "textBoxBituu";
            this.textBoxBituu.Size = new System.Drawing.Size(56, 22);
            this.textBoxBituu.TabIndex = 39;
            // 
            // labelBituu
            // 
            this.labelBituu.AutoSize = true;
            this.labelBituu.Location = new System.Drawing.Point(159, 149);
            this.labelBituu.Name = "labelBituu";
            this.labelBituu.Size = new System.Drawing.Size(40, 17);
            this.labelBituu.TabIndex = 41;
            this.labelBituu.Text = "5000";
            // 
            // textBoxHar
            // 
            this.textBoxHar.Location = new System.Drawing.Point(311, 120);
            this.textBoxHar.Name = "textBoxHar";
            this.textBoxHar.Size = new System.Drawing.Size(56, 22);
            this.textBoxHar.TabIndex = 38;
            // 
            // checkBoxBituu
            // 
            this.checkBoxBituu.AutoSize = true;
            this.checkBoxBituu.Location = new System.Drawing.Point(6, 148);
            this.checkBoxBituu.Name = "checkBoxBituu";
            this.checkBoxBituu.Size = new System.Drawing.Size(99, 21);
            this.checkBoxBituu.TabIndex = 36;
            this.checkBoxBituu.Text = "Битүү шөл";
            this.checkBoxBituu.UseVisualStyleBackColor = true;
            // 
            // checkBoxHar
            // 
            this.checkBoxHar.AutoSize = true;
            this.checkBoxHar.Location = new System.Drawing.Point(6, 122);
            this.checkBoxHar.Name = "checkBoxHar";
            this.checkBoxHar.Size = new System.Drawing.Size(86, 21);
            this.checkBoxHar.TabIndex = 35;
            this.checkBoxHar.Text = "Хар шөл";
            this.checkBoxHar.UseVisualStyleBackColor = true;
            // 
            // labelTsuivan
            // 
            this.labelTsuivan.AutoSize = true;
            this.labelTsuivan.Location = new System.Drawing.Point(159, 43);
            this.labelTsuivan.Name = "labelTsuivan";
            this.labelTsuivan.Size = new System.Drawing.Size(40, 17);
            this.labelTsuivan.TabIndex = 33;
            this.labelTsuivan.Text = "5000";
            // 
            // labelGul
            // 
            this.labelGul.AutoSize = true;
            this.labelGul.Location = new System.Drawing.Point(159, 96);
            this.labelGul.Name = "labelGul";
            this.labelGul.Size = new System.Drawing.Size(40, 17);
            this.labelGul.TabIndex = 34;
            this.labelGul.Text = "6500";
            // 
            // textBoxGul
            // 
            this.textBoxGul.Location = new System.Drawing.Point(311, 93);
            this.textBoxGul.Name = "textBoxGul";
            this.textBoxGul.Size = new System.Drawing.Size(56, 22);
            this.textBoxGul.TabIndex = 31;
            // 
            // textBoxTeptel
            // 
            this.textBoxTeptel.Location = new System.Drawing.Point(311, 66);
            this.textBoxTeptel.Name = "textBoxTeptel";
            this.textBoxTeptel.Size = new System.Drawing.Size(56, 22);
            this.textBoxTeptel.TabIndex = 30;
            // 
            // labelTeptel
            // 
            this.labelTeptel.AutoSize = true;
            this.labelTeptel.Location = new System.Drawing.Point(159, 69);
            this.labelTeptel.Name = "labelTeptel";
            this.labelTeptel.Size = new System.Drawing.Size(40, 17);
            this.labelTeptel.TabIndex = 32;
            this.labelTeptel.Text = "6000";
            // 
            // textBoxTsuivan
            // 
            this.textBoxTsuivan.Location = new System.Drawing.Point(311, 40);
            this.textBoxTsuivan.Name = "textBoxTsuivan";
            this.textBoxTsuivan.Size = new System.Drawing.Size(56, 22);
            this.textBoxTsuivan.TabIndex = 29;
            // 
            // checkBoxGul
            // 
            this.checkBoxGul.AutoSize = true;
            this.checkBoxGul.Location = new System.Drawing.Point(6, 95);
            this.checkBoxGul.Name = "checkBoxGul";
            this.checkBoxGul.Size = new System.Drawing.Size(87, 21);
            this.checkBoxGul.TabIndex = 28;
            this.checkBoxGul.Text = "Гульяаш";
            this.checkBoxGul.UseVisualStyleBackColor = true;
            // 
            // checkBoxTeptel
            // 
            this.checkBoxTeptel.AutoSize = true;
            this.checkBoxTeptel.Location = new System.Drawing.Point(6, 68);
            this.checkBoxTeptel.Name = "checkBoxTeptel";
            this.checkBoxTeptel.Size = new System.Drawing.Size(88, 21);
            this.checkBoxTeptel.TabIndex = 27;
            this.checkBoxTeptel.Text = "Тефтель";
            this.checkBoxTeptel.UseVisualStyleBackColor = true;
            // 
            // checkBoxTsuivan
            // 
            this.checkBoxTsuivan.AutoSize = true;
            this.checkBoxTsuivan.Location = new System.Drawing.Point(6, 42);
            this.checkBoxTsuivan.Name = "checkBoxTsuivan";
            this.checkBoxTsuivan.Size = new System.Drawing.Size(79, 21);
            this.checkBoxTsuivan.TabIndex = 26;
            this.checkBoxTsuivan.Text = "Цуйван";
            this.checkBoxTsuivan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelNiislel);
            this.groupBox2.Controls.Add(this.labelBaitsaa);
            this.groupBox2.Controls.Add(this.textBoxBaitsaa);
            this.groupBox2.Controls.Add(this.textBoxLuuvan);
            this.groupBox2.Controls.Add(this.labelLuuvan);
            this.groupBox2.Controls.Add(this.textBoxNiislel);
            this.groupBox2.Controls.Add(this.checkBoxBaitsaa);
            this.groupBox2.Controls.Add(this.checkBoxLuuvan);
            this.groupBox2.Controls.Add(this.checkBoxNiislel);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 149);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Зууш";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Тоо ширхэг";
            // 
            // labelNiislel
            // 
            this.labelNiislel.AutoSize = true;
            this.labelNiislel.Location = new System.Drawing.Point(159, 42);
            this.labelNiislel.Name = "labelNiislel";
            this.labelNiislel.Size = new System.Drawing.Size(40, 17);
            this.labelNiislel.TabIndex = 24;
            this.labelNiislel.Text = "2500";
            // 
            // labelBaitsaa
            // 
            this.labelBaitsaa.AutoSize = true;
            this.labelBaitsaa.Location = new System.Drawing.Point(159, 95);
            this.labelBaitsaa.Name = "labelBaitsaa";
            this.labelBaitsaa.Size = new System.Drawing.Size(40, 17);
            this.labelBaitsaa.TabIndex = 25;
            this.labelBaitsaa.Text = "2300";
            // 
            // textBoxBaitsaa
            // 
            this.textBoxBaitsaa.Location = new System.Drawing.Point(219, 92);
            this.textBoxBaitsaa.Name = "textBoxBaitsaa";
            this.textBoxBaitsaa.Size = new System.Drawing.Size(56, 22);
            this.textBoxBaitsaa.TabIndex = 5;
            // 
            // textBoxLuuvan
            // 
            this.textBoxLuuvan.Location = new System.Drawing.Point(219, 65);
            this.textBoxLuuvan.Name = "textBoxLuuvan";
            this.textBoxLuuvan.Size = new System.Drawing.Size(56, 22);
            this.textBoxLuuvan.TabIndex = 4;
            // 
            // labelLuuvan
            // 
            this.labelLuuvan.AutoSize = true;
            this.labelLuuvan.Location = new System.Drawing.Point(159, 68);
            this.labelLuuvan.Name = "labelLuuvan";
            this.labelLuuvan.Size = new System.Drawing.Size(40, 17);
            this.labelLuuvan.TabIndex = 23;
            this.labelLuuvan.Text = "2000";
            // 
            // textBoxNiislel
            // 
            this.textBoxNiislel.Location = new System.Drawing.Point(219, 39);
            this.textBoxNiislel.Name = "textBoxNiislel";
            this.textBoxNiislel.Size = new System.Drawing.Size(56, 22);
            this.textBoxNiislel.TabIndex = 3;
            // 
            // checkBoxBaitsaa
            // 
            this.checkBoxBaitsaa.AutoSize = true;
            this.checkBoxBaitsaa.Location = new System.Drawing.Point(6, 94);
            this.checkBoxBaitsaa.Name = "checkBoxBaitsaa";
            this.checkBoxBaitsaa.Size = new System.Drawing.Size(139, 21);
            this.checkBoxBaitsaa.TabIndex = 2;
            this.checkBoxBaitsaa.Text = "Байцааны салат";
            this.checkBoxBaitsaa.UseVisualStyleBackColor = true;
            // 
            // checkBoxLuuvan
            // 
            this.checkBoxLuuvan.AutoSize = true;
            this.checkBoxLuuvan.Location = new System.Drawing.Point(6, 67);
            this.checkBoxLuuvan.Name = "checkBoxLuuvan";
            this.checkBoxLuuvan.Size = new System.Drawing.Size(148, 21);
            this.checkBoxLuuvan.TabIndex = 1;
            this.checkBoxLuuvan.Text = "Луувангийн салат";
            this.checkBoxLuuvan.UseVisualStyleBackColor = true;
            // 
            // checkBoxNiislel
            // 
            this.checkBoxNiislel.AutoSize = true;
            this.checkBoxNiislel.Location = new System.Drawing.Point(6, 41);
            this.checkBoxNiislel.Name = "checkBoxNiislel";
            this.checkBoxNiislel.Size = new System.Drawing.Size(128, 21);
            this.checkBoxNiislel.TabIndex = 0;
            this.checkBoxNiislel.Text = "Нийслэл салат";
            this.checkBoxNiislel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Бүтэн";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Хагас";
            // 
            // labelHarHagas
            // 
            this.labelHarHagas.AutoSize = true;
            this.labelHarHagas.Location = new System.Drawing.Point(234, 123);
            this.labelHarHagas.Name = "labelHarHagas";
            this.labelHarHagas.Size = new System.Drawing.Size(40, 17);
            this.labelHarHagas.TabIndex = 55;
            this.labelHarHagas.Text = "4500";
            // 
            // labelBituuHagas
            // 
            this.labelBituuHagas.AutoSize = true;
            this.labelBituuHagas.Location = new System.Drawing.Point(234, 149);
            this.labelBituuHagas.Name = "labelBituuHagas";
            this.labelBituuHagas.Size = new System.Drawing.Size(40, 17);
            this.labelBituuHagas.TabIndex = 54;
            this.labelBituuHagas.Text = "3500";
            // 
            // labelTsuivanHagas
            // 
            this.labelTsuivanHagas.AutoSize = true;
            this.labelTsuivanHagas.Location = new System.Drawing.Point(234, 43);
            this.labelTsuivanHagas.Name = "labelTsuivanHagas";
            this.labelTsuivanHagas.Size = new System.Drawing.Size(40, 17);
            this.labelTsuivanHagas.TabIndex = 52;
            this.labelTsuivanHagas.Text = "3500";
            // 
            // labelGulHagas
            // 
            this.labelGulHagas.AutoSize = true;
            this.labelGulHagas.Location = new System.Drawing.Point(234, 96);
            this.labelGulHagas.Name = "labelGulHagas";
            this.labelGulHagas.Size = new System.Drawing.Size(40, 17);
            this.labelGulHagas.TabIndex = 53;
            this.labelGulHagas.Text = "5000";
            // 
            // labelTeptelHagas
            // 
            this.labelTeptelHagas.AutoSize = true;
            this.labelTeptelHagas.Location = new System.Drawing.Point(234, 69);
            this.labelTeptelHagas.Name = "labelTeptelHagas";
            this.labelTeptelHagas.Size = new System.Drawing.Size(40, 17);
            this.labelTeptelHagas.TabIndex = 51;
            this.labelTeptelHagas.Text = "4500";
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 382);
            this.Controls.Add(this.button);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FoodForm";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FoodForm_FormClosing);
            this.Load += new System.EventHandler(this.FoodForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxBaitsaa;
        private System.Windows.Forms.CheckBox checkBoxLuuvan;
        private System.Windows.Forms.CheckBox checkBoxNiislel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelNiislel;
        private System.Windows.Forms.Label labelBaitsaa;
        private System.Windows.Forms.TextBox textBoxBaitsaa;
        private System.Windows.Forms.TextBox textBoxLuuvan;
        private System.Windows.Forms.Label labelLuuvan;
        private System.Windows.Forms.TextBox textBoxNiislel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelHar;
        private System.Windows.Forms.TextBox textBoxBituu;
        private System.Windows.Forms.Label labelBituu;
        private System.Windows.Forms.TextBox textBoxHar;
        private System.Windows.Forms.CheckBox checkBoxBituu;
        private System.Windows.Forms.CheckBox checkBoxHar;
        private System.Windows.Forms.Label labelTsuivan;
        private System.Windows.Forms.Label labelGul;
        private System.Windows.Forms.TextBox textBoxGul;
        private System.Windows.Forms.TextBox textBoxTeptel;
        private System.Windows.Forms.Label labelTeptel;
        private System.Windows.Forms.TextBox textBoxTsuivan;
        private System.Windows.Forms.CheckBox checkBoxGul;
        private System.Windows.Forms.CheckBox checkBoxTeptel;
        private System.Windows.Forms.CheckBox checkBoxTsuivan;
        private System.Windows.Forms.ComboBox comboBoxTsuivan;
        private System.Windows.Forms.ComboBox comboBoxBituu;
        private System.Windows.Forms.ComboBox comboBoxHar;
        private System.Windows.Forms.ComboBox comboBoxGul;
        private System.Windows.Forms.ComboBox comboBoxTeptel;
        private System.Windows.Forms.Label labelHarHagas;
        private System.Windows.Forms.Label labelBituuHagas;
        private System.Windows.Forms.Label labelTsuivanHagas;
        private System.Windows.Forms.Label labelGulHagas;
        private System.Windows.Forms.Label labelTeptelHagas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
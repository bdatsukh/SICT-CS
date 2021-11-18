namespace Lab7
{
    partial class Form1
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
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxUrag = new System.Windows.Forms.TextBox();
            this.textBoxOvog = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxSchool = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPhysics = new System.Windows.Forms.TextBox();
            this.textBoxMat = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(149, 28);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(126, 22);
            this.textBoxCode.TabIndex = 0;
            this.textBoxCode.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCode_Validating);
            this.textBoxCode.Validated += new System.EventHandler(this.textBoxCode_Validated);
            // 
            // textBoxUrag
            // 
            this.textBoxUrag.Location = new System.Drawing.Point(149, 56);
            this.textBoxUrag.Name = "textBoxUrag";
            this.textBoxUrag.Size = new System.Drawing.Size(126, 22);
            this.textBoxUrag.TabIndex = 1;
            this.textBoxUrag.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUrag_Validating);
            this.textBoxUrag.Validated += new System.EventHandler(this.textBoxUrag_Validated);
            // 
            // textBoxOvog
            // 
            this.textBoxOvog.Location = new System.Drawing.Point(149, 84);
            this.textBoxOvog.Name = "textBoxOvog";
            this.textBoxOvog.Size = new System.Drawing.Size(126, 22);
            this.textBoxOvog.TabIndex = 2;
            this.textBoxOvog.TextChanged += new System.EventHandler(this.textBoxOvog_TextChanged);
            this.textBoxOvog.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOvog_Validating);
            this.textBoxOvog.Validated += new System.EventHandler(this.textBoxOvog_Validated);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(149, 196);
            this.textBoxDate.MaxLength = 4;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(126, 22);
            this.textBoxDate.TabIndex = 6;
            // 
            // textBoxSchool
            // 
            this.textBoxSchool.Location = new System.Drawing.Point(149, 168);
            this.textBoxSchool.Name = "textBoxSchool";
            this.textBoxSchool.Size = new System.Drawing.Size(126, 22);
            this.textBoxSchool.TabIndex = 5;
            this.textBoxSchool.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSchool_Validating);
            this.textBoxSchool.Validated += new System.EventHandler(this.textBoxSchool_Validated);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(149, 112);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(126, 22);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            this.textBoxName.Validated += new System.EventHandler(this.textBoxName_Validated);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(149, 140);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(271, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Код:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ургийн овог:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Овог:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Нэр:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Төгссөн сургууль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Эеш өгсөн он:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Төрсөн огноо:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Эеш физик";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Эеш мат:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Төрсөн газар:";
            // 
            // textBoxPhysics
            // 
            this.textBoxPhysics.Location = new System.Drawing.Point(149, 280);
            this.textBoxPhysics.MaxLength = 3;
            this.textBoxPhysics.Name = "textBoxPhysics";
            this.textBoxPhysics.Size = new System.Drawing.Size(126, 22);
            this.textBoxPhysics.TabIndex = 9;
            this.textBoxPhysics.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPhysics_Validating);
            this.textBoxPhysics.Validated += new System.EventHandler(this.textBoxPhysics_Validated);
            // 
            // textBoxMat
            // 
            this.textBoxMat.Location = new System.Drawing.Point(149, 252);
            this.textBoxMat.MaxLength = 3;
            this.textBoxMat.Name = "textBoxMat";
            this.textBoxMat.Size = new System.Drawing.Size(126, 22);
            this.textBoxMat.TabIndex = 8;
            this.textBoxMat.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMat_Validating);
            this.textBoxMat.Validated += new System.EventHandler(this.textBoxMat_Validated);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(149, 224);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(126, 22);
            this.textBoxFrom.TabIndex = 7;
            this.textBoxFrom.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFrom_Validating);
            this.textBoxFrom.Validated += new System.EventHandler(this.textBoxFrom_Validated);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(149, 314);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(88, 39);
            this.buttonCheck.TabIndex = 10;
            this.buttonCheck.Text = "Шалгах";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 365);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxPhysics);
            this.Controls.Add(this.textBoxMat);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxSchool);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxOvog);
            this.Controls.Add(this.textBoxUrag);
            this.Controls.Add(this.textBoxCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxUrag;
        private System.Windows.Forms.TextBox textBoxOvog;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxSchool;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPhysics;
        private System.Windows.Forms.TextBox textBoxMat;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Button buttonCheck;
    }
}


namespace VigneroRectangleExceptions
{
    partial class RectangleAreaCalc
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
            this.gbMeasurements = new System.Windows.Forms.GroupBox();
            this.rbCentimeters = new System.Windows.Forms.RadioButton();
            this.rbMeters = new System.Windows.Forms.RadioButton();
            this.rbFeet = new System.Windows.Forms.RadioButton();
            this.rbInches = new System.Windows.Forms.RadioButton();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.dbArea = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.gbPerimeter = new System.Windows.Forms.GroupBox();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.gbConvert = new System.Windows.Forms.GroupBox();
            this.rbCentimetersConvert = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rbMetersConvert = new System.Windows.Forms.RadioButton();
            this.rbFeetConvert = new System.Windows.Forms.RadioButton();
            this.rbInchesConvert = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbMeasurements.SuspendLayout();
            this.dbArea.SuspendLayout();
            this.gbPerimeter.SuspendLayout();
            this.gbConvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMeasurements
            // 
            this.gbMeasurements.Controls.Add(this.rbCentimeters);
            this.gbMeasurements.Controls.Add(this.rbMeters);
            this.gbMeasurements.Controls.Add(this.rbFeet);
            this.gbMeasurements.Controls.Add(this.rbInches);
            this.gbMeasurements.Location = new System.Drawing.Point(16, 83);
            this.gbMeasurements.Name = "gbMeasurements";
            this.gbMeasurements.Size = new System.Drawing.Size(353, 88);
            this.gbMeasurements.TabIndex = 0;
            this.gbMeasurements.TabStop = false;
            this.gbMeasurements.Text = "Measurements";
            // 
            // rbCentimeters
            // 
            this.rbCentimeters.AutoSize = true;
            this.rbCentimeters.Location = new System.Drawing.Point(239, 34);
            this.rbCentimeters.Name = "rbCentimeters";
            this.rbCentimeters.Size = new System.Drawing.Size(102, 17);
            this.rbCentimeters.TabIndex = 3;
            this.rbCentimeters.TabStop = true;
            this.rbCentimeters.Text = "centimeters (cm)";
            this.rbCentimeters.UseVisualStyleBackColor = true;
            this.rbCentimeters.CheckedChanged += new System.EventHandler(this.rbCentimeters_CheckedChanged);
            // 
            // rbMeters
            // 
            this.rbMeters.AutoSize = true;
            this.rbMeters.Location = new System.Drawing.Point(160, 34);
            this.rbMeters.Name = "rbMeters";
            this.rbMeters.Size = new System.Drawing.Size(73, 17);
            this.rbMeters.TabIndex = 2;
            this.rbMeters.TabStop = true;
            this.rbMeters.Text = "meters (m)";
            this.rbMeters.UseVisualStyleBackColor = true;
            this.rbMeters.CheckedChanged += new System.EventHandler(this.rbMeters_CheckedChanged);
            // 
            // rbFeet
            // 
            this.rbFeet.AutoSize = true;
            this.rbFeet.Location = new System.Drawing.Point(96, 34);
            this.rbFeet.Name = "rbFeet";
            this.rbFeet.Size = new System.Drawing.Size(58, 17);
            this.rbFeet.TabIndex = 1;
            this.rbFeet.TabStop = true;
            this.rbFeet.Text = "feet (ft)";
            this.rbFeet.UseVisualStyleBackColor = true;
            this.rbFeet.CheckedChanged += new System.EventHandler(this.rbFeet_CheckedChanged);
            // 
            // rbInches
            // 
            this.rbInches.AutoSize = true;
            this.rbInches.Location = new System.Drawing.Point(17, 34);
            this.rbInches.Name = "rbInches";
            this.rbInches.Size = new System.Drawing.Size(73, 17);
            this.rbInches.TabIndex = 0;
            this.rbInches.TabStop = true;
            this.rbInches.Text = "inches (in)";
            this.rbInches.UseVisualStyleBackColor = true;
            this.rbInches.CheckedChanged += new System.EventHandler(this.rbInches_CheckedChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(148, 12);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 1;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(81, 15);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 13);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Length:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(81, 53);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Width:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(148, 50);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 4;
            // 
            // dbArea
            // 
            this.dbArea.Controls.Add(this.lblArea);
            this.dbArea.Location = new System.Drawing.Point(12, 241);
            this.dbArea.Name = "dbArea";
            this.dbArea.Size = new System.Drawing.Size(200, 100);
            this.dbArea.TabIndex = 5;
            this.dbArea.TabStop = false;
            this.dbArea.Text = "Area";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(59, 50);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 0;
            // 
            // gbPerimeter
            // 
            this.gbPerimeter.Controls.Add(this.lblPerimeter);
            this.gbPerimeter.Location = new System.Drawing.Point(235, 241);
            this.gbPerimeter.Name = "gbPerimeter";
            this.gbPerimeter.Size = new System.Drawing.Size(200, 100);
            this.gbPerimeter.TabIndex = 6;
            this.gbPerimeter.TabStop = false;
            this.gbPerimeter.Text = "Perimeter";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(67, 49);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(0, 13);
            this.lblPerimeter.TabIndex = 0;
            // 
            // gbConvert
            // 
            this.gbConvert.Controls.Add(this.rbCentimetersConvert);
            this.gbConvert.Controls.Add(this.btnConvert);
            this.gbConvert.Controls.Add(this.rbMetersConvert);
            this.gbConvert.Controls.Add(this.rbFeetConvert);
            this.gbConvert.Controls.Add(this.rbInchesConvert);
            this.gbConvert.Location = new System.Drawing.Point(457, 169);
            this.gbConvert.Name = "gbConvert";
            this.gbConvert.Size = new System.Drawing.Size(200, 172);
            this.gbConvert.TabIndex = 7;
            this.gbConvert.TabStop = false;
            this.gbConvert.Text = "Convert";
            // 
            // rbCentimetersConvert
            // 
            this.rbCentimetersConvert.AutoSize = true;
            this.rbCentimetersConvert.Location = new System.Drawing.Point(57, 91);
            this.rbCentimetersConvert.Name = "rbCentimetersConvert";
            this.rbCentimetersConvert.Size = new System.Drawing.Size(102, 17);
            this.rbCentimetersConvert.TabIndex = 4;
            this.rbCentimetersConvert.TabStop = true;
            this.rbCentimetersConvert.Text = "centimeters (cm)";
            this.rbCentimetersConvert.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(57, 143);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rbMetersConvert
            // 
            this.rbMetersConvert.AutoSize = true;
            this.rbMetersConvert.Location = new System.Drawing.Point(57, 67);
            this.rbMetersConvert.Name = "rbMetersConvert";
            this.rbMetersConvert.Size = new System.Drawing.Size(73, 17);
            this.rbMetersConvert.TabIndex = 2;
            this.rbMetersConvert.TabStop = true;
            this.rbMetersConvert.Text = "meters (m)";
            this.rbMetersConvert.UseVisualStyleBackColor = true;
            // 
            // rbFeetConvert
            // 
            this.rbFeetConvert.AutoSize = true;
            this.rbFeetConvert.Location = new System.Drawing.Point(57, 44);
            this.rbFeetConvert.Name = "rbFeetConvert";
            this.rbFeetConvert.Size = new System.Drawing.Size(58, 17);
            this.rbFeetConvert.TabIndex = 1;
            this.rbFeetConvert.TabStop = true;
            this.rbFeetConvert.Text = "feet (ft)";
            this.rbFeetConvert.UseVisualStyleBackColor = true;
            // 
            // rbInchesConvert
            // 
            this.rbInchesConvert.AutoSize = true;
            this.rbInchesConvert.Location = new System.Drawing.Point(57, 21);
            this.rbInchesConvert.Name = "rbInchesConvert";
            this.rbInchesConvert.Size = new System.Drawing.Size(73, 17);
            this.rbInchesConvert.TabIndex = 0;
            this.rbInchesConvert.TabStop = true;
            this.rbInchesConvert.Text = "inches (in)";
            this.rbInchesConvert.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(386, 43);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(386, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(386, 101);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RectangleAreaCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(669, 353);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbConvert);
            this.Controls.Add(this.gbPerimeter);
            this.Controls.Add(this.dbArea);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.gbMeasurements);
            this.Name = "RectangleAreaCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area and Perimeter Calculator";
            this.gbMeasurements.ResumeLayout(false);
            this.gbMeasurements.PerformLayout();
            this.dbArea.ResumeLayout(false);
            this.dbArea.PerformLayout();
            this.gbPerimeter.ResumeLayout(false);
            this.gbPerimeter.PerformLayout();
            this.gbConvert.ResumeLayout(false);
            this.gbConvert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMeasurements;
        private System.Windows.Forms.RadioButton rbCentimeters;
        private System.Windows.Forms.RadioButton rbMeters;
        private System.Windows.Forms.RadioButton rbFeet;
        private System.Windows.Forms.RadioButton rbInches;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.GroupBox dbArea;
        private System.Windows.Forms.GroupBox gbPerimeter;
        private System.Windows.Forms.GroupBox gbConvert;
        private System.Windows.Forms.RadioButton rbMetersConvert;
        private System.Windows.Forms.RadioButton rbFeetConvert;
        private System.Windows.Forms.RadioButton rbInchesConvert;
        private System.Windows.Forms.RadioButton rbCentimetersConvert;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
    }
}


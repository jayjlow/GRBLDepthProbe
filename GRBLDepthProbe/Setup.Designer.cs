namespace GRBLDepthProbe
{
	partial class Setup
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
			this.components = new System.ComponentModel.Container();
			this.heightBOX = new System.Windows.Forms.TextBox();
			this.widthBOX = new System.Windows.Forms.TextBox();
			this.gridBOX = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.safetyHeightBOX = new System.Windows.Forms.TextBox();
			this.plungeRateBOX = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.addedSafetyBOX = new System.Windows.Forms.TextBox();
			this.maxRetrysBOX = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.digitsBOX = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.maxDepthBOX = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// heightBOX
			// 
			this.heightBOX.Location = new System.Drawing.Point(12, 12);
			this.heightBOX.Name = "heightBOX";
			this.heightBOX.Size = new System.Drawing.Size(100, 20);
			this.heightBOX.TabIndex = 0;
			this.heightBOX.Text = Settings.height.ToString();
			// 
			// widthBOX
			// 
			this.widthBOX.Location = new System.Drawing.Point(12, 38);
			this.widthBOX.Name = "widthBOX";
			this.widthBOX.Size = new System.Drawing.Size(100, 20);
			this.widthBOX.TabIndex = 1;
			this.widthBOX.Text = Settings.width.ToString();
			// 
			// gridBOX
			// 
			this.gridBOX.Location = new System.Drawing.Point(12, 64);
			this.gridBOX.Name = "gridBOX";
			this.gridBOX.Size = new System.Drawing.Size(100, 20);
			this.gridBOX.TabIndex = 2;
			this.gridBOX.Text = Settings.grid.ToString();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(118, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Heigt of Probe Area (mm)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(118, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Width of Probe Area (mm)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(118, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Probe Spacing  (mm)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(118, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Safety Height (mm)";
			// 
			// safetyHeightBOX
			// 
			this.safetyHeightBOX.Location = new System.Drawing.Point(12, 92);
			this.safetyHeightBOX.Name = "safetyHeightBOX";
			this.safetyHeightBOX.Size = new System.Drawing.Size(100, 20);
			this.safetyHeightBOX.TabIndex = 7;
			this.safetyHeightBOX.Text = Settings.safety.ToString();
			// 
			// plungeRateBOX
			// 
			this.plungeRateBOX.Location = new System.Drawing.Point(12, 118);
			this.plungeRateBOX.Name = "plungeRateBOX";
			this.plungeRateBOX.Size = new System.Drawing.Size(100, 20);
			this.plungeRateBOX.TabIndex = 8;
			this.plungeRateBOX.Text = Settings.plunge.ToString();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(118, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Plunge Rate (mm/min)";
			// 
			// addedSafetyBOX
			// 
			this.addedSafetyBOX.Location = new System.Drawing.Point(12, 170);
			this.addedSafetyBOX.Name = "addedSafetyBOX";
			this.addedSafetyBOX.Size = new System.Drawing.Size(100, 20);
			this.addedSafetyBOX.TabIndex = 10;
			this.addedSafetyBOX.Text = Settings.minimumDistance.ToString();
			//
			// maxRetrysBOX
			// 
			this.maxRetrysBOX.Location = new System.Drawing.Point(12, 196);
			this.maxRetrysBOX.Name = "maxRetrysBOX";
			this.maxRetrysBOX.Size = new System.Drawing.Size(100, 20);
			this.maxRetrysBOX.TabIndex = 11;
			this.maxRetrysBOX.Text = Settings.retrys.ToString();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(118, 173);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(215, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Minimum Heigt Distance to Neighbours (mm)";
			this.toolTip1.SetToolTip(this.label6, "Safety Height must be greater than or equal to the Height of the highest neighbou" +
        "r point.\r\nThis value is also added to the safety height in case of a probe failu" +
        "re (ID36)");
			// 
			// toolTip1
			// 
			this.toolTip1.ToolTipTitle = "Description";
			// 
			// digitsBOX
			// 
			this.digitsBOX.Location = new System.Drawing.Point(12, 222);
			this.digitsBOX.Name = "digitsBOX";
			this.digitsBOX.Size = new System.Drawing.Size(100, 20);
			this.digitsBOX.TabIndex = 13;
			this.digitsBOX.Text = Settings.DecimalPlaces.ToString();
			this.digitsBOX.TextChanged += new System.EventHandler(this.digitsBOX_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(118, 199);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(136, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Maximum Number of Retrys";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(118, 225);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(147, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Truncate Decimals to X Digits\r\n";
			// 
			// maxDepthBOX
			// 
			this.maxDepthBOX.Location = new System.Drawing.Point(12, 144);
			this.maxDepthBOX.Name = "maxDepthBOX";
			this.maxDepthBOX.Size = new System.Drawing.Size(100, 20);
			this.maxDepthBOX.TabIndex = 16;
			this.maxDepthBOX.Text = Settings.maxDepth.ToString();
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(123, 147);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(86, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "max. Depth (mm)";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(47, 248);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(30, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "Y+";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.jog_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(10, 276);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(30, 23);
			this.button2.TabIndex = 19;
			this.button2.Text = "X-";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.jog_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(119, 305);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(30, 23);
			this.button3.TabIndex = 20;
			this.button3.Text = "Z-";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.jog_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(82, 276);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(30, 23);
			this.button4.TabIndex = 21;
			this.button4.Text = "X+";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.jog_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(47, 305);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(30, 23);
			this.button5.TabIndex = 22;
			this.button5.Text = "Y-";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.jog_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(119, 248);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(30, 23);
			this.button6.TabIndex = 23;
			this.button6.Text = "Z+";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.jog_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(190, 305);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(96, 23);
			this.button7.TabIndex = 24;
			this.button7.Text = "RUN";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 3;
			this.numericUpDown1.Location = new System.Drawing.Point(118, 277);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
			this.numericUpDown1.TabIndex = 25;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(190, 248);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(96, 23);
			this.button8.TabIndex = 26;
			this.button8.Text = "Zero Here";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(190, 274);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(96, 23);
			this.button9.TabIndex = 27;
			this.button9.Text = "runProbeCycle";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// Setup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 339);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.maxDepthBOX);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.digitsBOX);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.maxRetrysBOX);
			this.Controls.Add(this.addedSafetyBOX);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.plungeRateBOX);
			this.Controls.Add(this.safetyHeightBOX);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gridBOX);
			this.Controls.Add(this.widthBOX);
			this.Controls.Add(this.heightBOX);
			this.Name = "Setup";
			this.Text = "Setup";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox heightBOX;
		private System.Windows.Forms.TextBox widthBOX;
		private System.Windows.Forms.TextBox gridBOX;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox safetyHeightBOX;
		private System.Windows.Forms.TextBox plungeRateBOX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox addedSafetyBOX;
		private System.Windows.Forms.TextBox maxRetrysBOX;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox digitsBOX;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox maxDepthBOX;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
	}
}
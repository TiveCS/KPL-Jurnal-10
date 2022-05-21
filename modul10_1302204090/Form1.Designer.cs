namespace modul10_1302204090
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
			this.num_2 = new System.Windows.Forms.TextBox();
			this.num_1 = new System.Windows.Forms.TextBox();
			this.calculate = new System.Windows.Forms.Button();
			this.result = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// num_2
			// 
			this.num_2.Location = new System.Drawing.Point(260, 82);
			this.num_2.Name = "num_2";
			this.num_2.Size = new System.Drawing.Size(100, 22);
			this.num_2.TabIndex = 0;
			// 
			// num_1
			// 
			this.num_1.Location = new System.Drawing.Point(76, 82);
			this.num_1.Name = "num_1";
			this.num_1.Size = new System.Drawing.Size(100, 22);
			this.num_1.TabIndex = 1;
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(76, 179);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(75, 23);
			this.calculate.TabIndex = 2;
			this.calculate.Text = "Calculate";
			this.calculate.UseVisualStyleBackColor = true;
			this.calculate.Click += new System.EventHandler(this.calculate_Click);
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(257, 182);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(51, 16);
			this.result.TabIndex = 3;
			this.result.Text = "Result: ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.result);
			this.Controls.Add(this.calculate);
			this.Controls.Add(this.num_1);
			this.Controls.Add(this.num_2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox num_2;
		private System.Windows.Forms.TextBox num_1;
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.Label result;
	}
}


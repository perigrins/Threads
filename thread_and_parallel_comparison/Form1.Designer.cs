namespace thread_and_parallel_comparison
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox_table = new TextBox();
			button_start = new Button();
			SuspendLayout();
			// 
			// textBox_table
			// 
			textBox_table.BackColor = SystemColors.ControlLightLight;
			textBox_table.Location = new Point(125, 190);
			textBox_table.Multiline = true;
			textBox_table.Name = "textBox_table";
			textBox_table.ReadOnly = true;
			textBox_table.Size = new Size(1090, 624);
			textBox_table.TabIndex = 0;
			// 
			// button_start
			// 
			button_start.Location = new Point(536, 49);
			button_start.Name = "button_start";
			button_start.Size = new Size(240, 101);
			button_start.TabIndex = 1;
			button_start.Text = "start";
			button_start.UseVisualStyleBackColor = true;
			button_start.Click += button_start_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1365, 963);
			Controls.Add(button_start);
			Controls.Add(textBox_table);
			Name = "Form1";
			Text = "Comparision";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox_table;
		private Button button_start;
	}
}

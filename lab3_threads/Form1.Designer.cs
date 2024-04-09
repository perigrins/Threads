using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Matrix.cs"), InternalsVisibleTo("Program")]
namespace lab3_threads
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
		public void InitializeComponent()
		{
			textBox_input = new TextBox();
			textBox_output = new TextBox();
			label_input = new Label();
			label_output = new Label();
			button_start = new Button();
			textBox_time = new TextBox();
			textBox_input_2 = new TextBox();
			textBox_time_2 = new TextBox();
			SuspendLayout();
			// 
			// textBox_input
			// 
			textBox_input.BackColor = SystemColors.Control;
			textBox_input.Location = new Point(50, 148);
			textBox_input.Multiline = true;
			textBox_input.Name = "textBox_input";
			textBox_input.ReadOnly = true;
			textBox_input.ScrollBars = ScrollBars.Both;
			textBox_input.Size = new Size(970, 628);
			textBox_input.TabIndex = 0;
			// 
			// textBox_output
			// 
			textBox_output.Location = new Point(1143, 148);
			textBox_output.Multiline = true;
			textBox_output.Name = "textBox_output";
			textBox_output.ReadOnly = true;
			textBox_output.ScrollBars = ScrollBars.Both;
			textBox_output.Size = new Size(1123, 1014);
			textBox_output.TabIndex = 1;
			// 
			// label_input
			// 
			label_input.AutoSize = true;
			label_input.Location = new Point(50, 79);
			label_input.Name = "label_input";
			label_input.Size = new Size(87, 41);
			label_input.TabIndex = 2;
			label_input.Text = "input";
			// 
			// label_output
			// 
			label_output.AutoSize = true;
			label_output.Location = new Point(1392, 79);
			label_output.Name = "label_output";
			label_output.Size = new Size(108, 41);
			label_output.TabIndex = 3;
			label_output.Text = "output";
			// 
			// button_start
			// 
			button_start.Location = new Point(1143, 70);
			button_start.Name = "button_start";
			button_start.Size = new Size(188, 58);
			button_start.TabIndex = 4;
			button_start.Text = "start";
			button_start.UseVisualStyleBackColor = true;
			button_start.Click += button_start_Click;
			// 
			// textBox_time
			// 
			textBox_time.Location = new Point(1143, 1183);
			textBox_time.Multiline = true;
			textBox_time.Name = "textBox_time";
			textBox_time.ReadOnly = true;
			textBox_time.Size = new Size(547, 120);
			textBox_time.TabIndex = 5;
			// 
			// textBox_input_2
			// 
			textBox_input_2.Location = new Point(60, 799);
			textBox_input_2.Multiline = true;
			textBox_input_2.Name = "textBox_input_2";
			textBox_input_2.ReadOnly = true;
			textBox_input_2.ScrollBars = ScrollBars.Both;
			textBox_input_2.Size = new Size(960, 658);
			textBox_input_2.TabIndex = 6;
			// 
			// textBox_time_2
			// 
			textBox_time_2.Location = new Point(1730, 1183);
			textBox_time_2.Multiline = true;
			textBox_time_2.Name = "textBox_time_2";
			textBox_time_2.ReadOnly = true;
			textBox_time_2.Size = new Size(536, 120);
			textBox_time_2.TabIndex = 7;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.AppWorkspace;
			ClientSize = new Size(2324, 1491);
			Controls.Add(textBox_time_2);
			Controls.Add(textBox_input_2);
			Controls.Add(textBox_time);
			Controls.Add(button_start);
			Controls.Add(label_output);
			Controls.Add(label_input);
			Controls.Add(textBox_output);
			Controls.Add(textBox_input);
			Name = "Form1";
			Text = "Parallel matrix multiplication";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label_input;
		private Label label_output;
		public TextBox textBox_input;
		public TextBox textBox_output;
		private Button button_start;
		public TextBox textBox_time;
		public TextBox textBox_input_2;
		private TextBox textBox_time_2;
	}
}

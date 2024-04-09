namespace image_processing_with_threads
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
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			pictureBox4 = new PictureBox();
			pictureBox5 = new PictureBox();
			button_process = new Button();
			button_choose = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			SuspendLayout();

			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = SystemColors.ControlLightLight;
			pictureBox1.Location = new Point(53, 440);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(500, 500);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = SystemColors.ControlLightLight;
			pictureBox2.Location = new Point(642, 182);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(500, 500);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.BackColor = SystemColors.ControlLightLight;
			pictureBox3.Location = new Point(642, 716);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(500, 500);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 2;
			pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.BackColor = SystemColors.ControlLightLight;
			pictureBox4.Location = new Point(1177, 182);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(500, 500);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 3;
			pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			pictureBox5.BackColor = SystemColors.ControlLightLight;
			pictureBox5.Location = new Point(1177, 716);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(500, 500);
			pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 4;
			pictureBox5.TabStop = false;
			// 
			// button_process
			// 
			button_process.Location = new Point(306, 983);
			button_process.Name = "button_process";
			button_process.Size = new Size(247, 84);
			button_process.TabIndex = 5;
			button_process.Text = "process image";
			button_process.UseVisualStyleBackColor = true;
			//button_process.Click += button_process_ClickAsync;
			button_process.Click += button_process_Click;
			// 
			// button_choose
			// 
			button_choose.Location = new Point(306, 315);
			button_choose.Name = "button_choose";
			button_choose.Size = new Size(247, 84);
			button_choose.TabIndex = 6;
			button_choose.Text = "choose image";
			button_choose.UseVisualStyleBackColor = true;
			button_choose.Click += button_choose_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1733, 1386);
			Controls.Add(button_choose);
			Controls.Add(button_process);
			Controls.Add(pictureBox5);
			Controls.Add(pictureBox4);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private PictureBox pictureBox4;
		private PictureBox pictureBox5;
		private Button button_process;
		private Button button_choose;
	}
}

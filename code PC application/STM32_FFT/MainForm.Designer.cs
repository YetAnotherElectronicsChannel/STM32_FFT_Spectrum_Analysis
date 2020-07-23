/*
 * Created by SharpDevelop.
 * User: Markus
 * Date: 19.07.2020
 * Time: 15:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace STM32_FFT
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.progressBar4 = new System.Windows.Forms.ProgressBar();
			this.progressBar5 = new System.Windows.Forms.ProgressBar();
			this.progressBar6 = new System.Windows.Forms.ProgressBar();
			this.progressBar7 = new System.Windows.Forms.ProgressBar();
			this.progressBar8 = new System.Windows.Forms.ProgressBar();
			this.progressBar9 = new System.Windows.Forms.ProgressBar();
			this.progressBar10 = new System.Windows.Forms.ProgressBar();
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
			this.label11 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(246, 14);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(59, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(140, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 73);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(229, 27);
			this.progressBar1.TabIndex = 2;
			this.progressBar1.Value = 50;
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(12, 106);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(229, 27);
			this.progressBar2.TabIndex = 3;
			this.progressBar2.Value = 50;
			// 
			// progressBar3
			// 
			this.progressBar3.Location = new System.Drawing.Point(12, 139);
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(229, 27);
			this.progressBar3.TabIndex = 4;
			this.progressBar3.Value = 50;
			// 
			// progressBar4
			// 
			this.progressBar4.Location = new System.Drawing.Point(12, 172);
			this.progressBar4.Name = "progressBar4";
			this.progressBar4.Size = new System.Drawing.Size(229, 27);
			this.progressBar4.TabIndex = 5;
			this.progressBar4.Value = 50;
			// 
			// progressBar5
			// 
			this.progressBar5.Location = new System.Drawing.Point(12, 205);
			this.progressBar5.Name = "progressBar5";
			this.progressBar5.Size = new System.Drawing.Size(229, 27);
			this.progressBar5.TabIndex = 6;
			this.progressBar5.Value = 50;
			// 
			// progressBar6
			// 
			this.progressBar6.Location = new System.Drawing.Point(12, 238);
			this.progressBar6.Name = "progressBar6";
			this.progressBar6.Size = new System.Drawing.Size(229, 27);
			this.progressBar6.TabIndex = 7;
			this.progressBar6.Value = 50;
			// 
			// progressBar7
			// 
			this.progressBar7.Location = new System.Drawing.Point(12, 271);
			this.progressBar7.Name = "progressBar7";
			this.progressBar7.Size = new System.Drawing.Size(229, 27);
			this.progressBar7.TabIndex = 8;
			this.progressBar7.Value = 50;
			// 
			// progressBar8
			// 
			this.progressBar8.Location = new System.Drawing.Point(12, 304);
			this.progressBar8.Name = "progressBar8";
			this.progressBar8.Size = new System.Drawing.Size(229, 27);
			this.progressBar8.TabIndex = 9;
			this.progressBar8.Value = 50;
			// 
			// progressBar9
			// 
			this.progressBar9.Location = new System.Drawing.Point(12, 337);
			this.progressBar9.Name = "progressBar9";
			this.progressBar9.Size = new System.Drawing.Size(229, 27);
			this.progressBar9.TabIndex = 10;
			this.progressBar9.Value = 50;
			// 
			// progressBar10
			// 
			this.progressBar10.Location = new System.Drawing.Point(12, 370);
			this.progressBar10.Name = "progressBar10";
			this.progressBar10.Size = new System.Drawing.Size(229, 27);
			this.progressBar10.TabIndex = 11;
			this.progressBar10.Value = 50;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(271, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "31.5 Hz";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(271, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "63 Hz";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(271, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "125 Hz";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(271, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "250 Hz";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(271, 209);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "500 Hz";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(271, 242);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "1 kHz";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(271, 275);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 18;
			this.label7.Text = "2.2 kHz";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(271, 308);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 19;
			this.label8.Text = "4.5 kHz";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(271, 341);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 20;
			this.label9.Text = "9 kHz";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(271, 374);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 21;
			this.label10.Text = "15 kHz";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(18, 19);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(35, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "COM";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 423);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar10);
			this.Controls.Add(this.progressBar9);
			this.Controls.Add(this.progressBar8);
			this.Controls.Add(this.progressBar7);
			this.Controls.Add(this.progressBar6);
			this.Controls.Add(this.progressBar5);
			this.Controls.Add(this.progressBar4);
			this.Controls.Add(this.progressBar3);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "STM32_FFT";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar10;
		private System.Windows.Forms.ProgressBar progressBar9;
		private System.Windows.Forms.ProgressBar progressBar8;
		private System.Windows.Forms.ProgressBar progressBar7;
		private System.Windows.Forms.ProgressBar progressBar6;
		private System.Windows.Forms.ProgressBar progressBar5;
		private System.Windows.Forms.ProgressBar progressBar4;
		private System.Windows.Forms.ProgressBar progressBar3;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
	}
}

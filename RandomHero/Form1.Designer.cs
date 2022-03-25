namespace RandomHero
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
			this.button1 = new System.Windows.Forms.Button();
			this.heroAvatar = new System.Windows.Forms.PictureBox();
			this.itemBox1 = new System.Windows.Forms.PictureBox();
			this.itemBox4 = new System.Windows.Forms.PictureBox();
			this.itemBox2 = new System.Windows.Forms.PictureBox();
			this.itemBox5 = new System.Windows.Forms.PictureBox();
			this.itemBox6 = new System.Windows.Forms.PictureBox();
			this.itemBox3 = new System.Windows.Forms.PictureBox();
			this.specialItemBox1 = new System.Windows.Forms.PictureBox();
			this.specialItemBox2 = new System.Windows.Forms.PictureBox();
			this.specialItemBox3 = new System.Windows.Forms.PictureBox();
			this.minimumGold = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.generateNewButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.heroAvatar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specialItemBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specialItemBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specialItemBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(429, 116);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(21, 36);
			this.button1.TabIndex = 0;
			this.button1.Text = "Update Patch";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// heroAvatar
			// 
			this.heroAvatar.ImageLocation = "https://steamcdn-a.akamaihd.net/apps/dota2/images/dota_react/heroes/abaddon.png";
			this.heroAvatar.Location = new System.Drawing.Point(12, 12);
			this.heroAvatar.Name = "heroAvatar";
			this.heroAvatar.Size = new System.Drawing.Size(180, 103);
			this.heroAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.heroAvatar.TabIndex = 1;
			this.heroAvatar.TabStop = false;
			// 
			// itemBox1
			// 
			this.itemBox1.Location = new System.Drawing.Point(198, 12);
			this.itemBox1.Name = "itemBox1";
			this.itemBox1.Size = new System.Drawing.Size(80, 46);
			this.itemBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemBox1.TabIndex = 2;
			this.itemBox1.TabStop = false;
			this.itemBox1.WaitOnLoad = true;
			// 
			// itemBox4
			// 
			this.itemBox4.Location = new System.Drawing.Point(198, 64);
			this.itemBox4.Name = "itemBox4";
			this.itemBox4.Size = new System.Drawing.Size(80, 46);
			this.itemBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemBox4.TabIndex = 3;
			this.itemBox4.TabStop = false;
			this.itemBox4.WaitOnLoad = true;
			// 
			// itemBox2
			// 
			this.itemBox2.Location = new System.Drawing.Point(284, 12);
			this.itemBox2.Name = "itemBox2";
			this.itemBox2.Size = new System.Drawing.Size(80, 46);
			this.itemBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemBox2.TabIndex = 4;
			this.itemBox2.TabStop = false;
			this.itemBox2.WaitOnLoad = true;
			// 
			// itemBox5
			// 
			this.itemBox5.Location = new System.Drawing.Point(284, 64);
			this.itemBox5.Name = "itemBox5";
			this.itemBox5.Size = new System.Drawing.Size(80, 46);
			this.itemBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemBox5.TabIndex = 5;
			this.itemBox5.TabStop = false;
			this.itemBox5.WaitOnLoad = true;
			// 
			// itemBox6
			// 
			this.itemBox6.Location = new System.Drawing.Point(370, 64);
			this.itemBox6.Name = "itemBox6";
			this.itemBox6.Size = new System.Drawing.Size(80, 46);
			this.itemBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemBox6.TabIndex = 6;
			this.itemBox6.TabStop = false;
			this.itemBox6.WaitOnLoad = true;
			// 
			// itemBox3
			// 
			this.itemBox3.Location = new System.Drawing.Point(370, 12);
			this.itemBox3.Name = "itemBox3";
			this.itemBox3.Size = new System.Drawing.Size(80, 46);
			this.itemBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemBox3.TabIndex = 7;
			this.itemBox3.TabStop = false;
			this.itemBox3.WaitOnLoad = true;
			// 
			// specialItemBox1
			// 
			this.specialItemBox1.Location = new System.Drawing.Point(225, 116);
			this.specialItemBox1.Name = "specialItemBox1";
			this.specialItemBox1.Size = new System.Drawing.Size(62, 36);
			this.specialItemBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.specialItemBox1.TabIndex = 8;
			this.specialItemBox1.TabStop = false;
			this.specialItemBox1.WaitOnLoad = true;
			// 
			// specialItemBox2
			// 
			this.specialItemBox2.Location = new System.Drawing.Point(293, 116);
			this.specialItemBox2.Name = "specialItemBox2";
			this.specialItemBox2.Size = new System.Drawing.Size(62, 36);
			this.specialItemBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.specialItemBox2.TabIndex = 9;
			this.specialItemBox2.TabStop = false;
			this.specialItemBox2.WaitOnLoad = true;
			// 
			// specialItemBox3
			// 
			this.specialItemBox3.Location = new System.Drawing.Point(361, 116);
			this.specialItemBox3.Name = "specialItemBox3";
			this.specialItemBox3.Size = new System.Drawing.Size(62, 36);
			this.specialItemBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.specialItemBox3.TabIndex = 10;
			this.specialItemBox3.TabStop = false;
			this.specialItemBox3.WaitOnLoad = true;
			// 
			// minimumGold
			// 
			this.minimumGold.BackColor = System.Drawing.Color.White;
			this.minimumGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.minimumGold.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.minimumGold.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.minimumGold.Location = new System.Drawing.Point(116, 121);
			this.minimumGold.Name = "minimumGold";
			this.minimumGold.PlaceholderText = "Minimum";
			this.minimumGold.Size = new System.Drawing.Size(60, 28);
			this.minimumGold.TabIndex = 11;
			this.minimumGold.Text = "3850";
			this.minimumGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.minimumGold.TextChanged += new System.EventHandler(this.MinimumGoldChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/dota2_gamepedia/images/c/cd/Gold_symbol.png";
			this.pictureBox1.Location = new System.Drawing.Point(182, 121);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// generateNewButton
			// 
			this.generateNewButton.Location = new System.Drawing.Point(12, 121);
			this.generateNewButton.Name = "generateNewButton";
			this.generateNewButton.Size = new System.Drawing.Size(98, 28);
			this.generateNewButton.TabIndex = 13;
			this.generateNewButton.Text = "Generate Build";
			this.generateNewButton.UseVisualStyleBackColor = true;
			this.generateNewButton.Click += new System.EventHandler(this.GenerateNewButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(462, 160);
			this.Controls.Add(this.generateNewButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.minimumGold);
			this.Controls.Add(this.specialItemBox3);
			this.Controls.Add(this.specialItemBox2);
			this.Controls.Add(this.specialItemBox1);
			this.Controls.Add(this.itemBox3);
			this.Controls.Add(this.itemBox6);
			this.Controls.Add(this.itemBox5);
			this.Controls.Add(this.itemBox2);
			this.Controls.Add(this.itemBox4);
			this.Controls.Add(this.itemBox1);
			this.Controls.Add(this.heroAvatar);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.heroAvatar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specialItemBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specialItemBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specialItemBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button button1;
		private PictureBox heroAvatar;
		private PictureBox itemBox1;
		private PictureBox itemBox4;
		private PictureBox itemBox2;
		private PictureBox itemBox5;
		private PictureBox itemBox6;
		private PictureBox itemBox3;
		private PictureBox specialItemBox1;
		private PictureBox specialItemBox2;
		private PictureBox specialItemBox3;
		private TextBox minimumGold;
		private PictureBox pictureBox1;
		private Button generateNewButton;
	}
}
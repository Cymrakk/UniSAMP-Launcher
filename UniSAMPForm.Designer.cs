/*
 * Created by SharpDevelop.
 * User: User
 * Date: 13.09.2026
 * Time: 15:09
 */
namespace universal_samp_launcher
{
	partial class UniSAMPForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button PlayButton;
		private System.Windows.Forms.Button button_site; // Добавлено объявление
		private System.Windows.Forms.Button button_github;
		private System.Windows.Forms.Button button_changelog; // Оставлено в одном экземпляре
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button SettingsButton;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox NickNameTB;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox IPServerTB;
		
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
		
		// Добавлен пропущенный заголовок метода:
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniSAMPForm));
			this.PlayButton = new System.Windows.Forms.Button();
			this.button_site = new System.Windows.Forms.Button();
			this.button_github = new System.Windows.Forms.Button();
			this.button_changelog = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SettingsButton = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.NickNameTB = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.IPServerTB = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// PlayButton
			// 
			this.PlayButton.BackColor = System.Drawing.Color.White;
			this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
			this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PlayButton.Location = new System.Drawing.Point(611, 286);
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(164, 62);
			this.PlayButton.TabIndex = 0;
			this.PlayButton.UseMnemonic = false;
			this.PlayButton.UseVisualStyleBackColor = false;
			// 
			// button_site
			// 
			this.button_site.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_site.BackgroundImage")));
			this.button_site.Location = new System.Drawing.Point(622, 9);
			this.button_site.Name = "button_site";
			this.button_site.Size = new System.Drawing.Size(32, 29);
			this.button_site.TabIndex = 3;
			this.button_site.UseVisualStyleBackColor = true;
			this.button_site.Click += new System.EventHandler(this.Button_siteClick);
			// 
			// button_github
			// 
			this.button_github.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_github.BackgroundImage")));
			this.button_github.Location = new System.Drawing.Point(675, 9);
			this.button_github.Name = "button_github";
			this.button_github.Size = new System.Drawing.Size(32, 29);
			this.button_github.TabIndex = 4;
			this.button_github.UseVisualStyleBackColor = true;
			this.button_github.Click += new System.EventHandler(this.Button_githubClick);
			// 
			// button_changelog
			// 
			this.button_changelog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_changelog.BackgroundImage")));
			this.button_changelog.Location = new System.Drawing.Point(725, 9);
			this.button_changelog.Name = "button_changelog";
			this.button_changelog.Size = new System.Drawing.Size(32, 29);
			this.button_changelog.TabIndex = 5;
			this.button_changelog.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 303);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(32, 29);
			this.button5.TabIndex = 6;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// SettingsButton
			// 
			this.SettingsButton.Location = new System.Drawing.Point(12, 12);
			this.SettingsButton.Name = "SettingsButton";
			this.SettingsButton.Size = new System.Drawing.Size(32, 29);
			this.SettingsButton.TabIndex = 7;
			this.SettingsButton.Text = "button6";
			this.SettingsButton.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"SA-MP 0.3.7 R5",
			"SA-MP 0.3.7 R3",
			"SA-MP 0.3.7 R1",
			"SA-MP 0.3e",
			"SA-MP 0.3a",
			"SA-MP 0.3d",
			"SA-MP 0.3z"});
			this.comboBox1.Location = new System.Drawing.Point(66, 14);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// NickNameTB
			// 
			this.NickNameTB.Location = new System.Drawing.Point(231, 14);
			this.NickNameTB.Name = "NickNameTB";
			this.NickNameTB.Size = new System.Drawing.Size(140, 20);
			this.NickNameTB.TabIndex = 9;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 338);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(319, 23);
			this.progressBar1.TabIndex = 10;
			this.progressBar1.Value = 22;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(337, 348);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 18);
			this.label2.TabIndex = 18;
			this.label2.Text = "v0.1.0-beta";
			// 
			// IPServerTB
			// 
			this.IPServerTB.Location = new System.Drawing.Point(400, 14);
			this.IPServerTB.Name = "IPServerTB";
			this.IPServerTB.Size = new System.Drawing.Size(140, 20);
			this.IPServerTB.TabIndex = 19;
			// 
			// UniSAMPForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 380);
			this.Controls.Add(this.IPServerTB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.NickNameTB);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.SettingsButton);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button_changelog);
			this.Controls.Add(this.button_github);
			this.Controls.Add(this.button_site);
			this.Controls.Add(this.PlayButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "UniSAMPForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " UniSAMP";
			this.Load += new System.EventHandler(this.UniSAMPFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

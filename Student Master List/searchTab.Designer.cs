namespace Student_Master_List
{
    partial class searchTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchTab));
            this.button1 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(403, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "🔍 Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(54, 46);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(344, 31);
            this.tbSearch.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox.Controls.Add(this.lblGender);
            this.groupBox.Controls.Add(this.lblSection);
            this.groupBox.Controls.Add(this.lblId);
            this.groupBox.Controls.Add(this.lblCity);
            this.groupBox.Controls.Add(this.pictureBox);
            this.groupBox.Controls.Add(this.lblName);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox.Location = new System.Drawing.Point(54, 102);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(456, 352);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.BackColor = System.Drawing.Color.DarkGray;
            this.lblSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSection.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblSection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSection.Location = new System.Drawing.Point(22, 198);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(50, 18);
            this.lblSection.TabIndex = 4;
            this.lblSection.Text = "              ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.DarkGray;
            this.lblId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblId.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblId.Location = new System.Drawing.Point(179, 158);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(50, 18);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "              ";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.DarkGray;
            this.lblCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCity.Location = new System.Drawing.Point(22, 233);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 18);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "              ";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(25, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.DarkGray;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("Calibri", 13F);
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(178, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "              ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.DarkGray;
            this.lblGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGender.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGender.Location = new System.Drawing.Point(22, 270);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(50, 18);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "              ";
            // 
            // searchTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(562, 463);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSearch);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "searchTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.searchTab_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblGender;
    }
}
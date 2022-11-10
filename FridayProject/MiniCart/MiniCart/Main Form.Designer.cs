namespace MiniCart
{
    partial class MainForm
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
            this.minicart48pt = new System.Windows.Forms.PictureBox();
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.cartBox = new System.Windows.Forms.PictureBox();
            this.minicart48ptLeft = new System.Windows.Forms.PictureBox();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.itemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cartPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.minicart48pt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minicart48ptLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.cartPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // minicart48pt
            // 
            this.minicart48pt.BackColor = System.Drawing.Color.Transparent;
            this.minicart48pt.Location = new System.Drawing.Point(290, 15);
            this.minicart48pt.Name = "minicart48pt";
            this.minicart48pt.Size = new System.Drawing.Size(600, 180);
            this.minicart48pt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minicart48pt.TabIndex = 0;
            this.minicart48pt.TabStop = false;
            // 
            // mainLogo
            // 
            this.mainLogo.BackColor = System.Drawing.Color.Transparent;
            this.mainLogo.Location = new System.Drawing.Point(370, 180);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(440, 440);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainLogo.TabIndex = 1;
            this.mainLogo.TabStop = false;
            // 
            // cartBox
            // 
            this.cartBox.BackColor = System.Drawing.Color.White;
            this.cartBox.Location = new System.Drawing.Point(1060, 595);
            this.cartBox.Name = "cartBox";
            this.cartBox.Size = new System.Drawing.Size(85, 75);
            this.cartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartBox.TabIndex = 2;
            this.cartBox.TabStop = false;
            this.cartBox.Click += new System.EventHandler(this.cartBox_Click);
            // 
            // minicart48ptLeft
            // 
            this.minicart48ptLeft.BackColor = System.Drawing.Color.Transparent;
            this.minicart48ptLeft.Location = new System.Drawing.Point(-5, 38);
            this.minicart48ptLeft.Name = "minicart48ptLeft";
            this.minicart48ptLeft.Size = new System.Drawing.Size(310, 80);
            this.minicart48ptLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minicart48ptLeft.TabIndex = 4;
            this.minicart48ptLeft.TabStop = false;
            // 
            // searchIcon
            // 
            this.searchIcon.BackColor = System.Drawing.Color.Transparent;
            this.searchIcon.Location = new System.Drawing.Point(832, 55);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(26, 26);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchIcon.TabIndex = 5;
            this.searchIcon.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(2, 2);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(250, 28);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // itemPanel
            // 
            this.itemPanel.AutoScroll = true;
            this.itemPanel.BackColor = System.Drawing.Color.White;
            this.itemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.itemPanel.Location = new System.Drawing.Point(2, 2);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(1080, 485);
            this.itemPanel.TabIndex = 7;
            this.itemPanel.WrapContents = false;
            // 
            // cartPanel
            // 
            this.cartPanel.BackColor = System.Drawing.Color.White;
            this.cartPanel.Controls.Add(this.panel2);
            this.cartPanel.Controls.Add(this.panel1);
            this.cartPanel.Controls.Add(this.searchIcon);
            this.cartPanel.Controls.Add(this.minicart48ptLeft);
            this.cartPanel.Location = new System.Drawing.Point(2, 0);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(1160, 678);
            this.cartPanel.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(200)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.itemPanel);
            this.panel2.Location = new System.Drawing.Point(40, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 489);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(200)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Location = new System.Drawing.Point(870, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 33);
            this.panel1.TabIndex = 8;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.White;
            this.dashboardPanel.Controls.Add(this.mainLogo);
            this.dashboardPanel.Controls.Add(this.minicart48pt);
            this.dashboardPanel.Location = new System.Drawing.Point(2, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(1160, 678);
            this.dashboardPanel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(200)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1164, 681);
            this.Controls.Add(this.cartBox);
            this.Controls.Add(this.cartPanel);
            this.Controls.Add(this.dashboardPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 720);
            this.MinimumSize = new System.Drawing.Size(1180, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprobey Mini Cart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minicart48pt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minicart48ptLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.cartPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dashboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox minicart48pt;
        private System.Windows.Forms.PictureBox mainLogo;
        private System.Windows.Forms.PictureBox cartBox;
        private System.Windows.Forms.PictureBox minicart48ptLeft;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.FlowLayoutPanel itemPanel;
        private System.Windows.Forms.Panel cartPanel;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}


namespace MiniCart
{
    partial class ItemUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.image = new System.Windows.Forms.PictureBox();
            this.menuBox = new System.Windows.Forms.PictureBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.itemName);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.menuBox);
            this.panel1.Controls.Add(this.image);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 166);
            this.panel1.TabIndex = 0;
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image.Location = new System.Drawing.Point(15, 17);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(130, 130);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // menuBox
            // 
            this.menuBox.Location = new System.Drawing.Point(937, 15);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(45, 35);
            this.menuBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuBox.TabIndex = 1;
            this.menuBox.TabStop = false;
            this.menuBox.Click += new System.EventHandler(this.menuBox_Click);
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.idLabel.Location = new System.Drawing.Point(167, 23);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(100, 23);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "#001";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.quantity.Location = new System.Drawing.Point(170, 118);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(400, 32);
            this.quantity.TabIndex = 3;
            this.quantity.Text = "Available Stock :  69";
            this.quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.price.Location = new System.Drawing.Point(576, 118);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(406, 32);
            this.price.TabIndex = 4;
            this.price.Text = "$4.99";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.itemName.Location = new System.Drawing.Point(165, 46);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(717, 34);
            this.itemName.TabIndex = 5;
            this.itemName.Text = "Intel Core i9-11900K";
            this.itemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(200)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(30, 25, 30, 5);
            this.Name = "ItemUserControl";
            this.Size = new System.Drawing.Size(1000, 170);
            this.Load += new System.EventHandler(this.ItemUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.PictureBox menuBox;
        private System.Windows.Forms.PictureBox image;
    }
}

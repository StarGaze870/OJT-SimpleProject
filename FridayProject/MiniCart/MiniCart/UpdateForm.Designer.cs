namespace MiniCart
{
    partial class UpdateForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.editImage = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.deleteBox = new System.Windows.Forms.PictureBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.TextBox();
            this.minicart24pt = new System.Windows.Forms.PictureBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minicart24pt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.editImage);
            this.panel1.Controls.Add(this.image);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.deleteBox);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.itemName);
            this.panel1.Controls.Add(this.minicart24pt);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 596);
            this.panel1.TabIndex = 0;
            // 
            // editImage
            // 
            this.editImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editImage.ForeColor = System.Drawing.Color.Blue;
            this.editImage.Location = new System.Drawing.Point(379, 237);
            this.editImage.Name = "editImage";
            this.editImage.Size = new System.Drawing.Size(49, 20);
            this.editImage.TabIndex = 6;
            this.editImage.Text = "edit";
            this.editImage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.editImage.Click += new System.EventHandler(this.editImage_Click);
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(328, 134);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(100, 100);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 14;
            this.image.TabStop = false;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(74)))));
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.update.FlatAppearance.BorderSize = 2;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(262, 522);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(140, 35);
            this.update.TabIndex = 5;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(74)))));
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.cancel.FlatAppearance.BorderSize = 2;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(62, 522);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(140, 35);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(178, 423);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(250, 29);
            this.price.TabIndex = 3;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantity
            // 
            this.quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(178, 353);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(250, 29);
            this.quantity.TabIndex = 2;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(53, 134);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(35, 35);
            this.deleteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteBox.TabIndex = 9;
            this.deleteBox.TabStop = false;
            this.deleteBox.Click += new System.EventHandler(this.deleteBox_Click);
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(147, 209);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(175, 25);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "#001";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Name";
            // 
            // itemName
            // 
            this.itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(178, 282);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(250, 29);
            this.itemName.TabIndex = 1;
            this.itemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minicart24pt
            // 
            this.minicart24pt.BackColor = System.Drawing.Color.Transparent;
            this.minicart24pt.Location = new System.Drawing.Point(-25, 0);
            this.minicart24pt.Name = "minicart24pt";
            this.minicart24pt.Size = new System.Drawing.Size(515, 160);
            this.minicart24pt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minicart24pt.TabIndex = 1;
            this.minicart24pt.TabStop = false;
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(200)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(460, 600);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minicart24pt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minicart24pt;
        private System.Windows.Forms.PictureBox deleteBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label editImage;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}
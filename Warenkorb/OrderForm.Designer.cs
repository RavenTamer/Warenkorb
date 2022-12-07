namespace Warenkorb
{
    partial class OrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.quantitynum = new System.Windows.Forms.NumericUpDown();
            this.productbox = new System.Windows.Forms.TextBox();
            this.quantitylabel = new System.Windows.Forms.Label();
            this.productlabel = new System.Windows.Forms.Label();
            this.cartlabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cartcountlabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitynum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addbutton);
            this.groupBox1.Controls.Add(this.quantitynum);
            this.groupBox1.Controls.Add(this.productbox);
            this.groupBox1.Controls.Add(this.quantitylabel);
            this.groupBox1.Controls.Add(this.productlabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(79, 81);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(250, 23);
            this.addbutton.TabIndex = 4;
            this.addbutton.Text = "Zum Warenkorb hinzufügen";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // quantitynum
            // 
            this.quantitynum.Location = new System.Drawing.Point(79, 52);
            this.quantitynum.Maximum = new decimal(new int[] {
            700000,
            0,
            0,
            0});
            this.quantitynum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitynum.Name = "quantitynum";
            this.quantitynum.Size = new System.Drawing.Size(48, 23);
            this.quantitynum.TabIndex = 3;
            this.quantitynum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantitynum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productbox
            // 
            this.productbox.Location = new System.Drawing.Point(79, 16);
            this.productbox.Name = "productbox";
            this.productbox.Size = new System.Drawing.Size(250, 23);
            this.productbox.TabIndex = 2;
            // 
            // quantitylabel
            // 
            this.quantitylabel.AutoSize = true;
            this.quantitylabel.Location = new System.Drawing.Point(30, 54);
            this.quantitylabel.Name = "quantitylabel";
            this.quantitylabel.Size = new System.Drawing.Size(43, 15);
            this.quantitylabel.TabIndex = 1;
            this.quantitylabel.Text = "Anzahl";
            // 
            // productlabel
            // 
            this.productlabel.AutoSize = true;
            this.productlabel.Location = new System.Drawing.Point(24, 19);
            this.productlabel.Name = "productlabel";
            this.productlabel.Size = new System.Drawing.Size(49, 15);
            this.productlabel.TabIndex = 0;
            this.productlabel.Text = "Produkt";
            // 
            // cartlabel
            // 
            this.cartlabel.AutoSize = true;
            this.cartlabel.Location = new System.Drawing.Point(312, 19);
            this.cartlabel.Name = "cartlabel";
            this.cartlabel.Size = new System.Drawing.Size(115, 15);
            this.cartlabel.TabIndex = 1;
            this.cartlabel.TabStop = true;
            this.cartlabel.Text = "Warenkorb anzeigen";
            this.cartlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cartlabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Warenkorb.Properties.Resources.cart;
            this.pictureBox1.Location = new System.Drawing.Point(276, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cartcountlabel
            // 
            this.cartcountlabel.AutoSize = true;
            this.cartcountlabel.Location = new System.Drawing.Point(249, 19);
            this.cartcountlabel.Name = "cartcountlabel";
            this.cartcountlabel.Size = new System.Drawing.Size(21, 15);
            this.cartcountlabel.TabIndex = 3;
            this.cartcountlabel.Text = "(0)";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(439, 175);
            this.Controls.Add(this.cartcountlabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cartlabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitynum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button addbutton;
        private NumericUpDown quantitynum;
        private TextBox productbox;
        private Label quantitylabel;
        private Label productlabel;
        private LinkLabel cartlabel;
        private PictureBox pictureBox1;
        private Label cartcountlabel;
    }
}
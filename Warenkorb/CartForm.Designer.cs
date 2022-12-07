namespace Warenkorb
{
    partial class CartForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cartbox = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.yourcartlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Warenkorb.Properties.Resources.cart;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cartbox
            // 
            this.cartbox.Location = new System.Drawing.Point(12, 70);
            this.cartbox.Multiline = true;
            this.cartbox.Name = "cartbox";
            this.cartbox.ReadOnly = true;
            this.cartbox.Size = new System.Drawing.Size(342, 201);
            this.cartbox.TabIndex = 1;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(256, 296);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(86, 29);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Abbrechen";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // yourcartlabel
            // 
            this.yourcartlabel.AutoSize = true;
            this.yourcartlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yourcartlabel.Location = new System.Drawing.Point(65, 21);
            this.yourcartlabel.Name = "yourcartlabel";
            this.yourcartlabel.Size = new System.Drawing.Size(127, 21);
            this.yourcartlabel.TabIndex = 3;
            this.yourcartlabel.Text = "Dein Warenkorb";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(366, 351);
            this.Controls.Add(this.yourcartlabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.cartbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CartForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button cancel;
        private Label yourcartlabel;
        public TextBox cartbox;
    }
}
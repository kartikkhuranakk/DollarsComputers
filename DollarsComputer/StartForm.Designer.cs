namespace DollarsComputer
{
    partial class StartForm
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
            this.StartNewOrder = new System.Windows.Forms.Button();
            this.OpenSavedOrder = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartNewOrder
            // 
            this.StartNewOrder.Location = new System.Drawing.Point(85, 187);
            this.StartNewOrder.Name = "StartNewOrder";
            this.StartNewOrder.Size = new System.Drawing.Size(117, 23);
            this.StartNewOrder.TabIndex = 0;
            this.StartNewOrder.Text = "Start a New Order";
            this.StartNewOrder.UseVisualStyleBackColor = true;
            this.StartNewOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenSavedOrder
            // 
            this.OpenSavedOrder.Location = new System.Drawing.Point(85, 228);
            this.OpenSavedOrder.Name = "OpenSavedOrder";
            this.OpenSavedOrder.Size = new System.Drawing.Size(117, 23);
            this.OpenSavedOrder.TabIndex = 1;
            this.OpenSavedOrder.Text = "Open a Saved Order";
            this.OpenSavedOrder.UseVisualStyleBackColor = true;
            this.OpenSavedOrder.Click += new System.EventHandler(this.OpenSavedOrder_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(85, 268);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(117, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Your Computer Today!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DollarsComputer.Properties.Resources._26453672_Computer_Display_and_Gold_Coin_Dollar_Icon_Stock_Vector;
            this.pictureBox1.Location = new System.Drawing.Point(85, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(305, 303);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.OpenSavedOrder);
            this.Controls.Add(this.StartNewOrder);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartNewOrder;
        private System.Windows.Forms.Button OpenSavedOrder;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
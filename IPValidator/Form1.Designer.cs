namespace IPValidator
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
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.verifyButton = new System.Windows.Forms.Button();
            this.addressValidLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(47, 52);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(100, 23);
            this.ipAddressTextBox.TabIndex = 0;
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(47, 34);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(50, 15);
            this.ipAddressLabel.TabIndex = 1;
            this.ipAddressLabel.Text = "Adres IP";
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(47, 81);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(75, 23);
            this.verifyButton.TabIndex = 2;
            this.verifyButton.Text = "Sprawdź!";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // addressValidLabel
            // 
            this.addressValidLabel.AutoSize = true;
            this.addressValidLabel.Location = new System.Drawing.Point(47, 107);
            this.addressValidLabel.Name = "addressValidLabel";
            this.addressValidLabel.Size = new System.Drawing.Size(114, 15);
            this.addressValidLabel.TabIndex = 3;
            this.addressValidLabel.Text = "Adres jest poprawny";
            this.addressValidLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addressValidLabel);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.ipAddressLabel);
            this.Controls.Add(this.ipAddressTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ipAddressTextBox;
        private Label ipAddressLabel;
        private Button verifyButton;
        private Label addressValidLabel;
    }
}
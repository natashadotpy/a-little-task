
namespace a_little_task
{
    partial class Form1
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
            this.safeStatusLabel = new System.Windows.Forms.Label();
            this.safeStatusTextbox = new System.Windows.Forms.TextBox();
            this.enterKeyLabel = new System.Windows.Forms.Label();
            this.keyTextbox = new System.Windows.Forms.TextBox();
            this.testKeyButton = new System.Windows.Forms.Button();
            this.setCombinationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // safeStatusLabel
            // 
            this.safeStatusLabel.AutoSize = true;
            this.safeStatusLabel.Location = new System.Drawing.Point(132, 38);
            this.safeStatusLabel.Name = "safeStatusLabel";
            this.safeStatusLabel.Size = new System.Drawing.Size(62, 13);
            this.safeStatusLabel.TabIndex = 0;
            this.safeStatusLabel.Text = "Safe Status";
            // 
            // safeStatusTextbox
            // 
            this.safeStatusTextbox.BackColor = System.Drawing.Color.Coral;
            this.safeStatusTextbox.Location = new System.Drawing.Point(94, 54);
            this.safeStatusTextbox.Name = "safeStatusTextbox";
            this.safeStatusTextbox.ReadOnly = true;
            this.safeStatusTextbox.Size = new System.Drawing.Size(147, 20);
            this.safeStatusTextbox.TabIndex = 1;
            this.safeStatusTextbox.Text = "Combination not set";
            this.safeStatusTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enterKeyLabel
            // 
            this.enterKeyLabel.AutoSize = true;
            this.enterKeyLabel.Location = new System.Drawing.Point(125, 104);
            this.enterKeyLabel.Name = "enterKeyLabel";
            this.enterKeyLabel.Size = new System.Drawing.Size(75, 13);
            this.enterKeyLabel.TabIndex = 2;
            this.enterKeyLabel.Text = "Enter The Key";
            // 
            // keyTextbox
            // 
            this.keyTextbox.Location = new System.Drawing.Point(115, 120);
            this.keyTextbox.Name = "keyTextbox";
            this.keyTextbox.PasswordChar = '*';
            this.keyTextbox.Size = new System.Drawing.Size(100, 20);
            this.keyTextbox.TabIndex = 3;
            this.keyTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // testKeyButton
            // 
            this.testKeyButton.Location = new System.Drawing.Point(128, 146);
            this.testKeyButton.Name = "testKeyButton";
            this.testKeyButton.Size = new System.Drawing.Size(75, 23);
            this.testKeyButton.TabIndex = 4;
            this.testKeyButton.Text = "Test Key";
            this.testKeyButton.UseVisualStyleBackColor = true;
            this.testKeyButton.Click += new System.EventHandler(this.testKeyButton_Click);
            // 
            // setCombinationButton
            // 
            this.setCombinationButton.Location = new System.Drawing.Point(111, 189);
            this.setCombinationButton.Name = "setCombinationButton";
            this.setCombinationButton.Size = new System.Drawing.Size(104, 23);
            this.setCombinationButton.TabIndex = 5;
            this.setCombinationButton.Text = "Set Combination";
            this.setCombinationButton.UseVisualStyleBackColor = true;
            this.setCombinationButton.Click += new System.EventHandler(this.setCombinationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(335, 302);
            this.Controls.Add(this.setCombinationButton);
            this.Controls.Add(this.testKeyButton);
            this.Controls.Add(this.keyTextbox);
            this.Controls.Add(this.enterKeyLabel);
            this.Controls.Add(this.safeStatusTextbox);
            this.Controls.Add(this.safeStatusLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label safeStatusLabel;
        private System.Windows.Forms.TextBox safeStatusTextbox;
        private System.Windows.Forms.Label enterKeyLabel;
        private System.Windows.Forms.TextBox keyTextbox;
        private System.Windows.Forms.Button testKeyButton;
        private System.Windows.Forms.Button setCombinationButton;
    }
}


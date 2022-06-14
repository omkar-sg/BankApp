namespace BankApp
{
    partial class Form3
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
            this.fixedDipositGroupBox = new System.Windows.Forms.GroupBox();
            this.viewFDButton = new System.Windows.Forms.Button();
            this.createFDButton = new System.Windows.Forms.Button();
            this.createFDTextBox = new System.Windows.Forms.TextBox();
            this.recurringDipositGroupBox = new System.Windows.Forms.GroupBox();
            this.viewRDButton = new System.Windows.Forms.Button();
            this.createRDButton = new System.Windows.Forms.Button();
            this.createRDTextBox = new System.Windows.Forms.TextBox();
            this.fixedDipositGroupBox.SuspendLayout();
            this.recurringDipositGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fixedDipositGroupBox
            // 
            this.fixedDipositGroupBox.Controls.Add(this.viewFDButton);
            this.fixedDipositGroupBox.Controls.Add(this.createFDButton);
            this.fixedDipositGroupBox.Controls.Add(this.createFDTextBox);
            this.fixedDipositGroupBox.Location = new System.Drawing.Point(39, 106);
            this.fixedDipositGroupBox.Name = "fixedDipositGroupBox";
            this.fixedDipositGroupBox.Size = new System.Drawing.Size(309, 210);
            this.fixedDipositGroupBox.TabIndex = 0;
            this.fixedDipositGroupBox.TabStop = false;
            this.fixedDipositGroupBox.Text = "Fixed Diposit";
            // 
            // viewFDButton
            // 
            this.viewFDButton.Location = new System.Drawing.Point(92, 145);
            this.viewFDButton.Name = "viewFDButton";
            this.viewFDButton.Size = new System.Drawing.Size(75, 23);
            this.viewFDButton.TabIndex = 2;
            this.viewFDButton.Text = "View FD";
            this.viewFDButton.UseVisualStyleBackColor = true;
            this.viewFDButton.Click += new System.EventHandler(this.viewFDButton_Click);
            // 
            // createFDButton
            // 
            this.createFDButton.Location = new System.Drawing.Point(195, 65);
            this.createFDButton.Name = "createFDButton";
            this.createFDButton.Size = new System.Drawing.Size(75, 23);
            this.createFDButton.TabIndex = 1;
            this.createFDButton.Text = "Create FD";
            this.createFDButton.UseVisualStyleBackColor = true;
            this.createFDButton.Click += new System.EventHandler(this.createFDButton_Click);
            // 
            // createFDTextBox
            // 
            this.createFDTextBox.Location = new System.Drawing.Point(35, 65);
            this.createFDTextBox.Name = "createFDTextBox";
            this.createFDTextBox.Size = new System.Drawing.Size(100, 22);
            this.createFDTextBox.TabIndex = 0;
            // 
            // recurringDipositGroupBox
            // 
            this.recurringDipositGroupBox.Controls.Add(this.viewRDButton);
            this.recurringDipositGroupBox.Controls.Add(this.createRDButton);
            this.recurringDipositGroupBox.Controls.Add(this.createRDTextBox);
            this.recurringDipositGroupBox.Location = new System.Drawing.Point(433, 106);
            this.recurringDipositGroupBox.Name = "recurringDipositGroupBox";
            this.recurringDipositGroupBox.Size = new System.Drawing.Size(316, 210);
            this.recurringDipositGroupBox.TabIndex = 1;
            this.recurringDipositGroupBox.TabStop = false;
            this.recurringDipositGroupBox.Text = "Recurring Diposit";
            // 
            // viewRDButton
            // 
            this.viewRDButton.Location = new System.Drawing.Point(122, 145);
            this.viewRDButton.Name = "viewRDButton";
            this.viewRDButton.Size = new System.Drawing.Size(75, 23);
            this.viewRDButton.TabIndex = 3;
            this.viewRDButton.Text = "View RD";
            this.viewRDButton.UseVisualStyleBackColor = true;
            this.viewRDButton.Click += new System.EventHandler(this.viewRDButton_Click);
            // 
            // createRDButton
            // 
            this.createRDButton.Location = new System.Drawing.Point(200, 65);
            this.createRDButton.Name = "createRDButton";
            this.createRDButton.Size = new System.Drawing.Size(75, 23);
            this.createRDButton.TabIndex = 3;
            this.createRDButton.Text = "Create RD";
            this.createRDButton.UseVisualStyleBackColor = true;
            this.createRDButton.Click += new System.EventHandler(this.createRDButton_Click);
            // 
            // createRDTextBox
            // 
            this.createRDTextBox.Location = new System.Drawing.Point(16, 65);
            this.createRDTextBox.Name = "createRDTextBox";
            this.createRDTextBox.Size = new System.Drawing.Size(100, 22);
            this.createRDTextBox.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recurringDipositGroupBox);
            this.Controls.Add(this.fixedDipositGroupBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.fixedDipositGroupBox.ResumeLayout(false);
            this.fixedDipositGroupBox.PerformLayout();
            this.recurringDipositGroupBox.ResumeLayout(false);
            this.recurringDipositGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fixedDipositGroupBox;
        private System.Windows.Forms.Button viewFDButton;
        private System.Windows.Forms.Button createFDButton;
        private System.Windows.Forms.TextBox createFDTextBox;
        private System.Windows.Forms.GroupBox recurringDipositGroupBox;
        private System.Windows.Forms.Button viewRDButton;
        private System.Windows.Forms.Button createRDButton;
        private System.Windows.Forms.TextBox createRDTextBox;
    }
}
namespace BankApp
{
    partial class Form2
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.accountDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.accountType1Label = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.widrawButton = new System.Windows.Forms.Button();
            this.viewBalanceButton = new System.Windows.Forms.Button();
            this.depositeButton = new System.Windows.Forms.Button();
            this.depositeTextBox = new System.Windows.Forms.TextBox();
            this.widrawTextBox = new System.Windows.Forms.TextBox();
            this.fixedDipositeGroupBox = new System.Windows.Forms.GroupBox();
            this.viewFixedDipositeLabel = new System.Windows.Forms.Label();
            this.viewFixedDipositeButton = new System.Windows.Forms.Button();
            this.createFixedDipositeButton = new System.Windows.Forms.Button();
            this.createFixedDipositeTextBox = new System.Windows.Forms.TextBox();
            this.createFixedDipositeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStrip = new System.Windows.Forms.ToolStripComboBox();
            this.investmentToolStrip = new System.Windows.Forms.ToolStripComboBox();
            this.accountDetailsGroupBox.SuspendLayout();
            this.fixedDipositeGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(104, 40);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(223, 29);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome To Bank !";
            // 
            // accountDetailsGroupBox
            // 
            this.accountDetailsGroupBox.Controls.Add(this.ageLabel);
            this.accountDetailsGroupBox.Controls.Add(this.ageNameLabel);
            this.accountDetailsGroupBox.Controls.Add(this.lastNameLabel);
            this.accountDetailsGroupBox.Controls.Add(this.accountType1Label);
            this.accountDetailsGroupBox.Controls.Add(this.fullNameLabel);
            this.accountDetailsGroupBox.Controls.Add(this.accountTypeLabel);
            this.accountDetailsGroupBox.Controls.Add(this.nameLabel);
            this.accountDetailsGroupBox.Controls.Add(this.widrawButton);
            this.accountDetailsGroupBox.Controls.Add(this.viewBalanceButton);
            this.accountDetailsGroupBox.Controls.Add(this.depositeButton);
            this.accountDetailsGroupBox.Controls.Add(this.depositeTextBox);
            this.accountDetailsGroupBox.Controls.Add(this.widrawTextBox);
            this.accountDetailsGroupBox.Location = new System.Drawing.Point(25, 83);
            this.accountDetailsGroupBox.Name = "accountDetailsGroupBox";
            this.accountDetailsGroupBox.Size = new System.Drawing.Size(430, 342);
            this.accountDetailsGroupBox.TabIndex = 1;
            this.accountDetailsGroupBox.TabStop = false;
            this.accountDetailsGroupBox.Text = "Account Details";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(345, 84);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(32, 16);
            this.ageLabel.TabIndex = 11;
            this.ageLabel.Text = "Age";
            // 
            // ageNameLabel
            // 
            this.ageNameLabel.AutoSize = true;
            this.ageNameLabel.Location = new System.Drawing.Point(292, 84);
            this.ageNameLabel.Name = "ageNameLabel";
            this.ageNameLabel.Size = new System.Drawing.Size(38, 16);
            this.ageNameLabel.TabIndex = 10;
            this.ageNameLabel.Text = "Age :";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(199, 45);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(72, 16);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last Name";
            // 
            // accountType1Label
            // 
            this.accountType1Label.AutoSize = true;
            this.accountType1Label.Location = new System.Drawing.Point(27, 84);
            this.accountType1Label.Name = "accountType1Label";
            this.accountType1Label.Size = new System.Drawing.Size(96, 16);
            this.accountType1Label.TabIndex = 8;
            this.accountType1Label.Text = "Account Type :";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(27, 45);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(50, 16);
            this.fullNameLabel.TabIndex = 7;
            this.fullNameLabel.Text = "Name :";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(129, 84);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(90, 16);
            this.accountTypeLabel.TabIndex = 6;
            this.accountTypeLabel.Text = "Account Type";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(129, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // widrawButton
            // 
            this.widrawButton.Location = new System.Drawing.Point(267, 149);
            this.widrawButton.Name = "widrawButton";
            this.widrawButton.Size = new System.Drawing.Size(75, 34);
            this.widrawButton.TabIndex = 4;
            this.widrawButton.Text = "Withdraw";
            this.widrawButton.UseVisualStyleBackColor = true;
            this.widrawButton.Click += new System.EventHandler(this.widrawButton_Click);
            // 
            // viewBalanceButton
            // 
            this.viewBalanceButton.Location = new System.Drawing.Point(109, 282);
            this.viewBalanceButton.Name = "viewBalanceButton";
            this.viewBalanceButton.Size = new System.Drawing.Size(162, 40);
            this.viewBalanceButton.TabIndex = 2;
            this.viewBalanceButton.Text = "View Balance";
            this.viewBalanceButton.UseVisualStyleBackColor = true;
            this.viewBalanceButton.Click += new System.EventHandler(this.viewBalanceButton_Click);
            // 
            // depositeButton
            // 
            this.depositeButton.Location = new System.Drawing.Point(267, 199);
            this.depositeButton.Name = "depositeButton";
            this.depositeButton.Size = new System.Drawing.Size(75, 34);
            this.depositeButton.TabIndex = 3;
            this.depositeButton.Text = "Deposite";
            this.depositeButton.UseVisualStyleBackColor = true;
            this.depositeButton.Click += new System.EventHandler(this.depositeButton_Click);
            // 
            // depositeTextBox
            // 
            this.depositeTextBox.Location = new System.Drawing.Point(84, 211);
            this.depositeTextBox.Name = "depositeTextBox";
            this.depositeTextBox.Size = new System.Drawing.Size(135, 22);
            this.depositeTextBox.TabIndex = 1;
            // 
            // widrawTextBox
            // 
            this.widrawTextBox.Location = new System.Drawing.Point(84, 161);
            this.widrawTextBox.Name = "widrawTextBox";
            this.widrawTextBox.Size = new System.Drawing.Size(135, 22);
            this.widrawTextBox.TabIndex = 0;
            // 
            // fixedDipositeGroupBox
            // 
            this.fixedDipositeGroupBox.Controls.Add(this.viewFixedDipositeLabel);
            this.fixedDipositeGroupBox.Controls.Add(this.viewFixedDipositeButton);
            this.fixedDipositeGroupBox.Controls.Add(this.createFixedDipositeButton);
            this.fixedDipositeGroupBox.Controls.Add(this.createFixedDipositeTextBox);
            this.fixedDipositeGroupBox.Controls.Add(this.createFixedDipositeLabel);
            this.fixedDipositeGroupBox.Location = new System.Drawing.Point(474, 83);
            this.fixedDipositeGroupBox.Name = "fixedDipositeGroupBox";
            this.fixedDipositeGroupBox.Size = new System.Drawing.Size(307, 258);
            this.fixedDipositeGroupBox.TabIndex = 2;
            this.fixedDipositeGroupBox.TabStop = false;
            this.fixedDipositeGroupBox.Text = "Fixed Diposit";
            // 
            // viewFixedDipositeLabel
            // 
            this.viewFixedDipositeLabel.AutoSize = true;
            this.viewFixedDipositeLabel.Location = new System.Drawing.Point(16, 155);
            this.viewFixedDipositeLabel.Name = "viewFixedDipositeLabel";
            this.viewFixedDipositeLabel.Size = new System.Drawing.Size(117, 16);
            this.viewFixedDipositeLabel.TabIndex = 4;
            this.viewFixedDipositeLabel.Text = "View Fixed Diposit";
            // 
            // viewFixedDipositeButton
            // 
            this.viewFixedDipositeButton.Location = new System.Drawing.Point(84, 199);
            this.viewFixedDipositeButton.Name = "viewFixedDipositeButton";
            this.viewFixedDipositeButton.Size = new System.Drawing.Size(123, 27);
            this.viewFixedDipositeButton.TabIndex = 3;
            this.viewFixedDipositeButton.Text = "View ";
            this.viewFixedDipositeButton.UseVisualStyleBackColor = true;
            this.viewFixedDipositeButton.Click += new System.EventHandler(this.viewFixedDipositeButton_Click);
            // 
            // createFixedDipositeButton
            // 
            this.createFixedDipositeButton.Location = new System.Drawing.Point(184, 93);
            this.createFixedDipositeButton.Name = "createFixedDipositeButton";
            this.createFixedDipositeButton.Size = new System.Drawing.Size(75, 23);
            this.createFixedDipositeButton.TabIndex = 2;
            this.createFixedDipositeButton.Text = "Create";
            this.createFixedDipositeButton.UseVisualStyleBackColor = true;
            this.createFixedDipositeButton.Click += new System.EventHandler(this.createFixedDipositeButton_Click);
            // 
            // createFixedDipositeTextBox
            // 
            this.createFixedDipositeTextBox.Location = new System.Drawing.Point(38, 93);
            this.createFixedDipositeTextBox.Name = "createFixedDipositeTextBox";
            this.createFixedDipositeTextBox.Size = new System.Drawing.Size(100, 22);
            this.createFixedDipositeTextBox.TabIndex = 1;
            // 
            // createFixedDipositeLabel
            // 
            this.createFixedDipositeLabel.AutoSize = true;
            this.createFixedDipositeLabel.Location = new System.Drawing.Point(16, 58);
            this.createFixedDipositeLabel.Name = "createFixedDipositeLabel";
            this.createFixedDipositeLabel.Size = new System.Drawing.Size(128, 16);
            this.createFixedDipositeLabel.TabIndex = 0;
            this.createFixedDipositeLabel.Text = "Create Fixed Diposit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStrip,
            this.investmentToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Investment";
            // 
            // accountToolStrip
            // 
            this.accountToolStrip.Name = "accountToolStrip";
            this.accountToolStrip.Size = new System.Drawing.Size(121, 28);
            this.accountToolStrip.Text = "Account";
            this.accountToolStrip.Click += new System.EventHandler(this.accountToolStrip_Click);
            // 
            // investmentToolStrip
            // 
            this.investmentToolStrip.Name = "investmentToolStrip";
            this.investmentToolStrip.Size = new System.Drawing.Size(121, 28);
            this.investmentToolStrip.Text = "Investment";
            this.investmentToolStrip.Click += new System.EventHandler(this.investmentToolStrip_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fixedDipositeGroupBox);
            this.Controls.Add(this.accountDetailsGroupBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.accountDetailsGroupBox.ResumeLayout(false);
            this.accountDetailsGroupBox.PerformLayout();
            this.fixedDipositeGroupBox.ResumeLayout(false);
            this.fixedDipositeGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.GroupBox accountDetailsGroupBox;
        private System.Windows.Forms.TextBox depositeTextBox;
        private System.Windows.Forms.TextBox widrawTextBox;
        private System.Windows.Forms.Button widrawButton;
        private System.Windows.Forms.Button depositeButton;
        private System.Windows.Forms.Button viewBalanceButton;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox fixedDipositeGroupBox;
        private System.Windows.Forms.Label viewFixedDipositeLabel;
        private System.Windows.Forms.Button viewFixedDipositeButton;
        private System.Windows.Forms.Button createFixedDipositeButton;
        private System.Windows.Forms.TextBox createFixedDipositeTextBox;
        private System.Windows.Forms.Label createFixedDipositeLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label accountType1Label;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label ageNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox accountToolStrip;
        private System.Windows.Forms.ToolStripComboBox investmentToolStrip;
    }
}
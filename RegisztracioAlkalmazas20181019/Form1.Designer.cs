namespace RegisztracioAlkalmazas20181019
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.bDateTextBox = new System.Windows.Forms.TextBox();
            this.addNewHobbieTextBox = new System.Windows.Forms.TextBox();
            this.addNewHobbieButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.bDateLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.hobbiesLabel = new System.Windows.Forms.Label();
            this.newHobbieLabel = new System.Windows.Forms.Label();
            this.hobbiesListBox = new System.Windows.Forms.ListBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // bDateTextBox
            // 
            this.bDateTextBox.Location = new System.Drawing.Point(85, 68);
            this.bDateTextBox.Name = "bDateTextBox";
            this.bDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.bDateTextBox.TabIndex = 1;
            // 
            // addNewHobbieTextBox
            // 
            this.addNewHobbieTextBox.Location = new System.Drawing.Point(268, 193);
            this.addNewHobbieTextBox.Name = "addNewHobbieTextBox";
            this.addNewHobbieTextBox.Size = new System.Drawing.Size(100, 20);
            this.addNewHobbieTextBox.TabIndex = 3;
            // 
            // addNewHobbieButton
            // 
            this.addNewHobbieButton.Location = new System.Drawing.Point(268, 219);
            this.addNewHobbieButton.Name = "addNewHobbieButton";
            this.addNewHobbieButton.Size = new System.Drawing.Size(75, 23);
            this.addNewHobbieButton.TabIndex = 4;
            this.addNewHobbieButton.Text = "Hozzád";
            this.addNewHobbieButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(226, 313);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Mentés";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(334, 313);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 6;
            this.openButton.Text = "Betöltés";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(85, 114);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(31, 17);
            this.maleRadioButton.TabIndex = 7;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "F";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(137, 114);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(33, 17);
            this.femaleRadioButton.TabIndex = 8;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "N";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Név: ";
            // 
            // bDateLabel
            // 
            this.bDateLabel.AutoSize = true;
            this.bDateLabel.Location = new System.Drawing.Point(13, 68);
            this.bDateLabel.Name = "bDateLabel";
            this.bDateLabel.Size = new System.Drawing.Size(64, 13);
            this.bDateLabel.TabIndex = 10;
            this.bDateLabel.Text = "Szül. Dátum";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(13, 114);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(35, 13);
            this.sexLabel.TabIndex = 11;
            this.sexLabel.Text = "Nem: ";
            // 
            // hobbiesLabel
            // 
            this.hobbiesLabel.AutoSize = true;
            this.hobbiesLabel.Location = new System.Drawing.Point(265, 9);
            this.hobbiesLabel.Name = "hobbiesLabel";
            this.hobbiesLabel.Size = new System.Drawing.Size(85, 13);
            this.hobbiesLabel.TabIndex = 12;
            this.hobbiesLabel.Text = "Kedvenc hobbi: ";
            // 
            // newHobbieLabel
            // 
            this.newHobbieLabel.AutoSize = true;
            this.newHobbieLabel.Location = new System.Drawing.Point(180, 196);
            this.newHobbieLabel.Name = "newHobbieLabel";
            this.newHobbieLabel.Size = new System.Drawing.Size(52, 13);
            this.newHobbieLabel.TabIndex = 13;
            this.newHobbieLabel.Text = "Új hobbi: ";
            // 
            // hobbiesListBox
            // 
            this.hobbiesListBox.FormattingEnabled = true;
            this.hobbiesListBox.Location = new System.Drawing.Point(268, 32);
            this.hobbiesListBox.Name = "hobbiesListBox";
            this.hobbiesListBox.Size = new System.Drawing.Size(120, 95);
            this.hobbiesListBox.TabIndex = 14;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 348);
            this.Controls.Add(this.hobbiesListBox);
            this.Controls.Add(this.newHobbieLabel);
            this.Controls.Add(this.hobbiesLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.bDateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addNewHobbieButton);
            this.Controls.Add(this.addNewHobbieTextBox);
            this.Controls.Add(this.bDateTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox bDateTextBox;
        private System.Windows.Forms.TextBox addNewHobbieTextBox;
        private System.Windows.Forms.Button addNewHobbieButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label bDateLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label hobbiesLabel;
        private System.Windows.Forms.Label newHobbieLabel;
        private System.Windows.Forms.ListBox hobbiesListBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


namespace FlatSharpTest
{
    partial class MainApp
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
            SerializeDataButton = new System.Windows.Forms.Button();
            PersonNameTextBox = new System.Windows.Forms.TextBox();
            PersonFavColorComboBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            LocationPanel = new System.Windows.Forms.Panel();
            PersonLatTextBox = new System.Windows.Forms.TextBox();
            PersonLongTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            LocationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SerializeDataButton
            // 
            SerializeDataButton.Location = new System.Drawing.Point(604, 38);
            SerializeDataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            SerializeDataButton.Name = "SerializeDataButton";
            SerializeDataButton.Size = new System.Drawing.Size(129, 29);
            SerializeDataButton.TabIndex = 0;
            SerializeDataButton.Text = "Write File";
            SerializeDataButton.UseVisualStyleBackColor = true;
            SerializeDataButton.Click += SerializeDataButton_Click;
            // 
            // PersonNameTextBox
            // 
            PersonNameTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            PersonNameTextBox.ForeColor = System.Drawing.SystemColors.Control;
            PersonNameTextBox.Location = new System.Drawing.Point(15, 38);
            PersonNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            PersonNameTextBox.Name = "PersonNameTextBox";
            PersonNameTextBox.Size = new System.Drawing.Size(418, 29);
            PersonNameTextBox.TabIndex = 1;
            // 
            // PersonFavColorComboBox
            // 
            PersonFavColorComboBox.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            PersonFavColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            PersonFavColorComboBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            PersonFavColorComboBox.FormattingEnabled = true;
            PersonFavColorComboBox.Items.AddRange(new object[] { "Red", "Green", "Blue" });
            PersonFavColorComboBox.Location = new System.Drawing.Point(442, 38);
            PersonFavColorComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            PersonFavColorComboBox.Name = "PersonFavColorComboBox";
            PersonFavColorComboBox.Size = new System.Drawing.Size(154, 29);
            PersonFavColorComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(15, 13);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 21);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(442, 11);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 21);
            label2.TabIndex = 4;
            label2.Text = "Color";
            // 
            // LocationPanel
            // 
            LocationPanel.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            LocationPanel.Controls.Add(label5);
            LocationPanel.Controls.Add(PersonLatTextBox);
            LocationPanel.Controls.Add(PersonLongTextBox);
            LocationPanel.Controls.Add(label3);
            LocationPanel.Controls.Add(label4);
            LocationPanel.Location = new System.Drawing.Point(15, 100);
            LocationPanel.Name = "LocationPanel";
            LocationPanel.Size = new System.Drawing.Size(213, 221);
            LocationPanel.TabIndex = 9;
            // 
            // PersonLatTextBox
            // 
            PersonLatTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            PersonLatTextBox.ForeColor = System.Drawing.SystemColors.Control;
            PersonLatTextBox.Location = new System.Drawing.Point(16, 100);
            PersonLatTextBox.Margin = new System.Windows.Forms.Padding(4);
            PersonLatTextBox.Name = "PersonLatTextBox";
            PersonLatTextBox.Size = new System.Drawing.Size(128, 29);
            PersonLatTextBox.TabIndex = 12;
            // 
            // PersonLongTextBox
            // 
            PersonLongTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            PersonLongTextBox.ForeColor = System.Drawing.SystemColors.Control;
            PersonLongTextBox.Location = new System.Drawing.Point(16, 157);
            PersonLongTextBox.Margin = new System.Windows.Forms.Padding(4);
            PersonLongTextBox.Name = "PersonLongTextBox";
            PersonLongTextBox.Size = new System.Drawing.Size(128, 29);
            PersonLongTextBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(14, 75);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 21);
            label3.TabIndex = 10;
            label3.Text = "Latitude";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(14, 133);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 21);
            label4.TabIndex = 9;
            label4.Text = "Longitude";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.MediumAquamarine;
            label5.Location = new System.Drawing.Point(14, 15);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(124, 21);
            label5.TabIndex = 13;
            label5.Text = "LOCATION INFO";
            // 
            // MainApp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            ClientSize = new System.Drawing.Size(1029, 630);
            Controls.Add(LocationPanel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PersonFavColorComboBox);
            Controls.Add(PersonNameTextBox);
            Controls.Add(SerializeDataButton);
            Font = new System.Drawing.Font("Segoe UI", 12F);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "MainApp";
            Text = "Flatbuffer Test App";
            LocationPanel.ResumeLayout(false);
            LocationPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button SerializeDataButton;
        private System.Windows.Forms.TextBox PersonNameTextBox;
        private System.Windows.Forms.ComboBox PersonFavColorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LocationPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PersonLatTextBox;
        private System.Windows.Forms.TextBox PersonLongTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
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
            LocationPanel = new System.Windows.Forms.Panel();
            PersonLongUpDown = new System.Windows.Forms.NumericUpDown();
            PersonLatUpDown = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            DeserializeDataButton = new System.Windows.Forms.Button();
            BasicInformationPanel = new System.Windows.Forms.Panel();
            ActiveCheckBox = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            PersonFavColorComboBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            PersonNameTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            BrowseFilePath = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            DataFilePath = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            RenderEditorViewButton = new System.Windows.Forms.Button();
            CharacterMapperViewButton = new System.Windows.Forms.Button();
            LocationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PersonLongUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonLatUpDown).BeginInit();
            BasicInformationPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SerializeDataButton
            // 
            SerializeDataButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            SerializeDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SerializeDataButton.ForeColor = System.Drawing.SystemColors.Control;
            SerializeDataButton.Location = new System.Drawing.Point(985, 11);
            SerializeDataButton.Margin = new System.Windows.Forms.Padding(4);
            SerializeDataButton.Name = "SerializeDataButton";
            SerializeDataButton.Size = new System.Drawing.Size(129, 61);
            SerializeDataButton.TabIndex = 0;
            SerializeDataButton.Text = "Serialize\r\nData";
            SerializeDataButton.UseVisualStyleBackColor = true;
            SerializeDataButton.Click += SerializeDataButton_Click;
            // 
            // LocationPanel
            // 
            LocationPanel.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            LocationPanel.Controls.Add(PersonLongUpDown);
            LocationPanel.Controls.Add(PersonLatUpDown);
            LocationPanel.Controls.Add(label5);
            LocationPanel.Controls.Add(label3);
            LocationPanel.Controls.Add(label4);
            LocationPanel.Location = new System.Drawing.Point(626, 177);
            LocationPanel.Name = "LocationPanel";
            LocationPanel.Size = new System.Drawing.Size(283, 141);
            LocationPanel.TabIndex = 9;
            // 
            // PersonLongUpDown
            // 
            PersonLongUpDown.DecimalPlaces = 1;
            PersonLongUpDown.Location = new System.Drawing.Point(144, 83);
            PersonLongUpDown.Name = "PersonLongUpDown";
            PersonLongUpDown.Size = new System.Drawing.Size(120, 29);
            PersonLongUpDown.TabIndex = 15;
            // 
            // PersonLatUpDown
            // 
            PersonLatUpDown.DecimalPlaces = 1;
            PersonLatUpDown.Location = new System.Drawing.Point(18, 84);
            PersonLatUpDown.Name = "PersonLatUpDown";
            PersonLatUpDown.Size = new System.Drawing.Size(120, 29);
            PersonLatUpDown.TabIndex = 14;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(14, 60);
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
            label4.Location = new System.Drawing.Point(140, 59);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 21);
            label4.TabIndex = 9;
            label4.Text = "Longitude";
            // 
            // DeserializeDataButton
            // 
            DeserializeDataButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            DeserializeDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DeserializeDataButton.ForeColor = System.Drawing.SystemColors.Control;
            DeserializeDataButton.Location = new System.Drawing.Point(985, 80);
            DeserializeDataButton.Margin = new System.Windows.Forms.Padding(4);
            DeserializeDataButton.Name = "DeserializeDataButton";
            DeserializeDataButton.Size = new System.Drawing.Size(129, 61);
            DeserializeDataButton.TabIndex = 10;
            DeserializeDataButton.Text = "Deserialize Data";
            DeserializeDataButton.UseVisualStyleBackColor = true;
            DeserializeDataButton.Click += DeserializeDataButton_Click;
            // 
            // BasicInformationPanel
            // 
            BasicInformationPanel.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            BasicInformationPanel.Controls.Add(ActiveCheckBox);
            BasicInformationPanel.Controls.Add(label2);
            BasicInformationPanel.Controls.Add(PersonFavColorComboBox);
            BasicInformationPanel.Controls.Add(label1);
            BasicInformationPanel.Controls.Add(PersonNameTextBox);
            BasicInformationPanel.Controls.Add(label6);
            BasicInformationPanel.Location = new System.Drawing.Point(12, 177);
            BasicInformationPanel.Name = "BasicInformationPanel";
            BasicInformationPanel.Size = new System.Drawing.Size(608, 183);
            BasicInformationPanel.TabIndex = 11;
            // 
            // ActiveCheckBox
            // 
            ActiveCheckBox.AutoSize = true;
            ActiveCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            ActiveCheckBox.Location = new System.Drawing.Point(14, 139);
            ActiveCheckBox.Name = "ActiveCheckBox";
            ActiveCheckBox.Size = new System.Drawing.Size(122, 25);
            ActiveCheckBox.TabIndex = 18;
            ActiveCheckBox.Text = "Active Person";
            ActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(440, 58);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 21);
            label2.TabIndex = 17;
            label2.Text = "Color";
            // 
            // PersonFavColorComboBox
            // 
            PersonFavColorComboBox.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            PersonFavColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            PersonFavColorComboBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            PersonFavColorComboBox.FormattingEnabled = true;
            PersonFavColorComboBox.Items.AddRange(new object[] { "Red", "Green", "Blue", "Orange" });
            PersonFavColorComboBox.Location = new System.Drawing.Point(440, 83);
            PersonFavColorComboBox.Margin = new System.Windows.Forms.Padding(4);
            PersonFavColorComboBox.Name = "PersonFavColorComboBox";
            PersonFavColorComboBox.Size = new System.Drawing.Size(154, 29);
            PersonFavColorComboBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(14, 58);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 21);
            label1.TabIndex = 15;
            label1.Text = "Name";
            // 
            // PersonNameTextBox
            // 
            PersonNameTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            PersonNameTextBox.ForeColor = System.Drawing.SystemColors.Control;
            PersonNameTextBox.Location = new System.Drawing.Point(14, 83);
            PersonNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            PersonNameTextBox.Name = "PersonNameTextBox";
            PersonNameTextBox.Size = new System.Drawing.Size(418, 29);
            PersonNameTextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.MediumAquamarine;
            label6.Location = new System.Drawing.Point(14, 15);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(161, 21);
            label6.TabIndex = 13;
            label6.Text = "BASIC INFORMATION";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel1.Controls.Add(BrowseFilePath);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(DataFilePath);
            panel1.Controls.Add(label9);
            panel1.Location = new System.Drawing.Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(897, 139);
            panel1.TabIndex = 18;
            // 
            // BrowseFilePath
            // 
            BrowseFilePath.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            BrowseFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BrowseFilePath.ForeColor = System.Drawing.SystemColors.Control;
            BrowseFilePath.Location = new System.Drawing.Point(812, 85);
            BrowseFilePath.Margin = new System.Windows.Forms.Padding(4);
            BrowseFilePath.Name = "BrowseFilePath";
            BrowseFilePath.Size = new System.Drawing.Size(66, 29);
            BrowseFilePath.TabIndex = 16;
            BrowseFilePath.Text = "...";
            BrowseFilePath.UseVisualStyleBackColor = true;
            BrowseFilePath.Click += BrowseFilePath_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.SystemColors.Control;
            label8.Location = new System.Drawing.Point(14, 58);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(104, 21);
            label8.TabIndex = 15;
            label8.Text = "Data File Path";
            // 
            // DataFilePath
            // 
            DataFilePath.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            DataFilePath.ForeColor = System.Drawing.SystemColors.Control;
            DataFilePath.Location = new System.Drawing.Point(14, 83);
            DataFilePath.Margin = new System.Windows.Forms.Padding(4);
            DataFilePath.Name = "DataFilePath";
            DataFilePath.Size = new System.Drawing.Size(790, 29);
            DataFilePath.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.MediumAquamarine;
            label9.Location = new System.Drawing.Point(14, 15);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(76, 21);
            label9.TabIndex = 13;
            label9.Text = "READING";
            // 
            // RenderEditorViewButton
            // 
            RenderEditorViewButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            RenderEditorViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RenderEditorViewButton.ForeColor = System.Drawing.SystemColors.Control;
            RenderEditorViewButton.Location = new System.Drawing.Point(985, 149);
            RenderEditorViewButton.Margin = new System.Windows.Forms.Padding(4);
            RenderEditorViewButton.Name = "RenderEditorViewButton";
            RenderEditorViewButton.Size = new System.Drawing.Size(129, 61);
            RenderEditorViewButton.TabIndex = 19;
            RenderEditorViewButton.Text = "Render Editor";
            RenderEditorViewButton.UseVisualStyleBackColor = true;
            RenderEditorViewButton.Click += RenderEditorViewButton_Click;
            // 
            // CharacterMapperViewButton
            // 
            CharacterMapperViewButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            CharacterMapperViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CharacterMapperViewButton.ForeColor = System.Drawing.SystemColors.Control;
            CharacterMapperViewButton.Location = new System.Drawing.Point(985, 218);
            CharacterMapperViewButton.Margin = new System.Windows.Forms.Padding(4);
            CharacterMapperViewButton.Name = "CharacterMapperViewButton";
            CharacterMapperViewButton.Size = new System.Drawing.Size(129, 61);
            CharacterMapperViewButton.TabIndex = 20;
            CharacterMapperViewButton.Text = "Character Mapper";
            CharacterMapperViewButton.UseVisualStyleBackColor = true;
            CharacterMapperViewButton.Click += CharacterMapperViewButton_Click;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            ClientSize = new System.Drawing.Size(1127, 630);
            Controls.Add(CharacterMapperViewButton);
            Controls.Add(RenderEditorViewButton);
            Controls.Add(panel1);
            Controls.Add(BasicInformationPanel);
            Controls.Add(DeserializeDataButton);
            Controls.Add(LocationPanel);
            Controls.Add(SerializeDataButton);
            Font = new System.Drawing.Font("Segoe UI", 12F);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "MainApp";
            Text = "Flatbuffer Test App";
            LocationPanel.ResumeLayout(false);
            LocationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PersonLongUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonLatUpDown).EndInit();
            BasicInformationPanel.ResumeLayout(false);
            BasicInformationPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button SerializeDataButton;
        private System.Windows.Forms.Panel LocationPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PersonLongTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeserializeDataButton;
        private System.Windows.Forms.Panel BasicInformationPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PersonLatUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PersonFavColorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PersonNameTextBox;
        private System.Windows.Forms.NumericUpDown PersonLongUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DataFilePath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BrowseFilePath;
        private System.Windows.Forms.CheckBox ActiveCheckBox;
        private System.Windows.Forms.Button RenderEditorViewButton;
        private System.Windows.Forms.Button CharacterMapperViewButton;
    }
}
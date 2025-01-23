namespace FlatSharpTest.Views
{
    partial class CharacterMappingEditorView
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
            DeserializeDataButton = new System.Windows.Forms.Button();
            SerializeDataButton = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            BrowseFilePath = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            DataFilePath = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            button5 = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            AttireFolderPathTextBox = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            LockedCheckBox = new System.Windows.Forms.CheckBox();
            button4 = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            CharacterFolderPathTextBox = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            AttireModelMTLsFilePathTextBox = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            AttireModelMDLFilePathTextBox = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            BaseModelMTLsFilePathTextBox = new System.Windows.Forms.TextBox();
            AddRenderButton = new System.Windows.Forms.Button();
            BrowseRenderPathButton = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            BaseModelMDLFilePathTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            CharacterIdUpDown = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CharacterIdUpDown).BeginInit();
            SuspendLayout();
            // 
            // DeserializeDataButton
            // 
            DeserializeDataButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            DeserializeDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DeserializeDataButton.ForeColor = System.Drawing.SystemColors.Control;
            DeserializeDataButton.Location = new System.Drawing.Point(916, 82);
            DeserializeDataButton.Margin = new System.Windows.Forms.Padding(4);
            DeserializeDataButton.Name = "DeserializeDataButton";
            DeserializeDataButton.Size = new System.Drawing.Size(129, 61);
            DeserializeDataButton.TabIndex = 23;
            DeserializeDataButton.Text = "Deserialize Data";
            DeserializeDataButton.UseVisualStyleBackColor = true;
            // 
            // SerializeDataButton
            // 
            SerializeDataButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            SerializeDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SerializeDataButton.ForeColor = System.Drawing.SystemColors.Control;
            SerializeDataButton.Location = new System.Drawing.Point(916, 13);
            SerializeDataButton.Margin = new System.Windows.Forms.Padding(4);
            SerializeDataButton.Name = "SerializeDataButton";
            SerializeDataButton.Size = new System.Drawing.Size(129, 61);
            SerializeDataButton.TabIndex = 22;
            SerializeDataButton.Text = "Serialize\r\nData";
            SerializeDataButton.UseVisualStyleBackColor = true;
            SerializeDataButton.Click += SerializeDataButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel1.Controls.Add(BrowseFilePath);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(DataFilePath);
            panel1.Controls.Add(label9);
            panel1.Location = new System.Drawing.Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(897, 130);
            panel1.TabIndex = 24;
            // 
            // BrowseFilePath
            // 
            BrowseFilePath.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            BrowseFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BrowseFilePath.ForeColor = System.Drawing.SystemColors.Control;
            BrowseFilePath.Location = new System.Drawing.Point(812, 83);
            BrowseFilePath.Margin = new System.Windows.Forms.Padding(4);
            BrowseFilePath.Name = "BrowseFilePath";
            BrowseFilePath.Size = new System.Drawing.Size(66, 29);
            BrowseFilePath.TabIndex = 16;
            BrowseFilePath.Text = "...";
            BrowseFilePath.UseVisualStyleBackColor = true;
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
            DataFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(AttireFolderPathTextBox);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(LockedCheckBox);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(CharacterFolderPathTextBox);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(AttireModelMTLsFilePathTextBox);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(AttireModelMDLFilePathTextBox);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BaseModelMTLsFilePathTextBox);
            panel2.Controls.Add(AddRenderButton);
            panel2.Controls.Add(BrowseRenderPathButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(BaseModelMDLFilePathTextBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(CharacterIdUpDown);
            panel2.Controls.Add(label2);
            panel2.Location = new System.Drawing.Point(12, 159);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(897, 590);
            panel2.TabIndex = 25;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.ForeColor = System.Drawing.SystemColors.Control;
            button5.Location = new System.Drawing.Point(812, 233);
            button5.Margin = new System.Windows.Forms.Padding(4);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(66, 29);
            button5.TabIndex = 41;
            button5.Text = "...";
            button5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = System.Drawing.SystemColors.Control;
            label11.Location = new System.Drawing.Point(14, 208);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(130, 21);
            label11.TabIndex = 40;
            label11.Text = "Attire Folder Path";
            // 
            // AttireFolderPathTextBox
            // 
            AttireFolderPathTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            AttireFolderPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            AttireFolderPathTextBox.ForeColor = System.Drawing.SystemColors.Control;
            AttireFolderPathTextBox.Location = new System.Drawing.Point(14, 233);
            AttireFolderPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            AttireFolderPathTextBox.Name = "AttireFolderPathTextBox";
            AttireFolderPathTextBox.Size = new System.Drawing.Size(790, 29);
            AttireFolderPathTextBox.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.SystemColors.Control;
            label10.Location = new System.Drawing.Point(140, 54);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(61, 21);
            label10.TabIndex = 38;
            label10.Text = "Attire #";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            numericUpDown1.ForeColor = System.Drawing.SystemColors.Control;
            numericUpDown1.Location = new System.Drawing.Point(140, 78);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            numericUpDown1.Size = new System.Drawing.Size(120, 29);
            numericUpDown1.TabIndex = 37;
            numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // LockedCheckBox
            // 
            LockedCheckBox.AutoSize = true;
            LockedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LockedCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            LockedCheckBox.Location = new System.Drawing.Point(288, 79);
            LockedCheckBox.Name = "LockedCheckBox";
            LockedCheckBox.Size = new System.Drawing.Size(117, 25);
            LockedCheckBox.TabIndex = 36;
            LockedCheckBox.Text = "Attire Locked";
            LockedCheckBox.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.ForeColor = System.Drawing.SystemColors.Control;
            button4.Location = new System.Drawing.Point(812, 156);
            button4.Margin = new System.Windows.Forms.Padding(4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(66, 29);
            button4.TabIndex = 35;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.SystemColors.Control;
            label7.Location = new System.Drawing.Point(14, 131);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(159, 21);
            label7.TabIndex = 34;
            label7.Text = "Character Folder Path";
            // 
            // CharacterFolderPathTextBox
            // 
            CharacterFolderPathTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            CharacterFolderPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            CharacterFolderPathTextBox.ForeColor = System.Drawing.SystemColors.Control;
            CharacterFolderPathTextBox.Location = new System.Drawing.Point(14, 156);
            CharacterFolderPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            CharacterFolderPathTextBox.Name = "CharacterFolderPathTextBox";
            CharacterFolderPathTextBox.Size = new System.Drawing.Size(790, 29);
            CharacterFolderPathTextBox.TabIndex = 33;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.ForeColor = System.Drawing.SystemColors.Control;
            button3.Location = new System.Drawing.Point(812, 539);
            button3.Margin = new System.Windows.Forms.Padding(4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(66, 29);
            button3.TabIndex = 32;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.Control;
            label6.Location = new System.Drawing.Point(14, 514);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(123, 21);
            label6.TabIndex = 31;
            label6.Text = "Attire MTLs Path";
            // 
            // AttireModelMTLsFilePathTextBox
            // 
            AttireModelMTLsFilePathTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            AttireModelMTLsFilePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            AttireModelMTLsFilePathTextBox.ForeColor = System.Drawing.SystemColors.Control;
            AttireModelMTLsFilePathTextBox.Location = new System.Drawing.Point(14, 539);
            AttireModelMTLsFilePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            AttireModelMTLsFilePathTextBox.Name = "AttireModelMTLsFilePathTextBox";
            AttireModelMTLsFilePathTextBox.Size = new System.Drawing.Size(790, 29);
            AttireModelMTLsFilePathTextBox.TabIndex = 30;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.SystemColors.Control;
            button2.Location = new System.Drawing.Point(812, 463);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(66, 29);
            button2.TabIndex = 29;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(14, 438);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(119, 21);
            label5.TabIndex = 28;
            label5.Text = "Attire MDL Path";
            // 
            // AttireModelMDLFilePathTextBox
            // 
            AttireModelMDLFilePathTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            AttireModelMDLFilePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            AttireModelMDLFilePathTextBox.ForeColor = System.Drawing.SystemColors.Control;
            AttireModelMDLFilePathTextBox.Location = new System.Drawing.Point(14, 463);
            AttireModelMDLFilePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            AttireModelMDLFilePathTextBox.Name = "AttireModelMDLFilePathTextBox";
            AttireModelMDLFilePathTextBox.Size = new System.Drawing.Size(790, 29);
            AttireModelMDLFilePathTextBox.TabIndex = 27;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.Control;
            button1.Location = new System.Drawing.Point(812, 389);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(66, 29);
            button1.TabIndex = 26;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(14, 364);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(161, 21);
            label4.TabIndex = 25;
            label4.Text = "BaseModel MTLs Path";
            // 
            // BaseModelMTLsFilePathTextBox
            // 
            BaseModelMTLsFilePathTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            BaseModelMTLsFilePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            BaseModelMTLsFilePathTextBox.ForeColor = System.Drawing.SystemColors.Control;
            BaseModelMTLsFilePathTextBox.Location = new System.Drawing.Point(14, 389);
            BaseModelMTLsFilePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            BaseModelMTLsFilePathTextBox.Name = "BaseModelMTLsFilePathTextBox";
            BaseModelMTLsFilePathTextBox.Size = new System.Drawing.Size(790, 29);
            BaseModelMTLsFilePathTextBox.TabIndex = 24;
            // 
            // AddRenderButton
            // 
            AddRenderButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            AddRenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddRenderButton.ForeColor = System.Drawing.SystemColors.Control;
            AddRenderButton.Location = new System.Drawing.Point(749, 15);
            AddRenderButton.Margin = new System.Windows.Forms.Padding(4);
            AddRenderButton.Name = "AddRenderButton";
            AddRenderButton.Size = new System.Drawing.Size(129, 61);
            AddRenderButton.TabIndex = 23;
            AddRenderButton.Text = "Add";
            AddRenderButton.UseVisualStyleBackColor = true;
            // 
            // BrowseRenderPathButton
            // 
            BrowseRenderPathButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            BrowseRenderPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BrowseRenderPathButton.ForeColor = System.Drawing.SystemColors.Control;
            BrowseRenderPathButton.Location = new System.Drawing.Point(812, 318);
            BrowseRenderPathButton.Margin = new System.Windows.Forms.Padding(4);
            BrowseRenderPathButton.Name = "BrowseRenderPathButton";
            BrowseRenderPathButton.Size = new System.Drawing.Size(66, 29);
            BrowseRenderPathButton.TabIndex = 20;
            BrowseRenderPathButton.Text = "...";
            BrowseRenderPathButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(14, 293);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(157, 21);
            label3.TabIndex = 19;
            label3.Text = "BaseModel MDL Path";
            // 
            // BaseModelMDLFilePathTextBox
            // 
            BaseModelMDLFilePathTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            BaseModelMDLFilePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            BaseModelMDLFilePathTextBox.ForeColor = System.Drawing.SystemColors.Control;
            BaseModelMDLFilePathTextBox.Location = new System.Drawing.Point(14, 318);
            BaseModelMDLFilePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            BaseModelMDLFilePathTextBox.Name = "BaseModelMDLFilePathTextBox";
            BaseModelMDLFilePathTextBox.Size = new System.Drawing.Size(790, 29);
            BaseModelMDLFilePathTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(14, 54);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 21);
            label1.TabIndex = 18;
            label1.Text = "Character ID";
            // 
            // CharacterIdUpDown
            // 
            CharacterIdUpDown.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            CharacterIdUpDown.ForeColor = System.Drawing.SystemColors.Control;
            CharacterIdUpDown.Location = new System.Drawing.Point(14, 78);
            CharacterIdUpDown.Name = "CharacterIdUpDown";
            CharacterIdUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            CharacterIdUpDown.Size = new System.Drawing.Size(120, 29);
            CharacterIdUpDown.TabIndex = 17;
            CharacterIdUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            label2.Location = new System.Drawing.Point(14, 15);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(188, 21);
            label2.TabIndex = 13;
            label2.Text = "MAPPING INFORMATION";
            // 
            // CharacterMappingEditorView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            ClientSize = new System.Drawing.Size(1054, 767);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DeserializeDataButton);
            Controls.Add(SerializeDataButton);
            Font = new System.Drawing.Font("Segoe UI", 12F);
            ForeColor = System.Drawing.SystemColors.Control;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "CharacterMappingEditorView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Character Mapper";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CharacterIdUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button DeserializeDataButton;
        private System.Windows.Forms.Button SerializeDataButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BrowseFilePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DataFilePath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CharacterFolderPathTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AttireModelMTLsFilePathTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AttireModelMDLFilePathTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BaseModelMTLsFilePathTextBox;
        private System.Windows.Forms.Button AddRenderButton;
        private System.Windows.Forms.Button BrowseRenderPathButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BaseModelMDLFilePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CharacterIdUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox LockedCheckBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AttireFolderPathTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
namespace FlatSharpTest.Views
{
    partial class RenderEditorView
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
            panel1 = new System.Windows.Forms.Panel();
            BrowseFilePath = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            DataFilePath = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            DeserializeDataButton = new System.Windows.Forms.Button();
            SerializeDataButton = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            AddRenderButton = new System.Windows.Forms.Button();
            AttireNumberUpDown = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            BrowseRenderPathButton = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            DDSRenderFilePathTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            WrestlerIdUpDown = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            RendersListBox = new System.Windows.Forms.ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AttireNumberUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WrestlerIdUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel1.Controls.Add(BrowseFilePath);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(DataFilePath);
            panel1.Controls.Add(label9);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(897, 130);
            panel1.TabIndex = 19;
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
            // DeserializeDataButton
            // 
            DeserializeDataButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            DeserializeDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DeserializeDataButton.ForeColor = System.Drawing.SystemColors.Control;
            DeserializeDataButton.Location = new System.Drawing.Point(1191, 81);
            DeserializeDataButton.Margin = new System.Windows.Forms.Padding(4);
            DeserializeDataButton.Name = "DeserializeDataButton";
            DeserializeDataButton.Size = new System.Drawing.Size(129, 61);
            DeserializeDataButton.TabIndex = 21;
            DeserializeDataButton.Text = "Deserialize Data";
            DeserializeDataButton.UseVisualStyleBackColor = true;
            // 
            // SerializeDataButton
            // 
            SerializeDataButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            SerializeDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SerializeDataButton.ForeColor = System.Drawing.SystemColors.Control;
            SerializeDataButton.Location = new System.Drawing.Point(1191, 12);
            SerializeDataButton.Margin = new System.Windows.Forms.Padding(4);
            SerializeDataButton.Name = "SerializeDataButton";
            SerializeDataButton.Size = new System.Drawing.Size(129, 61);
            SerializeDataButton.TabIndex = 20;
            SerializeDataButton.Text = "Serialize\r\nData";
            SerializeDataButton.UseVisualStyleBackColor = true;
            SerializeDataButton.Click += SerializeDataButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel2.Controls.Add(AddRenderButton);
            panel2.Controls.Add(AttireNumberUpDown);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BrowseRenderPathButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(DDSRenderFilePathTextBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(WrestlerIdUpDown);
            panel2.Controls.Add(label2);
            panel2.Location = new System.Drawing.Point(12, 175);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(897, 213);
            panel2.TabIndex = 20;
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
            // AttireNumberUpDown
            // 
            AttireNumberUpDown.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            AttireNumberUpDown.ForeColor = System.Drawing.SystemColors.Control;
            AttireNumberUpDown.Location = new System.Drawing.Point(146, 78);
            AttireNumberUpDown.Name = "AttireNumberUpDown";
            AttireNumberUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            AttireNumberUpDown.Size = new System.Drawing.Size(120, 29);
            AttireNumberUpDown.TabIndex = 22;
            AttireNumberUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(146, 54);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 21);
            label4.TabIndex = 21;
            label4.Text = "Attire #";
            // 
            // BrowseRenderPathButton
            // 
            BrowseRenderPathButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            BrowseRenderPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BrowseRenderPathButton.ForeColor = System.Drawing.SystemColors.Control;
            BrowseRenderPathButton.Location = new System.Drawing.Point(812, 155);
            BrowseRenderPathButton.Margin = new System.Windows.Forms.Padding(4);
            BrowseRenderPathButton.Name = "BrowseRenderPathButton";
            BrowseRenderPathButton.Size = new System.Drawing.Size(66, 29);
            BrowseRenderPathButton.TabIndex = 20;
            BrowseRenderPathButton.Text = "...";
            BrowseRenderPathButton.UseVisualStyleBackColor = true;
            BrowseRenderPathButton.Click += BrowseRenderPathButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(14, 130);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(129, 21);
            label3.TabIndex = 19;
            label3.Text = "DDS Render Path";
            // 
            // DDSRenderFilePathTextBox
            // 
            DDSRenderFilePathTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            DDSRenderFilePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DDSRenderFilePathTextBox.ForeColor = System.Drawing.SystemColors.Control;
            DDSRenderFilePathTextBox.Location = new System.Drawing.Point(14, 155);
            DDSRenderFilePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            DDSRenderFilePathTextBox.Name = "DDSRenderFilePathTextBox";
            DDSRenderFilePathTextBox.Size = new System.Drawing.Size(790, 29);
            DDSRenderFilePathTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(14, 54);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 21);
            label1.TabIndex = 18;
            label1.Text = "Wrestler ID";
            // 
            // WrestlerIdUpDown
            // 
            WrestlerIdUpDown.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            WrestlerIdUpDown.ForeColor = System.Drawing.SystemColors.Control;
            WrestlerIdUpDown.Location = new System.Drawing.Point(14, 78);
            WrestlerIdUpDown.Name = "WrestlerIdUpDown";
            WrestlerIdUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            WrestlerIdUpDown.Size = new System.Drawing.Size(120, 29);
            WrestlerIdUpDown.TabIndex = 17;
            WrestlerIdUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            label2.Location = new System.Drawing.Point(14, 15);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(178, 21);
            label2.TabIndex = 13;
            label2.Text = "RENDER INFORMATION";
            // 
            // RendersListBox
            // 
            RendersListBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            RendersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            RendersListBox.ForeColor = System.Drawing.SystemColors.Control;
            RendersListBox.FormattingEnabled = true;
            RendersListBox.ItemHeight = 21;
            RendersListBox.Location = new System.Drawing.Point(12, 413);
            RendersListBox.Name = "RendersListBox";
            RendersListBox.Size = new System.Drawing.Size(897, 86);
            RendersListBox.TabIndex = 22;
            // 
            // RenderEditorView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            ClientSize = new System.Drawing.Size(1333, 630);
            Controls.Add(RendersListBox);
            Controls.Add(panel2);
            Controls.Add(DeserializeDataButton);
            Controls.Add(SerializeDataButton);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Segoe UI", 12F);
            ForeColor = System.Drawing.SystemColors.Control;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "RenderEditorView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Render Editor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AttireNumberUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)WrestlerIdUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BrowseFilePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DataFilePath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeserializeDataButton;
        private System.Windows.Forms.Button SerializeDataButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BrowseRenderPathButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DDSRenderFilePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown WrestlerIdUpDown;
        private System.Windows.Forms.NumericUpDown AttireNumberUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddRenderButton;
        private System.Windows.Forms.ListBox RendersListBox;
    }
}
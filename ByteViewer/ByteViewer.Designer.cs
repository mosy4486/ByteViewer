namespace ByteViewer
{
    partial class ByteViewer
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
            MainPanel = new Panel();
            ViewByteButton_Hex = new Button();
            ViewByteButton_Decimal = new Button();
            InfoBox = new TextBox();
            ResultBox = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            FileSelectButton = new Button();
            MainPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(ViewByteButton_Hex);
            MainPanel.Controls.Add(ViewByteButton_Decimal);
            MainPanel.Controls.Add(InfoBox);
            MainPanel.Controls.Add(ResultBox);
            MainPanel.Controls.Add(panel1);
            MainPanel.Location = new Point(12, 12);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(719, 613);
            MainPanel.TabIndex = 0;
            // 
            // ViewByteButton_Hex
            // 
            ViewByteButton_Hex.BackColor = SystemColors.ButtonShadow;
            ViewByteButton_Hex.Font = new Font("바탕체", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ViewByteButton_Hex.ForeColor = Color.Snow;
            ViewByteButton_Hex.Location = new Point(365, 194);
            ViewByteButton_Hex.Name = "ViewByteButton_Hex";
            ViewByteButton_Hex.Size = new Size(345, 35);
            ViewByteButton_Hex.TabIndex = 4;
            ViewByteButton_Hex.UseVisualStyleBackColor = false;
            ViewByteButton_Hex.Click += ViewByteButton_Hex_Click;
            // 
            // ViewByteButton_Decimal
            // 
            ViewByteButton_Decimal.BackColor = SystemColors.ButtonShadow;
            ViewByteButton_Decimal.Font = new Font("바탕체", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ViewByteButton_Decimal.ForeColor = Color.Snow;
            ViewByteButton_Decimal.Location = new Point(12, 194);
            ViewByteButton_Decimal.Name = "ViewByteButton_Decimal";
            ViewByteButton_Decimal.Size = new Size(347, 35);
            ViewByteButton_Decimal.TabIndex = 3;
            ViewByteButton_Decimal.UseVisualStyleBackColor = false;
            ViewByteButton_Decimal.Click += ViewByteButton_Click;
            // 
            // InfoBox
            // 
            InfoBox.BackColor = SystemColors.ControlLight;
            InfoBox.Font = new Font("돋움체", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            InfoBox.Location = new Point(9, 99);
            InfoBox.Multiline = true;
            InfoBox.Name = "InfoBox";
            InfoBox.ReadOnly = true;
            InfoBox.ScrollBars = ScrollBars.Vertical;
            InfoBox.Size = new Size(701, 89);
            InfoBox.TabIndex = 3;
            InfoBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ResultBox
            // 
            ResultBox.BackColor = SystemColors.ControlLight;
            ResultBox.Font = new Font("돋움체", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ResultBox.Location = new Point(9, 235);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.ScrollBars = ScrollBars.Vertical;
            ResultBox.Size = new Size(701, 366);
            ResultBox.TabIndex = 2;
            ResultBox.TextAlign = HorizontalAlignment.Center;
            ResultBox.TextChanged += ResultBox_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(FileSelectButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 83);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 380);
            panel2.TabIndex = 2;
            // 
            // FileSelectButton
            // 
            FileSelectButton.BackColor = SystemColors.ButtonShadow;
            FileSelectButton.Font = new Font("바탕체", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            FileSelectButton.ForeColor = Color.Snow;
            FileSelectButton.Location = new Point(3, 3);
            FileSelectButton.Name = "FileSelectButton";
            FileSelectButton.Size = new Size(707, 77);
            FileSelectButton.TabIndex = 0;
            FileSelectButton.Text = "FileSelect";
            FileSelectButton.UseVisualStyleBackColor = false;
            FileSelectButton.Click += FileSelectButton_Click;
            // 
            // ByteViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 637);
            Controls.Add(MainPanel);
            Name = "ByteViewer";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel panel1;
        private Button FileSelectButton;
        private Panel panel2;
        private TextBox ResultBox;
        private Button ViewByteButton_Decimal;
        private TextBox InfoBox;
        private Button ViewByteButton_Hex;
    }
}

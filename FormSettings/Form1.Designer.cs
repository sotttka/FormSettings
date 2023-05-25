namespace FormSettings
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
            _selectFormColorComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            _selectForegroundColorComboBox = new ComboBox();
            SuspendLayout();
            // 
            // _selectFormColorComboBox
            // 
            _selectFormColorComboBox.FormattingEnabled = true;
            _selectFormColorComboBox.Location = new Point(159, 17);
            _selectFormColorComboBox.Name = "_selectFormColorComboBox";
            _selectFormColorComboBox.Size = new Size(226, 23);
            _selectFormColorComboBox.TabIndex = 0;
            _selectFormColorComboBox.SelectedIndexChanged += _selectFormColorComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 1;
            label1.Text = "Цвет формы:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(26, 44);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 3;
            label2.Text = "Цвет шрифта:";
            // 
            // _selectForegroundColorComboBox
            // 
            _selectForegroundColorComboBox.FormattingEnabled = true;
            _selectForegroundColorComboBox.Location = new Point(159, 42);
            _selectForegroundColorComboBox.Name = "_selectForegroundColorComboBox";
            _selectForegroundColorComboBox.Size = new Size(226, 23);
            _selectForegroundColorComboBox.TabIndex = 2;
            _selectForegroundColorComboBox.SelectedIndexChanged += _selectForegroundColorComboBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(487, 216);
            Controls.Add(label2);
            Controls.Add(_selectForegroundColorComboBox);
            Controls.Add(label1);
            Controls.Add(_selectFormColorComboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox _selectFormColorComboBox;
        private Label label1;
        private Label label2;
        private ComboBox _selectForegroundColorComboBox;
    }
}
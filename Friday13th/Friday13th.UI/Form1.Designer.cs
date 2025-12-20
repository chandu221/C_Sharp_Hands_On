namespace Friday13th.UI
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
            ShowDates = new Button();
            Friday_Only = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // ShowDates
            // 
            ShowDates.Location = new Point(71, 61);
            ShowDates.Name = "ShowDates";
            ShowDates.Size = new Size(94, 29);
            ShowDates.TabIndex = 0;
            ShowDates.Text = "Show 13th Dates";
            ShowDates.UseVisualStyleBackColor = true;
            ShowDates.Click += ShowDates_Click;
            // 
            // Friday_Only
            // 
            Friday_Only.Location = new Point(238, 61);
            Friday_Only.Name = "Friday_Only";
            Friday_Only.Size = new Size(94, 29);
            Friday_Only.TabIndex = 1;
            Friday_Only.Text = "Firday Only";
            Friday_Only.UseVisualStyleBackColor = true;
            Friday_Only.Click += Friday_Only_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(71, 134);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(261, 304);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 450);
            Controls.Add(listBox1);
            Controls.Add(Friday_Only);
            Controls.Add(ShowDates);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ShowDates;
        private Button Friday_Only;
        private ListBox listBox1;
    }
}

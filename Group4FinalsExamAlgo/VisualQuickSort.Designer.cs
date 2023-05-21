namespace Group4FinalsExamAlgo
{
    partial class VisualQuickSort
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
            BtnForward = new Button();
            BtnClear = new Button();
            TextBoxNumbersToSort = new TextBox();
            label1 = new Label();
            BtnSort = new Button();
            ListBoxSteps = new ListBox();
            BtnGenerate = new Button();
            SuspendLayout();
            // 
            // BtnForward
            // 
            BtnForward.Location = new Point(333, 66);
            BtnForward.Name = "BtnForward";
            BtnForward.Size = new Size(94, 29);
            BtnForward.TabIndex = 2;
            BtnForward.Text = "Forward";
            BtnForward.UseVisualStyleBackColor = true;
            BtnForward.Click += BtnForward_Click;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(433, 66);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(94, 29);
            BtnClear.TabIndex = 3;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // TextBoxNumbersToSort
            // 
            TextBoxNumbersToSort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxNumbersToSort.Location = new Point(133, 33);
            TextBoxNumbersToSort.Name = "TextBoxNumbersToSort";
            TextBoxNumbersToSort.Size = new Size(394, 27);
            TextBoxNumbersToSort.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 6;
            label1.Text = "Number to Sort:";
            // 
            // BtnSort
            // 
            BtnSort.Location = new Point(233, 66);
            BtnSort.Name = "BtnSort";
            BtnSort.Size = new Size(94, 29);
            BtnSort.TabIndex = 9;
            BtnSort.Text = "Sort";
            BtnSort.UseVisualStyleBackColor = true;
            BtnSort.Click += BtnSort_Click;
            // 
            // ListBoxSteps
            // 
            ListBoxSteps.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListBoxSteps.FormattingEnabled = true;
            ListBoxSteps.ItemHeight = 20;
            ListBoxSteps.Location = new Point(12, 124);
            ListBoxSteps.Name = "ListBoxSteps";
            ListBoxSteps.Size = new Size(776, 304);
            ListBoxSteps.TabIndex = 10;
            // 
            // BtnGenerate
            // 
            BtnGenerate.Location = new Point(133, 66);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(94, 29);
            BtnGenerate.TabIndex = 11;
            BtnGenerate.Text = "Generate";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // VisualInsertionSort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGenerate);
            Controls.Add(ListBoxSteps);
            Controls.Add(BtnSort);
            Controls.Add(label1);
            Controls.Add(TextBoxNumbersToSort);
            Controls.Add(BtnClear);
            Controls.Add(BtnForward);
            Name = "VisualInsertionSort";
            Text = "VisualInsertionSort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnForward;
        private Button BtnClear;
        private TextBox TextBoxNumbersToSort;
        private Label label1;
        private Button BtnSort;
        private ListBox ListBoxSteps;
        private Button BtnGenerate;
    }
}
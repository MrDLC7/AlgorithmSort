namespace AlgorithmSort
{
    partial class AlgorithmSort
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
            panelMain = new Panel();
            panel_PrintResult = new Panel();
            button_ClearLog = new Button();
            button_ClearArray = new Button();
            label_Log = new Label();
            label_Array = new Label();
            richTextBox_Log = new RichTextBox();
            richTextBox_Array = new RichTextBox();
            panelSort = new Panel();
            label_Sort = new Label();
            button_QuickSort = new Button();
            button_MergeSort = new Button();
            button_InsertSort = new Button();
            button_BubbleSort = new Button();
            panelGen = new Panel();
            textBox_Range = new TextBox();
            label_Range = new Label();
            button_GenerateArray = new Button();
            textBox_SizeArray = new TextBox();
            label_SizeArray = new Label();
            panelMain.SuspendLayout();
            panel_PrintResult.SuspendLayout();
            panelSort.SuspendLayout();
            panelGen.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.BackColor = Color.FloralWhite;
            panelMain.Controls.Add(panel_PrintResult);
            panelMain.Controls.Add(panelSort);
            panelMain.Controls.Add(panelGen);
            panelMain.Location = new Point(1, 1);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(979, 552);
            panelMain.TabIndex = 0;
            // 
            // panel_PrintResult
            // 
            panel_PrintResult.BackColor = SystemColors.Control;
            panel_PrintResult.BorderStyle = BorderStyle.FixedSingle;
            panel_PrintResult.Controls.Add(button_ClearLog);
            panel_PrintResult.Controls.Add(button_ClearArray);
            panel_PrintResult.Controls.Add(label_Log);
            panel_PrintResult.Controls.Add(label_Array);
            panel_PrintResult.Controls.Add(richTextBox_Log);
            panel_PrintResult.Controls.Add(richTextBox_Array);
            panel_PrintResult.Location = new Point(11, 122);
            panel_PrintResult.Name = "panel_PrintResult";
            panel_PrintResult.Size = new Size(958, 418);
            panel_PrintResult.TabIndex = 2;
            // 
            // button_ClearLog
            // 
            button_ClearLog.BackColor = SystemColors.GradientActiveCaption;
            button_ClearLog.Location = new Point(623, 373);
            button_ClearLog.Name = "button_ClearLog";
            button_ClearLog.Size = new Size(180, 35);
            button_ClearLog.TabIndex = 8;
            button_ClearLog.Text = "Очистити \"Лог\"";
            button_ClearLog.UseVisualStyleBackColor = false;
            button_ClearLog.Click += button_ClearLog_Click;
            // 
            // button_ClearArray
            // 
            button_ClearArray.BackColor = SystemColors.GradientActiveCaption;
            button_ClearArray.Location = new Point(156, 373);
            button_ClearArray.Name = "button_ClearArray";
            button_ClearArray.Size = new Size(180, 35);
            button_ClearArray.TabIndex = 7;
            button_ClearArray.Text = "Очистити \"Масив\"";
            button_ClearArray.UseVisualStyleBackColor = false;
            button_ClearArray.Click += button_ClearArray_Click;
            // 
            // label_Log
            // 
            label_Log.AutoSize = true;
            label_Log.Location = new Point(703, 10);
            label_Log.Name = "label_Log";
            label_Log.Size = new Size(35, 20);
            label_Log.TabIndex = 3;
            label_Log.Text = "Лог";
            // 
            // label_Array
            // 
            label_Array.AutoSize = true;
            label_Array.Location = new Point(225, 10);
            label_Array.Name = "label_Array";
            label_Array.Size = new Size(56, 20);
            label_Array.TabIndex = 2;
            label_Array.Text = "Масив";
            // 
            // richTextBox_Log
            // 
            richTextBox_Log.BackColor = SystemColors.Window;
            richTextBox_Log.Location = new Point(485, 40);
            richTextBox_Log.Name = "richTextBox_Log";
            richTextBox_Log.ReadOnly = true;
            richTextBox_Log.Size = new Size(460, 327);
            richTextBox_Log.TabIndex = 1;
            richTextBox_Log.TabStop = false;
            richTextBox_Log.Text = "";
            richTextBox_Log.TextChanged += richTextBox_TextChanged;
            // 
            // richTextBox_Array
            // 
            richTextBox_Array.BackColor = SystemColors.Window;
            richTextBox_Array.Location = new Point(12, 40);
            richTextBox_Array.Name = "richTextBox_Array";
            richTextBox_Array.ReadOnly = true;
            richTextBox_Array.Size = new Size(460, 327);
            richTextBox_Array.TabIndex = 0;
            richTextBox_Array.TabStop = false;
            richTextBox_Array.Text = "";
            richTextBox_Array.TextChanged += richTextBox_TextChanged;
            // 
            // panelSort
            // 
            panelSort.BackColor = SystemColors.Control;
            panelSort.BorderStyle = BorderStyle.FixedSingle;
            panelSort.Controls.Add(label_Sort);
            panelSort.Controls.Add(button_QuickSort);
            panelSort.Controls.Add(button_MergeSort);
            panelSort.Controls.Add(button_InsertSort);
            panelSort.Controls.Add(button_BubbleSort);
            panelSort.Enabled = false;
            panelSort.Location = new Point(392, 11);
            panelSort.Name = "panelSort";
            panelSort.Size = new Size(577, 97);
            panelSort.TabIndex = 1;
            // 
            // label_Sort
            // 
            label_Sort.AutoSize = true;
            label_Sort.Location = new Point(240, 13);
            label_Sort.Name = "label_Sort";
            label_Sort.Size = new Size(99, 20);
            label_Sort.TabIndex = 4;
            label_Sort.Text = "Сортування:";
            // 
            // button_QuickSort
            // 
            button_QuickSort.BackColor = Color.FromArgb(255, 255, 192);
            button_QuickSort.Location = new Point(433, 47);
            button_QuickSort.Name = "button_QuickSort";
            button_QuickSort.Size = new Size(131, 39);
            button_QuickSort.TabIndex = 6;
            button_QuickSort.Text = "Швидке";
            button_QuickSort.UseVisualStyleBackColor = false;
            button_QuickSort.Click += button_QuickSort_Click;
            // 
            // button_MergeSort
            // 
            button_MergeSort.BackColor = Color.FromArgb(255, 255, 192);
            button_MergeSort.Location = new Point(293, 47);
            button_MergeSort.Name = "button_MergeSort";
            button_MergeSort.Size = new Size(131, 39);
            button_MergeSort.TabIndex = 5;
            button_MergeSort.Text = "Злиттям";
            button_MergeSort.UseVisualStyleBackColor = false;
            button_MergeSort.Click += button_MergeSort_Click;
            // 
            // button_InsertSort
            // 
            button_InsertSort.BackColor = Color.FromArgb(255, 255, 192);
            button_InsertSort.Location = new Point(153, 47);
            button_InsertSort.Name = "button_InsertSort";
            button_InsertSort.Size = new Size(131, 39);
            button_InsertSort.TabIndex = 4;
            button_InsertSort.Text = "Вставками";
            button_InsertSort.UseVisualStyleBackColor = false;
            button_InsertSort.Click += button_InsertSort_Click;
            // 
            // button_BubbleSort
            // 
            button_BubbleSort.BackColor = Color.FromArgb(255, 255, 192);
            button_BubbleSort.Location = new Point(13, 47);
            button_BubbleSort.Name = "button_BubbleSort";
            button_BubbleSort.Size = new Size(131, 39);
            button_BubbleSort.TabIndex = 3;
            button_BubbleSort.Text = "Бульбашкою";
            button_BubbleSort.UseVisualStyleBackColor = false;
            button_BubbleSort.Click += button_BubbleSort_Click;
            // 
            // panelGen
            // 
            panelGen.BackColor = SystemColors.Control;
            panelGen.BorderStyle = BorderStyle.FixedSingle;
            panelGen.Controls.Add(textBox_Range);
            panelGen.Controls.Add(label_Range);
            panelGen.Controls.Add(button_GenerateArray);
            panelGen.Controls.Add(textBox_SizeArray);
            panelGen.Controls.Add(label_SizeArray);
            panelGen.Location = new Point(11, 11);
            panelGen.Name = "panelGen";
            panelGen.Size = new Size(366, 97);
            panelGen.TabIndex = 0;
            // 
            // textBox_Range
            // 
            textBox_Range.Location = new Point(141, 54);
            textBox_Range.Name = "textBox_Range";
            textBox_Range.Size = new Size(90, 27);
            textBox_Range.TabIndex = 4;
            textBox_Range.Text = "10000";
            textBox_Range.TextAlign = HorizontalAlignment.Center;
            textBox_Range.Click += textBox_Click;
            textBox_Range.Validating += textBox_Validating;
            // 
            // label_Range
            // 
            label_Range.AutoSize = true;
            label_Range.Location = new Point(12, 57);
            label_Range.Name = "label_Range";
            label_Range.Size = new Size(130, 20);
            label_Range.TabIndex = 3;
            label_Range.Text = "Діапозон чисел: ";
            // 
            // button_GenerateArray
            // 
            button_GenerateArray.BackColor = Color.FromArgb(210, 255, 135);
            button_GenerateArray.Location = new Point(239, 48);
            button_GenerateArray.Name = "button_GenerateArray";
            button_GenerateArray.Size = new Size(116, 38);
            button_GenerateArray.TabIndex = 2;
            button_GenerateArray.Text = "Згенерувати";
            button_GenerateArray.UseVisualStyleBackColor = false;
            button_GenerateArray.Click += button_GenerateArray_Click;
            // 
            // textBox_SizeArray
            // 
            textBox_SizeArray.Location = new Point(253, 10);
            textBox_SizeArray.Name = "textBox_SizeArray";
            textBox_SizeArray.Size = new Size(90, 27);
            textBox_SizeArray.TabIndex = 1;
            textBox_SizeArray.Text = "10";
            textBox_SizeArray.TextAlign = HorizontalAlignment.Center;
            textBox_SizeArray.Click += textBox_Click;
            textBox_SizeArray.Validating += textBox_Validating;
            // 
            // label_SizeArray
            // 
            label_SizeArray.AutoSize = true;
            label_SizeArray.Location = new Point(12, 13);
            label_SizeArray.Name = "label_SizeArray";
            label_SizeArray.Size = new Size(222, 20);
            label_SizeArray.TabIndex = 0;
            label_SizeArray.Text = "Кількість елементів в масиві:";
            // 
            // AlgorithmSort
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panelMain);
            MinimumSize = new Size(1000, 600);
            Name = "AlgorithmSort";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlgorithmSort";
            panelMain.ResumeLayout(false);
            panel_PrintResult.ResumeLayout(false);
            panel_PrintResult.PerformLayout();
            panelSort.ResumeLayout(false);
            panelSort.PerformLayout();
            panelGen.ResumeLayout(false);
            panelGen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelGen;
        private TextBox textBox_SizeArray;
        private Label label_SizeArray;
        private Button button_GenerateArray;
        private Panel panelSort;
        private Button button_MergeSort;
        private Button button_InsertSort;
        private Button button_BubbleSort;
        private Label label_Sort;
        private Button button_QuickSort;
        private Panel panel_PrintResult;
        private Button button_ClearLog;
        private Button button_ClearArray;
        private Label label_Log;
        private Label label_Array;
        private RichTextBox richTextBox_Log;
        private RichTextBox richTextBox_Array;
        private TextBox textBox_Range;
        private Label label_Range;
    }
}

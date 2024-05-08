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
            panelGen = new Panel();
            label_SizeArray = new Label();
            textBox_SizeArray = new TextBox();
            button_GenerateArray = new Button();
            panelSort = new Panel();
            button_BubbleSort = new Button();
            button_InsertSort = new Button();
            button_MergeSort = new Button();
            button_QuickSort = new Button();
            label_Sort = new Label();
            panel_PrintResult = new Panel();
            richTextBox_Array = new RichTextBox();
            richTextBox_Log = new RichTextBox();
            label_Array = new Label();
            label_Log = new Label();
            button_ClearArray = new Button();
            button_ClearLog = new Button();
            panelMain.SuspendLayout();
            panelGen.SuspendLayout();
            panelSort.SuspendLayout();
            panel_PrintResult.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panel_PrintResult);
            panelMain.Controls.Add(panelSort);
            panelMain.Controls.Add(panelGen);
            panelMain.Location = new Point(1, 1);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(979, 552);
            panelMain.TabIndex = 0;
            // 
            // panelGen
            // 
            panelGen.Controls.Add(button_GenerateArray);
            panelGen.Controls.Add(textBox_SizeArray);
            panelGen.Controls.Add(label_SizeArray);
            panelGen.Location = new Point(11, 11);
            panelGen.Name = "panelGen";
            panelGen.Size = new Size(366, 97);
            panelGen.TabIndex = 0;
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
            // textBox_SizeArray
            // 
            textBox_SizeArray.Location = new Point(238, 10);
            textBox_SizeArray.Name = "textBox_SizeArray";
            textBox_SizeArray.Size = new Size(110, 27);
            textBox_SizeArray.TabIndex = 1;
            textBox_SizeArray.Text = "10";
            textBox_SizeArray.TextAlign = HorizontalAlignment.Center;
            // 
            // button_GenerateArray
            // 
            button_GenerateArray.Location = new Point(12, 48);
            button_GenerateArray.Name = "button_GenerateArray";
            button_GenerateArray.Size = new Size(342, 38);
            button_GenerateArray.TabIndex = 2;
            button_GenerateArray.Text = "Згенерувати";
            button_GenerateArray.UseVisualStyleBackColor = true;
            // 
            // panelSort
            // 
            panelSort.Controls.Add(label_Sort);
            panelSort.Controls.Add(button_QuickSort);
            panelSort.Controls.Add(button_MergeSort);
            panelSort.Controls.Add(button_InsertSort);
            panelSort.Controls.Add(button_BubbleSort);
            panelSort.Location = new Point(392, 11);
            panelSort.Name = "panelSort";
            panelSort.Size = new Size(577, 97);
            panelSort.TabIndex = 1;
            // 
            // button_BubbleSort
            // 
            button_BubbleSort.Location = new Point(13, 47);
            button_BubbleSort.Name = "button_BubbleSort";
            button_BubbleSort.Size = new Size(131, 39);
            button_BubbleSort.TabIndex = 0;
            button_BubbleSort.Text = "Бульбашкою";
            button_BubbleSort.UseVisualStyleBackColor = true;
            // 
            // button_InsertSort
            // 
            button_InsertSort.Location = new Point(153, 47);
            button_InsertSort.Name = "button_InsertSort";
            button_InsertSort.Size = new Size(131, 39);
            button_InsertSort.TabIndex = 1;
            button_InsertSort.Text = "Вставками";
            button_InsertSort.UseVisualStyleBackColor = true;
            // 
            // button_MergeSort
            // 
            button_MergeSort.Location = new Point(293, 47);
            button_MergeSort.Name = "button_MergeSort";
            button_MergeSort.Size = new Size(131, 39);
            button_MergeSort.TabIndex = 2;
            button_MergeSort.Text = "Злиттям";
            button_MergeSort.UseVisualStyleBackColor = true;
            // 
            // button_QuickSort
            // 
            button_QuickSort.Location = new Point(433, 47);
            button_QuickSort.Name = "button_QuickSort";
            button_QuickSort.Size = new Size(131, 39);
            button_QuickSort.TabIndex = 3;
            button_QuickSort.Text = "Швидке";
            button_QuickSort.UseVisualStyleBackColor = true;
            // 
            // label_Sort
            // 
            label_Sort.AutoSize = true;
            label_Sort.Location = new Point(242, 13);
            label_Sort.Name = "label_Sort";
            label_Sort.Size = new Size(95, 20);
            label_Sort.TabIndex = 4;
            label_Sort.Text = "Сортування";
            // 
            // panel_PrintResult
            // 
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
            // richTextBox_Array
            // 
            richTextBox_Array.Location = new Point(12, 40);
            richTextBox_Array.Name = "richTextBox_Array";
            richTextBox_Array.Size = new Size(460, 327);
            richTextBox_Array.TabIndex = 0;
            richTextBox_Array.Text = "";
            // 
            // richTextBox_Log
            // 
            richTextBox_Log.Location = new Point(485, 40);
            richTextBox_Log.Name = "richTextBox_Log";
            richTextBox_Log.Size = new Size(460, 327);
            richTextBox_Log.TabIndex = 1;
            richTextBox_Log.Text = "";
            // 
            // label_Array
            // 
            label_Array.AutoSize = true;
            label_Array.Location = new Point(195, 10);
            label_Array.Name = "label_Array";
            label_Array.Size = new Size(56, 20);
            label_Array.TabIndex = 2;
            label_Array.Text = "Масив";
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
            // button_ClearArray
            // 
            button_ClearArray.Location = new Point(156, 373);
            button_ClearArray.Name = "button_ClearArray";
            button_ClearArray.Size = new Size(180, 38);
            button_ClearArray.TabIndex = 4;
            button_ClearArray.Text = "Очистити \"Масив\"";
            button_ClearArray.UseVisualStyleBackColor = true;
            // 
            // button_ClearLog
            // 
            button_ClearLog.Location = new Point(623, 373);
            button_ClearLog.Name = "button_ClearLog";
            button_ClearLog.Size = new Size(180, 35);
            button_ClearLog.TabIndex = 5;
            button_ClearLog.Text = "Очистити \"Лог\"";
            button_ClearLog.UseVisualStyleBackColor = true;
            // 
            // AlgorithmSort
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panelMain);
            Name = "AlgorithmSort";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlgorithmSort";
            panelMain.ResumeLayout(false);
            panelGen.ResumeLayout(false);
            panelGen.PerformLayout();
            panelSort.ResumeLayout(false);
            panelSort.PerformLayout();
            panel_PrintResult.ResumeLayout(false);
            panel_PrintResult.PerformLayout();
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
    }
}

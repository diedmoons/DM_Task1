namespace DM_Task1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SetArr_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CountOfArr_textBox = new System.Windows.Forms.TextBox();
            this.SortArr_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FindNumber_textBox = new System.Windows.Forms.TextBox();
            this.Arr_textBox = new System.Windows.Forms.TextBox();
            this.Result_textBox = new System.Windows.Forms.TextBox();
            this.SequentialSearch_button = new System.Windows.Forms.Button();
            this.BinarySearch_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SortArr_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_InsertionSort = new System.Windows.Forms.Button();
            this.button_BinaryInsertionSort = new System.Windows.Forms.Button();
            this.BackSort_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Step_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Shell_button = new System.Windows.Forms.Button();
            this.Bubble_button = new System.Windows.Forms.Button();
            this.button_QuickSort = new System.Windows.Forms.Button();
            this.button_MergeSort = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetArr_button
            // 
            this.SetArr_button.Location = new System.Drawing.Point(12, 91);
            this.SetArr_button.Name = "SetArr_button";
            this.SetArr_button.Size = new System.Drawing.Size(277, 33);
            this.SetArr_button.TabIndex = 0;
            this.SetArr_button.Text = "Задать рандомный массив";
            this.SetArr_button.UseVisualStyleBackColor = true;
            this.SetArr_button.Click += new System.EventHandler(this.SetArr_button_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количесво элементов в массиве:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // CountOfArr_textBox
            // 
            this.CountOfArr_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfArr_textBox.Location = new System.Drawing.Point(200, 16);
            this.CountOfArr_textBox.Name = "CountOfArr_textBox";
            this.CountOfArr_textBox.Size = new System.Drawing.Size(59, 26);
            this.CountOfArr_textBox.TabIndex = 2;
            // 
            // SortArr_button
            // 
            this.SortArr_button.Location = new System.Drawing.Point(12, 130);
            this.SortArr_button.Name = "SortArr_button";
            this.SortArr_button.Size = new System.Drawing.Size(277, 36);
            this.SortArr_button.TabIndex = 3;
            this.SortArr_button.Text = "Задать упорядоченный массив";
            this.SortArr_button.UseVisualStyleBackColor = true;
            this.SortArr_button.Click += new System.EventHandler(this.SortArr_button_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Искомое число для поиска :";
            // 
            // FindNumber_textBox
            // 
            this.FindNumber_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindNumber_textBox.Location = new System.Drawing.Point(200, 52);
            this.FindNumber_textBox.Name = "FindNumber_textBox";
            this.FindNumber_textBox.Size = new System.Drawing.Size(59, 26);
            this.FindNumber_textBox.TabIndex = 5;
            // 
            // Arr_textBox
            // 
            this.Arr_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arr_textBox.Location = new System.Drawing.Point(295, 16);
            this.Arr_textBox.Multiline = true;
            this.Arr_textBox.Name = "Arr_textBox";
            this.Arr_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Arr_textBox.Size = new System.Drawing.Size(213, 405);
            this.Arr_textBox.TabIndex = 6;
            // 
            // Result_textBox
            // 
            this.Result_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_textBox.Location = new System.Drawing.Point(12, 427);
            this.Result_textBox.Multiline = true;
            this.Result_textBox.Name = "Result_textBox";
            this.Result_textBox.Size = new System.Drawing.Size(750, 35);
            this.Result_textBox.TabIndex = 7;
            // 
            // SequentialSearch_button
            // 
            this.SequentialSearch_button.Location = new System.Drawing.Point(13, 214);
            this.SequentialSearch_button.Name = "SequentialSearch_button";
            this.SequentialSearch_button.Size = new System.Drawing.Size(130, 35);
            this.SequentialSearch_button.TabIndex = 8;
            this.SequentialSearch_button.Text = "Последовательный поиск";
            this.SequentialSearch_button.UseVisualStyleBackColor = true;
            this.SequentialSearch_button.Click += new System.EventHandler(this.SequentialSearch_button_Click);
            // 
            // BinarySearch_button
            // 
            this.BinarySearch_button.Location = new System.Drawing.Point(158, 214);
            this.BinarySearch_button.Name = "BinarySearch_button";
            this.BinarySearch_button.Size = new System.Drawing.Size(131, 35);
            this.BinarySearch_button.TabIndex = 9;
            this.BinarySearch_button.Text = "Бинарный поиск";
            this.BinarySearch_button.UseVisualStyleBackColor = true;
            this.BinarySearch_button.Click += new System.EventHandler(this.BinarySearch_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Заданный массив";
            // 
            // SortArr_textBox
            // 
            this.SortArr_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortArr_textBox.Location = new System.Drawing.Point(549, 16);
            this.SortArr_textBox.Multiline = true;
            this.SortArr_textBox.Name = "SortArr_textBox";
            this.SortArr_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SortArr_textBox.Size = new System.Drawing.Size(213, 405);
            this.SortArr_textBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Отсортированный массив";
            // 
            // button_InsertionSort
            // 
            this.button_InsertionSort.Location = new System.Drawing.Point(12, 255);
            this.button_InsertionSort.Name = "button_InsertionSort";
            this.button_InsertionSort.Size = new System.Drawing.Size(131, 34);
            this.button_InsertionSort.TabIndex = 13;
            this.button_InsertionSort.Text = "Сортировка вставками";
            this.button_InsertionSort.UseVisualStyleBackColor = true;
            this.button_InsertionSort.Click += new System.EventHandler(this.button_InsertionSort_Click);
            // 
            // button_BinaryInsertionSort
            // 
            this.button_BinaryInsertionSort.Location = new System.Drawing.Point(158, 255);
            this.button_BinaryInsertionSort.Name = "button_BinaryInsertionSort";
            this.button_BinaryInsertionSort.Size = new System.Drawing.Size(131, 34);
            this.button_BinaryInsertionSort.TabIndex = 14;
            this.button_BinaryInsertionSort.Text = "Сортировка бинарными вставками";
            this.button_BinaryInsertionSort.UseVisualStyleBackColor = true;
            this.button_BinaryInsertionSort.Click += new System.EventHandler(this.button_BinaryInsertionSort_Click);
            // 
            // BackSort_button
            // 
            this.BackSort_button.Location = new System.Drawing.Point(13, 172);
            this.BackSort_button.Name = "BackSort_button";
            this.BackSort_button.Size = new System.Drawing.Size(276, 36);
            this.BackSort_button.TabIndex = 15;
            this.BackSort_button.Text = "Задать обратно упорядоченный массив";
            this.BackSort_button.UseVisualStyleBackColor = true;
            this.BackSort_button.Click += new System.EventHandler(this.BackSort_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Step_textBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Shell_button);
            this.panel1.Location = new System.Drawing.Point(13, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 42);
            this.panel1.TabIndex = 16;
            // 
            // Step_textBox
            // 
            this.Step_textBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Step_textBox.Location = new System.Drawing.Point(47, 14);
            this.Step_textBox.Name = "Step_textBox";
            this.Step_textBox.Size = new System.Drawing.Size(50, 20);
            this.Step_textBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Шаг :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Shell_button
            // 
            this.Shell_button.Location = new System.Drawing.Point(145, 12);
            this.Shell_button.Name = "Shell_button";
            this.Shell_button.Size = new System.Drawing.Size(128, 23);
            this.Shell_button.TabIndex = 0;
            this.Shell_button.Text = "Сортировка Шелла";
            this.Shell_button.UseVisualStyleBackColor = true;
            this.Shell_button.Click += new System.EventHandler(this.Shell_button_Click);
            // 
            // Bubble_button
            // 
            this.Bubble_button.Location = new System.Drawing.Point(13, 334);
            this.Bubble_button.Name = "Bubble_button";
            this.Bubble_button.Size = new System.Drawing.Size(276, 39);
            this.Bubble_button.TabIndex = 17;
            this.Bubble_button.Text = "Пузырьковая сортировка";
            this.Bubble_button.UseVisualStyleBackColor = true;
            this.Bubble_button.Click += new System.EventHandler(this.Bubble_button_Click);
            // 
            // button_QuickSort
            // 
            this.button_QuickSort.Location = new System.Drawing.Point(13, 295);
            this.button_QuickSort.Name = "button_QuickSort";
            this.button_QuickSort.Size = new System.Drawing.Size(130, 33);
            this.button_QuickSort.TabIndex = 18;
            this.button_QuickSort.Text = "Быстрая сортировка";
            this.button_QuickSort.UseVisualStyleBackColor = true;
            this.button_QuickSort.Click += new System.EventHandler(this.button_QuickSort_Click);
            // 
            // button_MergeSort
            // 
            this.button_MergeSort.Location = new System.Drawing.Point(158, 295);
            this.button_MergeSort.Name = "button_MergeSort";
            this.button_MergeSort.Size = new System.Drawing.Size(131, 33);
            this.button_MergeSort.TabIndex = 19;
            this.button_MergeSort.Text = "Сортировка слиянием";
            this.button_MergeSort.UseVisualStyleBackColor = true;
            this.button_MergeSort.Click += new System.EventHandler(this.button_MergeSort_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(786, 474);
            this.Controls.Add(this.button_MergeSort);
            this.Controls.Add(this.button_QuickSort);
            this.Controls.Add(this.Bubble_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackSort_button);
            this.Controls.Add(this.button_BinaryInsertionSort);
            this.Controls.Add(this.button_InsertionSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SortArr_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BinarySearch_button);
            this.Controls.Add(this.SequentialSearch_button);
            this.Controls.Add(this.Result_textBox);
            this.Controls.Add(this.Arr_textBox);
            this.Controls.Add(this.FindNumber_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SortArr_button);
            this.Controls.Add(this.CountOfArr_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetArr_button);
            this.Name = "MainForm";
            this.Text = "Algorithms and Sorting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetArr_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountOfArr_textBox;
        private System.Windows.Forms.Button SortArr_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FindNumber_textBox;
        private System.Windows.Forms.TextBox Arr_textBox;
        private System.Windows.Forms.TextBox Result_textBox;
        private System.Windows.Forms.Button SequentialSearch_button;
        private System.Windows.Forms.Button BinarySearch_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SortArr_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_InsertionSort;
        private System.Windows.Forms.Button button_BinaryInsertionSort;
        private System.Windows.Forms.Button BackSort_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Step_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Shell_button;
        private System.Windows.Forms.Button Bubble_button;
        private System.Windows.Forms.Button button_QuickSort;
        private System.Windows.Forms.Button button_MergeSort;
    }
}


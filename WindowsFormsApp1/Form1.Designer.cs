namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtBoxSource = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnRemoveSpaces = new System.Windows.Forms.Button();
            this.btnUperrcase = new System.Windows.Forms.Button();
            this.btnSwapFirstLastLetterInWord = new System.Windows.Forms.Button();
            this.btnModDate = new System.Windows.Forms.Button();
            this.btnSaveTXT = new System.Windows.Forms.Button();
            this.btnAzSort = new System.Windows.Forms.Button();
            this.btnChooseDir = new System.Windows.Forms.Button();
            this.btnCleanDir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxSource
            // 
            this.txtBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxSource, 5);
            this.txtBoxSource.Location = new System.Drawing.Point(151, 6);
            this.txtBoxSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtBoxSource.Multiline = true;
            this.txtBoxSource.Name = "txtBoxSource";
            this.txtBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxSource.Size = new System.Drawing.Size(734, 138);
            this.txtBoxSource.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28469F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28469F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28469F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28469F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28469F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28469F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29183F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxResult, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxSource, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSwap, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveSpaces, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnUperrcase, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSwapFirstLastLetterInWord, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnModDate, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveTXT, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAzSort, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnChooseDir, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCleanDir, 6, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат";
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxResult, 5);
            this.txtBoxResult.Location = new System.Drawing.Point(151, 156);
            this.txtBoxResult.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtBoxResult.Multiline = true;
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxResult.Size = new System.Drawing.Size(734, 138);
            this.txtBoxResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходный текст";
            // 
            // btnSwap
            // 
            this.btnSwap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwap.Location = new System.Drawing.Point(6, 306);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(6);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(136, 138);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "Поменять текста местами";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // btnRemoveSpaces
            // 
            this.btnRemoveSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSpaces.Location = new System.Drawing.Point(154, 306);
            this.btnRemoveSpaces.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemoveSpaces.Name = "btnRemoveSpaces";
            this.btnRemoveSpaces.Size = new System.Drawing.Size(136, 138);
            this.btnRemoveSpaces.TabIndex = 6;
            this.btnRemoveSpaces.Text = "Убрать пробелы и переносы строк";
            this.btnRemoveSpaces.UseVisualStyleBackColor = true;
            this.btnRemoveSpaces.Click += new System.EventHandler(this.BtnRemoveSpaces_Click);
            // 
            // btnUperrcase
            // 
            this.btnUperrcase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUperrcase.Location = new System.Drawing.Point(302, 306);
            this.btnUperrcase.Margin = new System.Windows.Forms.Padding(6);
            this.btnUperrcase.Name = "btnUperrcase";
            this.btnUperrcase.Size = new System.Drawing.Size(136, 138);
            this.btnUperrcase.TabIndex = 4;
            this.btnUperrcase.Text = "Все слова начинаются с заглавной буквы";
            this.btnUperrcase.UseVisualStyleBackColor = true;
            this.btnUperrcase.Click += new System.EventHandler(this.BtnUperrcase_Click);
            // 
            // btnSwapFirstLastLetterInWord
            // 
            this.btnSwapFirstLastLetterInWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwapFirstLastLetterInWord.Location = new System.Drawing.Point(450, 306);
            this.btnSwapFirstLastLetterInWord.Margin = new System.Windows.Forms.Padding(6);
            this.btnSwapFirstLastLetterInWord.Name = "btnSwapFirstLastLetterInWord";
            this.btnSwapFirstLastLetterInWord.Size = new System.Drawing.Size(136, 138);
            this.btnSwapFirstLastLetterInWord.TabIndex = 7;
            this.btnSwapFirstLastLetterInWord.Text = "Поменять местами первую и последнюю буквы каждого слова";
            this.btnSwapFirstLastLetterInWord.UseVisualStyleBackColor = true;
            this.btnSwapFirstLastLetterInWord.Click += new System.EventHandler(this.BtnSwapFirstLastLetterInWord_Click);
            // 
            // btnModDate
            // 
            this.btnModDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModDate.Location = new System.Drawing.Point(894, 306);
            this.btnModDate.Margin = new System.Windows.Forms.Padding(6);
            this.btnModDate.Name = "btnModDate";
            this.btnModDate.Size = new System.Drawing.Size(142, 138);
            this.btnModDate.TabIndex = 9;
            this.btnModDate.Text = "Обработать дату";
            this.btnModDate.UseVisualStyleBackColor = true;
            this.btnModDate.Click += new System.EventHandler(this.BtnModDate_Click);
            // 
            // btnSaveTXT
            // 
            this.btnSaveTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTXT.Location = new System.Drawing.Point(746, 306);
            this.btnSaveTXT.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveTXT.Name = "btnSaveTXT";
            this.btnSaveTXT.Size = new System.Drawing.Size(136, 138);
            this.btnSaveTXT.TabIndex = 8;
            this.btnSaveTXT.Text = "Сохранить исходный текст";
            this.btnSaveTXT.UseVisualStyleBackColor = true;
            this.btnSaveTXT.Click += new System.EventHandler(this.BtnSaveTXT_Click);
            // 
            // btnAzSort
            // 
            this.btnAzSort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAzSort.Location = new System.Drawing.Point(598, 306);
            this.btnAzSort.Margin = new System.Windows.Forms.Padding(6);
            this.btnAzSort.Name = "btnAzSort";
            this.btnAzSort.Size = new System.Drawing.Size(136, 138);
            this.btnAzSort.TabIndex = 10;
            this.btnAzSort.Text = "Отсортировать в алфавитном порядке";
            this.btnAzSort.UseVisualStyleBackColor = true;
            this.btnAzSort.Click += new System.EventHandler(this.BtnAzSort_Click);
            // 
            // btnChooseDir
            // 
            this.btnChooseDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseDir.Location = new System.Drawing.Point(894, 6);
            this.btnChooseDir.Margin = new System.Windows.Forms.Padding(6);
            this.btnChooseDir.Name = "btnChooseDir";
            this.btnChooseDir.Size = new System.Drawing.Size(142, 138);
            this.btnChooseDir.TabIndex = 9;
            this.btnChooseDir.Text = "Выбрать папку";
            this.btnChooseDir.UseVisualStyleBackColor = true;
            this.btnChooseDir.Click += new System.EventHandler(this.BtnChooseDir_Click);
            // 
            // btnCleanDir
            // 
            this.btnCleanDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanDir.Location = new System.Drawing.Point(894, 156);
            this.btnCleanDir.Margin = new System.Windows.Forms.Padding(6);
            this.btnCleanDir.Name = "btnCleanDir";
            this.btnCleanDir.Size = new System.Drawing.Size(142, 138);
            this.btnCleanDir.TabIndex = 9;
            this.btnCleanDir.Text = "Очистить папку";
            this.btnCleanDir.UseVisualStyleBackColor = true;
            this.btnCleanDir.Click += new System.EventHandler(this.BtnCleanDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected internal System.Windows.Forms.TextBox txtBoxSource;
        protected internal System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUperrcase;
        private System.Windows.Forms.Button btnRemoveSpaces;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnModDate;
        private System.Windows.Forms.Button btnSaveTXT;
        private System.Windows.Forms.Button btnSwapFirstLastLetterInWord;
        private System.Windows.Forms.Button btnAzSort;
        private System.Windows.Forms.Button btnChooseDir;
        private System.Windows.Forms.Button btnCleanDir;
    }
}


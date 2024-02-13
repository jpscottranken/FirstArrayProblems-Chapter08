namespace GUIApp1
{
    partial class frmArrayGUI
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
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.btnOrginalArray = new System.Windows.Forms.Button();
            this.btnSmallestElement = new System.Windows.Forms.Button();
            this.btnLargestElement = new System.Windows.Forms.Button();
            this.btnSumOfElements = new System.Windows.Forms.Button();
            this.btnAvgOfElements = new System.Windows.Forms.Button();
            this.btnSortDescending = new System.Windows.Forms.Button();
            this.btnSortAscending = new System.Windows.Forms.Button();
            this.btnRange = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCSharpSearch = new System.Windows.Forms.Button();
            this.btnVisualBasicSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.Font = new System.Drawing.Font("Arial Narrow", 18.25F, System.Drawing.FontStyle.Bold);
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 29;
            this.lstNumbers.Location = new System.Drawing.Point(30, 21);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(65, 729);
            this.lstNumbers.TabIndex = 13;
            // 
            // btnOrginalArray
            // 
            this.btnOrginalArray.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrginalArray.Location = new System.Drawing.Point(162, 21);
            this.btnOrginalArray.Name = "btnOrginalArray";
            this.btnOrginalArray.Size = new System.Drawing.Size(113, 49);
            this.btnOrginalArray.TabIndex = 0;
            this.btnOrginalArray.Text = "Original";
            this.btnOrginalArray.UseVisualStyleBackColor = true;
            this.btnOrginalArray.Click += new System.EventHandler(this.btnOrginalArray_Click);
            // 
            // btnSmallestElement
            // 
            this.btnSmallestElement.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmallestElement.Location = new System.Drawing.Point(162, 348);
            this.btnSmallestElement.Name = "btnSmallestElement";
            this.btnSmallestElement.Size = new System.Drawing.Size(113, 49);
            this.btnSmallestElement.TabIndex = 5;
            this.btnSmallestElement.Text = "Smallest";
            this.btnSmallestElement.UseVisualStyleBackColor = true;
            this.btnSmallestElement.Click += new System.EventHandler(this.btnSmallestElement_Click);
            // 
            // btnLargestElement
            // 
            this.btnLargestElement.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargestElement.Location = new System.Drawing.Point(162, 459);
            this.btnLargestElement.Name = "btnLargestElement";
            this.btnLargestElement.Size = new System.Drawing.Size(113, 49);
            this.btnLargestElement.TabIndex = 7;
            this.btnLargestElement.Text = "Largest";
            this.btnLargestElement.UseVisualStyleBackColor = true;
            this.btnLargestElement.Click += new System.EventHandler(this.btnLargestElement_Click);
            // 
            // btnSumOfElements
            // 
            this.btnSumOfElements.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumOfElements.Location = new System.Drawing.Point(162, 577);
            this.btnSumOfElements.Name = "btnSumOfElements";
            this.btnSumOfElements.Size = new System.Drawing.Size(113, 49);
            this.btnSumOfElements.TabIndex = 9;
            this.btnSumOfElements.Text = "Sum";
            this.btnSumOfElements.UseVisualStyleBackColor = true;
            this.btnSumOfElements.Click += new System.EventHandler(this.btnSumOfElements_Click);
            // 
            // btnAvgOfElements
            // 
            this.btnAvgOfElements.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvgOfElements.Location = new System.Drawing.Point(162, 689);
            this.btnAvgOfElements.Name = "btnAvgOfElements";
            this.btnAvgOfElements.Size = new System.Drawing.Size(113, 49);
            this.btnAvgOfElements.TabIndex = 11;
            this.btnAvgOfElements.Text = "Avg";
            this.btnAvgOfElements.UseVisualStyleBackColor = true;
            this.btnAvgOfElements.Click += new System.EventHandler(this.btnAvgOfElements_Click);
            // 
            // btnSortDescending
            // 
            this.btnSortDescending.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortDescending.Location = new System.Drawing.Point(162, 236);
            this.btnSortDescending.Name = "btnSortDescending";
            this.btnSortDescending.Size = new System.Drawing.Size(113, 49);
            this.btnSortDescending.TabIndex = 3;
            this.btnSortDescending.Text = "Desc";
            this.btnSortDescending.UseVisualStyleBackColor = true;
            this.btnSortDescending.Click += new System.EventHandler(this.btnSortDescending_Click);
            // 
            // btnSortAscending
            // 
            this.btnSortAscending.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAscending.Location = new System.Drawing.Point(162, 125);
            this.btnSortAscending.Name = "btnSortAscending";
            this.btnSortAscending.Size = new System.Drawing.Size(113, 49);
            this.btnSortAscending.TabIndex = 1;
            this.btnSortAscending.Text = "Asc";
            this.btnSortAscending.UseVisualStyleBackColor = true;
            this.btnSortAscending.Click += new System.EventHandler(this.btnSortAscending_Click);
            // 
            // btnRange
            // 
            this.btnRange.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRange.Location = new System.Drawing.Point(353, 125);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(113, 49);
            this.btnRange.TabIndex = 2;
            this.btnRange.Text = "Range";
            this.btnRange.UseVisualStyleBackColor = true;
            this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
            // 
            // btnMedian
            // 
            this.btnMedian.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedian.Location = new System.Drawing.Point(353, 236);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(113, 49);
            this.btnMedian.TabIndex = 4;
            this.btnMedian.Text = "Median";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(353, 689);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 49);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(353, 577);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 49);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCSharpSearch
            // 
            this.btnCSharpSearch.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSharpSearch.Location = new System.Drawing.Point(353, 459);
            this.btnCSharpSearch.Name = "btnCSharpSearch";
            this.btnCSharpSearch.Size = new System.Drawing.Size(113, 49);
            this.btnCSharpSearch.TabIndex = 8;
            this.btnCSharpSearch.Text = "C#S";
            this.btnCSharpSearch.UseVisualStyleBackColor = true;
            this.btnCSharpSearch.Click += new System.EventHandler(this.btnCSharpSearch_Click);
            // 
            // btnVisualBasicSearch
            // 
            this.btnVisualBasicSearch.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualBasicSearch.Location = new System.Drawing.Point(353, 348);
            this.btnVisualBasicSearch.Name = "btnVisualBasicSearch";
            this.btnVisualBasicSearch.Size = new System.Drawing.Size(113, 49);
            this.btnVisualBasicSearch.TabIndex = 6;
            this.btnVisualBasicSearch.Text = "VBS";
            this.btnVisualBasicSearch.UseVisualStyleBackColor = true;
            this.btnVisualBasicSearch.Click += new System.EventHandler(this.btnVisualBasicSearch_Click);
            // 
            // frmArrayGUI
            // 
            this.AcceptButton = this.btnOrginalArray;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(514, 775);
            this.Controls.Add(this.btnRange);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCSharpSearch);
            this.Controls.Add(this.btnVisualBasicSearch);
            this.Controls.Add(this.btnSortAscending);
            this.Controls.Add(this.btnSortDescending);
            this.Controls.Add(this.btnAvgOfElements);
            this.Controls.Add(this.btnSumOfElements);
            this.Controls.Add(this.btnLargestElement);
            this.Controls.Add(this.btnSmallestElement);
            this.Controls.Add(this.btnOrginalArray);
            this.Controls.Add(this.lstNumbers);
            this.Name = "frmArrayGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array GUI";
            this.Load += new System.EventHandler(this.frmArrayGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Button btnOrginalArray;
        private System.Windows.Forms.Button btnSmallestElement;
        private System.Windows.Forms.Button btnLargestElement;
        private System.Windows.Forms.Button btnSumOfElements;
        private System.Windows.Forms.Button btnAvgOfElements;
        private System.Windows.Forms.Button btnSortDescending;
        private System.Windows.Forms.Button btnSortAscending;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCSharpSearch;
        private System.Windows.Forms.Button btnVisualBasicSearch;
    }
}


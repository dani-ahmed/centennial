
namespace ExpenseCalculator
{
    partial class ExpenseTracker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RecreationBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.REQID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTERVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INCOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXPENSES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CASH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEARLYCASH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntervalBox = new System.Windows.Forms.ComboBox();
            this.IncomeBox = new System.Windows.Forms.TextBox();
            this.FoodBox = new System.Windows.Forms.TextBox();
            this.TravelBox = new System.Windows.Forms.TextBox();
            this.BillsBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense Tracker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interval:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recreation(-):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Travel(-):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Income(+):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // RecreationBox
            // 
            this.RecreationBox.Location = new System.Drawing.Point(97, 187);
            this.RecreationBox.Name = "RecreationBox";
            this.RecreationBox.Size = new System.Drawing.Size(100, 23);
            this.RecreationBox.TabIndex = 4;
            this.RecreationBox.TextChanged += new System.EventHandler(this.RecreationBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Food(-):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bills(-):";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(97, 277);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 23);
            this.SubmitButton.TabIndex = 13;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REQID,
            this.INTERVAL,
            this.INCOME,
            this.EXPENSES,
            this.CASH,
            this.YEARLYCASH});
            this.dataGridView1.Location = new System.Drawing.Point(203, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(663, 173);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // REQID
            // 
            this.REQID.HeaderText = "REQUEST ID";
            this.REQID.Name = "REQID";
            // 
            // INTERVAL
            // 
            this.INTERVAL.HeaderText = "INTERVAL";
            this.INTERVAL.Name = "INTERVAL";
            // 
            // INCOME
            // 
            this.INCOME.HeaderText = "INCOME";
            this.INCOME.Name = "INCOME";
            // 
            // EXPENSES
            // 
            this.EXPENSES.HeaderText = "EXPENSES";
            this.EXPENSES.Name = "EXPENSES";
            // 
            // CASH
            // 
            this.CASH.HeaderText = "CASH";
            this.CASH.Name = "CASH";
            // 
            // YEARLYCASH
            // 
            this.YEARLYCASH.HeaderText = "YEARLY CASH";
            this.YEARLYCASH.Name = "YEARLYCASH";
            // 
            // IntervalBox
            // 
            this.IntervalBox.AutoCompleteCustomSource.AddRange(new string[] {
            "WEEKLY",
            "BIWEEKLY",
            "MONTHLY",
            "YEARLY"});
            this.IntervalBox.FormattingEnabled = true;
            this.IntervalBox.Items.AddRange(new object[] {
            "YEARLY",
            "MONTHLY",
            "BIWEEKLY",
            "WEEKLY"});
            this.IntervalBox.Location = new System.Drawing.Point(97, 97);
            this.IntervalBox.Name = "IntervalBox";
            this.IntervalBox.Size = new System.Drawing.Size(100, 23);
            this.IntervalBox.TabIndex = 1;
            this.IntervalBox.SelectedIndexChanged += new System.EventHandler(this.IntervalBox_SelectedIndexChanged);
            // 
            // IncomeBox
            // 
            this.IncomeBox.Location = new System.Drawing.Point(97, 127);
            this.IncomeBox.Name = "IncomeBox";
            this.IncomeBox.Size = new System.Drawing.Size(100, 23);
            this.IncomeBox.TabIndex = 2;
            this.IncomeBox.TextChanged += new System.EventHandler(this.IncomeBox_TextChanged);
            // 
            // FoodBox
            // 
            this.FoodBox.Location = new System.Drawing.Point(97, 157);
            this.FoodBox.Name = "FoodBox";
            this.FoodBox.Size = new System.Drawing.Size(100, 23);
            this.FoodBox.TabIndex = 3;
            // 
            // TravelBox
            // 
            this.TravelBox.Location = new System.Drawing.Point(97, 217);
            this.TravelBox.Name = "TravelBox";
            this.TravelBox.Size = new System.Drawing.Size(100, 23);
            this.TravelBox.TabIndex = 5;
            this.TravelBox.TextChanged += new System.EventHandler(this.TravelBox_TextChanged);
            // 
            // BillsBox
            // 
            this.BillsBox.Location = new System.Drawing.Point(97, 247);
            this.BillsBox.Name = "BillsBox";
            this.BillsBox.Size = new System.Drawing.Size(100, 23);
            this.BillsBox.TabIndex = 6;
            this.BillsBox.TextChanged += new System.EventHandler(this.BillsBox_TextChanged);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(204, 277);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 20;
            this.LoadButton.Text = "LOAD FROM FILE";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(286, 277);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "DELETE ";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExpenseTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 389);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.BillsBox);
            this.Controls.Add(this.TravelBox);
            this.Controls.Add(this.FoodBox);
            this.Controls.Add(this.IncomeBox);
            this.Controls.Add(this.IntervalBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RecreationBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExpenseTracker";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RecreationBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox IntervalBox;
        private System.Windows.Forms.TextBox IncomeBox;
        private System.Windows.Forms.TextBox FoodBox;
        private System.Windows.Forms.TextBox TravelBox;
        private System.Windows.Forms.TextBox BillsBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQID;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTERVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn INCOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPENSES;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASH;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEARLYCASH;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button DeleteButton;
    }
}


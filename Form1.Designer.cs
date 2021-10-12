
namespace matrix
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_matrix = new System.Windows.Forms.DataGridView();
            this.button_create = new System.Windows.Forms.Button();
            this.button_repeat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_matrix
            // 
            this.dataGridView_matrix.AllowUserToAddRows = false;
            this.dataGridView_matrix.AllowUserToDeleteRows = false;
            this.dataGridView_matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_matrix.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_matrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_matrix.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_matrix.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_matrix.Location = new System.Drawing.Point(133, 12);
            this.dataGridView_matrix.Name = "dataGridView_matrix";
            this.dataGridView_matrix.ReadOnly = true;
            this.dataGridView_matrix.RowHeadersVisible = false;
            this.dataGridView_matrix.RowTemplate.Height = 25;
            this.dataGridView_matrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView_matrix.Size = new System.Drawing.Size(184, 152);
            this.dataGridView_matrix.TabIndex = 0;
            // 
            // button_create
            // 
            this.button_create.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_create.Location = new System.Drawing.Point(12, 176);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(198, 30);
            this.button_create.TabIndex = 1;
            this.button_create.Text = "Создать матрицу";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_repeat
            // 
            this.button_repeat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_repeat.Location = new System.Drawing.Point(229, 176);
            this.button_repeat.Name = "button_repeat";
            this.button_repeat.Size = new System.Drawing.Size(207, 30);
            this.button_repeat.TabIndex = 3;
            this.button_repeat.Text = "Узнать частоту повторений";
            this.button_repeat.UseVisualStyleBackColor = true;
            this.button_repeat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 226);
            this.Controls.Add(this.button_repeat);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.dataGridView_matrix);
            this.Name = "Form1";
            this.Text = "Матрица";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_matrix;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_repeat;
    }
}


namespace SchoolAssignmentSoft
{
    partial class Form2
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
            this.dgvUser2 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.queryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser2
            // 
            this.dgvUser2.AllowUserToAddRows = false;
            this.dgvUser2.AllowUserToDeleteRows = false;
            this.dgvUser2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser2.Location = new System.Drawing.Point(30, 42);
            this.dgvUser2.Name = "dgvUser2";
            this.dgvUser2.RowHeadersWidth = 51;
            this.dgvUser2.RowTemplate.Height = 24;
            this.dgvUser2.Size = new System.Drawing.Size(1056, 423);
            this.dgvUser2.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(30, 471);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(247, 54);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // queryComboBox
            // 
            this.queryComboBox.FormattingEnabled = true;
            this.queryComboBox.Items.AddRange(new object[] {
            "List of users with largest number of friends",
            "List of users whos id is a multiple of 985",
            "List of users who are Male",
            "List of users who are Female whos id is a multiple of 985",
            "List of users who are Male whos id is a multiple of 985 sorted alphabetically"});
            this.queryComboBox.Location = new System.Drawing.Point(30, 12);
            this.queryComboBox.Name = "queryComboBox";
            this.queryComboBox.Size = new System.Drawing.Size(1056, 24);
            this.queryComboBox.TabIndex = 21;
            this.queryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 549);
            this.Controls.Add(this.queryComboBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvUser2);
            this.Name = "Form2";
            this.Text = "FaceBookQuery";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox queryComboBox;
    }
}
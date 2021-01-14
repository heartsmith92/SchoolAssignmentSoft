namespace SchoolAssignmentSoft
{
    partial class form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtHometown = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRelationshipStatus = new System.Windows.Forms.TextBox();
            this.RelationshipStatus = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.CityCurrentTown = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 43);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(14, 24);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(76, 17);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(115, 24);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(170, 22);
            this.txtFname.TabIndex = 2;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(321, 24);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(807, 423);
            this.dgvUser.TabIndex = 3;
            this.dgvUser.DoubleClick += new System.EventHandler(this.dgvUser_DoubleClick);
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(115, 61);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(170, 22);
            this.txtLname.TabIndex = 6;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(14, 64);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(76, 17);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "Last Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(111, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 43);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(115, 101);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(170, 22);
            this.txtGender.TabIndex = 9;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(14, 104);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(56, 17);
            this.Gender.TabIndex = 8;
            this.Gender.Text = "Gender";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(205, 325);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 43);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtHometown
            // 
            this.txtHometown.Location = new System.Drawing.Point(115, 141);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.Size = new System.Drawing.Size(170, 22);
            this.txtHometown.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Home Town";
            // 
            // txtRelationshipStatus
            // 
            this.txtRelationshipStatus.Location = new System.Drawing.Point(115, 236);
            this.txtRelationshipStatus.Name = "txtRelationshipStatus";
            this.txtRelationshipStatus.Size = new System.Drawing.Size(170, 22);
            this.txtRelationshipStatus.TabIndex = 16;
            // 
            // RelationshipStatus
            // 
            this.RelationshipStatus.AutoSize = true;
            this.RelationshipStatus.Location = new System.Drawing.Point(14, 236);
            this.RelationshipStatus.Name = "RelationshipStatus";
            this.RelationshipStatus.Size = new System.Drawing.Size(90, 34);
            this.RelationshipStatus.TabIndex = 15;
            this.RelationshipStatus.Text = "Relationship \r\nStatus";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(115, 188);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(170, 22);
            this.txtCity.TabIndex = 18;
            // 
            // CityCurrentTown
            // 
            this.CityCurrentTown.AutoSize = true;
            this.CityCurrentTown.Location = new System.Drawing.Point(14, 188);
            this.CityCurrentTown.Name = "CityCurrentTown";
            this.CityCurrentTown.Size = new System.Drawing.Size(89, 34);
            this.CityCurrentTown.TabIndex = 17;
            this.CityCurrentTown.Text = "City/\r\nCurrentTown";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(17, 393);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(272, 54);
            this.btnQuery.TabIndex = 19;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Double Click Row to update";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.CityCurrentTown);
            this.Controls.Add(this.txtRelationshipStatus);
            this.Controls.Add(this.RelationshipStatus);
            this.Controls.Add(this.txtHometown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.btnSave);
            this.Name = "form1";
            this.Text = "FacebookCRUD";
            this.Load += new System.EventHandler(this.txtFirstName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtHometown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRelationshipStatus;
        private System.Windows.Forms.Label RelationshipStatus;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label CityCurrentTown;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label1;
    }
}


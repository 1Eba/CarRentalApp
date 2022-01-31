namespace CarRentalApp
{
    partial class ManageUsers
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeactivateUser = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(14, 71);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 30);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeactivateUser
            // 
            this.btnDeactivateUser.Location = new System.Drawing.Point(386, 313);
            this.btnDeactivateUser.Name = "btnDeactivateUser";
            this.btnDeactivateUser.Size = new System.Drawing.Size(141, 46);
            this.btnDeactivateUser.TabIndex = 18;
            this.btnDeactivateUser.Text = "Deactivate/Activate User";
            this.btnDeactivateUser.UseVisualStyleBackColor = true;
            this.btnDeactivateUser.Click += new System.EventHandler(this.btnDeactivateUser_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(191, 313);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(118, 46);
            this.btnResetPassword.TabIndex = 17;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(17, 313);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(118, 46);
            this.btnAddUser.TabIndex = 16;
            this.btnAddUser.Text = "Add New user";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // gvUserList
            // 
            this.gvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserList.Location = new System.Drawing.Point(17, 107);
            this.gvUserList.Name = "gvUserList";
            this.gvUserList.Size = new System.Drawing.Size(510, 183);
            this.gvUserList.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Manage Users";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 388);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeactivateUser);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.gvUserList);
            this.Controls.Add(this.label1);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeactivateUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView gvUserList;
        private System.Windows.Forms.Label label1;
    }
}
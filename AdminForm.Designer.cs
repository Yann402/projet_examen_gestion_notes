namespace GestionNotesExamesApp
{
    partial class AdminForm
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
            dgvUsers = new DataGridView();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnAddUser = new Button();
            btnSaveChanges = new Button();
            btnDeleteUser = new Button();
            txtRole = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(32, 12);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(779, 135);
            dgvUsers.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(293, 183);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(231, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(293, 233);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(231, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(146, 352);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(125, 34);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "Ajouter";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(343, 353);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(125, 33);
            btnSaveChanges.TabIndex = 4;
            btnSaveChanges.Text = "Sauvegarder";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(547, 352);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(125, 33);
            btnDeleteUser.TabIndex = 5;
            btnDeleteUser.Text = "Supprimer";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(293, 289);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(231, 23);
            txtRole.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 186);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nom :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 236);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 8;
            label2.Text = "Mot de passe :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 297);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Rôle :";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 416);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRole);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnAddUser);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(dgvUsers);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnAddUser;
        private Button btnSaveChanges;
        private Button btnDeleteUser;
        private TextBox txtRole;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
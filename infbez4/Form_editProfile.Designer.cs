namespace infbez4
{
    partial class Form_editProfile
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_loginChange = new System.Windows.Forms.Button();
            this.toolTip_UserPicture = new System.Windows.Forms.ToolTip(this.components);
            this.txt_role = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_passwordNew = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_passwordChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::infbez4.Properties.Resources.human;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 0;
            this.toolTip_UserPicture.SetToolTip(this.button1, "К сожалению, пока что в данной версии приложения не поддерживается фотокарточка у" +
        " пользователя :(");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_id.Location = new System.Drawing.Point(7, 140);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(318, 27);
            this.txt_id.TabIndex = 1;
            // 
            // txt_login
            // 
            this.txt_login.BackColor = System.Drawing.Color.White;
            this.txt_login.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_login.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_login.Location = new System.Drawing.Point(7, 265);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(318, 30);
            this.txt_login.TabIndex = 2;
            this.txt_login.TextChanged += new System.EventHandler(this.txt_login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Роль доступа";
            // 
            // btn_loginChange
            // 
            this.btn_loginChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loginChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loginChange.Location = new System.Drawing.Point(220, 301);
            this.btn_loginChange.Name = "btn_loginChange";
            this.btn_loginChange.Size = new System.Drawing.Size(105, 30);
            this.btn_loginChange.TabIndex = 5;
            this.btn_loginChange.Text = "Сменить логин";
            this.btn_loginChange.UseVisualStyleBackColor = true;
            this.btn_loginChange.Click += new System.EventHandler(this.btn_loginChange_Click);
            // 
            // toolTip_UserPicture
            // 
            this.toolTip_UserPicture.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_UserPicture.ToolTipTitle = "Инфо";
            // 
            // txt_role
            // 
            this.txt_role.BackColor = System.Drawing.Color.White;
            this.txt_role.Enabled = false;
            this.txt_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_role.Location = new System.Drawing.Point(7, 202);
            this.txt_role.Name = "txt_role";
            this.txt_role.ReadOnly = true;
            this.txt_role.Size = new System.Drawing.Size(318, 27);
            this.txt_role.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Логин";
            // 
            // txt_passwordNew
            // 
            this.txt_passwordNew.BackColor = System.Drawing.Color.White;
            this.txt_passwordNew.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_passwordNew.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwordNew.Location = new System.Drawing.Point(7, 369);
            this.txt_passwordNew.Name = "txt_passwordNew";
            this.txt_passwordNew.Size = new System.Drawing.Size(318, 30);
            this.txt_passwordNew.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(7, 335);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(231, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Включить смену пароля";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_passwordChange
            // 
            this.btn_passwordChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_passwordChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_passwordChange.Location = new System.Drawing.Point(94, 405);
            this.btn_passwordChange.Name = "btn_passwordChange";
            this.btn_passwordChange.Size = new System.Drawing.Size(168, 30);
            this.btn_passwordChange.TabIndex = 10;
            this.btn_passwordChange.Text = "Сохранить пароль";
            this.btn_passwordChange.UseVisualStyleBackColor = true;
            this.btn_passwordChange.Click += new System.EventHandler(this.btn_passwordChange_Click);
            // 
            // Form_editProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 444);
            this.Controls.Add(this.btn_passwordChange);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_passwordNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.btn_loginChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_editProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование профиля";
            this.Load += new System.EventHandler(this.Form_editProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_loginChange;
        private System.Windows.Forms.ToolTip toolTip_UserPicture;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_passwordNew;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_passwordChange;
    }
}
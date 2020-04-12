namespace infbez4
{
    partial class Form_editSearch
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
            this.btn_change = new System.Windows.Forms.Button();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.btn_setDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_change
            // 
            this.btn_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_change.Location = new System.Drawing.Point(7, 69);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(113, 38);
            this.btn_change.TabIndex = 0;
            this.btn_change.TabStop = false;
            this.btn_change.Text = "Изменить";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // txt_link
            // 
            this.txt_link.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_link.Location = new System.Drawing.Point(7, 17);
            this.txt_link.MaxLength = 100000;
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(425, 29);
            this.txt_link.TabIndex = 1;
            this.txt_link.TabStop = false;
            this.txt_link.WordWrap = false;
            // 
            // btn_setDefault
            // 
            this.btn_setDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_setDefault.Location = new System.Drawing.Point(304, 62);
            this.btn_setDefault.Name = "btn_setDefault";
            this.btn_setDefault.Size = new System.Drawing.Size(126, 54);
            this.btn_setDefault.TabIndex = 2;
            this.btn_setDefault.TabStop = false;
            this.btn_setDefault.Text = "Установить по умолчанию";
            this.btn_setDefault.UseVisualStyleBackColor = true;
            this.btn_setDefault.Click += new System.EventHandler(this.btn_setDefault_Click);
            // 
            // Form_editSearch
            // 
            this.AcceptButton = this.btn_change;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 129);
            this.Controls.Add(this.btn_setDefault);
            this.Controls.Add(this.txt_link);
            this.Controls.Add(this.btn_change);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_editSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование поисковой системы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Button btn_setDefault;
    }
}
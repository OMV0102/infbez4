﻿namespace infbez4
{
    partial class Form_browser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_GoHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 36);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1180, 502);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.TabStop = false;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // txt_url
            // 
            this.txt_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_url.BackColor = System.Drawing.Color.DimGray;
            this.txt_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_url.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_url.ForeColor = System.Drawing.Color.White;
            this.txt_url.Location = new System.Drawing.Point(209, 3);
            this.txt_url.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(967, 30);
            this.txt_url.TabIndex = 1;
            this.txt_url.Text = "google.ru";
            this.txt_url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_url_KeyPress);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.Gray;
            this.btn_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prev.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_prev.FlatAppearance.BorderSize = 0;
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.Font = new System.Drawing.Font("Wingdings 3", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_prev.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_prev.Location = new System.Drawing.Point(-4, -7);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(43, 43);
            this.btn_prev.TabIndex = 2;
            this.btn_prev.Text = "";
            this.btn_prev.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Gray;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Wingdings 3", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_next.Location = new System.Drawing.Point(38, -7);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(43, 43);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "";
            this.btn_next.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_GoHome
            // 
            this.btn_GoHome.BackColor = System.Drawing.Color.Gray;
            this.btn_GoHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GoHome.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_GoHome.FlatAppearance.BorderSize = 0;
            this.btn_GoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoHome.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_GoHome.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_GoHome.Location = new System.Drawing.Point(96, -7);
            this.btn_GoHome.Name = "btn_GoHome";
            this.btn_GoHome.Size = new System.Drawing.Size(43, 43);
            this.btn_GoHome.TabIndex = 4;
            this.btn_GoHome.Text = "h";
            this.btn_GoHome.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_GoHome.UseVisualStyleBackColor = false;
            this.btn_GoHome.Click += new System.EventHandler(this.btn_GoHome_Click);
            // 
            // Form_browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1180, 538);
            this.Controls.Add(this.btn_GoHome);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrowserApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_browser_FormClosed);
            this.Load += new System.EventHandler(this.Form_browser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_GoHome;
    }
}
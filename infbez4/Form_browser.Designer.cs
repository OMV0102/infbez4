namespace infbez4
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
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.label_user_login = new System.Windows.Forms.Label();
            this.contextMenu_user = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dfgdfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfgToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfgToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfgToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfgToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfgToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_refreshOrStop = new System.Windows.Forms.Button();
            this.btn_GoHome = new System.Windows.Forms.Button();
            this.contextMenu_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 41);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1180, 502);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.TabStop = false;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
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
            this.txt_url.Size = new System.Drawing.Size(796, 30);
            this.txt_url.TabIndex = 1;
            this.txt_url.TabStop = false;
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
            this.btn_prev.ForeColor = System.Drawing.Color.Black;
            this.btn_prev.Location = new System.Drawing.Point(-4, -4);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(43, 43);
            this.btn_prev.TabIndex = 2;
            this.btn_prev.TabStop = false;
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
            this.btn_next.ForeColor = System.Drawing.Color.Black;
            this.btn_next.Location = new System.Drawing.Point(38, -4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(43, 43);
            this.btn_next.TabIndex = 3;
            this.btn_next.TabStop = false;
            this.btn_next.Text = "";
            this.btn_next.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label_user_login
            // 
            this.label_user_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_user_login.BackColor = System.Drawing.Color.Transparent;
            this.label_user_login.ContextMenuStrip = this.contextMenu_user;
            this.label_user_login.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label_user_login.Location = new System.Drawing.Point(1034, 0);
            this.label_user_login.Name = "label_user_login";
            this.label_user_login.Size = new System.Drawing.Size(146, 36);
            this.label_user_login.TabIndex = 88;
            this.label_user_login.Text = "user_login";
            this.label_user_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenu_user
            // 
            this.contextMenu_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenu_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfgdfgToolStripMenuItem,
            this.dfgdfgToolStripMenuItem1});
            this.contextMenu_user.Name = "contextMenu_user";
            this.contextMenu_user.Size = new System.Drawing.Size(125, 52);
            // 
            // dfgdfgToolStripMenuItem
            // 
            this.dfgdfgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfgdfgToolStripMenuItem4,
            this.dfgToolStripMenuItem});
            this.dfgdfgToolStripMenuItem.Name = "dfgdfgToolStripMenuItem";
            this.dfgdfgToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.dfgdfgToolStripMenuItem.Text = "dfgd";
            // 
            // dfgdfgToolStripMenuItem4
            // 
            this.dfgdfgToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfgdfgToolStripMenuItem5});
            this.dfgdfgToolStripMenuItem4.Name = "dfgdfgToolStripMenuItem4";
            this.dfgdfgToolStripMenuItem4.Size = new System.Drawing.Size(124, 24);
            this.dfgdfgToolStripMenuItem4.Text = "dfgdfg";
            // 
            // dfgdfgToolStripMenuItem5
            // 
            this.dfgdfgToolStripMenuItem5.Name = "dfgdfgToolStripMenuItem5";
            this.dfgdfgToolStripMenuItem5.Size = new System.Drawing.Size(124, 24);
            this.dfgdfgToolStripMenuItem5.Text = "dfgdfg";
            // 
            // dfgToolStripMenuItem
            // 
            this.dfgToolStripMenuItem.Name = "dfgToolStripMenuItem";
            this.dfgToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.dfgToolStripMenuItem.Text = "dfg";
            // 
            // dfgdfgToolStripMenuItem1
            // 
            this.dfgdfgToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfgdfgToolStripMenuItem2,
            this.dfgdfgToolStripMenuItem3});
            this.dfgdfgToolStripMenuItem1.Name = "dfgdfgToolStripMenuItem1";
            this.dfgdfgToolStripMenuItem1.Size = new System.Drawing.Size(124, 24);
            this.dfgdfgToolStripMenuItem1.Text = "dfgdfg";
            // 
            // dfgdfgToolStripMenuItem2
            // 
            this.dfgdfgToolStripMenuItem2.Name = "dfgdfgToolStripMenuItem2";
            this.dfgdfgToolStripMenuItem2.Size = new System.Drawing.Size(124, 24);
            this.dfgdfgToolStripMenuItem2.Text = "dfgdfg";
            // 
            // dfgdfgToolStripMenuItem3
            // 
            this.dfgdfgToolStripMenuItem3.Name = "dfgdfgToolStripMenuItem3";
            this.dfgdfgToolStripMenuItem3.Size = new System.Drawing.Size(124, 24);
            this.dfgdfgToolStripMenuItem3.Text = "dfgdfg";
            // 
            // btn_refreshOrStop
            // 
            this.btn_refreshOrStop.BackColor = System.Drawing.Color.Gray;
            this.btn_refreshOrStop.BackgroundImage = global::infbez4.Properties.Resources.arrow;
            this.btn_refreshOrStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_refreshOrStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refreshOrStop.FlatAppearance.BorderSize = 0;
            this.btn_refreshOrStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshOrStop.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_refreshOrStop.Location = new System.Drawing.Point(131, 1);
            this.btn_refreshOrStop.Name = "btn_refreshOrStop";
            this.btn_refreshOrStop.Size = new System.Drawing.Size(35, 35);
            this.btn_refreshOrStop.TabIndex = 87;
            this.btn_refreshOrStop.TabStop = false;
            this.btn_refreshOrStop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_refreshOrStop.UseVisualStyleBackColor = false;
            this.btn_refreshOrStop.Click += new System.EventHandler(this.btn_refreshOrStop_Click);
            // 
            // btn_GoHome
            // 
            this.btn_GoHome.BackColor = System.Drawing.Color.Gray;
            this.btn_GoHome.BackgroundImage = global::infbez4.Properties.Resources.house;
            this.btn_GoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_GoHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GoHome.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_GoHome.FlatAppearance.BorderSize = 0;
            this.btn_GoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoHome.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_GoHome.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_GoHome.Location = new System.Drawing.Point(91, 0);
            this.btn_GoHome.Name = "btn_GoHome";
            this.btn_GoHome.Size = new System.Drawing.Size(40, 40);
            this.btn_GoHome.TabIndex = 4;
            this.btn_GoHome.TabStop = false;
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
            this.Controls.Add(this.btn_refreshOrStop);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_GoHome);
            this.Controls.Add(this.label_user_login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BrowserApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_browser_FormClosed);
            this.Load += new System.EventHandler(this.Form_browser_Load);
            this.contextMenu_user.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_GoHome;
        private System.Windows.Forms.Button btn_refreshOrStop;
        private System.Windows.Forms.Label label_user_login;
        private System.Windows.Forms.ContextMenuStrip contextMenu_user;
        private System.Windows.Forms.ToolStripMenuItem dfgdfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfgdfgToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem dfgdfgToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem dfgdfgToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dfgdfgToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dfgdfgToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dfgToolStripMenuItem;
    }
}
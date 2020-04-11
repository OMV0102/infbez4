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
            this.MenuItem_editProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_showHistory = new System.Windows.Forms.ToolStripMenuItem();
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
            this.txt_url.Location = new System.Drawing.Point(174, 5);
            this.txt_url.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(847, 30);
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
            this.label_user_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_user_login.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label_user_login.Location = new System.Drawing.Point(1028, 2);
            this.label_user_login.Name = "label_user_login";
            this.label_user_login.Size = new System.Drawing.Size(150, 38);
            this.label_user_login.TabIndex = 88;
            this.label_user_login.Text = "user_login";
            this.label_user_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_user_login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_user_login_MouseClick);
            // 
            // contextMenu_user
            // 
            this.contextMenu_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.contextMenu_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenu_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_editProfile,
            this.toolStripSeparator1,
            this.MenuItem_showHistory});
            this.contextMenu_user.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenu_user.Name = "contextMenu_user";
            this.contextMenu_user.Size = new System.Drawing.Size(258, 58);
            // 
            // MenuItem_editProfile
            // 
            this.MenuItem_editProfile.AutoToolTip = true;
            this.MenuItem_editProfile.Image = global::infbez4.Properties.Resources.human;
            this.MenuItem_editProfile.Name = "MenuItem_editProfile";
            this.MenuItem_editProfile.ShortcutKeyDisplayString = "";
            this.MenuItem_editProfile.Size = new System.Drawing.Size(257, 24);
            this.MenuItem_editProfile.Text = "Радактировать профиль";
            this.MenuItem_editProfile.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MenuItem_editProfile.ToolTipText = "Радактирование логина и смена пароля";
            this.MenuItem_editProfile.Click += new System.EventHandler(this.MenuItem_editProfile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
            // 
            // MenuItem_showHistory
            // 
            this.MenuItem_showHistory.AutoToolTip = true;
            this.MenuItem_showHistory.Image = global::infbez4.Properties.Resources.history;
            this.MenuItem_showHistory.Name = "MenuItem_showHistory";
            this.MenuItem_showHistory.Size = new System.Drawing.Size(257, 24);
            this.MenuItem_showHistory.Text = "Просмотр истории";
            this.MenuItem_showHistory.ToolTipText = "Просмотр посещенных веб страниц за все время";
            this.MenuItem_showHistory.Click += new System.EventHandler(this.MenuItem_showHistory_Click);
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
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label_user_login);
            this.Controls.Add(this.btn_refreshOrStop);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_GoHome);
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
        private System.Windows.Forms.ToolStripMenuItem MenuItem_editProfile;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_showHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
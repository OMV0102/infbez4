namespace infbez4
{
    partial class Form_historyShow
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
            this.listBox_hystory = new System.Windows.Forms.ListBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.contextMenu_listBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Navigate = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_listBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_hystory
            // 
            this.listBox_hystory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_hystory.ContextMenuStrip = this.contextMenu_listBox;
            this.listBox_hystory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBox_hystory.ItemHeight = 24;
            this.listBox_hystory.Location = new System.Drawing.Point(15, 15);
            this.listBox_hystory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_hystory.Name = "listBox_hystory";
            this.listBox_hystory.Size = new System.Drawing.Size(827, 412);
            this.listBox_hystory.TabIndex = 0;
            this.listBox_hystory.TabStop = false;
            this.listBox_hystory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_hystory_MouseDoubleClick);
            this.listBox_hystory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_hystory_MouseDown);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Location = new System.Drawing.Point(352, 433);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(147, 42);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.TabStop = false;
            this.btn_clear.Text = "Очистить всё";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // contextMenu_listBox
            // 
            this.contextMenu_listBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenu_listBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Navigate});
            this.contextMenu_listBox.Name = "contextMenu_listBox";
            this.contextMenu_listBox.Size = new System.Drawing.Size(265, 30);
            // 
            // MenuItem_Navigate
            // 
            this.MenuItem_Navigate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuItem_Navigate.Image = global::infbez4.Properties.Resources.net;
            this.MenuItem_Navigate.Name = "MenuItem_Navigate";
            this.MenuItem_Navigate.Size = new System.Drawing.Size(264, 26);
            this.MenuItem_Navigate.Text = "Перейти на этот сайт";
            this.MenuItem_Navigate.Click += new System.EventHandler(this.MenuItem_Navigate_Click);
            // 
            // Form_historyShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(856, 480);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.listBox_hystory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_historyShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "История веб-сёрфинга";
            this.Load += new System.EventHandler(this.Form_historyShow_Load);
            this.contextMenu_listBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_hystory;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ContextMenuStrip contextMenu_listBox;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Navigate;
    }
}
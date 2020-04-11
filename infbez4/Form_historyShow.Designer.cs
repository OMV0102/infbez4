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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(15, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 412);
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(94, 433);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(147, 42);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.TabStop = false;
            this.btn_clear.Text = "Очистить всё";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // Form_historyShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(341, 480);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_historyShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "История веб-сёрфинга";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_clear;
    }
}
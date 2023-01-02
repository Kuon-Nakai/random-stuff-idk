namespace SSPasteHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.src_txtbx = new System.Windows.Forms.TextBox();
            this.html_txtbx = new System.Windows.Forms.TextBox();
            this.emu_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.src_txtbx);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.html_txtbx);
            this.splitContainer1.Size = new System.Drawing.Size(1178, 616);
            this.splitContainer1.SplitterDistance = 586;
            this.splitContainer1.TabIndex = 1;
            // 
            // src_txtbx
            // 
            this.src_txtbx.AcceptsReturn = true;
            this.src_txtbx.AcceptsTab = true;
            this.src_txtbx.AllowDrop = true;
            this.src_txtbx.Location = new System.Drawing.Point(3, 3);
            this.src_txtbx.Multiline = true;
            this.src_txtbx.Name = "src_txtbx";
            this.src_txtbx.PlaceholderText = "Source text";
            this.src_txtbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.src_txtbx.Size = new System.Drawing.Size(580, 610);
            this.src_txtbx.TabIndex = 0;
            this.src_txtbx.WordWrap = false;
            // 
            // html_txtbx
            // 
            this.html_txtbx.AcceptsReturn = true;
            this.html_txtbx.AcceptsTab = true;
            this.html_txtbx.AllowDrop = true;
            this.html_txtbx.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.html_txtbx.Location = new System.Drawing.Point(5, 3);
            this.html_txtbx.Multiline = true;
            this.html_txtbx.Name = "html_txtbx";
            this.html_txtbx.PlaceholderText = "HTML text";
            this.html_txtbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.html_txtbx.Size = new System.Drawing.Size(580, 610);
            this.html_txtbx.TabIndex = 1;
            // 
            // emu_btn
            // 
            this.emu_btn.Location = new System.Drawing.Point(1078, 634);
            this.emu_btn.Name = "emu_btn";
            this.emu_btn.Size = new System.Drawing.Size(112, 34);
            this.emu_btn.TabIndex = 2;
            this.emu_btn.Text = "Emulate";
            this.emu_btn.UseVisualStyleBackColor = true;
            this.emu_btn.Click += new System.EventHandler(this.emu_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 709);
            this.Controls.Add(this.emu_btn);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "SS Paste Helper";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private SplitContainer splitContainer1;
        private TextBox src_txtbx;
        private TextBox html_txtbx;
        private Button emu_btn;
    }
}
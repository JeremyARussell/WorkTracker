namespace WorkTracker
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.lstEntries = new System.Windows.Forms.ListBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Location = new System.Drawing.Point(13, 13);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(51, 17);
            this.chkTop.TabIndex = 0;
            this.chkTop.Text = "Top?";
            this.chkTop.UseVisualStyleBackColor = true;
            this.chkTop.CheckedChanged += new System.EventHandler(this.chkTop_CheckedChanged);
            // 
            // btnTrigger
            // 
            this.btnTrigger.Location = new System.Drawing.Point(153, 33);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(156, 28);
            this.btnTrigger.TabIndex = 1;
            this.btnTrigger.Text = "Go";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(70, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(182, 26);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Start - End - Total";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(13, 67);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(419, 78);
            this.rtbNotes.TabIndex = 3;
            this.rtbNotes.Text = "";
            // 
            // btnCollapse
            // 
            this.btnCollapse.Location = new System.Drawing.Point(13, 151);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(419, 19);
            this.btnCollapse.TabIndex = 4;
            this.btnCollapse.Text = "˄     ˄     ˄     ˄     ˄     ˄     ˄     ˄     ˄";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // lstEntries
            // 
            this.lstEntries.FormattingEnabled = true;
            this.lstEntries.Location = new System.Drawing.Point(12, 176);
            this.lstEntries.Name = "lstEntries";
            this.lstEntries.Size = new System.Drawing.Size(420, 355);
            this.lstEntries.TabIndex = 5;
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 250;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(444, 547);
            this.Controls.Add(this.lstEntries);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnTrigger);
            this.Controls.Add(this.chkTop);
            this.Name = "frmMain";
            this.Text = "Work Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.ListBox lstEntries;
        private System.Windows.Forms.Timer tmr;
    }
}


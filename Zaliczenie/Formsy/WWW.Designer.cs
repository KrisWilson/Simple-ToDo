namespace Zaliczenie
{
    partial class WWW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WWW));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.main_bar = new System.Windows.Forms.GroupBox();
            this.web = new System.Windows.Forms.WebBrowser();
            this.main_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(302, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "WebBrowser ";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cat_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cat_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Cat_MouseUp);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::Zaliczenie.Properties.Resources.x;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.Location = new System.Drawing.Point(710, 19);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(30, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "X";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // main_bar
            // 
            this.main_bar.BackColor = System.Drawing.Color.Transparent;
            this.main_bar.Controls.Add(this.label2);
            this.main_bar.Controls.Add(this.btn_cancel);
            this.main_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_bar.Location = new System.Drawing.Point(-3, -11);
            this.main_bar.Name = "main_bar";
            this.main_bar.Size = new System.Drawing.Size(756, 48);
            this.main_bar.TabIndex = 9;
            this.main_bar.TabStop = false;
            this.main_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cat_MouseDown);
            this.main_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Cat_MouseUp);
            this.main_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cat_MouseMove);
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(12, 43);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(725, 533);
            this.web.TabIndex = 10;
            // 
            // WWW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zaliczenie.Properties.Resources.wallhaven_640333;
            this.ClientSize = new System.Drawing.Size(749, 588);
            this.Controls.Add(this.web);
            this.Controls.Add(this.main_bar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WWW";
            this.Text = "WWW";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddCat_Paint);
            this.main_bar.ResumeLayout(false);
            this.main_bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox main_bar;
        private System.Windows.Forms.WebBrowser web;
    }
}
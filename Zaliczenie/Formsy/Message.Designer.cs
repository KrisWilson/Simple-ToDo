namespace Zaliczenie
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.text_info = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.main_bar = new System.Windows.Forms.GroupBox();
            this.main_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_info
            // 
            this.text_info.AutoSize = true;
            this.text_info.BackColor = System.Drawing.Color.Transparent;
            this.text_info.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_info.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.text_info.Location = new System.Drawing.Point(12, 53);
            this.text_info.Name = "text_info";
            this.text_info.Size = new System.Drawing.Size(110, 22);
            this.text_info.TabIndex = 0;
            this.text_info.Text = "Informacja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(229, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informacja";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cat_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cat_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Cat_MouseUp);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(256, 176);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "OK";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // main_bar
            // 
            this.main_bar.BackColor = System.Drawing.Color.Transparent;
            this.main_bar.Controls.Add(this.label2);
            this.main_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_bar.Location = new System.Drawing.Point(-3, -11);
            this.main_bar.Name = "main_bar";
            this.main_bar.Size = new System.Drawing.Size(588, 48);
            this.main_bar.TabIndex = 9;
            this.main_bar.TabStop = false;
            this.main_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cat_MouseDown);
            this.main_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Cat_MouseUp);
            this.main_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cat_MouseMove);
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zaliczenie.Properties.Resources.wallhaven_640333;
            this.ClientSize = new System.Drawing.Size(574, 211);
            this.Controls.Add(this.main_bar);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.text_info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Message";
            this.Text = "Informacja";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddCat_Paint);
            this.main_bar.ResumeLayout(false);
            this.main_bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox main_bar;
    }
}
namespace Zaliczenie
{
    partial class AddWpis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWpis));
            this.label1 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.main_bar = new System.Windows.Forms.GroupBox();
            this.dateTimeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(91, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa wpisu:";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(20, 72);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(260, 20);
            this.text_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(47, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podgląd wpisu";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Wpis_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Wpis_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Wpis_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(97, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Opis wpisu:";
            // 
            // text_desc
            // 
            this.text_desc.Location = new System.Drawing.Point(20, 132);
            this.text_desc.Multiline = true;
            this.text_desc.Name = "text_desc";
            this.text_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_desc.Size = new System.Drawing.Size(260, 142);
            this.text_desc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(82, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data wykonania:";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(88, 311);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(203, 20);
            this.dateTime.TabIndex = 6;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(20, 373);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 0;
            this.btn_apply.Text = "Zapisz";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(205, 373);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Anuluj";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // main_bar
            // 
            this.main_bar.BackColor = System.Drawing.Color.Transparent;
            this.main_bar.Controls.Add(this.pictureBox1);
            this.main_bar.Controls.Add(this.label2);
            this.main_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_bar.Location = new System.Drawing.Point(-3, -11);
            this.main_bar.Name = "main_bar";
            this.main_bar.Size = new System.Drawing.Size(310, 48);
            this.main_bar.TabIndex = 9;
            this.main_bar.TabStop = false;
            this.main_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Wpis_MouseDown);
            this.main_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Wpis_MouseUp);
            this.main_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Wpis_MouseMove);
            // 
            // dateTimeTimePicker
            // 
            this.dateTimeTimePicker.Location = new System.Drawing.Point(12, 311);
            this.dateTimeTimePicker.Name = "dateTimeTimePicker";
            this.dateTimeTimePicker.Size = new System.Drawing.Size(71, 20);
            this.dateTimeTimePicker.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Zaliczenie.Properties.Resources.plus;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Wpis_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Wpis_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Wpis_MouseUp);
            // 
            // AddWpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zaliczenie.Properties.Resources.wallhaven_640333;
            this.ClientSize = new System.Drawing.Size(303, 408);
            this.Controls.Add(this.dateTimeTimePicker);
            this.Controls.Add(this.main_bar);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddWpis";
            this.Text = "Wyświetl Wpis";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddWpis_Paint);
            this.main_bar.ResumeLayout(false);
            this.main_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox main_bar;
        private System.Windows.Forms.DateTimePicker dateTimeTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace Zaliczenie
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.card_picture1 = new System.Windows.Forms.PictureBox();
            this.card_name1 = new System.Windows.Forms.Label();
            this.cat1 = new System.Windows.Forms.GroupBox();
            this.card_size1 = new System.Windows.Forms.Label();
            this.card1 = new System.Windows.Forms.GroupBox();
            this.img_title = new System.Windows.Forms.PictureBox();
            this.str_title = new System.Windows.Forms.Label();
            this.view_panel = new System.Windows.Forms.Panel();
            this.view_add = new System.Windows.Forms.Button();
            this.view_save = new System.Windows.Forms.Button();
            this.view_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.view_name = new System.Windows.Forms.Label();
            this.view_img_cat = new System.Windows.Forms.PictureBox();
            this.sep2 = new System.Windows.Forms.GroupBox();
            this.cat2 = new System.Windows.Forms.GroupBox();
            this.card_size2 = new System.Windows.Forms.Label();
            this.card_name2 = new System.Windows.Forms.Label();
            this.card_picture2 = new System.Windows.Forms.PictureBox();
            this.view_desc = new System.Windows.Forms.Label();
            this.cat_add = new System.Windows.Forms.Button();
            this.btn_closeX = new System.Windows.Forms.Button();
            this.main_bar = new System.Windows.Forms.GroupBox();
            this.main_btn_min = new System.Windows.Forms.Button();
            this.cat_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delta = new System.Windows.Forms.Button();
            this.openBrows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.card_picture1)).BeginInit();
            this.cat1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_title)).BeginInit();
            this.view_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_img_cat)).BeginInit();
            this.cat2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card_picture2)).BeginInit();
            this.main_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // card_picture1
            // 
            this.card_picture1.BackgroundImage = global::Zaliczenie.Properties.Resources.heart;
            this.card_picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card_picture1.Location = new System.Drawing.Point(9, 16);
            this.card_picture1.Margin = new System.Windows.Forms.Padding(4);
            this.card_picture1.Name = "card_picture1";
            this.card_picture1.Size = new System.Drawing.Size(54, 48);
            this.card_picture1.TabIndex = 0;
            this.card_picture1.TabStop = false;
            this.card_picture1.Click += new System.EventHandler(this.selectedCategory);
            this.card_picture1.MouseEnter += new System.EventHandler(this.selectingCategory);
            this.card_picture1.MouseLeave += new System.EventHandler(this.selectingCategory);
            // 
            // card_name1
            // 
            this.card_name1.AutoSize = true;
            this.card_name1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.card_name1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.card_name1.Location = new System.Drawing.Point(75, 24);
            this.card_name1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.card_name1.Name = "card_name1";
            this.card_name1.Size = new System.Drawing.Size(90, 28);
            this.card_name1.TabIndex = 1;
            this.card_name1.Text = "Ogólne";
            this.card_name1.Click += new System.EventHandler(this.selectedCategory);
            this.card_name1.MouseEnter += new System.EventHandler(this.selectingCategory);
            this.card_name1.MouseLeave += new System.EventHandler(this.selectingCategory);
            // 
            // cat1
            // 
            this.cat1.BackColor = System.Drawing.Color.Transparent;
            this.cat1.Controls.Add(this.card_size1);
            this.cat1.Controls.Add(this.card_name1);
            this.cat1.Controls.Add(this.card_picture1);
            this.cat1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cat1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cat1.Font = new System.Drawing.Font("Consolas", 1.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cat1.ForeColor = System.Drawing.Color.Maroon;
            this.cat1.Location = new System.Drawing.Point(18, 111);
            this.cat1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.cat1.Name = "cat1";
            this.cat1.Padding = new System.Windows.Forms.Padding(4);
            this.cat1.Size = new System.Drawing.Size(291, 82);
            this.cat1.TabIndex = 2;
            this.cat1.TabStop = false;
            this.cat1.Click += new System.EventHandler(this.selectedCategory);
            this.cat1.MouseEnter += new System.EventHandler(this.selectingCategory);
            this.cat1.MouseLeave += new System.EventHandler(this.selectingCategory);
            // 
            // card_size1
            // 
            this.card_size1.AutoSize = true;
            this.card_size1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.card_size1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.card_size1.Location = new System.Drawing.Point(224, 24);
            this.card_size1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.card_size1.Name = "card_size1";
            this.card_size1.Size = new System.Drawing.Size(25, 28);
            this.card_size1.TabIndex = 2;
            this.card_size1.Text = "1";
            this.card_size1.Click += new System.EventHandler(this.selectedCategory);
            this.card_size1.MouseEnter += new System.EventHandler(this.selectingCategory);
            this.card_size1.MouseLeave += new System.EventHandler(this.selectingCategory);
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.Transparent;
            this.card1.Location = new System.Drawing.Point(330, 56);
            this.card1.Margin = new System.Windows.Forms.Padding(4);
            this.card1.Name = "card1";
            this.card1.Padding = new System.Windows.Forms.Padding(4);
            this.card1.Size = new System.Drawing.Size(2, 897);
            this.card1.TabIndex = 3;
            this.card1.TabStop = false;
            // 
            // img_title
            // 
            this.img_title.BackColor = System.Drawing.Color.Transparent;
            this.img_title.BackgroundImage = global::Zaliczenie.Properties.Resources.done;
            this.img_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_title.Cursor = System.Windows.Forms.Cursors.Help;
            this.img_title.Location = new System.Drawing.Point(26, 22);
            this.img_title.Margin = new System.Windows.Forms.Padding(4);
            this.img_title.Name = "img_title";
            this.img_title.Size = new System.Drawing.Size(54, 48);
            this.img_title.TabIndex = 4;
            this.img_title.TabStop = false;
            this.img_title.Click += new System.EventHandler(this.img_title_Click);
            // 
            // str_title
            // 
            this.str_title.AutoSize = true;
            this.str_title.BackColor = System.Drawing.Color.Transparent;
            this.str_title.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.str_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.str_title.Location = new System.Drawing.Point(92, 33);
            this.str_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.str_title.Name = "str_title";
            this.str_title.Size = new System.Drawing.Size(181, 28);
            this.str_title.TabIndex = 2;
            this.str_title.Text = "Kaszuba To Do";
            this.str_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.str_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.str_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // view_panel
            // 
            this.view_panel.BackColor = System.Drawing.Color.Transparent;
            this.view_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view_panel.Controls.Add(this.view_add);
            this.view_panel.Controls.Add(this.view_save);
            this.view_panel.Controls.Add(this.view_flow);
            this.view_panel.Location = new System.Drawing.Point(340, 158);
            this.view_panel.Margin = new System.Windows.Forms.Padding(4);
            this.view_panel.Name = "view_panel";
            this.view_panel.Size = new System.Drawing.Size(840, 788);
            this.view_panel.TabIndex = 5;
            // 
            // view_add
            // 
            this.view_add.BackgroundImage = global::Zaliczenie.Properties.Resources.plus;
            this.view_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_add.ForeColor = System.Drawing.Color.BurlyWood;
            this.view_add.Location = new System.Drawing.Point(774, 722);
            this.view_add.Margin = new System.Windows.Forms.Padding(4);
            this.view_add.Name = "view_add";
            this.view_add.Size = new System.Drawing.Size(60, 60);
            this.view_add.TabIndex = 14;
            this.view_add.UseVisualStyleBackColor = true;
            this.view_add.Click += new System.EventHandler(this.view_add_Click);
            // 
            // view_save
            // 
            this.view_save.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.view_save.Location = new System.Drawing.Point(633, 722);
            this.view_save.Margin = new System.Windows.Forms.Padding(4);
            this.view_save.Name = "view_save";
            this.view_save.Size = new System.Drawing.Size(132, 60);
            this.view_save.TabIndex = 13;
            this.view_save.Text = "Zapisz wpisy do pliku";
            this.view_save.UseVisualStyleBackColor = true;
            this.view_save.Click += new System.EventHandler(this.view_save_Click);
            // 
            // view_flow
            // 
            this.view_flow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.view_flow.AutoScroll = true;
            this.view_flow.AutoSize = true;
            this.view_flow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.view_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.view_flow.Location = new System.Drawing.Point(4, 4);
            this.view_flow.Margin = new System.Windows.Forms.Padding(4);
            this.view_flow.MaximumSize = new System.Drawing.Size(840, 705);
            this.view_flow.MinimumSize = new System.Drawing.Size(840, 705);
            this.view_flow.Name = "view_flow";
            this.view_flow.Size = new System.Drawing.Size(840, 705);
            this.view_flow.TabIndex = 12;
            this.view_flow.WrapContents = false;
            // 
            // view_name
            // 
            this.view_name.AutoSize = true;
            this.view_name.BackColor = System.Drawing.Color.Transparent;
            this.view_name.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.view_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.view_name.Location = new System.Drawing.Point(664, 81);
            this.view_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.view_name.Name = "view_name";
            this.view_name.Size = new System.Drawing.Size(220, 28);
            this.view_name.TabIndex = 6;
            this.view_name.Text = "View of category";
            // 
            // view_img_cat
            // 
            this.view_img_cat.BackColor = System.Drawing.Color.Transparent;
            this.view_img_cat.BackgroundImage = global::Zaliczenie.Properties.Resources.heart;
            this.view_img_cat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_img_cat.Location = new System.Drawing.Point(602, 74);
            this.view_img_cat.Margin = new System.Windows.Forms.Padding(4);
            this.view_img_cat.Name = "view_img_cat";
            this.view_img_cat.Size = new System.Drawing.Size(54, 48);
            this.view_img_cat.TabIndex = 7;
            this.view_img_cat.TabStop = false;
            // 
            // sep2
            // 
            this.sep2.BackColor = System.Drawing.Color.Transparent;
            this.sep2.Location = new System.Drawing.Point(0, 356);
            this.sep2.Margin = new System.Windows.Forms.Padding(4);
            this.sep2.Name = "sep2";
            this.sep2.Padding = new System.Windows.Forms.Padding(4);
            this.sep2.Size = new System.Drawing.Size(330, 2);
            this.sep2.TabIndex = 4;
            this.sep2.TabStop = false;
            // 
            // cat2
            // 
            this.cat2.BackColor = System.Drawing.Color.Transparent;
            this.cat2.Controls.Add(this.card_size2);
            this.cat2.Controls.Add(this.card_name2);
            this.cat2.Controls.Add(this.card_picture2);
            this.cat2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cat2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cat2.Font = new System.Drawing.Font("Consolas", 1.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cat2.ForeColor = System.Drawing.Color.Maroon;
            this.cat2.Location = new System.Drawing.Point(18, 214);
            this.cat2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.cat2.Name = "cat2";
            this.cat2.Padding = new System.Windows.Forms.Padding(4);
            this.cat2.Size = new System.Drawing.Size(291, 82);
            this.cat2.TabIndex = 8;
            this.cat2.TabStop = false;
            this.cat2.Click += new System.EventHandler(this.selectedCategory);
            this.cat2.MouseEnter += new System.EventHandler(this.selectingCategory);
            this.cat2.MouseLeave += new System.EventHandler(this.selectingCategory);
            // 
            // card_size2
            // 
            this.card_size2.AutoSize = true;
            this.card_size2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.card_size2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.card_size2.Location = new System.Drawing.Point(224, 24);
            this.card_size2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.card_size2.Name = "card_size2";
            this.card_size2.Size = new System.Drawing.Size(25, 28);
            this.card_size2.TabIndex = 2;
            this.card_size2.Text = "1";
            this.card_size2.Click += new System.EventHandler(this.selectedCategory);
            this.card_size2.MouseEnter += new System.EventHandler(this.selectingCategory);
            this.card_size2.MouseLeave += new System.EventHandler(this.selectingCategory);
            // 
            // card_name2
            // 
            this.card_name2.AutoSize = true;
            this.card_name2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.card_name2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.card_name2.Location = new System.Drawing.Point(75, 24);
            this.card_name2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.card_name2.Name = "card_name2";
            this.card_name2.Size = new System.Drawing.Size(116, 28);
            this.card_name2.TabIndex = 1;
            this.card_name2.Text = "Wykonane";
            this.card_name2.Click += new System.EventHandler(this.selectedCategory);
            this.card_name2.MouseEnter += new System.EventHandler(this.selectingCategory);
            this.card_name2.MouseLeave += new System.EventHandler(this.selectingCategory);
            // 
            // card_picture2
            // 
            this.card_picture2.BackgroundImage = global::Zaliczenie.Properties.Resources.heartBlue;
            this.card_picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card_picture2.Location = new System.Drawing.Point(9, 16);
            this.card_picture2.Margin = new System.Windows.Forms.Padding(4);
            this.card_picture2.Name = "card_picture2";
            this.card_picture2.Size = new System.Drawing.Size(54, 48);
            this.card_picture2.TabIndex = 0;
            this.card_picture2.TabStop = false;
            this.card_picture2.Click += new System.EventHandler(this.selectedCategory);
            this.card_picture2.MouseEnter += new System.EventHandler(this.selectingCategory);
            this.card_picture2.MouseLeave += new System.EventHandler(this.selectingCategory);
            // 
            // view_desc
            // 
            this.view_desc.AutoSize = true;
            this.view_desc.BackColor = System.Drawing.Color.Transparent;
            this.view_desc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.view_desc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.view_desc.Location = new System.Drawing.Point(340, 124);
            this.view_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.view_desc.Name = "view_desc";
            this.view_desc.Size = new System.Drawing.Size(311, 28);
            this.view_desc.TabIndex = 10;
            this.view_desc.Text = "Description of category";
            this.view_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cat_add
            // 
            this.cat_add.BackgroundImage = global::Zaliczenie.Properties.Resources.plus;
            this.cat_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cat_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cat_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cat_add.ForeColor = System.Drawing.Color.BurlyWood;
            this.cat_add.Location = new System.Drawing.Point(262, 881);
            this.cat_add.Margin = new System.Windows.Forms.Padding(4);
            this.cat_add.Name = "cat_add";
            this.cat_add.Size = new System.Drawing.Size(60, 60);
            this.cat_add.TabIndex = 15;
            this.cat_add.UseVisualStyleBackColor = true;
            this.cat_add.Click += new System.EventHandler(this.cat_add_Click);
            // 
            // btn_closeX
            // 
            this.btn_closeX.BackgroundImage = global::Zaliczenie.Properties.Resources.x;
            this.btn_closeX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_closeX.Location = new System.Drawing.Point(1149, 22);
            this.btn_closeX.Margin = new System.Windows.Forms.Padding(4);
            this.btn_closeX.Name = "btn_closeX";
            this.btn_closeX.Size = new System.Drawing.Size(45, 45);
            this.btn_closeX.TabIndex = 16;
            this.btn_closeX.UseVisualStyleBackColor = true;
            this.btn_closeX.Click += new System.EventHandler(this.btn_closeX_Click);
            // 
            // main_bar
            // 
            this.main_bar.BackColor = System.Drawing.Color.Transparent;
            this.main_bar.Controls.Add(this.main_btn_min);
            this.main_bar.Controls.Add(this.btn_closeX);
            this.main_bar.Controls.Add(this.img_title);
            this.main_bar.Controls.Add(this.str_title);
            this.main_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_bar.Location = new System.Drawing.Point(-8, -16);
            this.main_bar.Margin = new System.Windows.Forms.Padding(4);
            this.main_bar.Name = "main_bar";
            this.main_bar.Padding = new System.Windows.Forms.Padding(4);
            this.main_bar.Size = new System.Drawing.Size(1210, 81);
            this.main_bar.TabIndex = 17;
            this.main_bar.TabStop = false;
            this.main_bar.Text = "groupBox1";
            this.main_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.main_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.main_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // main_btn_min
            // 
            this.main_btn_min.BackgroundImage = global::Zaliczenie.Properties.Resources.Minus;
            this.main_btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_btn_min.Location = new System.Drawing.Point(1096, 22);
            this.main_btn_min.Margin = new System.Windows.Forms.Padding(4);
            this.main_btn_min.Name = "main_btn_min";
            this.main_btn_min.Size = new System.Drawing.Size(45, 45);
            this.main_btn_min.TabIndex = 17;
            this.main_btn_min.UseVisualStyleBackColor = true;
            this.main_btn_min.Click += new System.EventHandler(this.main_btn_min_Click);
            // 
            // cat_flow
            // 
            this.cat_flow.AutoScroll = true;
            this.cat_flow.BackColor = System.Drawing.Color.Transparent;
            this.cat_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.cat_flow.Location = new System.Drawing.Point(8, 369);
            this.cat_flow.Margin = new System.Windows.Forms.Padding(4);
            this.cat_flow.Name = "cat_flow";
            this.cat_flow.Size = new System.Drawing.Size(327, 502);
            this.cat_flow.TabIndex = 18;
            this.cat_flow.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(93, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Domyślne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(64, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Niestandardowe";
            // 
            // btn_delta
            // 
            this.btn_delta.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_delta.Location = new System.Drawing.Point(134, 882);
            this.btn_delta.Name = "btn_delta";
            this.btn_delta.Size = new System.Drawing.Size(108, 59);
            this.btn_delta.TabIndex = 21;
            this.btn_delta.Text = "Delta built-in";
            this.btn_delta.UseVisualStyleBackColor = true;
            this.btn_delta.Click += new System.EventHandler(this.btn_delta_Click);
            // 
            // openBrows
            // 
            this.openBrows.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openBrows.Location = new System.Drawing.Point(8, 881);
            this.openBrows.Name = "openBrows";
            this.openBrows.Size = new System.Drawing.Size(108, 59);
            this.openBrows.TabIndex = 22;
            this.openBrows.Text = "Delta WWW";
            this.openBrows.UseVisualStyleBackColor = true;
            this.openBrows.Click += new System.EventHandler(this.openBrows_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Zaliczenie.Properties.Resources.wallhaven_640333;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 958);
            this.Controls.Add(this.openBrows);
            this.Controls.Add(this.btn_delta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cat_flow);
            this.Controls.Add(this.main_bar);
            this.Controls.Add(this.cat_add);
            this.Controls.Add(this.view_desc);
            this.Controls.Add(this.cat2);
            this.Controls.Add(this.sep2);
            this.Controls.Add(this.view_img_cat);
            this.Controls.Add(this.view_name);
            this.Controls.Add(this.view_panel);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.cat1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.9D;
            this.Text = "Kaszuba To Do";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.card_picture1)).EndInit();
            this.cat1.ResumeLayout(false);
            this.cat1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_title)).EndInit();
            this.view_panel.ResumeLayout(false);
            this.view_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_img_cat)).EndInit();
            this.cat2.ResumeLayout(false);
            this.cat2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card_picture2)).EndInit();
            this.main_bar.ResumeLayout(false);
            this.main_bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox card_picture1;
        private System.Windows.Forms.Label card_name1;
        private System.Windows.Forms.GroupBox cat1;
        private System.Windows.Forms.GroupBox card1;
        private System.Windows.Forms.PictureBox img_title;
        private System.Windows.Forms.Label str_title;
        private System.Windows.Forms.Label card_size1;
        private System.Windows.Forms.Panel view_panel;
        private System.Windows.Forms.Label view_name;
        private System.Windows.Forms.PictureBox view_img_cat;
        private System.Windows.Forms.GroupBox sep2;
        private System.Windows.Forms.GroupBox cat2;
        private System.Windows.Forms.Label card_size2;
        private System.Windows.Forms.Label card_name2;
        private System.Windows.Forms.PictureBox card_picture2;
        private System.Windows.Forms.Label view_desc;
        private System.Windows.Forms.FlowLayoutPanel view_flow;
        private System.Windows.Forms.Button view_save;
        private System.Windows.Forms.Button view_add;
        private System.Windows.Forms.Button cat_add;
        private System.Windows.Forms.Button btn_closeX;
        private System.Windows.Forms.GroupBox main_bar;
        private System.Windows.Forms.FlowLayoutPanel cat_flow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delta;
        private System.Windows.Forms.Button main_btn_min;
        private System.Windows.Forms.Button openBrows;
    }
}


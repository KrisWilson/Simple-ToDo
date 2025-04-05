using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using GroupBox = System.Windows.Forms.GroupBox;

namespace Zaliczenie
{
    public partial class Main : Form
    {
        private int selectedCat = 0;
        private int selectingCat = -1;
        private LinkedList<Kategoria> kategoria = new LinkedList<Kategoria>();
        public Main()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            kategoria.AddLast(new Kategoria("Wszystkie", "Wszystkie zadania z każdej grupy"));
            kategoria.Last.Value.representation = cat1;
            SelectCategory(1);
            kategoria.AddLast(new Kategoria("Wykonane", "Wszystkie zadania które zostały wykonane"));
            kategoria.Last.Value.representation = cat2;
        }

        private Label createLabel(String text)
        {
            Label label = new Label();
            label.Text = text;
            label.Font = view_name.Font;
            label.ForeColor = view_desc.ForeColor;
            label.Size = new Size(label.PreferredWidth, label.PreferredHeight);
            label.Visible = true;
            label.Cursor = Cursors.Hand;
            return label;
        }
        private GroupBox createGroupBoxWpis(String name, String desc, DateTime date, int id)
        {
            GroupBox gb = new GroupBox();
            gb.Font = new Font(gb.Font.Name, 1, gb.Font.Style);
            Button button = new Button();
            button.Size = new Size(40, 40);
            button.BackgroundImageLayout = ImageLayout.Stretch;
            if (selectedCat != 1)
                button.Image = Properties.Resources.done;
            else
                button.Image = Properties.Resources.x;
            button.BackColor = Color.Transparent;
            button.Click += new EventHandler(doneWpis);
            gb.Controls.Add(button);
            if (name.Length > 8) name = name.Substring(0, 8) + "...";
            if (desc.Length > 15) desc = desc.Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty).Substring(0, 15) + "...";
            gb.Text = "";
            Label text = createLabel(name + " " + desc + " " + date.ToString());
            text.MouseEnter += new EventHandler(selectingWpisMethod);
            text.MouseLeave += new EventHandler(selectingWpisMethod);
            text.Click += new EventHandler(openWpis);
            gb.Controls.Add(text);
            foreach (var item in gb.Controls)
            {
                if (item.GetType() == typeof(Button))
                    (item as Control).Location = new Point(10, 5);
                if (item.GetType() == typeof(Label))
                    (item as Control).Location = new Point(60, 15);
            }
            gb.Size = new Size(530, 50);
            gb.Cursor = Cursors.Hand;
            gb.Name = "wpis" + id;
            gb.MouseEnter += new EventHandler(selectingWpisMethod);
            gb.MouseLeave += new EventHandler(selectingWpisMethod);
            gb.Click += new EventHandler(openWpis);
            return gb;
        }
        private GroupBox createGroupBoxCat(String name)
        {
            GroupBox gb = new GroupBox();
            gb.Font = new Font(gb.Font.Name, 1, gb.Font.Style);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(40, 40);
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Image = Properties.Resources.done;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Click += new EventHandler(selectedCategory);
            pictureBox.MouseEnter += new EventHandler(selectingCategory);
            pictureBox.MouseLeave += new EventHandler(selectingCategory);
            gb.Controls.Add(pictureBox);

            if (name.Length > 10) name = name.Substring(0, 7) + "...";
            gb.Text = "";
            Label text = createLabel(name);
            text.MouseEnter += new EventHandler(selectingCategory);
            text.MouseLeave += new EventHandler(selectingCategory);
            text.Click      += new EventHandler(selectedCategory);
            gb.Controls.Add(text);

            Label sizeL = createLabel("1");
            sizeL.MouseEnter += new EventHandler(selectingCategory);
            sizeL.MouseLeave += new EventHandler(selectingCategory);
            sizeL.Click += new EventHandler(selectedCategory);
            gb.Controls.Add(sizeL);
            int counter = 0;
            foreach (var item in gb.Controls)
            {
                if (counter == 0)
                    (item as Control).Location = new Point(5, 5);
                else if (counter == 1)
                    (item as Control).Location = new Point(45, 15);
                else if (counter == 2)
                    (item as Control).Location = new Point(149, 15);
                counter++;
            }

            gb.Size = new Size(194, 55);
            gb.Cursor = Cursors.Hand;
            gb.Name = "cat" + (kategoria.Count+1);
            gb.MouseEnter += new EventHandler(selectingCategory);
            gb.MouseLeave += new EventHandler(selectingCategory);
            gb.Click += new EventHandler(selectedCategory);

            gb.ContextMenuStrip = new ContextMenuStrip();
            gb.ContextMenuStrip.Text = gb.Name;
            gb.ContextMenuStrip.Items.Add("Usuń", null, removeCat);
            gb.ContextMenuStrip.Items.Add("Edytuj", null, editCat);
            return gb;
        }
        private void removeCat(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
           // MessageBox.Show(menu.Owner.Text);

            int id = int.Parse(menu.Owner.Text.Substring(3));

            int counter = 0;
            foreach (var item in kategoria)
            {
                if (item.representation.Name == menu.Owner.Text)
                        break;
                counter++;
            }
            cat_flow.Controls.Remove(kategoria.ElementAt(counter).representation);
            kategoria.Remove(
                kategoria.ElementAt(counter)
                );

        }
        private void editCat(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            // MessageBox.Show(menu.Owner.Text);

            int id = int.Parse(menu.Owner.Text.Substring(3));

            int counter = 0;
            foreach (var item in kategoria)
            {
                if (item.representation.Name == menu.Owner.Text)
                    break;
                counter++;
            }
            var result = new AddCat(kategoria.ElementAt(counter));
            result.ShowDialog();
            if (result.apply)
            {
                kategoria.ElementAt(counter).Name = result.ReturnCat.Name;
                kategoria.ElementAt(counter).Description = result.ReturnCat.Description;
                cat_flow.Controls.Remove(kategoria.ElementAt(counter).representation);

                GroupBox representation = createGroupBoxCat(result.ReturnCat.Name);
                result.ReturnCat.representation = representation;
                kategoria.AddLast(result.ReturnCat);
                cat_flow.Controls.Add(representation);
                SelectCategory(selectedCat+1);
            }
        }
        private void openWpis(object sender, EventArgs e)
        {
            try
            {
                GroupBox groupBox;
                if (sender.GetType() == typeof(GroupBox))
                {
                    groupBox = (GroupBox)sender;
                }
                else
                {
                    Control control = sender as Control;
                    groupBox = (GroupBox)control.Parent;
                }

                int id = int.Parse(groupBox.Name.Substring(4));

                var result = new AddWpis(kategoria.ElementAt(selectedCat).Wpis.ElementAt(id));
                result.ShowDialog();
                if (result.apply)
                {
                    kategoria.ElementAt(selectedCat).Wpis.ElementAt(id).Name = result.ReturnWpis.Name;
                    kategoria.ElementAt(selectedCat).Wpis.ElementAt(id).Description = result.ReturnWpis.Description;
                    kategoria.ElementAt(selectedCat).Wpis.ElementAt(id).Deadline = result.ReturnWpis.Deadline;
                    SelectCategory(selectedCat + 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void doneWpis(object sender, EventArgs e)
        {
            try
            {
                GroupBox groupBox;
                if (sender.GetType() == typeof(GroupBox))
                {
                    groupBox = (GroupBox)sender;
                }
                else
                {
                    Control control = sender as Control;
                    groupBox = (GroupBox)control.Parent;
                }

                int id = int.Parse(groupBox.Name.Substring(4));
                // ta linijka powoduje usuwanie wszystkich po 1 kliknieciu
                //foreach (var item in view_flow.Controls)

                if (selectedCat != 1)
                {
                    kategoria.ElementAt(1).Wpis.AddLast(kategoria.ElementAt(selectedCat).Wpis.ElementAt(id));
                    kategoria.ElementAt(selectedCat).Wpis.Remove(kategoria.ElementAt(selectedCat).Wpis.ElementAt(id));
                }
                else
                    kategoria.ElementAt(selectedCat).Wpis.Remove(kategoria.ElementAt(selectedCat).Wpis.ElementAt(id));
                kategoria.ElementAt(1).representation.GetChildAtPoint(new Point(150, 17)).Text = kategoria.ElementAt(1).Wpis.Count.ToString();
                kategoria.ElementAt(selectedCat).representation.GetChildAtPoint(new Point(150, 17)).Text = kategoria.ElementAt(selectedCat).Wpis.Count.ToString();
                SelectCategory(selectedCat + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SelectCategory(int id)
        {
            id--;   // od 1 zacząłem opisywać elementy w Designerze
            selectedCat = id;
            foreach (var item in kategoria)
            {
                item.representation.BackColor = Color.Transparent;
            }

            Kategoria cat = kategoria.ElementAt(id);

            GroupBox groupBox = cat.representation;
            if (groupBox.BackColor == Color.Transparent)
                groupBox.BackColor = Color.MidnightBlue;
            else
                groupBox.BackColor = Color.Transparent;

            view_desc.Text = cat.Description;
            view_name.Text = cat.Name;
            view_flow.Controls.Clear();
            int numer = 0;
            foreach (var item in cat.Wpis)
            {
                view_flow.Controls.Add(createGroupBoxWpis(item.Name, item.Description, item.Deadline, numer));
                numer++;
            }
        }

        //List<System.Windows.Forms.GroupBox> groups = new List<System.Windows.Forms.GroupBox>();
        //private void addCategoryToList(object sender, EventArgs e)
        //{
        //    System.Windows.Forms.GroupBox gb = (System.Windows.Forms.GroupBox)sender;
        //    groups.Add(gb);
        //    Console.WriteLine("Dodano element do listy GroupBox!" + gb.Name);
        //}

        private void selectedCategory(object sender, EventArgs e) // Metoda do ustawienia aktualnej wyświetlanej kategorii.
        {
            try
            {
                /*      
                 *      Dlaczego długie nazwy jednoznacznie definiujące klase?
                 *      
                 * 'Element „GroupBox” to niejednoznaczne odwołanie między elementem
                 * „System.Windows.Forms.VisualStyles.VisualStyleElement.Button.GroupBox”
                 * i „System.Windows.Forms.GroupBox”
                 */
                GroupBox groupBox;
                if (sender.GetType() == typeof(GroupBox))
                {
                    groupBox = (GroupBox)sender;
                }
                else
                {
                    Control control = sender as Control;
                    groupBox = (GroupBox)control.Parent;
                }
                SelectCategory(int.Parse(groupBox.Name.Substring(3)));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void selectingCategory(object sender, EventArgs e) // Metoda do podswietlania Kategorii.
        {
            try
            {
                /*      
                 *      Dlaczego długie nazwy jednoznacznie definiujące klase?
                 *      
                 * 'Element „GroupBox” to niejednoznaczne odwołanie między elementem
                 * „System.Windows.Forms.VisualStyles.VisualStyleElement.Button.GroupBox”
                 * i „System.Windows.Forms.GroupBox”
                 */
                GroupBox groupBox;
                if (sender.GetType() == typeof(GroupBox))
                {
                    groupBox = (GroupBox)sender;
                }
                else
                {
                    Control control = sender as Control;
                    groupBox = (GroupBox)control.Parent;
                }
                int id = int.Parse(groupBox.Name.Substring(3));
                id--;
                if (selectedCat != id)
                {
                    if (selectingCat != id)
                    {
                        groupBox.BackColor = Color.Maroon;
                        selectingCat = id;
                    }
                    else
                    {
                        groupBox.BackColor = Color.Transparent;
                        selectingCat = -1;
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void selectingWpisMethod(object sender, EventArgs e) // Metoda do podswietlania Wpisu
        {
            try
            {
                GroupBox groupBox;
                if (sender.GetType() == typeof(GroupBox))
                {
                    groupBox = (GroupBox)sender;
                }
                else
                {
                    Control control = sender as Control;
                    groupBox = (GroupBox)control.Parent;
                }

                int id = int.Parse(groupBox.Name.Substring(4));

                if (selectingCat != id)
                {
                    groupBox.BackColor = Color.Maroon;
                    selectingCat = id;
                }
                else
                {
                    groupBox.BackColor = Color.Transparent;
                    selectingCat = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void img_title_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(message, caption, buttons); 
            //MessageBox.Show("Projekt zaliczeniowy .NET Framework\nKrystian Kaszuba 12K2 (2025)", "Autor projektu", MessageBoxButtons.OK);
            new Message("Projekt zaliczeniowy .NET Framework\nKrystian Kaszuba 12K2").Visible = true;
        }


        private void view_add_Click(object sender, EventArgs e)
        {
            var result = new AddWpis();
            result.ShowDialog();
            if (result.apply)
            {
                kategoria.ElementAt(selectedCat).Wpis.AddLast(result.ReturnWpis);
                kategoria.ElementAt(selectedCat).representation.GetChildAtPoint(new Point(150, 17)).Text = kategoria.ElementAt(selectedCat).Wpis.Count.ToString();
                view_flow.Controls.Add(createGroupBoxWpis(result.ReturnWpis.Name, result.ReturnWpis.Description, result.ReturnWpis.Deadline, view_flow.Controls.Count));

                //SelectCategory(selectedCat + 1);
            }
        }

        private void btn_closeX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 2);
            g.DrawRectangle(pen, new Rectangle(new Point(0, 0), new Size(Width, Height)));
        }

        private void view_save_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                //https://learn.microsoft.com/en-us/previous-versions/windows/silverlight/dotnet-windows-silverlight/dd459587(v=vs.95)
                sfd.Filter = "Pliki tekstowe (*.txt)|*.txt|Dowolny (*.*)|*.*";
                sfd.DefaultExt = "txt";
                sfd.AddExtension = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Kategoria selected = kategoria.ElementAt(selectedCat);
                    LinkedList<Wpis> wpisy = selected.Wpis;

                    string path = Path.GetFullPath(sfd.FileName);
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine("Nazwa: " + selected.Name);
                    sw.WriteLine("Opis: " + selected.Description);
                    foreach (var item in wpisy)
                    {
                        sw.WriteLine("\n\t" + item.Name + " - " + item.Deadline.ToString() + "\n" + item.Description);
                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cat_add_Click(object sender, EventArgs e)
        {
            var result = new AddCat();
            result.ShowDialog();
            if (result.apply)
            {
                GroupBox representation = createGroupBoxCat(result.ReturnCat.Name);
                result.ReturnCat.representation = representation;
                kategoria.AddLast(result.ReturnCat);
                cat_flow.Controls.Add(representation);
            }
        }

        private void btn_delta_Click(object sender, EventArgs e)
        {
            new WWW("https://delta.pk.edu.pl/my/").Visible = true;
        }

        private void main_btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void openBrows_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://delta.pk.edu.pl/my/");
        }
    }
}

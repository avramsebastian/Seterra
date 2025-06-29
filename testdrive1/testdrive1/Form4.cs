using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testdrive1
{
    public partial class Joc_Învățare : Form
    {
        public Joc_Învățare()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            foreach (var oraș in coordonateOrașe)
            {
                Button button = new Button();
                button.Name = oraș.Key;
                button.Width = TextRenderer.MeasureText(oraș.Key, button.Font).Width + 15;
                button.BackColor = Color.White;
                button.Location = oraș.Value;
                button.Padding = Padding.Empty;
                button.Click += new EventHandler(MyClick);
                panel1.Controls.Add(button);
            }
        }

        private Dictionary<string, Point> coordonateOrașe = new Dictionary<string, Point>
        {
            {"Sibiu", new Point(425, 365)},
            {"Brașov", new Point(520, 373)},
            {"Hunedoara", new Point(270, 377)},
            {"Alba", new Point(349, 325)},
            {"Covasna", new Point(599, 354)},
            {"Timiș", new Point(125, 374)},
            {"Arad", new Point(164, 301)},
            {"Vrancea", new Point(695, 366)},
            {"Galați", new Point(797, 367)},
            {"Bihor", new Point(210, 228)},
            {"Satu Mare", new Point(251, 133)},
            {"Sălaj", new Point(308, 195)},
            {"Maramureș", new Point(376, 131)},
            {"Cluj", new Point(365, 246)},
            {"Mureș", new Point(454, 273)},
            {"Bistrița-Năsăud", new Point(428, 184)},
            {"Harghita", new Point(552, 282)},
            {"Suceava", new Point(569, 142)},
            {"Neamț", new Point(637, 223)},
            {"Bacău", new Point(686, 293)},
            {"Botoșani", new Point(669, 95)},
            {"Iași", new Point(734, 182)},
            {"Vaslui", new Point(794, 273)},
            {"Caraș-Severin", new Point(165, 454)},
            {"Tulcea", new Point(959, 441)},
            {"Constanța", new Point(845, 580)},
            {"Călărași", new Point(717, 558)},
            {"Ialomița", new Point(763, 517)},
            {"Brăila", new Point(790, 460)},
            {"Ilfov", new Point(628, 533)},
            {"Giurgiu", new Point(609, 585)},
            {"Teleorman", new Point(510, 605)},
            {"Dolj", new Point(355, 585)},
            {"Mehedinți", new Point(260, 546)},
            {"Olt", new Point(454, 568)},
            {"Buzău", new Point(688, 444)},
            {"Prahova", new Point(606, 463)},
            {"Dâmbovița", new Point(547, 502)},
            {"Argeș", new Point(486, 474)},
            {"Vâlcea", new Point(407, 467)},
            {"Gorj", new Point(330, 477)},
        };

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (Control control in panel1.Controls)
                    if (control is Button button && button.Name != "button1")
                        button.Text = button.Name;
            }
            else if (!checkBox1.Checked)
            {
                foreach (Control control in panel1.Controls)
                    if (control is Button button && button.Name != "button1")
                        button.Text = "";
            }
        }

        private async void MyClick(object sender, EventArgs e)
        {
            Button v = (Button)sender;
            if(v.Text == "")
            {
                v.Text = v.Name;
                await Task.Delay(1000);
                if(!checkBox1.Checked)
                    v.Text = "";
            }
        }
    }
}
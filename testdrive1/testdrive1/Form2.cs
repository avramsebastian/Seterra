using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testdrive1
{
    public partial class Joc : Form
    {
        int timp, numarIncercari, scor = 0, gata = 0, secunde, minute;
        string orasRandom, timpFormatat;
        Random r = new Random();
        private List<string> listaOrase = new List<string> { "Sibiu", "Brașov", "Hunedoara", "Alba", "Covasna", "Timiș", "Arad", "Vrancea","Galați", "Bihor", "Satu Mare", "Sălaj", "Maramureș",
                                                             "Cluj", "Mureș", "Bistrița-Năsăud", "Harghita", "Suceava", "Neamț", "Bacău", "Botoșani", "Iași", "Vaslui", "Caraș-Severin", "Tulcea", "Constanța", 
                                                             "Călărași", "Ialomița", "Brăila","Ilfov", "Giurgiu", "Teleorman", "Dolj", "Mehedinți", "Olt", "Buzău", "Prahova", "Dâmbovița", "Argeș", "Vâlcea", "Gorj"};
        private List<string> listaOraseAuxiliara;

        public Joc(int timpselectat)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; 
            this.timp = timpselectat;
            secunde = timp % 60;
            minute = timp / 60;
            if(minute != 0)
                timpFormatat = ("0" + minute + ":" + secunde + "0").ToString();
            else timpFormatat = ("0" + minute + ":" + secunde).ToString();
            label2.Text = timpFormatat;
        }

        private const string Verde = "#1e8346", Galben = "#ffd970", Rosu = "#Ff0700";

        private Color HexToColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
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

        private void butst_Click(object sender, EventArgs e)
        {
            butst.Enabled = false;
            foreach (var oraș in coordonateOrașe)
            {
                Button button = new Button();
                button.Name = oraș.Key;
                button.Width = TextRenderer.MeasureText(oraș.Key, button.Font).Width+15;
                button.BackColor = Color.White;
                button.Location = oraș.Value;
                button.Padding = Padding.Empty;
                button.Click += new EventHandler(MyClick);
                panel1.Controls.Add(button);
            }
            label5.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            listaOraseAuxiliara = new List<string>(listaOrase);
            timer1.Start();
            orasRandom = GenerareOrasAleator();
            label4.Text = orasRandom.ToString();
            numarIncercari = 0;
        }

        private async void MyClick(object sender, EventArgs e)
        {
            Button v = (Button)sender;
            if (gata == 0)
            {
                if (v.Text == "")
                    numarIncercari++;
                if (v.Name == orasRandom && numarIncercari <= 2)
                {
                    if (numarIncercari == 1)
                    {
                        v.BackColor = HexToColor(Verde);
                        v.Text = orasRandom;
                        v.ForeColor = Color.White;
                        scor++;
                    }
                    else if (numarIncercari == 2)
                    {
                        v.BackColor = HexToColor(Galben);
                        v.Text = orasRandom;
                    }
                    label6.Text = scor + "/41";
                    orasRandom = GenerareOrasAleator();
                    label4.Text = orasRandom.ToString();
                    if (string.IsNullOrEmpty(orasRandom))
                    {
                        timer1.Stop();
                        gata = 1;
                        label3.Visible = false;
                        button1.Visible = true;
                        label4.Text = "";
                    }
                    numarIncercari = 0;
                }
                else if (numarIncercari == 3)
                {
                    if(v.Name == orasRandom)
                    {
                        v.Text = v.Name;
                        v.BackColor = HexToColor(Rosu);
                    }
                    else
                    {
                        v.Enabled = false;
                        v.BackColor = HexToColor(Rosu);
                        v.Text = v.Name;
                        await Task.Delay(500);
                        v.Enabled = true;
                        v.BackColor = Color.White;
                        v.Text = "";
                        foreach (Control verif in panel1.Controls)
                            if (verif is Button)
                            {
                                Button button = (Button)verif;
                                if (button.Name == orasRandom)
                                {
                                    button.BackColor = HexToColor(Rosu);
                                    button.Text = orasRandom;
                                    v.ForeColor = Color.Black;
                                }
                            }
                    }
                    orasRandom = GenerareOrasAleator();
                    label4.Text = orasRandom.ToString();
                    if (string.IsNullOrEmpty(orasRandom))
                    {
                        timer1.Stop();
                        gata = 1;
                        label3.Visible = false;
                        button1.Visible = true;
                        label4.Text = "";
                    }
                    numarIncercari = 0;
                }
                else if (v.Text == "" && numarIncercari<3)
                {
                    v.Enabled = false;
                    v.BackColor = HexToColor(Rosu);
                    v.Text = v.Name;
                    await Task.Delay(500);
                    v.Enabled = true;
                    v.BackColor = Color.White;
                    v.Text = "";
                }
            }
        }

        private string GenerareOrasAleator()
        {
            if (listaOraseAuxiliara.Count > 0)
            {
                int index = r.Next(listaOraseAuxiliara.Count);
                string orasGenerat = listaOraseAuxiliara[index];
                listaOraseAuxiliara.RemoveAt(index);
                return orasGenerat;
            }
            else return "";
        }

        private void UpdateTimp()
        {
            secunde = timp % 60;
            minute = timp / 60;
            if (secunde < 10)
                timpFormatat = ("0" + minute + ":0" + secunde).ToString();
            else timpFormatat = ("0" + minute + ":" + secunde).ToString();
            label2.Text = timpFormatat;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timp--;
            UpdateTimp();
            if (timp == 0)
            {
                timer1.Stop();
                gata = 1;
                label3.Visible = false;
                button1.Visible = true;
                label4.Text = "";
                label2.Text = "";
                label1.Text = "Timpul a expirat!";
                foreach (Control verif in panel1.Controls)
                    if (verif is Button)
                    {
                        Button button = (Button)verif;
                        if (button.Text == "")
                        {
                            button.BackColor = HexToColor(Rosu);
                            button.Text = button.Name;
                        }
                    }
            }
        }
    }
}